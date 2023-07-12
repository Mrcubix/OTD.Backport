using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Attributes;

namespace OTD.Backport.Configurations
{
    [PluginName("OTD.Backport")]
    public class OTD_Backport : ITool
    {
        // We obtain the current location of the plugin
        private readonly static string assemblyLocation = Assembly.GetExecutingAssembly().Location;
        // We obtain the parent directory of the plugin
        private readonly static string location = assemblyLocation.Substring(0, assemblyLocation.LastIndexOf(Path.DirectorySeparatorChar));
        private static string rootFolder;
        private readonly static string backportedConfigs = location + "/Configurations";
        private static string settingFile;

        public bool Initialize()
        {
            _ = Task.Run(InitializeAsync);
            return true;
        }

        public void Dispose() { }

        public void InitializeAsync()
        {
            if (!DetectPlatform()) return;

            settingFile = Path.Combine(location, "OTD.Backport.lock");

            if (ShouldUpdate())
            {
                try
                {
                    // Moving &/OR overwriting configs
                    PlatformSpecificUpdate();
                    Log.Write("OTD.Backport", "Some Configs have been altered.", LogLevel.Warning);
                    Log.Write("OTD.Backport", "Go to Tablets > Detect tablet OR Restart OTD for changes to apply.", LogLevel.Warning);
                }
                catch (Exception) { }

                if (ForceInstall)
                {
                    Log.Write("OTD.Backport", "Force Apply is enabled, don't forget to disable it in Tool > OTD.Backport by unticking 'Force Apply'", LogLevel.Warning);
                }

            }
        }

        public bool ShouldUpdate()
        {
            if (!File.Exists(settingFile))
            {
                File.Create(settingFile);
                return true;
            }

            return ForceInstall;
        }

        public bool DetectPlatform()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                rootFolder = Directory.GetCurrentDirectory();
                return true;
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Log.Write("OTD.Backport", "Platform Detected: Linux", LogLevel.Error);
                Log.Write("OTD.Backport", "Users don't have write access to /usr/share/OpenTabletDriver/ by default.", LogLevel.Error);
                Log.Write("OTD.Backport", $"To fix it, run 'update.sh' located in '~/.config/OpenTabletDriver/Plugins/OTD.Backport/' OR get the release and run 'update.sh'", LogLevel.Error);
                Log.Write("OTD.Backport", "Link to Release: https://github.com/Mrcubix/OTD.Backport/releases", LogLevel.Error);
                return false;
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                rootFolder = Path.Combine(Environment.GetEnvironmentVariable("HOME"), "Library/Application Support/OpenTabletDriver");
                return true;
            }

            Log.Write("OTD.Backport", "Unknown platform detected, tablet configurations cannot be updated.", LogLevel.Error);
            Log.Write("OTD.Backport", "Please update configurations manually.", LogLevel.Error);
            Log.Write("OTD.Backport", "Link to Release: https://github.com/Mrcubix/OTD.Backport/releases", LogLevel.Error);
            return false;
        }

        public void PlatformSpecificUpdate()
        {
            string source = backportedConfigs;
            string target = Path.Combine(rootFolder, "Configurations");

            if (Directory.Exists(source))
            {
                // Backup Configurations   
                string backupConfigs = Path.Combine(rootFolder, "Configurations.backup");

                Log.Write("OTD.Backport", $"Backing up Configurations to {backupConfigs}", LogLevel.Info);

                // Check if backup folder exists
                if (!Directory.Exists(backupConfigs))
                    Directory.CreateDirectory(backupConfigs);

                // Move Configurations
                if (!MoveConfigurations(target, backupConfigs))
                    return;

                Log.Write("OTD.Backport", "Configurations have been backed up.", LogLevel.Info);

                // Update Configurations
                if (!MoveConfigurations(source, target))
                    return;
            }
            else
            {
                Log.Write("OTD.Backport", "OTD.Backport's Configurations folder is missing, has it been deleted?", LogLevel.Error);
                Log.Write("OTD.Backport", "Re-install the plugin to recover the missing folder or extract the Configurations folder manually.", LogLevel.Error);
                Log.Write("OTD.Backport", "Link to Release: https://github.com/Mrcubix/OTD.Backport/releases", LogLevel.Error);
            }
        }

        public bool MoveConfigurations(string source, string target)
        {
            try
            {
                MergeConfigs(source, target);
                return true;
            }
            catch (UnauthorizedAccessException e)
            {
                Log.Write("OTD.Backport", "An exception occured while backing up Configurations: Permission Denied.", LogLevel.Fatal);
                Log.Write("OTD.Backport", "This exception can be encountered if you don't have permission to read from the plugin folder OR/AND write or create file/folder in:", LogLevel.Fatal);
                Log.Write("OTD.Backport", target, LogLevel.Fatal);
                Log.Write("OTD.Backport", e.ToString(), LogLevel.Fatal);
            }
            catch (Exception e)
            {
                Log.Write("OTD.Backport", "An unhandled exception occured while backing up Configurations: ", LogLevel.Fatal);
                Log.Write("OTD.Backport", e.ToString(), LogLevel.Fatal);
            }

            return false;
        }

        public void MergeConfigs(string source, string target)
        {
            string[] directories = new DirectoryInfo(source).GetDirectories().Select(d => d.Name).ToArray();
            foreach (string directory in directories)
            {
                string sourceVendorDirectory = Path.Combine(source, directory);
                string targetVendorDirectory = Path.Combine(target, directory);

                if (!Directory.Exists(targetVendorDirectory))
                {
                    Directory.CreateDirectory(targetVendorDirectory);
                }

                FileInfo[] files = new DirectoryInfo(sourceVendorDirectory).GetFiles();
                foreach (FileInfo file in files)
                {
                    byte[] data = File.ReadAllBytes(file.FullName);
                    File.WriteAllBytes(Path.Combine(targetVendorDirectory, file.Name), data);
                }
            }
        }

        [BooleanProperty("Force Install", ""),
         DefaultPropertyValue(false),
         ToolTip("OTD.Backport:\n\n" +
                 "When enabled, Configs will be overwritten on Apply & Save.\n\n" +
                 "Don't forget to disable it after updating configurations.")
        ]
        public bool ForceInstall { set; get; }
    }
}
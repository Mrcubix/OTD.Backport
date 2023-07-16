dotnet restore

dotnet publish -c Release -o temp

del /Q build

mkdir build

move /Y temp\OTD.Backport.Parsers.dll build\OTD.Backport.Parsers.dll
move /Y temp\OTD.Backport.Parsers.pdb build\OTD.Backport.Parsers.pdb
move /Y temp\OTD.Backport.Configurations.dll build\OTD.Backport.Configurations.dll
move /Y temp\OTD.Backport.Configurations.pdb build\OTD.Backport.Configurations.pdb

del /Q temp

robocopy OTD.Backport.Configurations/Configurations build/Configurations /E /NFL /NDL /NJH /NJS /NC /NS

7z a -r ./build/OTD.Backport.zip ./build/*
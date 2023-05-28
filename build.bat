dotnet publish -c Release -o temp
mkdir build
move /Y temp\OTD.Backport.dll build\OTD.Backport.dll
move /Y temp\OTD.Backport.pdb build\OTD.Backport.pdb
del /Q temp
robocopy Configurations build/Configurations /E /NFL /NDL /NJH /NJS /NC /NS
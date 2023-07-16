dotnet restore

dotnet publish -c Release -o temp

mkdir build

move /Y temp\OTD.Backport.dll build\OTD.Backport.Parsers.dll
move /Y temp\OTD.Backport.dll build\OTD.Backport.Parsers.pdb
move /Y temp\OTD.Backport.dll build\OTD.Backport.Configurations.dll
move /Y temp\OTD.Backport.pdb build\OTD.Backport.Configurations.pdb

del /Q temp

robocopy OTD.Backport.Configurations/Configurations build/Configurations /E /NFL /NDL /NJH /NJS /NC /NS
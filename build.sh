dotnet restore

dotnet publish -c Release -o build

echo build/* | tr " " "\n" | grep -P -v "build/OTD.Backport.(Parsers|Configurations).(dll|pdb)" | xargs rm

cp -R OTD.Backport.Configurations/Configurations build/

zip build/OTD.Backport.zip build/*
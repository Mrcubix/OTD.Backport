dotnet publish -c Release -o build
echo build/* | tr " " "\n" | grep -P -v "build/OTD.Backport.(dll|pdb)" | xargs rm
cp -R Configurations build/
zip build/OTD.Backport.zip build/*
@echo off
echo Publishing GeminiFix as a single Windows executable...

dotnet publish -c Release -r win-x64 -p:PublishSingleFile=true -p:SelfContained=true

echo.
echo Build complete. The single file executable can be found in:
echo bin\Release\net8.0\win-x64\publish\
pause

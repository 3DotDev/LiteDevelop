"%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe" "%~dp0\LiteDevelop.sln" /t:Clean /p:Configuration=Debug "/p:Platform=Any CPU"

"%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe" "%~dp0\LiteDevelop.sln" /t:Clean /p:Configuration=Release "/p:Platform=Any CPU"
"%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe" "%~dp0\LiteDevelop.sln" /t:Clean /p:Configuration=Minimal "/p:Platform=Any CPU"
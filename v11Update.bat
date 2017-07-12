git.exe pull
git.exe reset --hard origin/master
git.exe checkout master
git.exe checkout esapi11 ESAPIX/AppKit/StandAloneContext.cs
git.exe checkout esapi11 ESAPIX/AppKit/PluginContext.cs
git.exe checkout esapi11 ESAPIX/Interfaces/IScriptContext.cs
git.exe rm -r ESAPIX/Facade/API
git.exe checkout esapi11 ESAPIX/Facade/API
git.exe rm -r ESAPIX/lib
git.exe checkout esapi11 ESAPIX/lib
git.exe checkout esapi11 ESAPIX/ESAPIX.csproj
git.exe branch -D esapi11
git.exe branch esapi11
git.exe checkout esapi11
pause

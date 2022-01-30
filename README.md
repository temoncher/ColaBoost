# F# Unity starter
Starter project for Unity with F# as a scripting language

## Development
Before you start make sure the following criteria are met:
1. FSharp.Core.dll is present in the Assets folder
2. Assembly-CSharp.dll is compiled into Library\ScriptAssemblies\ folder (in case you have at least one `.cs` file in the project it should be compiled by Unity on a startup)
2. CoreScripts/CoreScripts.fsproj has valid paths to Unity dependencies (validate the path itself and a Unity version)
3. CoreScripts.dll is compiled into Assets folder (it can be done by running `dotnet build` inside of the CoreScripts folder)

To auto-reload F# scripts on save run `dotnet watch build` inside of the CoreScripts folder, Unity will pick up the changes automatically.

### TODO
1. Use env variables for Unity dll paths and Unity versions for F# project
2. Add CI/CD configuration

open System
#r "paket:
source https://api.nuget.org/v3/index.json
source packages
nuget Fake.Core.Target
nuget Wonderstorm.Tools.Build //"
#I __SOURCE_DIRECTORY__
#load ".fake/build.fsx/intellisense.fsx"

open Wonderstorm.Tools.Build
open Fake.Core

Target.create "Nothing" WsBuild.BuildNothing

Target.runOrDefault "Nothing"

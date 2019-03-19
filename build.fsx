open System
#r "paket:
source https://api.nuget.org/v3/index.json
source packages
nuget Fake.Core.Target
nuget TestNamespace.Assembly //"
#I __SOURCE_DIRECTORY__
#load ".fake/build.fsx/intellisense.fsx"

open TestNamespace
open Fake.Core

Target.create "Nothing" TestBuild.BuildNothing

Target.runOrDefault "Nothing"

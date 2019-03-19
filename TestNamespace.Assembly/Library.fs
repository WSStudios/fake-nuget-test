namespace TestNamespace

open Fake.Core

module TestBuild =

    type Configuration =
        | Debug
        | Release

    let BuildNothing _ =
        Trace.trace "Do nothing!"

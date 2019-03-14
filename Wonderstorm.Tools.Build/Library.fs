namespace Wonderstorm.Tools.Build

module WsBuild =

    type Configuration =
        | Debug
        | Release

    let BuildNothing _ =
        Trace.trace "Do nothing!"
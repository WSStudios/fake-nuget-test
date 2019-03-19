# fake-nuget-test
test project to diagnose FAKE nuget package usage problems

Usage:

#. `paket install`
#. `cd TestNamespace.Assembly`
#. `publish.sh`
#. `cd ..`
#. `fake run builds.fsx`

The result is an error saying the `TestNamespace` namespace is not defined. Can you help me fix that?

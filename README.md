# fake-nuget-test
test project to diagnose FAKE nuget package usage problems

Usage:

1. `paket install`
2. `cd TestNamespace.Assembly`
3. `publish.sh`
4. `cd ..`
5. `fake run builds.fsx`

The result is an error saying the `TestNamespace` namespace is not defined. Can you help me fix that?

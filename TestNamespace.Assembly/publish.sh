#!/usr/bin/env bash
dotnet build && nuget pack TestNamespace.Assembly.fsproj && cp *.nupkg ../packages/

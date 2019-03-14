#!/usr/bin/env bash
dotnet build && nuget pack Wonderstorm.Tools.Build.fsproj && cp *.nupkg ../packages/

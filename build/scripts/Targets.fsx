#load @"Commandline.fsx"
#load @"Projects.fsx"
#load @"Paths.fsx"
#load @"Tooling.fsx"
#load @"Versioning.fsx"
#load @"Testing.fsx"
#load @"Building.fsx"
#load @"Documentation.fsx"
#load @"Releasing.fsx"
#load @"Benchmarking.fsx"
#load @"XmlDocPatcher.fsx"
#nowarn "0044" //TODO sort out FAKE 5

open System
open Fake
open System.IO

open Paths
open Building
open Testing
open Versioning
open Documentation
open Releasing
open Benchmarking
open XmlDocPatcher
open Commandline
open Fake.IO
open Tooling

Commandline.parse()

Target "Touch" <| fun _ -> traceHeader "Touching build"
Target "Build" <| fun _ -> traceHeader "STARTING BUILD"
Target "Start" <| fun _ -> 
    match (isMono, Commandline.validMonoTarget) with
    | (true, false) -> traceHeader "STARTING BUILD ON MONO" //failwithf "%s is not a valid target on mono because it can not call ILRepack" (Commandline.target)
    | _ -> traceHeader "STARTING BUILD"

Target "Clean" Build.Clean

Target "Restore" Build.Restore

Target "FullBuild" <| fun _ -> Build.Compile Commandline.needsFullBuild
    
Target "Test" Tests.RunUnitTests

Target "Integrate" Tests.RunIntegrationTests

Target "Benchmark" Benchmarker.Run

Target "InternalizeDependencies" Build.ILRepack

Target "InheritDoc" InheritDoc.PatchInheritDocs

Target "Documentation" Documentation.Generate

Target "Version" <| fun _ -> 
    tracefn "Current Version: %s" (Versioning.CurrentVersion.ToString())

Target "TestNugetPackage" <| fun _ -> 
    //RunReleaseUnitTests restores the canary nugetpackages in tests, since these end up being cached
    //its too evasive to run on development machines or TC, Run only on AppVeyor containers.
    if buildServer <> AppVeyor then Tests.RunUnitTests()
    else Tests.RunReleaseUnitTests()
    
Target "Canary" <| fun _ -> tracefn "Finished Release Build %O" Versioning.CurrentVersion
    
Target "Diff" <| fun _ ->
    let differ = Paths.PaketDotNetGlobalTool "assembly-differ" @"tools\netcoreapp2.1\any\assembly-differ.dll"
    let args = Commandline.arguments |> List.skip 1 |> String.concat " "
    let command = sprintf @"%s %s" differ args
    setProcessEnvironVar "NUGET" Tooling.nugetFile
    DotNetCli.RunCommand (fun p -> { p with TimeOut = TimeSpan.FromMinutes(3.) }) command |> ignore

Target "Cluster" <| fun _ -> 
    let clusterName = getBuildParam "clusterName"
    let clusterVersion = getBuildParam "clusterVersion"
    let testsProjectDirectory = Path.Combine(Path.GetFullPath(Paths.Output("Tests.ClusterLauncher")), "netcoreapp2.1")
    let tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
    Shell.copyDir tempDir testsProjectDirectory (fun s -> true)
    trace testsProjectDirectory
    trace tempDir
    let command = sprintf "%s %s" clusterName clusterVersion
    DotNetCli.RunCommand(fun p ->
        { p with
            WorkingDir = tempDir;
            TimeOut = TimeSpan.FromMinutes(60.)
        }) (sprintf "%s %s" (Path.Combine(tempDir, "Tests.ClusterLauncher.dll")) command)
    
    Shell.deleteDir tempDir

Target "Release" <| fun _ -> traceHeader (sprintf "Finished Release Build %O" Versioning.CurrentVersion)

Target "NugetPack" Release.NugetPack

Target "NugetPackVersioned" Release.NugetPackVersioned

Target "ValidateArtifacts" Versioning.ValidateArtifacts

Target "GenerateReleaseNotes" Release.GenerateNotes


// Dependencies
"Start"
  =?> ("Clean", Commandline.needsClean )
  =?> ("Version", hasBuildParam "version")
  ==> "Restore"
  =?> ("FullBuild", Commandline.needsFullBuild)
  =?> ("Test", (not Commandline.skipTests && Commandline.target <> "canary"))
  =?> ("InternalizeDependencies", (not isMono))
  ==> "InheritDoc"
  =?> ("Documentation", (not Commandline.skipDocs))
  ==> "Build"

"Start"
  =?> ("Clean", Commandline.needsClean )
  =?> ("FullBuild", Commandline.needsFullBuild)
  ==> "Benchmark"

"Version"
  ==> "Release"
  =?> ("TestNugetPackage", (not isMono && not Commandline.skipTests))
  ==> "Canary"

"Start"
  =?> ("Clean", Commandline.needsClean )
  ==> "Restore"
  =?> ("FullBuild", Commandline.needsFullBuild)
  ==> "Integrate"

"Build"
  ==> "NugetPack"
  =?> ("NugetPackVersioned", Commandline.target = "canary")
  ==> "ValidateArtifacts"
  =?> ("GenerateReleaseNotes", Commandline.target <> "canary")
  ==> "Release"
  
"Touch"
"Start"
  ==> "Clean"
  ==> "Diff"
  
"Start"
  ==> "Restore"
  ==> "FullBuild"
  ==> "Cluster"
  
RunTargetOrListTargets()


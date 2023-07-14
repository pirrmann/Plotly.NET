(**
---
title: 3D point and line charts
category: 3D Charts
categoryindex: 4
index: 1
---
*)


(*** hide ***)

(*** condition: prepare ***)
#r "nuget: Newtonsoft.JSON, 13.0.1"
#r "nuget: DynamicObj, 2.0.0"
#r "nuget: Giraffe.ViewEngine.StrongName, 2.0.0-alpha1"
#r "../src/Plotly.NET/bin/Release/netstandard2.0/Plotly.NET.dll"

Plotly.NET.Defaults.DefaultDisplayOptions <-
    Plotly.NET.DisplayOptions.init (PlotlyJSReference = Plotly.NET.PlotlyJSReference.NoReference)

(*** condition: ipynb ***)
#if IPYNB
#r "nuget: Plotly.NET, {{fsdocs-package-version}}"
#r "nuget: Plotly.NET.Interactive, {{fsdocs-package-version}}"
#endif // IPYNB

(** 
# 3D point plots

[![Binder]({{root}}img/badge-binder.svg)](https://mybinder.org/v2/gh/plotly/plotly.net/gh-pages?urlpath=/tree/home/jovyan/{{fsdocs-source-basename}}.ipynb)&emsp;
[![Script]({{root}}img/badge-script.svg)]({{root}}{{fsdocs-source-basename}}.fsx)&emsp;
[![Notebook]({{root}}img/badge-notebook.svg)]({{root}}{{fsdocs-source-basename}}.ipynb)

*Summary:* This example shows how to create three-dimensional point and line charts in F#.

Point3D, Line3D, and Bubble3D charts are all derived from `Chart.Scatter3D` and can be generated by that function as well.
However, `Chart.Point3D`, `Chart.Line3D`, or `Chart.Bubble3D` provide sensible defaults and arguments for the respective derived chart, and are recommended to use.

## 3D point chart
*)

open Plotly.NET

let point3d =
    Chart.Point3D(
        xyz = [ 1, 3, 2; 6, 5, 4; 7, 9, 8 ],
        MultiText = [ "A"; "B"; "C" ],
        TextPosition = StyleParam.TextPosition.BottomCenter
    )
    |> Chart.withXAxisStyle ("my x-axis", Id = StyleParam.SubPlotId.Scene 1) // in contrast to 2D plots, x and y axes of 3D charts have to be set via the scene object
    |> Chart.withYAxisStyle ("my y-axis", Id = StyleParam.SubPlotId.Scene 1) // in contrast to 2D plots, x and y axes of 3D charts have to be set via the scene object
    |> Chart.withZAxisStyle ("my z-axis")
    |> Chart.withSize (800., 800.)

(*** condition: ipynb ***)
#if IPYNB
point3d
#endif // IPYNB

(***hide***)
point3d |> GenericChart.toChartHTML
(*** include-it-raw ***)

(**
## 3D point chart with marker colorscale
*)

let point3d2 =
    Chart.Point3D(
        xyz = [ 1, 3, 2; 6, 5, 4; 7, 9, 8 ],
        MarkerColor = Color.fromColorScaleValues [ 0; 1; 2 ],
        MultiText = [ "A"; "B"; "C" ],
        TextPosition = StyleParam.TextPosition.BottomCenter
    )

(*** condition: ipynb ***)
#if IPYNB
point3d2
#endif // IPYNB

(***hide***)
point3d2 |> GenericChart.toChartHTML
(*** include-it-raw ***)

(**
# 3D Line chart
*)

let line3d =
    Chart.Line3D(
        xyz = [ 1, 3, 2; 6, 5, 4; 7, 9, 8 ],
        MultiText = [ "A"; "B"; "C" ],
        TextPosition = StyleParam.TextPosition.BottomCenter,
        ShowMarkers = true
    )

(*** condition: ipynb ***)
#if IPYNB
line3d
#endif // IPYNB

(***hide***)
line3d |> GenericChart.toChartHTML
(*** include-it-raw ***)

(**
## 3D line chart with line colorscale
*)

let line3d2 =
    Chart.Line3D(
        xyz = [ 1, 3, 2; 6, 5, 4; 7, 9, 8 ],
        MultiText = [ "A"; "B"; "C" ],
        TextPosition = StyleParam.TextPosition.BottomCenter,
        ShowMarkers = true,
        LineColor = Color.fromColorScaleValues [ 0; 1; 2 ],
        LineWidth = 10.
    )

(*** condition: ipynb ***)
#if IPYNB
line3d2
#endif // IPYNB

(***hide***)
line3d2 |> GenericChart.toChartHTML
(*** include-it-raw ***)


(**
# 3D Bubble plots
*)

let bubble3d =
    Chart.Bubble3D(
        xyz = [ 1, 3, 2; 6, 5, 4; 7, 9, 8 ],
        sizes = [ 10; 20; 30 ],
        MultiText = [ "A"; "B"; "C" ],
        TextPosition = StyleParam.TextPosition.BottomCenter
    )

(*** condition: ipynb ***)
#if IPYNB
bubble3d
#endif // IPYNB

(***hide***)
bubble3d |> GenericChart.toChartHTML
(*** include-it-raw ***)


(**
## 3D bubble chart with colorscale
*)

let bubble3d2 =
    Chart.Bubble3D(
        xyz = [ 1, 3, 2; 6, 5, 4; 7, 9, 8 ],
        sizes = [ 10; 20; 30 ],
        MultiText = [ "A"; "B"; "C" ],
        TextPosition = StyleParam.TextPosition.BottomCenter,
        MarkerColor = Color.fromColorScaleValues [ 0; 1; 2 ],
        MarkerColorScale = StyleParam.Colorscale.Viridis
    )

(*** condition: ipynb ***)
#if IPYNB
bubble3d2
#endif // IPYNB

(***hide***)
bubble3d2 |> GenericChart.toChartHTML
(*** include-it-raw ***)

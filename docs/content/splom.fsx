(*** hide ***)
#r "../../bin/Plotly.NET/net5.0/Plotly.NET.dll"

(** 
# Scatterplot matrix 

*Summary:* This example shows how to plot a scatterplot matrix (splom) in F#.

let's first create some data for the purpose of creating example charts:

*)

open Plotly.NET 

let data = 
    [
        'A',[|1.;4.;3.4;0.7;|]
        'B',[|3.;1.5;1.7;2.3;|]
        'C',[|2.;4.;3.1;5.|]
        'D',[|4.;2.;2.;4.;|]
    ]

(**
Using a scatterplot matrix of several different variables can help to determine whether there are any
relationships among the variables in the dataset.

**Attention**: this function is not very well tested and does not use the `Chart.Grid` functionality. 
Until that is fixed, consider creating splom plot programatically using `Chart.Grid` for more control.
*)

let splom1 =
    Chart.Splom(data,Color="blue")

(***hide***)
splom1 |> GenericChart.toChartHTML
(***include-it-raw***)






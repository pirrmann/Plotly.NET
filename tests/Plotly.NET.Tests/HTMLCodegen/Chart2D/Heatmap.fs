namespace Plotly.NET.Tests.HTMLCodegen.Chart2D

open Expecto
open Plotly.NET
open Plotly.NET.LayoutObjects
open Plotly.NET.TraceObjects
open Plotly.NET.GenericChart

open TestUtils.HtmlCodegen
module Heatmap =
    [<Tests>]
    let ``Heatmap tests`` =
        testList "Heatmap" []

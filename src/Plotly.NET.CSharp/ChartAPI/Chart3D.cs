﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plotly.NET;
using Plotly.NET.LayoutObjects;
using Plotly.NET.TraceObjects;

namespace Plotly.NET.CSharp
{
    public static partial class Chart
    {
        /// <summary>
        /// Creates a Scatter3D plot.
        ///
        /// In general, Scatter3D Plots plot three-dimensional data on 3 cartesian position scales in the X, Y, and Z dimension.
        ///
        /// Scatter3D charts are the basis of Point3D, Line3D, and Bubble3D Charts, and can be customized as such. We also provide abstractions for those: Chart.Line3D, Chart.Point3D, Chart.Bubble3D
        /// </summary>
        /// <param name="x">Sets the x coordinates of the plotted data.</param>
        /// <param name="y">Sets the y coordinates of the plotted data.</param>
        /// <param name="z">Sets the z coordinates of the plotted data.</param>
        /// <param name="mode">Determines the drawing mode for this scatter trace.</param>
        /// <param name="Name">Sets the trace name. The trace name appear as the legend item and on hover</param>
        /// <param name="ShowLegend">Determines whether or not an item corresponding to this trace is shown in the legend.</param>
        /// <param name="Opacity">Sets the opactity of the trace</param>
        /// <param name="MultiOpacity">Sets the opactity of individual datum markers</param>
        /// <param name="Text">Sets a text associated with each datum</param>
        /// <param name="MultiText">Sets individual text for each datum</param>
        /// <param name="TextPosition">Sets the position of text associated with each datum</param>
        /// <param name="MultiTextPosition">Sets the position of text associated with individual datum</param>
        /// <param name="MarkerColor">Sets the color of the marker</param>
        /// <param name="MarkerColorScale">Sets the colorscale of the marker</param>
        /// <param name="MarkerOutline">Sets the outline of the marker</param>
        /// <param name="MarkerSymbol">Sets the marker symbol for each datum</param>
        /// <param name="MultiMarkerSymbol">Sets the marker symbol for each individual datum</param>
        /// <param name="Marker">Sets the marker (use this for more finegrained control than the other marker-associated arguments)</param>
        /// <param name="LineColor">Sets the color of the line</param>
        /// <param name="LineColorScale">Sets the colorscale of the line</param>
        /// <param name="LineWidth">Sets the width of the line</param>
        /// <param name="LineDash">sets the drawing style of the line</param>
        /// <param name="Line">Sets the line (use this for more finegrained control than the other line-associated arguments)</param>
        /// <param name="Projection">Sets the projection of this trace.</param>
        /// <param name="UseDefaults">If set to false, ignore the global default settings set in `Defaults`</param>
        public static GenericChart.GenericChart Scatter3D<XData, YData, ZData, TextData>(
            IEnumerable<XData> x,
            IEnumerable<YData> y,
            IEnumerable<ZData> z,
            StyleParam.Mode mode,
            string? Name = null,
            bool? ShowLegend = null,
            double? Opacity = null,
            IEnumerable<double>? MultiOpacity = null,
            TextData? Text = null,
            IEnumerable<TextData>? MultiText = null,
            StyleParam.TextPosition? TextPosition = null,
            IEnumerable<StyleParam.TextPosition>? MultiTextPosition = null,
            Color? MarkerColor = null,
            StyleParam.Colorscale? MarkerColorScale = null,
            Line? MarkerOutline = null,
            StyleParam.MarkerSymbol3D? MarkerSymbol = null,
            IEnumerable<StyleParam.MarkerSymbol3D>? MultiMarkerSymbol = null,
            Marker? Marker = null,
            Color? LineColor = null,
            StyleParam.Colorscale? LineColorScale = null,
            double? LineWidth = null,
            StyleParam.DrawingStyle? LineDash = null,
            Line? Line = null,
            Projection? Projection = null,
            bool? UseDefaults = null
        )
            where XData: IConvertible
            where YData: IConvertible
            where ZData: IConvertible
            where TextData: class, IConvertible
            
            => Plotly.NET.Chart3D.Chart.Scatter3D<XData, YData, ZData, TextData>(
                x: x,
                y: y,
                z: z,
                mode: mode,
                Name: Helpers.ToOption(Name),
                ShowLegend: Helpers.ToOptionV(ShowLegend),
                Opacity: Helpers.ToOptionV(Opacity),
                MultiOpacity: Helpers.ToOption(MultiOpacity),
                Text: Helpers.ToOption(Text),
                MultiText: Helpers.ToOption(MultiText),
                TextPosition: Helpers.ToOption(TextPosition),
                MultiTextPosition: Helpers.ToOption(MultiTextPosition),
                MarkerColor: Helpers.ToOption(MarkerColor),
                MarkerColorScale: Helpers.ToOption(MarkerColorScale),
                MarkerOutline: Helpers.ToOption(MarkerOutline),
                MarkerSymbol: Helpers.ToOption(MarkerSymbol),
                MultiMarkerSymbol: Helpers.ToOption(MultiMarkerSymbol),
                Marker: Helpers.ToOption(Marker),
                LineColor: Helpers.ToOption(LineColor),
                LineColorScale: Helpers.ToOption(LineColorScale),
                LineWidth: Helpers.ToOptionV(LineWidth),
                LineDash: Helpers.ToOption(LineDash),
                Line: Helpers.ToOption(Line),
                Projection: Helpers.ToOption(Projection),
                UseDefaults: Helpers.ToOptionV(UseDefaults)
            );
    }
}
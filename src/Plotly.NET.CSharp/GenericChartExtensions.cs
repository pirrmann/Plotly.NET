﻿using Plotly.NET;
using Plotly.NET.LayoutObjects;
using Plotly.NET.TraceObjects;

namespace Plotly.NET.CSharp
{
    /// <summary>
    /// Extension methods for fluid-style chart styling and creation API.
    /// </summary>
    public static class GenericChartExtensions
    {
        /// <summary>
        /// Returns the layout of the given chart
        /// </summary>
        /// <param name="gChart">The chart of which to get the layout</param>
        public static Layout GetLayout(this GenericChart.GenericChart gChart) => GenericChart.getLayout(gChart);

        /// <summary>
        /// Returns all traces of the given chart as an array
        /// </summary>
        /// <param name="gChart">The chart of which to get all traces</param>
        public static Trace [] GetTraces(this GenericChart.GenericChart gChart) => GenericChart.getTraces(gChart).ToArray();

        /// <summary>
        /// Saves the given Chart as html file at the given path (.html file extension is added if not present).
        /// Optionally opens the generated file in the browser.
        /// </summary>
        /// <param name="gChart">The chart to save as html file.</param>
        /// <param name="path">The path to save the chart html at.</param>
        /// <param name="OpenInBrowser">Wether or not to open the generated file in the browser (default: false)</param>
        public static void SaveHtml(
            this GenericChart.GenericChart gChart,
            string path,
            bool? OpenInBrowser = null
        ) =>
            Plotly.NET.Chart.SaveHtml(
                path: path,
                OpenInBrowser: OpenInBrowser.ToOptionV()
            ).Invoke(gChart);

        /// <summary>
        /// Saves the given chart as a temporary html file and opens it in the browser.
        /// </summary>
        /// <param name="gChart">The chart to show in the browser</param>
        public static void Show(this GenericChart.GenericChart gChart) => Plotly.NET.Chart.Show(gChart);

        /// <summary>
        /// Sets trace information on the given chart.
        /// </summary>
        /// <param name="gChart">The chart in which to change the trace info</param>
        /// <param name="Name">Sets the name of the chart's trace(s). When the chart is a multichart (it contains multiple traces), the name is suffixed by '_%i' where %i is the index of the trace.</param>
        /// <param name="Visible">Wether or not the chart's traces are visible</param>
        /// <param name="ShowLegend">Determines whether or not item(s) corresponding to this chart's trace(s) is/are shown in the legend.</param>
        /// <param name="LegendRank">Sets the legend rank for the chart's trace(s). Items and groups with smaller ranks are presented on top/left side while with `"reversed" `legend.traceorder` they are on bottom/right side. The default legendrank is 1000, so that you can use ranks less than 1000 to place certain items before all unranked items, and ranks greater than 1000 to go after all unranked items.</param>
        /// <param name="LegendGroup">Sets the legend group for the chart's trace(s). Traces part of the same legend group hide/show at the same time when toggling legend items.</param>
        /// <param name="LegendGroupTitle">Sets the title for the chart's trace legend group </param>
        public static GenericChart.GenericChart WithTraceInfo(
            this GenericChart.GenericChart gChart,
            string? Name = null,
            StyleParam.Visible? Visible = null,
            bool? ShowLegend = null,
            int? LegendRank = null,
            string? LegendGroup = null,
            Title? LegendGroupTitle = null
        ) =>
            Plotly.NET.Chart.WithTraceInfo(
                Name: Name.ToOption(),
                Visible: Visible.ToOption(),
                ShowLegend: ShowLegend.ToOptionV(),
                LegendRank: LegendRank.ToOptionV(),
                LegendGroup: LegendGroup.ToOption(),
                LegendGroupTitle: LegendGroupTitle.ToOption()
            ).Invoke(gChart);

        /// Sets the size of a Chart (in pixels)
        public static GenericChart.GenericChart WithSize(
            this GenericChart.GenericChart gChart,
            int? Width = null,
            int? Height = null
        ) =>
            Plotly.NET.Chart.WithSize(Width: Width.ToOptionV(), Height: Height.ToOptionV()).Invoke(gChart);

        /// <summary>
        /// Sets the given x axis styles on the input chart's layout.
        ///
        /// If there is already an axis set at the given id, the styles are applied to it. If there is no axis present, a new LinearAxis object with the given styles will be set.
        /// </summary>
        /// <param name="gChart">The chart in which to change the X axis style</param>
        /// <param name="TitleText">Sets the text of the axis title.</param>
        /// <param name="TitleFont">Sets the font of the axis title.</param>
        /// <param name="TitleStandoff">Sets the standoff distance (in px) between the axis labels and the title text.</param>
        /// <param name="Title">Sets the Title (use this for more finegrained control than the other title-associated arguments)</param>
        /// <param name="Color">Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors.</param>
        /// <param name="AxisType">Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.</param>
        /// <param name="MinMax">Tuple of (Min*Max value). Sets the range of this axis (the axis will go from Min to Max). If the axis `type` is "log", then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2).</param>
        /// <param name="Mirror">Determines if and how the axis lines or/and ticks are mirrored to the opposite side of the plotting area.</param>
        /// <param name="ShowSpikes">Determines whether or not spikes (aka droplines) are drawn for this axis.</param>
        /// <param name="SpikeColor">Sets the spike color. If not set, will use the series color</param>
        /// <param name="SpikeThickness">Sets the width (in px) of the zero line.</param>
        /// <param name="ShowLine">Determines whether or not a line bounding this axis is drawn.</param>
        /// <param name="LineColor">Sets the axis line color.</param>
        /// <param name="ShowGrid">Determines whether or not grid lines are drawn. If "true", the grid lines are drawn at every tick mark.</param>
        /// <param name="GridColor">Sets the color of the grid lines.</param>
        /// <param name="ZeroLine">Determines whether or not a line is drawn at along the 0 value of this axis. If "true", the zero line is drawn on top of the grid lines.</param>
        /// <param name="ZeroLineColor">Sets the line color of the zero line.</param>
        /// <param name="Anchor">If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to "free", this axis' position is determined by `position`.</param>
        /// <param name="Side">Determines whether a x (y) axis is positioned at the "bottom" ("left") or "top" ("right") of the plotting area.</param>
        /// <param name="Overlaying">If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If "false", this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.</param>
        /// <param name="Domain">Tuple of (X*Y fractions). Sets the domain of this axis (in plot fraction).</param>
        /// <param name="Position">Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to "free".</param>
        /// <param name="CategoryOrder">Specifies the ordering logic for the case of categorical variables. By default, plotly uses "trace", which specifies the order that is present in the data supplied. Set `categoryorder` to "category ascending" or "category descending" if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to "array" to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the "trace" mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to "total ascending" or "total descending" if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.</param>
        /// <param name="CategoryArray">Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to "array". Used with `categoryorder`.</param>
        /// <param name="RangeSlider">Sets a range slider for this axis</param>
        /// <param name="RangeSelector">Sets a range selector for this axis. This object contains toggable presets for the rangeslider.</param>
        /// <param name="BackgroundColor">Sets the background color of this axis' wall. (Only has an effect on 3D scenes)</param>
        /// <param name="ShowBackground">Sets whether or not this axis' wall has a background color. (Only has an effect on 3D scenes)</param>
        /// <param name="Id">The target axis id on which the styles should be applied. Default is 1.</param>
        public static GenericChart.GenericChart WithXAxisStyle<MinType, MaxType, CategoryArrayType>(
            this GenericChart.GenericChart gChart,
            string? TitleText = null,
            Font? TitleFont = null,
            int? TitleStandoff = null,
            Title? Title = null,
            Color? Color = null,
            StyleParam.AxisType? AxisType = null,
            Tuple<MinType, MaxType>? MinMax = null,
            StyleParam.Mirror? Mirror = null,
            bool? ShowSpikes = null,
            Color? SpikeColor = null,
            int? SpikeThickness = null,
            bool? ShowLine = null,
            Color? LineColor = null,
            bool? ShowGrid = null,
            Color? GridColor = null,
            bool? ZeroLine = null,
            Color? ZeroLineColor = null,
            StyleParam.LinearAxisId? Anchor = null,
            StyleParam.Side? Side = null,
            StyleParam.LinearAxisId? Overlaying = null,
            Tuple<double, double>? Domain = null,
            double? Position = null,
            StyleParam.CategoryOrder? CategoryOrder = null,
            IEnumerable<CategoryArrayType>? CategoryArray = null,
            RangeSlider? RangeSlider = null,
            RangeSelector? RangeSelector = null,
            Color? BackgroundColor = null,
            bool? ShowBackground = null,
            StyleParam.SubPlotId? Id = null
        )
            where MinType : IConvertible
            where MaxType : IConvertible
            where CategoryArrayType : class, IConvertible
            =>
                Plotly.NET.Chart.WithXAxisStyle<MinType, MaxType, CategoryArrayType>(
                    TitleText: TitleText.ToOption(),
                    TitleFont: TitleFont.ToOption(),
                    TitleStandoff: TitleStandoff.ToOptionV(),
                    Title: Title.ToOption(),
                    Color: Color.ToOption(),
                    AxisType: AxisType.ToOption(),
                    MinMax: MinMax.ToOption(),
                    Mirror: Mirror.ToOption(),
                    ShowSpikes: ShowSpikes.ToOptionV(),
                    SpikeColor: SpikeColor.ToOption(),
                    SpikeThickness: SpikeThickness.ToOptionV(),
                    ShowLine: ShowLine.ToOptionV(),
                    LineColor: LineColor.ToOption(),
                    ShowGrid: ShowGrid.ToOptionV(),
                    GridColor: GridColor.ToOption(),
                    ZeroLine: ZeroLine.ToOptionV(),
                    ZeroLineColor: ZeroLineColor.ToOption(),
                    Anchor: Anchor.ToOption(),
                    Side: Side.ToOption(),
                    Overlaying: Overlaying.ToOption(),
                    Domain: Domain.ToOption(),
                    Position: Position.ToOptionV(),
                    CategoryOrder: CategoryOrder.ToOption(),
                    CategoryArray: CategoryArray.ToOption(),
                    RangeSlider: RangeSlider.ToOption(),
                    RangeSelector: RangeSelector.ToOption(),
                    BackgroundColor: BackgroundColor.ToOption(),
                    ShowBackground: ShowBackground.ToOptionV(),
                    Id: Id.ToOption()

                ).Invoke(gChart);

        /// <summary>
        /// Sets the given y axis styles on the input chart's layout.
        ///
        /// If there is already an axis set at the given id, the styles are applied to it. If there is no axis present, a new LinearAxis object with the given styles will be set.
        /// </summary>
        /// <param name="gChart">The chart in which to change the Y axis style</param>
        /// <param name="TitleText">Sets the text of the axis title.</param>
        /// <param name="TitleFont">Sets the font of the axis title.</param>
        /// <param name="TitleStandoff">Sets the standoff distance (in px) between the axis labels and the title text.</param>
        /// <param name="Title">Sets the Title (use this for more finegrained control than the other title-associated arguments)</param>
        /// <param name="Color">Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors.</param>
        /// <param name="AxisType">Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.</param>
        /// <param name="MinMax">Tuple of (Min*Max value). Sets the range of this axis (the axis will go from Min to Max). If the axis `type` is "log", then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2).</param>
        /// <param name="Mirror">Determines if and how the axis lines or/and ticks are mirrored to the opposite side of the plotting area.</param>
        /// <param name="ShowSpikes">Determines whether or not spikes (aka droplines) are drawn for this axis.</param>
        /// <param name="SpikeColor">Sets the spike color. If not set, will use the series color</param>
        /// <param name="SpikeThickness">Sets the width (in px) of the zero line.</param>
        /// <param name="ShowLine">Determines whether or not a line bounding this axis is drawn.</param>
        /// <param name="LineColor">Sets the axis line color.</param>
        /// <param name="ShowGrid">Determines whether or not grid lines are drawn. If "true", the grid lines are drawn at every tick mark.</param>
        /// <param name="GridColor">Sets the color of the grid lines.</param>
        /// <param name="ZeroLine">Determines whether or not a line is drawn at along the 0 value of this axis. If "true", the zero line is drawn on top of the grid lines.</param>
        /// <param name="ZeroLineColor">Sets the line color of the zero line.</param>
        /// <param name="Anchor">If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to "free", this axis' position is determined by `position`.</param>
        /// <param name="Side">Determines whether a x (y) axis is positioned at the "bottom" ("left") or "top" ("right") of the plotting area.</param>
        /// <param name="Overlaying">If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If "false", this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.</param>
        /// <param name="Domain">Tuple of (X*Y fractions). Sets the domain of this axis (in plot fraction).</param>
        /// <param name="Position">Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to "free".</param>
        /// <param name="CategoryOrder">Specifies the ordering logic for the case of categorical variables. By default, plotly uses "trace", which specifies the order that is present in the data supplied. Set `categoryorder` to "category ascending" or "category descending" if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to "array" to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the "trace" mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to "total ascending" or "total descending" if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.</param>
        /// <param name="CategoryArray">Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to "array". Used with `categoryorder`.</param>
        /// <param name="RangeSlider">Sets a range slider for this axis</param>
        /// <param name="RangeSelector">Sets a range selector for this axis. This object contains toggable presets for the rangeslider.</param>
        /// <param name="BackgroundColor">Sets the background color of this axis' wall. (Only has an effect on 3D scenes)</param>
        /// <param name="ShowBackground">Sets whether or not this axis' wall has a background color. (Only has an effect on 3D scenes)</param>
        /// <param name="Id">The target axis id on which the styles should be applied. Default is 1.</param>
        public static GenericChart.GenericChart WithYAxisStyle<MinType, MaxType, CategoryArrayType>(
            this GenericChart.GenericChart gChart,
            string? TitleText = null,
            Font? TitleFont = null,
            int? TitleStandoff = null,
            Title? Title = null,
            Color? Color = null,
            StyleParam.AxisType? AxisType = null,
            Tuple<MinType, MaxType>? MinMax = null,
            StyleParam.Mirror? Mirror = null,
            bool? ShowSpikes = null,
            Color? SpikeColor = null,
            int? SpikeThickness = null,
            bool? ShowLine = null,
            Color? LineColor = null,
            bool? ShowGrid = null,
            Color? GridColor = null,
            bool? ZeroLine = null,
            Color? ZeroLineColor = null,
            StyleParam.LinearAxisId? Anchor = null,
            StyleParam.Side? Side = null,
            StyleParam.LinearAxisId? Overlaying = null,
            Tuple<double, double>? Domain = null,
            double? Position = null,
            StyleParam.CategoryOrder? CategoryOrder = null,
            IEnumerable<CategoryArrayType>? CategoryArray = null,
            RangeSlider? RangeSlider = null,
            RangeSelector? RangeSelector = null,
            Color? BackgroundColor = null,
            bool? ShowBackground = null,
            StyleParam.SubPlotId? Id = null
        )
            where MinType : IConvertible
            where MaxType : IConvertible
            where CategoryArrayType : class, IConvertible
            =>
                Plotly.NET.Chart.WithYAxisStyle<MinType, MaxType, CategoryArrayType>(
                    TitleText: TitleText.ToOption(),
                    TitleFont: TitleFont.ToOption(),
                    TitleStandoff: TitleStandoff.ToOptionV(),
                    Title: Title.ToOption(),
                    Color: Color.ToOption(),
                    AxisType: AxisType.ToOption(),
                    MinMax: MinMax.ToOption(),
                    Mirror: Mirror.ToOption(),
                    ShowSpikes: ShowSpikes.ToOptionV(),
                    SpikeColor: SpikeColor.ToOption(),
                    SpikeThickness: SpikeThickness.ToOptionV(),
                    ShowLine: ShowLine.ToOptionV(),
                    LineColor: LineColor.ToOption(),
                    ShowGrid: ShowGrid.ToOptionV(),
                    GridColor: GridColor.ToOption(),
                    ZeroLine: ZeroLine.ToOptionV(),
                    ZeroLineColor: ZeroLineColor.ToOption(),
                    Anchor: Anchor.ToOption(),
                    Side: Side.ToOption(),
                    Overlaying: Overlaying.ToOption(),
                    Domain: Domain.ToOption(),
                    Position: Position.ToOptionV(),
                    CategoryOrder: CategoryOrder.ToOption(),
                    CategoryArray: CategoryArray.ToOption(),
                    RangeSlider: RangeSlider.ToOption(),
                    RangeSelector: RangeSelector.ToOption(),
                    BackgroundColor: BackgroundColor.ToOption(),
                    ShowBackground: ShowBackground.ToOptionV(),
                    Id: Id.ToOption()

                ).Invoke(gChart);
    }

}
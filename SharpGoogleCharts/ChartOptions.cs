using System.Collections.Generic;

namespace SharpGoogleCharts
{
    public class ChartOptions
    {
        public PlotChartType ChartType { get; set; }
        public List<ChartCurveOptions> Curves { get; set; }
        public PlotResolution Resolution { get; set; }
        public AxisOptions XAxis { get; set; }
        public bool Showlegend { get; set; }
        public bool Showgrid { get; set; }
        public AxisOptions YAxis { get; set; }

        public ChartOptions()
        {
            ChartType = PlotChartType.Line;
            Curves = new List<ChartCurveOptions>();
            Resolution = PlotResolution.None;
            XAxis = new AxisOptions();
            YAxis = new AxisOptions();
        }
    }


}
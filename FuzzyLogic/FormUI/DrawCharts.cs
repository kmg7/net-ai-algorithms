namespace FormUI
{
    public partial class MainForm : Form
    {
        public void DrawInputCharts()
        {
            Dictionary<String, List<double[]>> sensitivitySeries = new()
            {
                { "STRONG",
                [
                    [0,1],
                    [1,1],
                    [2,1],
                    [4,0]
                ] },
                {"MEDIUM",
                [
                    [3,0],
                    [5,1],
                    [7,0]
                ]},
                {"SENSITIVE",
                [
                    [5.5, 0],
                    [8, 1],
                    [9,1],
                    [10,1]
                    ]}
            };
            Dictionary<String, List<double[]>> quantitySeries = new()
            {
                { "SMALL",
                [
                    [0,1],
                    [1,1],
                    [2,1],
                    [4,0]
                ] },
                {"MEDIUM",
                [
                    [3,0],
                    [5,1],
                    [7,0]
                ]},
                {"LARGE",
                [
                    [5.5, 0],
                    [8, 1],
                    [9,1],
                    [10,1]
                    ]}
            };
            Dictionary<String, List<double[]>> dirtinessSeries = new()
            {
                { "SMALL",
                [
                    [0,1],
                    [1,1],
                    [2,1],
                    [4.5,0]
                ] },
                {"MEDIUM",
                [
                    [3,0],
                    [5,1],
                    [7,0]
                ]},
                {"LARGE",
                [
                    [5.5, 0],
                    [8, 1],
                    [9,1],
                    [10,1]
                    ]}
            };
            chart_sensitivity.DrawChart(sensitivitySeries);
            chart_quantity.DrawChart(quantitySeries);
            chart_dirtiness.DrawChart(dirtinessSeries);
        }
        public void DrawOutputCharts()
        {
            Dictionary<String, List<double[]>> spinrateSeries = new()
            {
                { "SENSITIVE",
                [
                    [0,1],
                    [0.25,1],
                    [0.5,1],
                    [1.5,0]
                ] },
                {"AVG-SENSITIVE",
                [
                    [0.5,0],
                    [2.75,1],
                    [5,0]
                ]},
                {"MEDIUM",
                [
                    [2.75, 0],
                    [5, 1],
                    [7.25,0],
                    ]},
                {"AVG-STRONG",
                [
                    [5, 0],
                    [7.25,1],
                    [9.5,0],
                    ]},
                {"STRONG",
                [
                    [8.5, 0],
                    [9.5, 1],
                    [10,1],
                    ]}
            };

            Dictionary<String, List<double[]>> timeSeries = new()
            {
                { "SHORT",
                [
                    [0,1],
                    [22.3,1],
                    [39.9,0]
                ] },
                {"AVG-SHORT",
                [
                    [22.3,0],
                    [39.9,1],
                    [57.5,0],
                ]},
                {"MEDIUM",
                [
                    [39.9,0],
                    [57.5,1],
                    [75.1,0]
                    ]},
                {"AVG-LONG",
                [
                    [57.5,0],
                    [75.1,1],
                    [92.7,0],
                    ]},
                {"LONG",
                [
                    [75,0],
                    [92.7,1],
                    [100, 1],
                    ]}
        };
            Dictionary<String, List<double[]>> detergentSeries = new()
            {
                { "TOO-FEW",
                [
                    [0,1],
                    [20,1],
                    [85,0]
                ] },
                {"FEW",
                [
                    [20,0],
                    [85,1],
                    [150,0]
                ]},
                {"MEDIUM",
                [
                    [85, 0],
                    [150, 1],
                    [215,0],
                    ]},
                {"MUCH",
                [
                    [150,0],
                    [215,1],
                    [280,0]
                ]},
                {"TOO-MUCH",
                [
                    [215,0],
                    [280,1],
                    [300,1],
                ]},
            };
            chart_spinrate.DrawChart(spinrateSeries);
            chart_time.DrawChart(timeSeries);
            chart_detergent.DrawChart(detergentSeries);
        }

    }
}

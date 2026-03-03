using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms;
using System.Windows.Media;

namespace ChartTest
{
    public partial class MainForm : Form
    {

        void FillCartesianChart()
        {
            LineSeries series = new LineSeries
            {
                Title = "Продажи",
                Values = new ChartValues<int> { 10, 15, 25, 23, 25, 22 },

                Stroke = new SolidColorBrush(Colors.Pink),
                StrokeThickness = 2,

                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 7,

                Fill = new LinearGradientBrush(
                    System.Windows.Media.Color.FromArgb(123, 01, 160, 243),
                    System.Windows.Media.Color.FromArgb(40, 33, 150, 243),
                    90)
            };

            cartesian.Series = new SeriesCollection { series, /*series_2, series_3*/ };

            /// Ось Y
            cartesian.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                LabelFormatter = value => value.ToString("N0"),

                Separator = new Separator
                {
                    Stroke = new SolidColorBrush(Color.FromArgb(40, 0, 0, 0)),
                    StrokeThickness = 1
                },

                MaxValue = 30,
                MinValue = 1
            }              
            );


            /// Ось X
            cartesian.AxisX.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                Labels = new[] { "Янв", "Фев", "Мар", "Апр", "Май", "Июн" },

                Separator = new Separator
                {
                    IsEnabled = false,
                },
            }
            );
        }

        void FillAngular()
        {
            angular.Value = 23;
            angular.FromValue = 0;
            angular.ToValue = 100;

            angular.TicksForeground = Brushes.Gray;
            angular.NeedleFill = Brushes.DarkBlue;
        }

        void FillSolid()
        {
            solid.Value = 40;
            solid.From = 0;
            solid.To = 100;
            solid.LabelFormatter = value => value + "%";
        }
        public MainForm()
        {
            InitializeComponent();

            FillCartesianChart();

            FillAngular();

            FillSolid();
        }
    }
}

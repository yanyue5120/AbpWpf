using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Controls;

namespace DataCollectionAndAnalysis.MyUserControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> { 3, 5, 7, 4 }
                },
                 new ColumnSeries
                {
                    Values = new ChartValues<decimal> { 5, 6, 2, 7 }
                }
            };

            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }
    }
}
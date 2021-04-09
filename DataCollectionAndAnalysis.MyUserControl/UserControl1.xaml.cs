using DataCollectionAndAnalysis.MyUserControl.ViewModel;
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

            DataContext = new UserControl1Vm();
        }
    }
}
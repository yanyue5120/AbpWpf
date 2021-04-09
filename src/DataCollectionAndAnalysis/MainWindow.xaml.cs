using DataCollectionAndAnalysis.Service.Contracts.IService;
using Serilog;
using System;
using System.Windows;

namespace DataCollectionAndAnalysis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IHellowWorldService _helloWorldService;

        public MainWindow(IHellowWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
            InitializeComponent();
        }

        protected override void OnContentRendered(EventArgs e)
        {
            try
            {
                var res = int.Parse("asdf");
                HelloLabel.Content = _helloWorldService.Run();
                Log.Debug("==========Hellow World !==========");
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
    }
}

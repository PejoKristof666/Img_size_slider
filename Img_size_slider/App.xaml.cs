using Img_size_slider.Model;
using Img_size_slider.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Img_size_slider
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindow _window;
        private VieWModel _viewmodel;
        private PModel _model;
        public App()
        {
            Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            _model = new PModel();
            _window = new MainWindow();
            _viewmodel = new VieWModel(_model);
            _window.DataContext = _viewmodel;
            _window.Show();
        }
    }
}

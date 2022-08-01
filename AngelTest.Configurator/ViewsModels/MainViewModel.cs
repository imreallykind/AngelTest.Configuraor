using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace AngelTest.Configurator.ViewsModels
{
    class MainViewModel : ViewModelBase
    {
        private Page UsersAdd;
        private Page UsersPg;
        private Page MainWindow;

        public MainViewModel()
        {
            MainWindow = new Pages.MainWindow();
        }
    }
}

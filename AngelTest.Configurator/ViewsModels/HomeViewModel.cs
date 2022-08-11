using AngelTest.Configurator.Commands;
using AngelTest.Configurator.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AngelTest.Configurator.ViewsModels
{
    class HomeViewModel : ViewModelBase
    {


        public ICommand NavigateCommand { get; }
        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateCommand = new NavigateCommand<UsersViewModel>(navigationStore, () => new UsersViewModel(navigationStore));
        }
    }
}

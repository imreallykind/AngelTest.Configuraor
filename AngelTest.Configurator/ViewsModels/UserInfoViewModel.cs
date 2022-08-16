using AngelTest.Configurator.Models;
using AngelTest.Configurator.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AngelTest.Configurator.ViewsModels
{
    class UserInfoViewModel : ViewModelBase
    {

        public ICommand NavigateCommand { get; }
        public UserInfoViewModel(NavigationStore navigationStore, User SelectedUser)
        {

        }

    }
}
    


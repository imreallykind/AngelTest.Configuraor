using AngelTest.Configurator.Commands;
using AngelTest.Configurator.Models;
using AngelTest.Configurator.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AngelTest.Configurator.ViewsModels
{
    class UsersViewModel : ViewModelBase
    {
        public User _selectedUser;
        public ObservableCollection<User> Users { get; set; }
        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        public ICommand NavigateUser { get; }
        public ICommand NavigateCommand { get; }

        public UsersViewModel(NavigationStore navigationStore)
        {
            Users = new ObservableCollection<User>
            {
                new User{Id = 1, Login = "Гриша", Password = "1234"},
                new User{Id = 2, Login = "Олежа", Password = "1dd34"},
            };
            NavigateCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
            NavigateUser = new NavigateUser<UserInfoViewModel>(navigationStore, () => new UserInfoViewModel(navigationStore, SelectedUser));
        }

    }
}

using RegistrationApp.WPF.Commands;
using RegistrationApp.WPF.MVVM.Models;
using RegistrationApp.WPF.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegistrationApp.WPF.State.Navigation
{
    public class Navigator : ObservableObject, INavigator
    {
        #region CurrentViewModel
        private BaseViewModel _currentViewModel = new CallCenterOperatorViewModel();
        public BaseViewModel CurrentViewModel 
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));

            }
        }
        #endregion

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentVIewModelCommand(this);

    }
}

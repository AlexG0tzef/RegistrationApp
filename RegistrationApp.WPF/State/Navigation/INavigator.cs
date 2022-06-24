using RegistrationApp.WPF.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegistrationApp.WPF.State.Navigation
{
    public interface INavigator
    {
        BaseViewModel CurrentViewModal { get; set; }
        ICommand UpdateCurrentViewModalCommand { get; }
    }
}

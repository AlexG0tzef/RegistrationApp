using RegistrationApp.WPF.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegistrationApp.WPF.State.Navigation
{
    public enum ViewType
    {
        Guid,
        Registration,
        AnnualReports,
        CallCenter,
        Correspondence,
        Downloads,
        Guides,
        LogBook,
        Stats,
        Reports
    }
    public interface INavigator
    {
        BaseViewModel CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}

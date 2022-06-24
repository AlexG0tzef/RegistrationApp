using RegistrationApp.WPF.MVVM.ViewModel;
using RegistrationApp.WPF.State.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegistrationApp.WPF.Commands
{
    public class UpdateCurrentVIewModelCommand : ICommand
    {
        private INavigator _Navigator;

        public UpdateCurrentVIewModelCommand(INavigator _navigator)
        {
            _Navigator = _navigator;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Guid:
                        _Navigator.CurrentViewModel = new GuidViewModel();
                        break;
                    case ViewType.Registration:
                        _Navigator.CurrentViewModel = new RegistrationViewModel();
                        break;
                    case ViewType.Guides:
                        _Navigator.CurrentViewModel = new GuidesViewModel();
                        break;
                    case ViewType.CallCenter:
                        _Navigator.CurrentViewModel = new CallCenterOperatorViewModel();
                        break;
                    case ViewType.Downloads:
                        _Navigator.CurrentViewModel = new DownloadsViewModel();
                        break;
                    case ViewType.LogBook:
                        _Navigator.CurrentViewModel = new LogBookViewModel();
                        break;
                    case ViewType.AnnualReports:
                        _Navigator.CurrentViewModel = new AnnualReportsViewModel();
                        break;
                    case ViewType.Correspondence:
                        _Navigator.CurrentViewModel = new CorrespondenceViewModel();
                        break;
                    case ViewType.Reports:
                        _Navigator.CurrentViewModel = new ReportsViewModel();
                        break;
                    case ViewType.Stats:
                        _Navigator.CurrentViewModel = new StatsViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

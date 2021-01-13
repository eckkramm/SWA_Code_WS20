using CommonServiceLocator;
using FirstMultiVmApp.Navigators;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;

namespace FirstMultiVmApp.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentDetail;
        private INavigator navigator = new Navigator();
        public ViewModelBase CurrentDetail
        {
            get { return currentDetail; }
            set { currentDetail = value; RaisePropertyChanged(); }
        }

        public RelayCommand<string> MenuBtnClickCmd { get; set; }

        public MainViewModel()
        {
            CurrentDetail = navigator.Navigate("masterdata");
            MenuBtnClickCmd = new RelayCommand<string>((p) => { CurrentDetail = navigator.Navigate(p); });
        }


    }
}
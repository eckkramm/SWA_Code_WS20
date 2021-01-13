using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;

namespace FirstMultiVmApp.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentDetail;

        public ViewModelBase CurrentDetail
        {
            get { return currentDetail; }
            set { currentDetail = value; RaisePropertyChanged(); }
        }

        public RelayCommand<string> MenuBtnClickCmd { get; set; }

        public MainViewModel()
        {
            CurrentDetail = ServiceLocator.Current.GetInstance<ReportVm>();
            MenuBtnClickCmd = new RelayCommand<string>(ContentSwitcher);
        }

        private void ContentSwitcher(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
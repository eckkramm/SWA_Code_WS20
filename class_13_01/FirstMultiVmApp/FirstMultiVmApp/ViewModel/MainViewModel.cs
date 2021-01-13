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
            ContentSwitcher("masterdata");
            MenuBtnClickCmd = new RelayCommand<string>(ContentSwitcher);
        }

        private void ContentSwitcher(string obj)
        {
            switch (obj)
            {
                case "masterdata":
                    CurrentDetail = ServiceLocator.Current.GetInstance<MasterDataVm>();
                    break;
                case "reports":
                    CurrentDetail = ServiceLocator.Current.GetInstance<ReportVm>();
                    break;
                case "dynamicdata":
                    CurrentDetail = ServiceLocator.Current.GetInstance<DynamicDataVm>();
                    break;
                default:
                    CurrentDetail = ServiceLocator.Current.GetInstance<MasterDataVm>();
                    break;
            }
        }
    }
}
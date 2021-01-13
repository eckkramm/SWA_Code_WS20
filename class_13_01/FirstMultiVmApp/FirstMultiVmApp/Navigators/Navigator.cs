using CommonServiceLocator;
using FirstMultiVmApp.ViewModel;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMultiVmApp.Navigators
{
    class Navigator : INavigator
    {
        public ViewModelBase Navigate(string param)
        {
            switch (param)
            {
                case "masterdata":
                    return ServiceLocator.Current.GetInstance<MasterDataVm>();
                  
                case "reports":
                    return ServiceLocator.Current.GetInstance<ReportVm>();
                   
                case "dynamicdata":
                    return ServiceLocator.Current.GetInstance<DynamicDataVm>();
                  
                default:
                    return ServiceLocator.Current.GetInstance<MasterDataVm>();
                    
            }
        }
    }
}

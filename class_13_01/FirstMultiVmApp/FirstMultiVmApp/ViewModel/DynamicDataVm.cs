using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMultiVmApp.ViewModel
{
    public class DynamicDataVm : ViewModelBase
    {
        private string dynamicData;

        public string DynamicData
        {
            get => dynamicData;
            set { dynamicData = value; RaisePropertyChanged(); }
        }
        public DynamicDataVm()
        {
            DynamicData = "Initial Value";
            Messenger.Default.Register<PersonVm>(this, "MasterDataInfo", Update);
        }

        private void Update(PersonVm obj)
        {
            DynamicData = obj.Lastname;
        }
    }
}

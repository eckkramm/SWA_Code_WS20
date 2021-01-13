using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMultiVmApp.ViewModel
{
    public class MasterDataVm : ViewModelBase
    {
        private PersonVm person;
        public string DemoData { get; set; }
        public RelayCommand SaveBtnClickedCmd { get; set; }
        
        public MasterDataVm()
        {
            person = new PersonVm() { Age = 10, Firstname = "Jane", Lastname = "Doe" };
            
            SaveBtnClickedCmd = new RelayCommand(() => {
                person.Lastname = DemoData;
                Messenger.Default.Send<PersonVm>(person, "MasterDataInfo");
            });
        }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;

namespace FirstDatatemplate.ViewModel
{
  
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ItemVm> Items { get; set; }
        public ItemVm NewItem { get; set; }
        public RelayCommand AddBtnClickCmd { get; set; }
        public RelayCommand DeleteBtnClickCmd { get; set; }
        public ObservableCollection<string> PrioList { get; set; }
        public ItemVm SelectedItem { get; set; }

        public MainViewModel()
        {
            PrioList = new ObservableCollection<string>() { "Hoch", "Mittel", "Niedrig" };
        }
    }
}
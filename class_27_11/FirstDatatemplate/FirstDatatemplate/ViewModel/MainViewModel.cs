using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;

namespace FirstDatatemplate.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private ItemVm newItem;

        public ObservableCollection<ItemVm> Items { get; set; }
        public ItemVm NewItem { get => newItem; set { newItem = value; RaisePropertyChanged(); } }
        public RelayCommand AddBtnClickCmd { get; set; }
        public RelayCommand DeleteBtnClickCmd { get; set; }
        public RelayCommand<ItemVm> DeleteBtnClickCmd2 { get; set; }
        public ObservableCollection<string> PrioList { get; set; }
        public ItemVm SelectedItem { get; set; }

        public MainViewModel()
        {
            Items = new ObservableCollection<ItemVm>();
            if (IsInDesignMode)
            {
                GenerateDemoData();
            }
           
            NewItem = new ItemVm();

            PrioList = new ObservableCollection<string>() { "Hoch", "Mittel", "Niedrig" };
            AddBtnClickCmd = new RelayCommand(
                //Action
                () =>
                {
                    Items.Add(NewItem);
                    NewItem = new ItemVm();
                },
                //CanExecute
                () => { return NewItem.OrderId.Length > 0; }
                );
            DeleteBtnClickCmd = new  RelayCommand(DeleteEntry, CanDeleteEntry);
            DeleteBtnClickCmd2 = new RelayCommand<ItemVm>(DeleteSpecificEntry);
        }

        private void DeleteSpecificEntry(ItemVm obj)
        {
            Items.Remove(obj);
        }
        private void DeleteEntry()
        {
            Items.Remove(SelectedItem);
        }

        private bool CanDeleteEntry()
        {
            return SelectedItem != null;
        }

        private void GenerateDemoData()
        {
            Items.Add(new ItemVm() { OrderId = "Demo-01", Description = "Test", Amount = 3, Price = 5, Prio = "Mittel" });
            Items.Add(new ItemVm() { OrderId = "Demo-02", Description = "Test", Amount = 3, Price = 5, Prio = "Mittel" });
            Items.Add(new ItemVm() { OrderId = "Demo-03", Description = "Test", Amount = 3, Price = 5, Prio = "Mittel" });
            Items.Add(new ItemVm() { OrderId = "Demo-04", Description = "Test", Amount = 3, Price = 5, Prio = "Mittel" });
            Items.Add(new ItemVm() { OrderId = "Demo-05", Description = "Test", Amount = 3, Price = 5, Prio = "Mittel" });
            Items.Add(new ItemVm() { OrderId = "Demo-06", Description = "Test", Amount = 3, Price = 5, Prio = "Mittel" });
            Items.Add(new ItemVm() { OrderId = "Demo-07", Description = "Test", Amount = 3, Price = 5, Prio = "Mittel" });
            Items.Add(new ItemVm() { OrderId = "Demo-08", Description = "Test", Amount = 3, Price = 5, Prio = "Mittel" });
        }
    }
}
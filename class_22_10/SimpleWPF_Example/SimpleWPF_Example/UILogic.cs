using System;
using System.Collections.ObjectModel;
using System.Windows.Threading;

namespace SimpleWPF_Example
{
    public class UILogic : BaseViewModel
    {
        public ObservableCollection<Transportation> WaitingList { get; set; }
        public ObservableCollection<Transportation> ReadyList { get; set; }
        public ObservableCollection<CargoItem> SelectedCargo { get; set; }
        public RelayCommand DetailBtnClickedCmd { get; set; }
        public RelayCommand StartBtnClickedcmd { get; set; }

        public Transportation SelectedReadyEntry //Property
        {
            get { return selectedReadyEntry; }
            set
            {
        
                selectedReadyEntry = value;
            }
        }

        #region VARIABLES
      
        private Transportation selectedReadyEntry; //variable | class member
        DispatcherTimer timer;
        //Delegate of Type Informer (own defined Delegate) used to point to CounterEllapsed Method
        Informer CounterEllapsedInformer;

        #endregion

        public UILogic()
        {
            WaitingList = new ObservableCollection<Transportation>();
            ReadyList = new ObservableCollection<Transportation>();

            CounterEllapsedInformer = new Informer(CounterEllapsed); //create instance of Informer and point to specific method which is called if informer is evaluated
                                                                     // DetailBtnClickedCmd = new RelayCommand(DetailsBtnClicked, CanExecuteShowDetailsBtn);
            DetailBtnClickedCmd = new RelayCommand(new Action(DetailsBtnClicked),
                () => { if (selectedReadyEntry == null) return false; else return true; });

            var demodata = new DemoDataGenerator(CounterEllapsedInformer, 5, DataGeneratedFromGenerator);
  
            StartBtnClickedcmd = new RelayCommand(() =>
            {
                demodata.StartToGenerate();
            }, () => { return true; });

        }

        private void DataGeneratedFromGenerator(Transportation obj)
        {
            WaitingList.Add(obj);
        }
        private void DetailsBtnClicked()
        {
            //write details to property
            SelectedCargo = selectedReadyEntry.Cargo;
            NotifyPropertyChanged("SelectedCargo");
        }

        private void CounterEllapsed(Transportation source)
        {
            ReadyList.Add(source);
            WaitingList.Remove(source);
        }
    }
}

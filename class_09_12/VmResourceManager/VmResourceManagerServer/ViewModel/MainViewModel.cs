using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using VmResourceManagerServer.Communication;

namespace VmResourceManagerServer.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private Server server;

        public ObservableCollection<InstanceVm> DeployableInstances { get; set; }
        public ObservableCollection<InstanceVm> DeployedInstances { get; set; }
        public InstanceVm SelectedDeployableInstance { get; set; }
        public RelayCommand DeployBtnClickCmd { get; set; }


        public MainViewModel()
        {

            DeployableInstances = new ObservableCollection<InstanceVm>();
            DeployedInstances = new ObservableCollection<InstanceVm>();

            DeployBtnClickCmd = new RelayCommand(
                () =>
                {
                    DeployedInstances.Add(SelectedDeployableInstance);
                    DeployableInstances.Remove(SelectedDeployableInstance);
                },
                () => { return SelectedDeployableInstance != null; });

            if (IsInDesignMode)
            {
                GenerateDemoData();
            }
            else
            {//Start server here!
                server = new Server("127.0.0.1", 10100, new Action<string>(UpdateGui));
                GenerateDemoData();

            }
        }
        private void UpdateGui(string data)
        {
            var seperated = data.Split('@');
            //here is the problem!
            Console.WriteLine("Thread ID of TCP handling thread:" + Dispatcher.CurrentDispatcher.Thread.ManagedThreadId);
            App.Current.Dispatcher.Invoke(() =>
            {
                Console.WriteLine("Thread of GUI:" + App.Current.Dispatcher.Thread.ManagedThreadId);

                DeployableInstances.Add(new InstanceVm()
                {
                    Type = seperated[0],
                    RAM = int.Parse(seperated[1]), //use tryParse instead!!
                    CPUs = int.Parse(seperated[2]),
                    StorageSize = int.Parse(seperated[3]),
                    State = StateType.OnHold
                });
            });
        }
        private void GenerateDemoData()
        {
            DeployableInstances.Add(new InstanceVm()
            {
                CPUs = 4,
                RAM = 16,
                StorageSize = 1000,
                Type = "VM"
            });

            DeployedInstances.Add(new InstanceVm()
            {
                CPUs = 4,
                RAM = 16,
                StorageSize = 1000,
                Type = "VM",
                State = StateType.OnHold
            });
        }
    }
}
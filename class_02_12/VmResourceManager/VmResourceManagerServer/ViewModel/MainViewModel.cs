using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;

namespace VmResourceManagerServer.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
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
            {
                GenerateDemoData();

            }
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
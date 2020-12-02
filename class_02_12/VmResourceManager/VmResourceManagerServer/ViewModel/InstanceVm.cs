using GalaSoft.MvvmLight;
using System;
using System.Windows.Threading;

namespace VmResourceManagerServer.ViewModel
{
    public class InstanceVm : ViewModelBase
    {
        private DateTime startUpTime;
        private DispatcherTimer timer;

        public string Type { get; set; }
        public int RAM { get; set; }
        public int CPUs { get; set; }
        public int StorageSize { get; set; }
        public StateType State { get; set; }

        public TimeSpan UpTime
        {
            get { return DateTime.Now.Subtract(startUpTime); }

        }
        public InstanceVm()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 20);
            timer.Tick += Timer_Tick;
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RaisePropertyChanged("UpTime");
        }

        public void StartUp()
        {
            startUpTime = DateTime.Now;
            RaisePropertyChanged("UpTime");
            timer.Start();
        }
    }
}
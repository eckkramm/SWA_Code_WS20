using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
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
        public RelayCommand StateChangeBtnClickCmd { get; set; }

        public string UpTime
        {
            get
            {
                if (State != StateType.Running)
                { return "NA"; }
                else
                {
                    return DateTime.Now.Subtract(startUpTime).TotalMinutes.ToString();
                }
            }

        }
        public InstanceVm()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += Timer_Tick;

            StateChangeBtnClickCmd = new RelayCommand(()=> {
                switch (State)
                {
                    case StateType.Running:
                        State = StateType.OnHold;
                        break;
                    case StateType.OnHold:
                        State = StateType.Stopped;
                        break;
                    case StateType.Stopped:
                        StartUp();
                        break;
                    default:
                        break;
                }
                RaisePropertyChanged("State");
            });

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RaisePropertyChanged("UpTime");
        }

        public void StartUp()
        {
            State = StateType.Running;
            startUpTime = DateTime.Now;
            RaisePropertyChanged("UpTime");
            timer.Start();
        }
    }
}
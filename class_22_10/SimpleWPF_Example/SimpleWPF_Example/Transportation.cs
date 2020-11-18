using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SimpleWPF_Example
{
    public class Transportation
    {
        public string Destination { get; set; }
        public string Source { get; set; }
        public int Countdown { get; set; }
        public ObservableCollection<CargoItem> Cargo { get; set; }

        private DispatcherTimer timer = new DispatcherTimer();
        private Informer call;

        public Transportation(Informer call)
        {
            this.call = call;

        }
        public void StartCountDown()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, Countdown);
            timer.Tick += TimerReady;
            timer.Start();
        }

        private void TimerReady(object sender, EventArgs e)
        {
            call(this);
            timer.Stop();
        }

        public override string ToString()
        {
            return $"{Source} - {Destination} - {Countdown}";
            //return Source + "-" + Destination + "-" + Countdown;
        }

    }
}

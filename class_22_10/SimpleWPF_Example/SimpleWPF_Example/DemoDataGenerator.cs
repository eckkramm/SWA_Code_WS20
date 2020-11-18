using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Threading;

namespace SimpleWPF_Example
{
    class DemoDataGenerator
    {
        private Informer CounterEllapsedInformer;
        private static Random rand = new Random();
        private DispatcherTimer generateNewTimer;
        private Action<Transportation> dataGenerated;

        public DemoDataGenerator(Informer counterEllapsedInformer, int interval, Action<Transportation> dataGenerated)
        {
            this.CounterEllapsedInformer = counterEllapsedInformer;
            generateNewTimer = new DispatcherTimer();
            generateNewTimer.Interval = new TimeSpan(0, 0, interval);
            generateNewTimer.Tick += (object s, EventArgs a) => { GenerateDemoEntries(); };
            this.dataGenerated = dataGenerated;
        }

        public void StartToGenerate()
        {
            generateNewTimer.Start();
        }

        public void StopGenerating()
        {
            generateNewTimer.Stop();
        }

        private void GenerateDemoEntries()
        {
            var temp = new Transportation(CounterEllapsedInformer) //constructur used to provide instance of Informer delegate to Transportation object
            {
                Countdown = rand.Next(3, 10),
                Destination = "Vienna",
                Source = "Linz",
                Cargo = new ObservableCollection<CargoItem>()
                {
                    new CargoItem()
                    {
                        Description = "Manna Schnitten",
                        Amount=1000,
                        Weight=2
                    },
                    new CargoItem()
                    {
                        Description = "Auer Torten Ecken",
                        Amount=2000,
                        Weight=3
                    }
                }
            };
            temp.StartCountDown();
            // TODO: return object to UILogic via delegate call!
            dataGenerated(temp);

        }
    }
}

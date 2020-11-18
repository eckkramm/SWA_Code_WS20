using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConverterExample
{
    public class Character : ViewModelBase
    {
        private int power, hitpoints;

        public string CharacterClass { get; set; }
        public string Name { get; set; }
        public int Mana { get; set; } //Manner ;-)
        public int Power
        {
            get { return power; }
            set
            {
                if (power > 0)
                {
                    power = power * value;
                }
                else power = value;
            }
        }
        public int Hitpoints
        { //hitpoints <50 (red), >50<100 (yellow), else green
            get { return hitpoints; }
            set
            {
                hitpoints = value;
                RaisePropertyChanged("IsAlive");
            }
        }
        //computational property
        public bool IsAlive
        {
            get
            {
                if (Hitpoints > 0) return true;
                else return false;
            }

        }
    }
}

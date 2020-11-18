using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOExample.Animals
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override string MakeNoise()
        {
            return "WUFFF...";
        }

        public new string Eat()
        {
            return "dog schmatz... ";
        }
    }
}

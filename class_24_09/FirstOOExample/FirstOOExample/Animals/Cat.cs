using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOExample.Animals
{
    public class Cat : Animal , //IFlyable , ICloneable, IComparable
    {
        public Cat(string name) : base(name)
        {

        }

        public override string MakeNoise()
        {
            return "MIAU!";
        }

        /// <summary>
        /// Override the virtual method Move from base class
        /// </summary>
        /// <returns></returns>
        public override string Move()
        {
            return "run like a cat";
        }
    }
}

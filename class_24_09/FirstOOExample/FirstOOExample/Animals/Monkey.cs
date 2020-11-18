using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOExample.Animals
{
    public class Monkey : Animal
    {
        public Monkey(string name) : base(name)
        {
        }

        public override string MakeNoise()
        {
            return "uhhuhhh...";
        }
    }
}

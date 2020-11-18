using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOExample.Animals
{
    public abstract class Animal
    {
       

        //Attributes
        #region Properties
        public string Name { get; set; }
        public Skin Skin { get; set; }
        #endregion
        #region Constructors
        protected Animal(string name)
        {
            Name = name;
        }
        #endregion 
        //Methods


        public abstract string MakeNoise();

        public virtual string Move()
        {
            return ".... just move ....";
        }

        public string Eat()
        {
            return "schmatz...";
        }


    }
}

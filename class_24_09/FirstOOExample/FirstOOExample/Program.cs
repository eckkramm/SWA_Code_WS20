
using FirstOOExample.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();
            zoo.Add(new Cat("Rabe"));
            zoo.Add(new Dog("Baltasa"));
            zoo.Add(new Monkey("Chitta"));

    
            foreach (var item in zoo)
            {
                Console.WriteLine(item.MakeNoise());
                Console.WriteLine("\t" + item.Move());
                Console.WriteLine("\t" + item.Eat());
            }

            Dog dog = new Dog("Dog2");
            Console.WriteLine(dog.Eat());

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals =
                new List<Animal>
                {
                    new Dog(), new Cat(), new Cat(),
                    new Dog(), new Dog(), new Cat()
                };

            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();
            }

            /*foreach(Dog dog in dogs)
            {
                dog.Eat();
                dog.Bark();
                dog.Sleep();
            }
            foreach (Dog dog in dogs)
            {
                dog.Eat();
                dog.Bark();
                dog.Sleep();
            }*/
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePrac
{
    class Dog : Animal
    {
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog() { Color = "하얀색"; }
        public void Bark() { Console.WriteLine("왕왕~!!"); }

    }
}

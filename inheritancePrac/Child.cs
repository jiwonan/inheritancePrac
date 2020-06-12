using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePrac
{
    class Child : Parent
    {
        public Child(int age) : base(age)
        {
            Console.WriteLine("자식입니다!");
        }
    }
}

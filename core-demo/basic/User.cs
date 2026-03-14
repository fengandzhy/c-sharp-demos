using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core_demo.basic
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}, and I am {Age} yesrs olds.");
        }       
    }
}

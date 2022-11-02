using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {

        public string Year { get; set; } = "2018";
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Challenger";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name} goes boom!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }
        public bool HasHandleBars { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("boop boop");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name} goes bam!");
        }
    }
}

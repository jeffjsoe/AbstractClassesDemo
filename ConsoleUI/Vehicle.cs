

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
     public abstract class Vehicle
    {
        //These are default as well
        public string Year { get; set; } = "Something Generic";
        public string Make { get; set; } = "Something Generic";
        public string Model { get; set; } = "Something Generic";

        public abstract void DriveAbstract();
        //Default values, if there is no
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"I am driving a {Make} virtually");
        }
    }
}

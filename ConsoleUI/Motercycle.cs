//JESUS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motercycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;//This  property only pertains to motorcycle//This is deafult
        

        //This is like the template or base. This should be executing inside of the code. 
        public override void DriveAbstract()
        {

            Console.WriteLine($"Hey guys I drive a motercycle. It is has sidekart which is :{HasSideCart} ");

        }

        //
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is driving virtually");
        }
    }
}

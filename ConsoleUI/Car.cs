
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {

        public bool HasTrunk { get; set; } 
        public override void DriveAbstract()
        {


            Console.WriteLine($"Hey guys im driving a car it has");

        }



    }
}

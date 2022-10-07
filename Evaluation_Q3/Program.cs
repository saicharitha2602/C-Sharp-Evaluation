using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Q3
{
    public interface IVehicle
    {
        void drive();
        bool refuel(int re);
    }
    public class Car : IVehicle
    {
        public int fuel { get; set; }


        public void drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("Car is driving");
            }
            else
            {
                Console.WriteLine("Lacks sufficient fuel");
                Console.WriteLine("need to refuel");
            }
        }



        public bool refuel(int re)
        {
            fuel = fuel + re;
            Console.WriteLine("Car refuelled with " + re + " litres");
            return true;
        }



    }



    internal class Program
    {
        static void Main()
        {
            int fuel;
            Console.WriteLine("Enter the amount of fuel");
            fuel = Convert.ToInt32(Console.ReadLine());
            Car c = new Car();
            c.fuel = 0;
            c.drive();
            Console.WriteLine(c.refuel(fuel));
        }



    }
}

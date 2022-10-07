using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Q9
{


    public delegate void promote(string name);






    internal class Program
    {
        public void promotion(string person)
        {
            Console.WriteLine(person + " " + "gets the promotion ");

        }
        static void Main()
        {

            List<string> emp = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter name of employee " + (i + 1));
                string name = Console.ReadLine();
                emp.Add(name);
                ;
            }
            Console.WriteLine("Select the employee from below list to be promoted:");
            foreach (string e in emp)
            {
                Console.WriteLine(e);
            }

            string temp = Console.ReadLine();
            Program obj = new Program();
            promote p = new promote(obj.promotion);
            p.Invoke(temp);



        }
    }
}

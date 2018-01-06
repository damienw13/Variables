using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)

        {
            //Variables - Assigning Names 

            Console.WriteLine("What is your name?");
            Console.Write("Type Your First Name: ");
            string myFirstName = Console.ReadLine();



            //string myLastName;
            //Console.Write("Type Your Last Name: ");
            //myLastName = Console.ReadLine();


            Console.Write("Type Your Last Name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + " ");
            Console.ReadLine();
            
            


        }
    }
}


    
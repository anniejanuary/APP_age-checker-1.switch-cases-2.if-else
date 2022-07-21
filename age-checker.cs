using System;

namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
       ///Example A with int
            
            int age = 25;

            //Way 1: Switch case - in some cases more appealing and easier to handle
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to get into the club");
                    break;

                case 25:
                    Console.WriteLine("Good to go!");
                    break;

                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            //Way 2: If Else 
            if (age == 15)
            {
                Console.WriteLine("Too young to get into the club");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }




       //Example B with strings
            string username = "Magda";

            switch (username)
            {
                case "Magda":
                    Console.WriteLine("username is Magda");
                    break;
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                    Console.WriteLine("username unknown");
                    break;
            }

            Console.Read();
        }
    }
}

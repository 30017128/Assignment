using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rotorua login system, press enter to continue");

            string input = Console.ReadLine();
            while (input != "n")
            {

                Console.WriteLine("Please enter a username that is 8 or more characters long.");
                string username = Console.ReadLine();


                int length = validateUsername(username);


                if (length < 8)
                {
                    while (input != "y")
                    {

                        Console.WriteLine($"Your username is {length} letters long which means it's to short");
                        Console.WriteLine("Press Y to retry or any other key to exit the program");
                        input = Console.ReadLine();
                        if (input != "y")
                        {
                            Environment.Exit(0);
                        }


                    }
                }

                else if (length >= 8)
                {
                    Console.WriteLine($"Your username is {length} letters long which means it's the right length");
                    break;


                }
            }
            string password = Console.ReadLine();
            while (input != "n")
            {

                Console.WriteLine("Please enter a password that is 8 or more characters long");
                password = Console.ReadLine();

                int length2 = validatePasswordLength(password);

                if (length2 < 8)
                {
                    while (input != "y")
                    {
                        Console.WriteLine("Your password is not long enougth");
                        Console.WriteLine("Press Y to retry or any other key to exit the program ");
                        input = Console.ReadLine();
                        if (input != "y")
                        {
                            Environment.Exit(0);
                        }

                    }
                }

                else
                {
                    Console.WriteLine("Your password is the right length");
                    break;
                }
                

            }


            string password2 = Console.ReadLine();
            while (input != "n")
            {
                Console.WriteLine("Please enter your password again");
                password2 = Console.ReadLine();

                int match = validatePasswordMatch(password, password2);

                if (match != 0)
                {
                    while (input != "y")
                    {
                        {
                            Console.WriteLine("Your password does not match");
                            Console.WriteLine("Press Y to retry or any other key to exit the program ");
                            input = Console.ReadLine();
                            if (input != "y")
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                }

                else if (match == 0)
                {
                    Console.WriteLine("Your passwords match");
                    Console.ReadLine();
                    break;

                }



                Employee p1 = new Employee();
                Console.WriteLine("Welcome");

                Console.WriteLine("Enter employee name here");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your gross salary");
                double salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your tax rate");
                double tax = double.Parse(Console.ReadLine());
            }
            








        }

        static int validateUsername(string username)
        {
            return username.Length;


        }
        static int validatePasswordMatch(string password, string password2)
        {

           return string.Compare(password, password2);
        }
        static int validatePasswordLength(string password)
        {

            int passwordlength = password.Length;

            return passwordlength;



            
        }

        class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }
            public double Tax { get; set; }
        

        }




    }
}
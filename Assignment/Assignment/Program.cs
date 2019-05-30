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
            Console.WriteLine("Welcome to the Rotorua login system.");


            Console.WriteLine("Please enter a username that is 8 or more characters long.");
            string username = Console.ReadLine();

            int length = validateUsername(username);
           

            if (length < 8)
            {
                Console.WriteLine($"Your username is {length} letters long which means it's to short");
                Console.ReadLine();
            }
           
            else if (length >= 8)
            {
                Console.WriteLine($"Your username is {length} letters long which means it's the right length");
                Console.ReadLine();
            }
            
            Console.WriteLine("Please enter a password that is 8 or more characters long");
            string password = Console.ReadLine();
           
            int passwordlength = password.Length;





            Console.WriteLine("Please enter your password again");
            string password2 = Console.ReadLine();

            int length2 = validatePassword(password, password2);

            

            





        }

        static int validateUsername (string username)
        {
            return username.Length;
            

        }
        static int validatePassword(string password, string password2)
        {
            int match = password.Length / password2.Length;
            int passwordlength = password.Length;

            if (passwordlength > 8) ;
            {
                return
            }
           
            
            
            
            

        }


        

    }
}

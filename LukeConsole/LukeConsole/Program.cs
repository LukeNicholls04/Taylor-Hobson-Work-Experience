using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeConsole
{
    class Program
    {

        public static void Main(string[] args)
        {
            Login manager = new Login();
            Console.WriteLine("Would you like to log in (enter L), sign up (enter S) or delete an account (enter D)?");
            var ans = Console.ReadLine();
            if (ans == "S" || ans == "s")
            {
                manager.SignIn();

            }
            else if (ans == "L" || ans == "l")
            {
                manager.LogIn();

            }

            else if (ans == "D" || ans == "d")
            {
                manager.DeleteAccount();

            }
        }

       
    }
}
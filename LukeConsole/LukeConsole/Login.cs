using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeConsole
{
    public class Login
    {
        private string path = @"C:\TH2\Tools\Example\LukeConsole\LukeConsole\bin\Debug\LoginScript.txt";
        bool userin = false;
        public int SignIn()
        {
            while (true)
            {
                Console.WriteLine("Enter your username");
                var username = Console.ReadLine();
                Console.WriteLine("Enter your password");
                var password = Console.ReadLine();
                bool flag = true;
                var list1 = File.ReadAllLines(path);
                int length = list1.Length;
                for (int i = 0; i < length; i++)
                {
                    var line = list1[i];
                    var user = line.Split(',');
                    var user2 = user[0];
                    if (username == user2)
                    {
                        flag = false;
                        Console.WriteLine("This username is taken");
                        break;
                    }

                }
                if (flag == true)
                {
                    File.AppendAllText(path, "\n" + username + "," + password);
                    break;

                }


            }
            int t = 0;
            return t;
        }



        public int LogIn()
        {
            {
                Console.WriteLine("Enter your username");
                var username = Console.ReadLine();
                Console.WriteLine("Enter your password");
                var password = Console.ReadLine();
                bool flag = true;
                var list1 = File.ReadAllLines(path).ToList();
                int length = list1.Count;
                for (int i = 0; i < length; i++)
                {
                    var line = list1[i];
                    var user = line.Split(',');
                    if (user[0] == username && user[1] == password)
                    {
                        Console.WriteLine("Welcome," + username);
                        flag = false;
                        break;

                    }

                }
                if (flag == true)
                    Console.WriteLine("This account does not exist");
                Console.Read();

            }



            int t = 0;
            return t;
        }



        public int DeleteAccount()
        {
            Console.WriteLine("Enter the username of the account that you want to delete");
            var deleteusername = Console.ReadLine();
            Console.WriteLine("Enter the password for this account");
            var deletepassword = Console.ReadLine();
            var list1 = File.ReadAllLines(path).ToList();
            int length = list1.Count;
            bool deleted = false;
            string filecontents = "";
            for (int i = 0; i < length; i++)
            {
                string line = list1[i];
                var user = line.Split(',');

                if (user[0] == deleteusername && user[1] == deletepassword)
                {
                    Console.WriteLine("This account has been deleted");
                    deleted = true;
                }
                else
                {
                    filecontents = filecontents + line;
                    if (i < length - 1)
                        filecontents = filecontents + "\n";
                }
                if (i == length - 1 && deleted == false)
                    Console.WriteLine("This account doesnt exist");

            }
            File.WriteAllText(path, filecontents);
            Console.Read();





            int t = 0;
            return t;
        }
    }
}

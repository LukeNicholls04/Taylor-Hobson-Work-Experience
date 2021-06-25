using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeForms
{
    
    
}
public class Login
{
    private string path = @"C:\TH2\Tools\Example\LukeConsole\LukeConsole\bin\Debug\LoginScript.txt";
    public bool SignIn(string username1, string password)
    {
        bool flag = true;
        { 
            flag = true;
            var list1 = File.ReadAllLines(path);
            int length = list1.Length;
            for (int i = 0; i < length; i++)
            {
                var line = list1[i];
                var user = line.Split(',');
                var user2 = user[0];
                if (username1 == user2)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                File.AppendAllText(path, "\n" + username1 + "," + password);
            }


        }

        return flag;
    }
    public bool LogIn(string username1, string password)
    {
        bool flag = true;
        {

            flag = true;
            var list1 = File.ReadAllLines(path).ToList();
            int length = list1.Count;
            for (int i = 0; i < length; i++)
            {
                var line = list1[i];
                var user = line.Split(',');
                if (user[0] == username1 && user[1] == password)
                {
                    flag = false;
                    break;
                }         
            }
        }
        return flag;
    }
    public bool DeleteAccount(string username1, string password)
    {

        var list1 = File.ReadAllLines(path).ToList();
        int length = list1.Count;
        bool flag = false;
        string filecontents = "";
        for (int i = 0; i < length; i++)
        {
            string line = list1[i];
            var user = line.Split(',');

            if (user[0] == username1 && user[1] == password)
            {
                flag = true;
            }
            else
            {
                filecontents = filecontents + line;
                if (i < length - 1)
                    filecontents = filecontents + "\n";
            }
        }
        File.WriteAllText(path, filecontents);
        return flag;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukeForms
{
    public partial class Form1 : Form
    {   
        //string which shows which option the user chooses
        
        string mode = "";
        Login manager;


        public Form1()
        {
            //Hides labels

            InitializeComponent();
            manager = new Login();
            enterpanel.Hide();
            usernametakenlabel.Hide();
            youreinlabel.Hide();
            doesntexistlabel.Hide();
            accountdeletedlabel.Hide();
            continuebutton.Hide();
        }

        //user wants to log in , allows the user to submit username + password

        private void LoginButton_Click(object sender, EventArgs e)
        {
                enterpanel.Show();
                continuebutton.Show(); 
                userdecisionpanel.Hide();
                mode = "l";
        }

        //user wants to delete an account , allows the user to submit username + password

        private void DeleteaccountButton_Click(object sender, EventArgs e)
        {
                enterpanel.Show();
                continuebutton.Show();
                userdecisionpanel.Hide();
                mode = "d";
        }

        //user wants to sign up , allows the user to submit username + password

        private void SignUpButton_Click_1(object sender, EventArgs e)
       {
                enterpanel.Show();
                continuebutton.Show();
                userdecisionpanel.Hide();
                mode = "s";                 
        }

        private void continuebutton_Click(object sender, EventArgs e)
        {   string username1 = textBox1.Text;
            string password = textBox2.Text;
            if (mode == "l")
            {
                {
                    bool flag = manager.LogIn(textBox1.Text, textBox2.Text);
                    if (flag == false)
                    {
                        youreinlabel.Show();
                        enterpanel.Hide();
                        continuebutton.Hide();
                        doesntexistlabel.Hide();
                    }
                    if (flag == true)
                    {
                        doesntexistlabel.Show();
                    }
                }
            }
            else if (mode == "s")
            {
                {
                    bool flag = manager.SignIn(textBox1.Text, textBox2.Text);
                    if (flag == true)
                    {
                        usernametakenlabel.Hide();
                        youreinlabel.Show();
                        enterpanel.Hide();
                        continuebutton.Hide();
                    }
                    else
                        usernametakenlabel.Show();


                }
            }
            else if (mode == "d")
            {
                {
                    bool flag = manager.DeleteAccount(textBox1.Text, textBox2.Text);
                    if (flag == true)
                        accountdeletedlabel.Show();
                        doesntexistlabel.Hide();
                    if (flag == false)
                        doesntexistlabel.Show();
                }                             
            }            
        }      
    }    
}  


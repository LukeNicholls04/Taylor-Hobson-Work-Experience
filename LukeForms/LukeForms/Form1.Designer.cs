
namespace LukeForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.DeleteaccountButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterpanel = new System.Windows.Forms.Panel();
            this.continuebutton = new System.Windows.Forms.Button();
            this.usernametakenlabel = new System.Windows.Forms.Label();
            this.youreinlabel = new System.Windows.Forms.Label();
            this.doesntexistlabel = new System.Windows.Forms.Label();
            this.accountdeletedlabel = new System.Windows.Forms.Label();
            this.userdecisionpanel = new System.Windows.Forms.Panel();
            this.enterpanel.SuspendLayout();
            this.userdecisionpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(4, 0);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(174, 65);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(195, 0);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(174, 65);
            this.SignUpButton.TabIndex = 2;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click_1);
            // 
            // DeleteaccountButton
            // 
            this.DeleteaccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteaccountButton.Location = new System.Drawing.Point(384, 0);
            this.DeleteaccountButton.Name = "DeleteaccountButton";
            this.DeleteaccountButton.Size = new System.Drawing.Size(174, 65);
            this.DeleteaccountButton.TabIndex = 3;
            this.DeleteaccountButton.Text = "Delete Account";
            this.DeleteaccountButton.UseVisualStyleBackColor = true;
            this.DeleteaccountButton.Click += new System.EventHandler(this.DeleteaccountButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(3, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(196, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 26);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // enterpanel
            // 
            this.enterpanel.Controls.Add(this.continuebutton);
            this.enterpanel.Controls.Add(this.textBox1);
            this.enterpanel.Controls.Add(this.label1);
            this.enterpanel.Controls.Add(this.textBox2);
            this.enterpanel.Controls.Add(this.label2);
            this.enterpanel.Location = new System.Drawing.Point(198, 177);
            this.enterpanel.Name = "enterpanel";
            this.enterpanel.Size = new System.Drawing.Size(391, 104);
            this.enterpanel.TabIndex = 9;
            // 
            // continuebutton
            // 
            this.continuebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuebutton.Location = new System.Drawing.Point(59, 60);
            this.continuebutton.Name = "continuebutton";
            this.continuebutton.Size = new System.Drawing.Size(245, 41);
            this.continuebutton.TabIndex = 10;
            this.continuebutton.Text = "Continue";
            this.continuebutton.UseVisualStyleBackColor = true;
            this.continuebutton.Click += new System.EventHandler(this.continuebutton_Click);
            // 
            // usernametakenlabel
            // 
            this.usernametakenlabel.AutoSize = true;
            this.usernametakenlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametakenlabel.Location = new System.Drawing.Point(90, 303);
            this.usernametakenlabel.Name = "usernametakenlabel";
            this.usernametakenlabel.Size = new System.Drawing.Size(611, 84);
            this.usernametakenlabel.TabIndex = 11;
            this.usernametakenlabel.Text = "This username is taken, try again.\r\n\r\n";
            // 
            // youreinlabel
            // 
            this.youreinlabel.AutoSize = true;
            this.youreinlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youreinlabel.Location = new System.Drawing.Point(287, 303);
            this.youreinlabel.Name = "youreinlabel";
            this.youreinlabel.Size = new System.Drawing.Size(184, 42);
            this.youreinlabel.TabIndex = 12;
            this.youreinlabel.Text = "You\'re in!";
            // 
            // doesntexistlabel
            // 
            this.doesntexistlabel.AutoSize = true;
            this.doesntexistlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doesntexistlabel.Location = new System.Drawing.Point(157, 303);
            this.doesntexistlabel.Name = "doesntexistlabel";
            this.doesntexistlabel.Size = new System.Drawing.Size(474, 42);
            this.doesntexistlabel.TabIndex = 13;
            this.doesntexistlabel.Text = "This account doesn\'t exist";
            // 
            // accountdeletedlabel
            // 
            this.accountdeletedlabel.AutoSize = true;
            this.accountdeletedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountdeletedlabel.Location = new System.Drawing.Point(119, 303);
            this.accountdeletedlabel.Name = "accountdeletedlabel";
            this.accountdeletedlabel.Size = new System.Drawing.Size(558, 42);
            this.accountdeletedlabel.TabIndex = 14;
            this.accountdeletedlabel.Text = "This account has been deleted";
            // 
            // userdecisionpanel
            // 
            this.userdecisionpanel.Controls.Add(this.LoginButton);
            this.userdecisionpanel.Controls.Add(this.SignUpButton);
            this.userdecisionpanel.Controls.Add(this.DeleteaccountButton);
            this.userdecisionpanel.Location = new System.Drawing.Point(113, 86);
            this.userdecisionpanel.Name = "userdecisionpanel";
            this.userdecisionpanel.Size = new System.Drawing.Size(564, 68);
            this.userdecisionpanel.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userdecisionpanel);
            this.Controls.Add(this.youreinlabel);
            this.Controls.Add(this.accountdeletedlabel);
            this.Controls.Add(this.doesntexistlabel);
            this.Controls.Add(this.usernametakenlabel);
            this.Controls.Add(this.enterpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.enterpanel.ResumeLayout(false);
            this.enterpanel.PerformLayout();
            this.userdecisionpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button DeleteaccountButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel enterpanel;
        private System.Windows.Forms.Button continuebutton;
        private System.Windows.Forms.Label usernametakenlabel;
        private System.Windows.Forms.Label youreinlabel;
        private System.Windows.Forms.Label doesntexistlabel;
        private System.Windows.Forms.Label accountdeletedlabel;
        private System.Windows.Forms.Panel userdecisionpanel;
    }
}


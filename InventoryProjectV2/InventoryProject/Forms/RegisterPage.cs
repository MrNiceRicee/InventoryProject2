using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryProject.Classes;



namespace InventoryProject.Forms
{
    public partial class RegisterPage : Form
    {
        FileAccessModule FAM = new FileAccessModule();
        Boolean CloseUp = true;
        int IGNLength = 5;
        int UsernameLength = 5;
        int PasswordLength = 5;
        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public RegisterPage()
        {
            InitializeComponent();
            this.FormClosed += our_FormClosed;
        }

        private void our_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseUp)
            {
                Environment.Exit(0);

            }
        }


        private void Register_Click(object sender, EventArgs e)
        {
            //Check the textboxes first
            string ign = this.IGNBox.Text;
            string username = this.UsernameBox.Text;
            string pass1 = this.PasswordBox.Text;
            string pass2 = this.PasswordConfirmBox.Text;

            Label userwarning = this.UserWarning;
            Label passwarning = this.PasswordWarning;
            if (ign.Length >= IGNLength) {
                if (username.Length >= UsernameLength) {
                    if (!FAM.checkUsernameExist(username))
                    {
                        userwarning.Text = "Available";
                        if (pass1.Length >= PasswordLength)
                        {
                            if (pass1.Equals(pass2))
                            {
                                Console.WriteLine("RegisterPage. Logged in");
                                passwarning.Visible = true;
                                passwarning.Text = "Password match";
                                User newOne = new User(ign, username, pass1);
                                FAM.saveUser(newOne);
                                LoginPage goback = new LoginPage();
                                goback.Show();
                                goback.UsernameBox.Text = newOne.UserName;
                                goback.UserWarning.Text = "Registration autofill";
                                goback.UserWarning.Visible = true;
                                this.Dispose();
                                this.Close();
                            }
                            else
                            {
                                passwarning.Visible = true;
                                passwarning.Text = "Password not matching";
                            }
                        }else
                        {
                            passwarning.Visible = true;
                            passwarning.Text = "At least "+PasswordLength+" characters";
                        }

                    } else
                    {
                        userwarning.Text = "Already Exist";

                    }
                }
            }
        }

        private void UsernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                this.UserWarning.Visible = true;
                this.UserWarning.Text = "No spaces";
                wait(500);
                this.UserWarning.Visible = false;

            }
            else if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
                this.UserWarning.Visible = true;
                this.UserWarning.Text = "No special characters";
                wait(500);
                this.UserWarning.Visible = false;
            }
            else
            {
                if (this.UsernameBox.TextLength < UsernameLength)
                {
                    this.UserWarning.Visible = true;
                    this.UserWarning.Text = "At least "+UsernameLength+" characters";
                }
                else
                {
                    this.UserWarning.Visible = false;

                }
            }
        }

        private void PasswordConfirmBox_TextChanged(object sender, EventArgs e)
        {
            if (this.PasswordBox.Text.Equals(this.PasswordConfirmBox.Text))
            {
                this.PasswordWarning.Text = "Password match";
            }
            else
            {
                PasswordWarning.Visible = true;
                PasswordWarning.Text = "Password do not match";
            }
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (this.PasswordBox.Text.Length < PasswordLength)
            {
                this.PasswordWarning.Visible = true;
                this.PasswordWarning.Text = "At least "+PasswordLength+" characters";
            }
            else if (this.PasswordBox.Text.Equals(this.PasswordConfirmBox.Text))
            {
                this.PasswordWarning.Text = "Password match";
            }
        }

        private void IGNBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                this.IGNWarning.Visible = true;
                this.IGNWarning.Text = "No Space";
                wait(500);
                this.IGNWarning.Visible = false;
            }
            if (IGNBox.Text.Length < IGNLength)
            {
                this.IGNWarning.Visible = true;
                this.IGNWarning.Text = "At least "+IGNLength+" characters";
            }else
            {
                this.IGNWarning.Visible = false;

            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginPage goback = new LoginPage();
            goback.Show();
            CloseUp = false;
            this.Close();
        }

        private void RegisterPage_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                IGNBox.Text = "";
                UsernameBox.Text = "";
                PasswordBox.Text = "";
                PasswordConfirmBox.Text = "";
            }
        }
    }
}

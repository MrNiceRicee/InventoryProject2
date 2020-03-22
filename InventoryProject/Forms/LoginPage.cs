using InventoryProject.Classes;
using InventoryProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace InventoryProject
{


    public partial class LoginPage : Form
    {
        Boolean CloseUp = true;
        User loggedIn;
        WelcomePage Welcomepage;


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

        public void loggingIn()
        {
            string username = this.UsernameBox.Text;
            string password = this.PasswordBox.Text;
            FileAccessModule FAM = new FileAccessModule();
            if (!FAM.checkUser(username, password))
            {
                this.LogInWarning.Text = "Invalid Login Credentials";
                this.LogInWarning.Visible = true;
                wait(1500);
                this.LogInWarning.Visible = false;

            }
            else
            {
                //Check user came positive
                //we can search it now
                this.LogInWarning.Text = "Successful Login. Please Wait.";
                this.LogInWarning.Visible = true;
                wait(2000);
                this.LogInWarning.Visible = false;
                Console.WriteLine();
                loggedIn = FAM.readUserFile(username,password);

                StoreSystems LoggedIn = new StoreSystems();

                LoggedIn.loggedUser = loggedIn;

                Welcomepage = new WelcomePage(LoggedIn);
                Welcomepage.StartPosition = FormStartPosition.Manual;
                Welcomepage.Left = this.Location.X;
                Welcomepage.Top = this.Location.Y;
                Welcomepage.Location = this.Location;
                Welcomepage.SetDesktopLocation(this.Location.X, this.Location.Y);

                Welcomepage.setLoggedIn();

                Welcomepage.MainForm = this;

                Welcomepage.Show();

                //Time to purge loggin
                this.UsernameBox.Text = "";
                this.PasswordBox.Text = "";
                loggedIn = null;
                this.Hide();
            }
        }


        public LoginPage()
        {
            InitializeComponent();
            this.FormClosed += our_FormClosed;
            FileAccessModule FAM = new FileAccessModule();


            RandomizeGame RandomGame = new RandomizeGame();

            /* FAM.ToGameFile(FAM.CreateGame(10));*/
        }

        private void our_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseUp)
            {
                Environment.Exit(0);

            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            loggingIn();        



        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            RegisterPage j = new RegisterPage();
            j.Show();
            this.Hide();
        }

        private void UsernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                this.UserWarning.Text = "No Spaces";
                this.UserWarning.Visible = true;
                wait(500);
                this.UserWarning.Visible = false;
            }
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            if ((regex.IsMatch(e.KeyChar.ToString())))
            {
                e.Handled = true;
                this.UserWarning.Text = "No special characters";
                this.UserWarning.Visible = true;
                wait(500);
                this.UserWarning.Visible = false;
            }
        }

        private void LoginPage_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                this.UsernameBox.Text = "";
                this.PasswordBox.Text = "";
                this.LogInWarning.Visible = false;
                this.UserWarning.Visible = false;
            }
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                loggingIn();
            }
        }
    }
}

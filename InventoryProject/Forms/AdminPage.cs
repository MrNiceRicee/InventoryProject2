using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InventoryProject.Classes;


namespace InventoryProject.Forms
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }


        /*Modes:
            Add Game
            Edit Game
            Remove Game
            Add User
            Edit User
            Remove User
         */


        FileAccessModule FAM = new FileAccessModule();

        public void updateTable()
        {
            String selection = this.ModeSelection.Text;
            
            if (selection.Equals("Add Game"))
            {
                this.AddTableLayoutPanel.Visible = true;
                this.radioButton1.Visible = true;
                this.radioButton2.Visible = true;

                if (this.radioButton1.Checked)
                {
                    this.TextLabel1.Text = "Game Name: ";
                    this.TextLabel2.Text = "Studio Name: ";
                    this.TextLabel3.Text = "Genre: ";
                    this.TextLabel4.Text = "Price: ";
                    this.TextLabel5.Text = "Ratings: ";

                    this.radioButton1.Text = "Custom";
                    this.radioButton2.Text = "Generate";

                    this.TextLabel6.Visible = false;
                    this.TextLabel7.Visible = false;
                    this.TextBox6.Visible = false;
                    this.TextBox7.Visible = false;
                }
                else
                {
                    this.TextLabel1.Text = "Amount";                    

                    this.TextLabel2.Visible = false;
                    this.TextLabel3.Visible = false;
                    this.TextLabel4.Visible = false;
                    this.TextLabel5.Visible = false;
                    this.TextLabel6.Visible = false;
                    this.TextLabel7.Visible = false;

                    this.TextBox2.Visible = false;
                    this.TextBox3.Visible = false;
                    this.TextBox4.Visible = false;
                    this.TextBox5.Visible = false; 
                    this.TextBox6.Visible = false;
                    this.TextBox7.Visible = false;
                }


            }
            else if (selection.Equals("Edit Game"))
            {
                this.AddTableLayoutPanel.Visible = false;
                this.radioButton1.Visible = false;
                this.radioButton2.Visible = false;


            }            
            else if (selection.Equals("Add User"))
            {
                this.AddTableLayoutPanel.Visible = true;


                this.TextLabel1.Text = "IG Name: ";
                this.TextLabel2.Text = "Username: ";
                this.TextLabel3.Text = "Password: ";
                this.TextLabel4.Text = "Funds: ";

                this.TextLabel5.Visible = false;
                this.TextLabel6.Visible = false;
                this.TextLabel7.Visible = false;

                this.TextBox5.Visible = false;
                this.TextBox6.Visible = false;
                this.TextBox7.Visible = false;

                this.radioButton1.Visible = false;
                this.radioButton2.Visible = false;
            }
        }

        private void ModeSelect(object sender, EventArgs e)
        {
            updateTable();
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            RadioButton suspect = (RadioButton)sender;

            if (suspect.Name.Equals(radioButton1.Name))
            {
                this.radioButton2.Checked = false;
            }else if (suspect.Name.Equals(radioButton2.Name))
            {
                this.radioButton1.Checked = false;

            }
        }


        /*
         Modes:
            Add Game
            Edit Game
            Remove Game
            Add User
            Edit User
            Remove User
        */

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            String selection = this.ModeSelection.Text;
            if (selection.Equals("Add Game"))
            {
                if (this.radioButton1.Checked)
                {

                    Game newGame = new Game(0+"",
                        this.TextBox1.Text,
                        this.TextBox2.Text,
                        this.TextBox3.Text,
                        Convert.ToDouble(this.TextBox4),
                        DateTime.Today,
                        Convert.ToInt32(this.TextBox5),
                        0,
                        0);
                }else if (this.radioButton2.Checked)
                {
                    if (Int32.TryParse(this.TextBox1.Text,out int GameAmount))
                    {
                        FAM.ToGameFile(FAM.CreateGame(GameAmount));
                    }
                }


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void updateTable()
        {
            String selection = this.ModeSelection.Text;
            
            if (selection.Equals("Add Game"))
            {
                this.AddTableLayoutPanel.Visible = true;

                this.TextLabel1.Text = "Game Name: ";
                this.TextLabel2.Text = "Studio Name: ";
                this.TextLabel3.Text = "Genre: ";
                this.TextLabel4.Text = "Price: ";
                this.TextLabel5.Text = "Ratings: ";


                this.TextLabel6.Visible = false;
                this.TextLabel7.Visible = false;
                this.TextBox6.Visible = false;
                this.TextBox7.Visible = false;

            }
            else if (selection.Equals("Edit Game"))
            {
                this.AddTableLayoutPanel.Visible = false;



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
            }
        }

        private void ModeSelect(object sender, EventArgs e)
        {
            updateTable();
        }

    }
}

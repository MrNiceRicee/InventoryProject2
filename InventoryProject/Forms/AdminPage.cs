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


        /*
         *  TO DO LIST
         * Modes:
            Add Game    DONE
            Edit Game   DONE
            Remove Game DONE
            Add User    DONE
            Edit User
            Remove User
         */




        FileAccessModule FAM = new FileAccessModule();
        RandomizeGame randogame = new RandomizeGame();


        Game FocusedGame;
        User FocusedUser;

        bool hasFocus = false;

        public void updateTable()
        {
            String selection = this.ModeSelection.Text;
            this.Notification.Text = "";
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox4.Text = "";
            this.TextBox5.Text = "";
            this.TextBox6.Text = "";

            this.TextBox1.Visible = false;
            this.TextBox2.Visible = false;
            this.ComboBoxLayOut.Visible = false;
            this.TextBox4.Visible = false;
            this.TextBox5.Visible = false;
            this.TextBox6.Visible = false;


            this.checkBox1.Visible = false;
            this.TextLabel1.Visible = false;
            this.TextLabel2.Visible = false;
            this.TextLabel3.Visible = false;
            this.TextLabel4.Visible = false;
            this.TextLabel5.Visible = false;
            this.TextLabel6.Visible = false;
            this.TextLabel7.Visible = false;



            if (selection.Equals("Add Game"))
            {
                this.radioButton1.Text = "Custom";
                this.radioButton2.Text = "Generate";

                this.AddTableLayoutPanel.Visible = true;
                this.radioButton1.Visible = true;
                this.radioButton2.Visible = true;
                this.radioButton2.Checked = true;

                if (this.radioButton1.Checked)
                {

                    this.ComboBoxLayOut.Items.Clear();
                    this.ComboBoxLayOut.Items.AddRange(randogame.Genres);

                    this.TextLabel1.Text = "Game Name: ";
                    this.TextLabel2.Text = "Studio Name: ";
                    this.TextLabel3.Text = "Genre: ";
                    this.TextLabel4.Text = "Price: ";
                    this.TextLabel5.Text = "Ratings: ";

                    this.TextLabel1.Visible = true;
                    this.TextLabel2.Visible = true;
                    this.TextLabel3.Visible = true;
                    this.TextLabel4.Visible = true;
                    this.TextLabel5.Visible = true;

                    this.TextBox1.Visible = true;
                    this.TextBox2.Visible = true;
                    this.ComboBoxLayOut.Visible = true;
                    this.TextBox4.Visible = true;
                    this.TextBox5.Visible = true;



                    this.radioButton1.Text = "Custom";
                    this.radioButton2.Text = "Generate";

                    this.TextLabel6.Visible = false;
                    this.TextLabel7.Visible = false;
                    this.TextBox6.Visible = false;
                    this.checkBox1.Visible = false;
                }
                else
                {
                    this.TextLabel1.Text = "Amount";
                    this.TextLabel1.Visible = true;

                    this.TextBox1.Visible = true;
                    this.TextBox1.ReadOnly = false;


                    this.TextLabel2.Visible = false;
                    this.TextLabel3.Visible = false;
                    this.TextLabel4.Visible = false;
                    this.TextLabel5.Visible = false;
                    this.TextLabel6.Visible = false;
                    this.TextLabel7.Visible = false;

                    this.TextBox2.Visible = false;
                    this.ComboBoxLayOut.Visible = false;
                    this.TextBox4.Visible = false;
                    this.TextBox5.Visible = false;
                    this.TextBox6.Visible = false;
                    this.checkBox1.Visible = false;
                }


            }
            else if (selection.Equals("Edit Game"))
            {
                this.ComboBoxLayOut.Items.Clear();
                this.ComboBoxLayOut.Items.AddRange(randogame.Genres);

                this.Notification.Text = "Search Game";

                this.AddTableLayoutPanel.Visible = true;
                this.radioButton1.Visible = false;
                this.radioButton2.Visible = false;

                this.TextLabel1.Text = "Game Name: ";
                this.TextLabel2.Text = "Studio Name: ";
                this.TextLabel3.Text = "Genre: ";
                this.TextLabel4.Text = "Price: ";
                this.TextLabel5.Text = "Ratings: ";
                this.TextLabel6.Text = "Search by GameID: ";

                this.TextLabel1.Visible = true;
                this.TextLabel2.Visible = true;
                this.TextLabel3.Visible = true;
                this.TextLabel4.Visible = true;
                this.TextLabel5.Visible = true;
                this.TextLabel6.Visible = true;


                this.TextBox1.ReadOnly = true;
                this.TextBox2.ReadOnly = true;
                this.TextBox4.ReadOnly = true;
                this.TextBox5.ReadOnly = true;
                this.TextBox6.ReadOnly = false;

                this.TextBox1.Visible = true;
                this.TextBox2.Visible = true;
                this.ComboBoxLayOut.Visible = true;
                this.TextBox4.Visible = true;
                this.TextBox5.Visible = true;
                this.TextBox6.Visible = true;
            }
            else if (selection.Equals("Remove Game"))
            {
                this.ComboBoxLayOut.Items.Clear();
                this.ComboBoxLayOut.Items.AddRange(randogame.Genres);

                this.Notification.Text = "Search Game";

                this.AddTableLayoutPanel.Visible = true;
                this.radioButton1.Visible = false;
                this.radioButton2.Visible = false;

                this.TextLabel1.Text = "Game Name: ";
                this.TextLabel2.Text = "Studio Name: ";
                this.TextLabel3.Text = "Genre: ";
                this.TextLabel4.Text = "Price: ";
                this.TextLabel5.Text = "Ratings: ";
                this.TextLabel6.Text = "Search by GameID: ";

                this.TextLabel1.Visible = true;
                this.TextLabel2.Visible = true;
                this.TextLabel3.Visible = true;
                this.TextLabel4.Visible = true;
                this.TextLabel5.Visible = true;
                this.TextLabel6.Visible = true;


                this.TextBox1.ReadOnly = true;
                this.TextBox2.ReadOnly = true;
                this.TextBox4.ReadOnly = true;
                this.TextBox5.ReadOnly = true;
                this.TextBox6.ReadOnly = false;

                this.TextBox1.Visible = true;
                this.TextBox2.Visible = true;
                this.ComboBoxLayOut.Visible = true;
                this.TextBox4.Visible = true;
                this.TextBox5.Visible = true;
                this.TextBox6.Visible = true;
            }
            else if (selection.Equals("Add User"))
            {
                this.AddTableLayoutPanel.Visible = true;


                this.TextLabel1.Text = "IG Name: ";
                this.TextLabel2.Text = "Username: ";
                this.TextLabel4.Text = "Password: ";
                this.TextLabel5.Text = "Funds: ";

                this.TextBox1.Visible = true;
                this.TextBox2.Visible = true;
                this.TextBox4.Visible = true;
                this.TextBox5.Visible = true;

                this.TextBox1.ReadOnly = false;
                this.TextBox2.ReadOnly = false;
                this.TextBox4.ReadOnly = false;
                this.TextBox5.ReadOnly = false;

                this.TextLabel1.Visible = true;
                this.TextLabel2.Visible = true;
                this.TextLabel4.Visible = true;
                this.TextLabel5.Visible = true;


                this.TextLabel3.Visible = false;
                this.TextLabel6.Visible = false;
                this.TextLabel7.Visible = false;

                this.ComboBoxLayOut.Visible = false;
                this.TextBox6.Visible = false;
                this.checkBox1.Visible = false;

                this.radioButton1.Visible = false;
                this.radioButton2.Visible = false;
            }
            else if (selection.Equals("Edit User"))
            {
                this.AddTableLayoutPanel.Visible = true;

                this.Notification.Text = "Search User";


                this.TextLabel1.Text = "IG Name: ";
                this.TextLabel2.Text = "Username: ";
                this.TextLabel4.Text = "Password: ";
                this.TextLabel5.Text = "Funds: ";
                this.TextLabel6.Text = "Search Username: ";

                this.TextBox1.Visible = true;
                this.TextBox2.Visible = true;
                this.TextBox4.Visible = true;
                this.TextBox5.Visible = true;
                this.TextBox6.Visible = true;


                this.TextBox5.ReadOnly = false;

                this.TextBox1.ReadOnly = true;
                this.TextBox2.ReadOnly = true;
                this.TextBox4.ReadOnly = true;
                this.TextBox5.ReadOnly = true;

                this.TextLabel1.Visible = true;
                this.TextLabel2.Visible = true;
                this.TextLabel4.Visible = true;
                this.TextLabel5.Visible = true;
                this.TextLabel6.Visible = true;


                this.TextLabel3.Visible = false;
                this.TextLabel7.Visible = false;

                this.ComboBoxLayOut.Visible = false;
                this.checkBox1.Visible = false;

                this.radioButton1.Visible = false;
                this.radioButton2.Visible = false;
            }
            else if (selection.Equals("Edit User"))
            {
                this.AddTableLayoutPanel.Visible = true;

                this.Notification.Text = "Search User";


                this.TextLabel1.Text = "IG Name: ";
                this.TextLabel2.Text = "Username: ";
                this.TextLabel4.Text = "Password: ";
                this.TextLabel5.Text = "Funds: ";
                this.TextLabel6.Text = "Search Username: ";

                this.TextBox1.Visible = true;
                this.TextBox2.Visible = true;
                this.TextBox4.Visible = true;
                this.TextBox5.Visible = true;
                this.TextBox6.Visible = true;


                this.TextBox5.ReadOnly = false;

                this.TextBox1.ReadOnly = true;
                this.TextBox2.ReadOnly = true;
                this.TextBox4.ReadOnly = true;
                this.TextBox5.ReadOnly = true;

                this.TextLabel1.Visible = true;
                this.TextLabel2.Visible = true;
                this.TextLabel4.Visible = true;
                this.TextLabel5.Visible = true;
                this.TextLabel6.Visible = true;


                this.TextLabel3.Visible = false;
                this.TextLabel7.Visible = false;

                this.ComboBoxLayOut.Visible = false;
                this.checkBox1.Visible = false;

                this.radioButton1.Visible = false;
                this.radioButton2.Visible = false;
            }
            else if (selection.Equals("Remove User"))
            {
                this.AddTableLayoutPanel.Visible = true;

                this.Notification.Text = "Search User";


                this.TextLabel1.Text = "IG Name: ";
                this.TextLabel2.Text = "Username: ";
                this.TextLabel4.Text = "Password: ";
                this.TextLabel5.Text = "Funds: ";
                this.TextLabel6.Text = "Search Username: ";

                this.TextBox1.Visible = true;
                this.TextBox2.Visible = true;
                this.TextBox4.Visible = true;
                this.TextBox5.Visible = true;
                this.TextBox6.Visible = true;


                this.TextBox5.ReadOnly = false;

                this.TextBox1.ReadOnly = true;
                this.TextBox2.ReadOnly = true;
                this.TextBox4.ReadOnly = true;
                this.TextBox5.ReadOnly = true;

                this.TextLabel1.Visible = true;
                this.TextLabel2.Visible = true;
                this.TextLabel4.Visible = true;
                this.TextLabel5.Visible = true;
                this.TextLabel6.Visible = true;


                this.TextLabel3.Visible = false;
                this.TextLabel7.Visible = false;

                this.ComboBoxLayOut.Visible = false;
                this.checkBox1.Visible = false;

                this.radioButton1.Visible = false;
                this.radioButton2.Visible = false;
            }
            else if (selection.Equals("Add Pictures")){

                this.TextLabel1.Text = "Amount";

                this.TextBox1.ReadOnly = false;

                this.TextLabel1.Visible = true;
                this.TextBox1.Visible = true;
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
                updateTable();
            }
            else if (suspect.Name.Equals(radioButton2.Name))
            {
                this.radioButton1.Checked = false;
                updateTable();

            }
        }


        /*
         Modes:
            Add Game    done
            Edit Game   done
            Remove Game done
            Add User    done
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
                    Game newGame = new Game(0 + "",
                        this.TextBox1.Text,
                        this.TextBox2.Text,
                        this.ComboBoxLayOut.Text,
                        Convert.ToDouble(this.TextBox4.Text),
                        DateTime.Today,
                        Convert.ToInt32(this.TextBox5.Text),
                        0,
                        0);

                    FAM.CreateGame(newGame);
                    this.Notification.Text = "Made Game";

                }
                else if (this.radioButton2.Checked)
                {
                    if (Int32.TryParse(this.TextBox1.Text, out int GameAmount))
                    {
                        FAM.ToGameFile(FAM.CreateGame(GameAmount));
                        this.Notification.Text = "Made " + GameAmount + " games";

                    }
                }


            }
            else if (selection.Equals("Edit Game"))
            {
                String searchbox = this.TextBox6.Text;
                if (Int32.TryParse(searchbox, out int searchresult))        //Redundancy.
                {
                    List<Game> GameLibrary = FAM.GetGameLibrary();
                    var FindGame = GameLibrary.Find(a => a.GameID.Equals(searchresult.ToString()));
                    if (FindGame != null)
                    {
                        try
                        {


                            if (FindGame.GameID.Equals(FocusedGame.GameID))     //more redundancy.
                                                                                //check if the game that's searched, is the same as the game that is saved in memory
                            {
                                double price = Convert.ToDouble(this.TextBox4.Text);
                                if (price < 0)
                                {
                                    price = .99;
                                    this.TextBox4.Text = price.ToString();
                                }

                                int rating = Convert.ToInt32(this.TextBox5.Text);

                                if (rating < 0)
                                {
                                    rating = 1;
                                }
                                else if (rating > 100)
                                {
                                    rating = 100;
                                }

                                Console.WriteLine("Found Game");
                                FocusedGame.Name = this.TextBox1.Text;
                                FocusedGame.Studio = this.TextBox2.Text;
                                FocusedGame.Genre = this.ComboBoxLayOut.Text;
                                FocusedGame.Price = price;
                                FocusedGame.Ratings = rating;



                                FAM.UpdateGameFile(FocusedGame);

                                FocusedGame = null;
                                updateTable();

                                this.TextBox1.ReadOnly = true;
                                this.TextBox2.ReadOnly = true;
                                this.TextBox4.ReadOnly = true;
                                this.TextBox5.ReadOnly = true;
                                this.TextBox6.ReadOnly = false;

                                this.TextBox1.Text = "";
                                this.TextBox2.Text = "";
                                this.TextBox4.Text = "";
                                this.TextBox5.Text = "";
                                this.TextBox6.Text = "";
                            }
                        }
                        catch
                        {
                            this.Notification.Text = "Search first";
                        }
                    }
                }
            }
            else if (selection.Equals("Remove Game"))
            {
                String searchbox = this.TextBox6.Text;
                if (Int32.TryParse(searchbox, out int searchresult))        //Redundancy.
                {
                    List<Game> GameLibrary = FAM.GetGameLibrary();
                    var FindGame = GameLibrary.Find(a => a.GameID.Equals(searchresult.ToString()));
                    if (FindGame != null)
                    {
                        try
                        {
                            if (FindGame.GameID.Equals(FocusedGame.GameID))     //more redundancy.
                                                                                //check if the game that's searched, is the same as the game that is saved in memory
                            {
                                FAM.RemoveGame(FocusedGame);

                                FocusedGame = null;
                                updateTable();

                                this.TextBox1.ReadOnly = true;
                                this.TextBox2.ReadOnly = true;
                                this.TextBox4.ReadOnly = true;
                                this.TextBox5.ReadOnly = true;
                                this.TextBox6.ReadOnly = false;

                                this.TextBox1.Text = "";
                                this.TextBox2.Text = "";
                                this.TextBox4.Text = "";
                                this.TextBox5.Text = "";
                                this.TextBox6.Text = "";
                            }
                        }
                        catch
                        {
                            this.Notification.Text = "Search First";
                        }
                    }
                }
            }
            else if (selection.Equals("Add User"))
            {
                if (FAM.checkUsernameExist(this.TextBox1.Text))
                {
                    this.Notification.Text = "Username exist";
                }
                else
                {
                    User newUser = new User(this.TextBox1.Text,
                        this.TextBox2.Text,
                        this.TextBox4.Text);
                    newUser.Funds = Convert.ToInt32(this.TextBox5.Text);

                    this.TextBox1.Text = "";
                    this.TextBox2.Text = "";
                    this.TextBox4.Text = "";
                    this.TextBox5.Text = "";

                    this.Notification.Text = "";

                    FAM.saveUser(newUser);
                }
            }
            else if (selection.Equals("Edit User"))
            {
                String searchbox = this.TextBox6.Text;
                if (FAM.checkUsernameExist(searchbox))      //Check that it's still the same thing
                {
                    if (FocusedUser != null)
                    {
                        if (FocusedUser.UserName != this.TextBox2.Text)
                        {
                            if (!FAM.checkUsernameExist(this.TextBox2.Text))
                            {
                                string oldUser = FocusedUser.UserName;              //old user name
                                FocusedUser.IGName = this.TextBox1.Text;
                                FocusedUser.UserName = this.TextBox2.Text;          //updated username
                                FocusedUser.Password = this.TextBox4.Text;
                                FocusedUser.Funds = Convert.ToDouble(this.TextBox5.Text);

                                FAM.RenamedUserSave(FocusedUser, oldUser);
                                FAM.saveUser(FocusedUser);

                                if (this.checkBox1.Checked)
                                {
                                    FAM.makeUserAdmin(FocusedUser);
                                }

                                this.TextBox1.Text = "";
                                this.TextBox2.Text = "";
                                this.TextBox4.Text = "";
                                this.TextBox5.Text = "";
                                this.TextBox6.Text = "";
                                FocusedGame = null;
                            }
                            else
                            {
                                this.Notification.Text = "Username Exist.";
                            }
                        }
                        else
                        {

                            this.TextLabel1.Text = "IG Name: ";
                            this.TextLabel2.Text = "Username: ";
                            this.TextLabel4.Text = "Password: ";
                            this.TextLabel5.Text = "Funds: ";
                            this.TextLabel6.Text = "Search Username: ";

                            FocusedUser.IGName = this.TextBox1.Text;
                            FocusedUser.Password = this.TextBox4.Text;
                            FocusedUser.Funds = Convert.ToDouble(this.TextBox5.Text);

                            if (this.checkBox1.Checked)
                            {
                                FAM.makeUserAdmin(FocusedUser);
                            }

                            FAM.saveUser(FocusedUser);

                            this.TextBox1.Text = "";
                            this.TextBox2.Text = "";
                            this.TextBox4.Text = "";
                            this.TextBox5.Text = "";
                            this.TextBox6.Text = "";
                            FocusedGame = null;
                        }
                    }

                }
            }
            else if (selection.Equals("Remove User"))
            {
                String searchbox = this.TextBox6.Text;
                if (FAM.checkUsernameExist(searchbox))      //Check that it's still the same thing
                {
                    if (FocusedUser != null)
                    {

                        FAM.RemoveUser(FocusedUser);

                        FocusedUser = null;
                        this.TextBox1.Text = "";
                        this.TextBox2.Text = "";
                        this.TextBox4.Text = "";
                        this.TextBox5.Text = "";
                        this.TextBox6.Text = "";
                        this.Notification.Text = "Removed User";
                    }
                }
            }
        }

        private void setGameInfo(Game SelectedGame)
        {
            if (SelectedGame != null)
            {
                this.TextBox1.Text = SelectedGame.Name;
                this.TextBox2.Text = SelectedGame.Studio;
                this.ComboBoxLayOut.Text = SelectedGame.Genre;
                this.TextBox4.Text = SelectedGame.Price.ToString();
                this.TextBox5.Text = SelectedGame.Ratings.ToString();
            }
            else
            {
                updateTable();
                this.Notification.Text = "Search Again.";
            }
        }

        private void setUserInfo(User SelectedUser)
        {
            if (SelectedUser != null)
            {
                this.TextBox1.Text = SelectedUser.IGName;
                this.TextBox2.Text = SelectedUser.UserName;
                this.TextBox4.Text = SelectedUser.Password;
                this.TextBox5.Text = SelectedUser.Funds.ToString();
                this.TextLabel7.Text = "Admin";
                this.checkBox1.Text = "Status";
                this.checkBox1.Checked = FAM.CheckUserAdmin(SelectedUser);

                this.TextLabel7.Visible = true;
                this.checkBox1.Visible = true;
            }
            else
            {
                updateTable();
                this.Notification.Text = "Search Again.";

            }
        }

        private void Notif_Click(object sender, EventArgs e)
        {
            String selection = this.ModeSelection.Text;
            if (selection.Equals("Edit Game"))
            {
                String searchbox = this.TextBox6.Text;
                if (Int32.TryParse(searchbox, out int searchresult))
                {
                    List<Game> GameLibrary = FAM.GetGameLibrary();
                    var FindGame = GameLibrary.Find(a => a.GameID.Equals(searchresult.ToString()));

                    FocusedGame = FindGame;         //establish game in memory
                    setGameInfo(FocusedGame);

                    this.TextBox1.ReadOnly = false;
                    this.TextBox2.ReadOnly = false;
                    this.TextBox4.ReadOnly = false;
                    this.TextBox5.ReadOnly = false;
                    this.TextBox6.ReadOnly = false;
                }
            }
            else if (selection.Equals("Remove Game"))
            {
                String searchbox = this.TextBox6.Text;
                if (Int32.TryParse(searchbox, out int searchresult))
                {
                    List<Game> GameLibrary = FAM.GetGameLibrary();
                    var FindGame = GameLibrary.Find(a => a.GameID.Equals(searchresult.ToString()));
                    FocusedGame = FindGame;
                    setGameInfo(FocusedGame);

                    this.TextBox1.ReadOnly = true;
                    this.TextBox2.ReadOnly = true;
                    this.TextBox4.ReadOnly = true;
                    this.TextBox5.ReadOnly = true;
                    this.TextBox6.ReadOnly = false;
                }
            }
            else if (selection.Equals("Edit User"))
            {
                String searchbox = this.TextBox6.Text;
                if (FAM.checkUsernameExist(searchbox))
                {
                    FocusedUser = FAM.ADMINreadUserFile(searchbox);
                    setUserInfo(FocusedUser);
                    this.TextBox1.ReadOnly = false;
                    this.TextBox2.ReadOnly = false;
                    this.TextBox4.ReadOnly = false;
                    this.TextBox5.ReadOnly = false;
                    this.TextBox6.ReadOnly = false;

                }
            }
            else if (selection.Equals("Remove User"))
            {
                String searchbox = this.TextBox6.Text;
                if (FAM.checkUsernameExist(searchbox))
                {
                    FocusedUser = FAM.ADMINreadUserFile(searchbox);
                    setUserInfo(FocusedUser);
                }
            }
        }

        private void TextOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            String selection = this.ModeSelection.Text;
            TextBox suspect = (TextBox)sender;
            if (selection.Equals("Add Pictures"))
            {
                if (suspect.Name.Equals(this.TextBox1.Name))
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))     //numbers only
                    {
                        e.Handled = true;
                    }
                }
            }
            else if (selection.Equals("Edit Game"))
            {
                if (suspect.Name.Equals(this.TextBox4.Name))
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                        (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }

                    // only allow one decimal point
                    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                    {
                        e.Handled = true;
                    }
                }
                else if (suspect.Name.Equals(this.TextBox5.Name))
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
            else if (selection.Equals("Add User"))
            {
                if (suspect.Name.Equals(this.TextBox5.Name))
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }

            }
            else if (selection.Equals("Edit User"))
            {
                if (suspect.Name.Equals(this.TextBox5.Name))
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

    }
}

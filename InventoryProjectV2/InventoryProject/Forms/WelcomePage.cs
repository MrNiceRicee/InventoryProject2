using InventoryProject.Classes;
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
    public partial class WelcomePage : Form
    {
        
        Form mainform;
        internal User LoggedIn;
        FileAccessModule FAM = new FileAccessModule();
        List<Game> StoreLibrary = new List<Game>();
        internal List<Game> InCart = new List<Game>();
        Boolean CloseUp = true;



        private void initiatePage()
        {
            FAM.FromGameFile("", StoreLibrary);                         //get the store running
            StoreLibrary.Sort((a, b) => b.Name.CompareTo(a.Name));      //sort alphabetically
            MostPopularPanelFill(this.MostPopularPanel, StoreLibrary);  //fill in most popular tab
            MostRatedPanelFill(this.MostLikedPanel, StoreLibrary);      //fill in most rated tab

            
        }

        public WelcomePage(Form parent)
        {
            InitializeComponent();
            mainform = parent;
            initiatePage();
            this.UserProfileLabel.Text = "Profile";           
            this.FormClosed += our_FormClosed;
            this.InCartLabel.Text = "(" + InCart.Count + ") Cart";
            //updatePage();

        }

        public void updatePage()
        {
            this.InCartLabel.Text = "(" + InCart.Count + ") Cart";
            this.UserFunds.Text = string.Format("{0:C}", (LoggedIn.Funds));
        }

        private void our_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseUp)
            {
                Environment.Exit(0);
            }
        }


        internal void setLoggedIn(User logged)
        {
            LoggedIn = logged;
            FAM.FromGameFile(FAM.FindUserLocation(LoggedIn.UserName) + "\\uGameLibrary.txt",LoggedIn.gameLibrary);
            this.WelcomeLabel.Text = "Welcome back, " + LoggedIn.IGName;
            this.UserFunds.Text = string.Format("{0:C}",(LoggedIn.Funds));


        }

        private void MostPopularPanelFill(Panel panelstore, List<Game> gamelibrary)
        {
            List<Game> copy = new List<Game>(gamelibrary);
            copy.Sort((a, b) => b.ItemSold.CompareTo(a.ItemSold));
            GamePanels(panelstore, copy);
        }
        private void MostRatedPanelFill(Panel panelstore, List<Game> gamelibrary)
        {
            List<Game> copy = new List<Game>(gamelibrary);
            copy.Sort((a, b) => b.Ratings.CompareTo(a.Ratings));
            GamePanels(panelstore, copy);
        }

        //Make Panel for games
        private void GamePanels(Panel parentPanel, List<Game> gamelibrary)
        {
            //starting positions
            int panelheight = 60;
            int edgepad = 20;

            int max = gamelibrary.Count;
            if (max > 10)
            {
                max = 10;
            }
            //loop this thing
            for (int i = 0; i < max; i++)
            {
                //items in the label
                Panel gameFrame = new Panel();                  //holds everthing
                PictureBox gamePicture = new PictureBox();
                Label gameTitle = new Label();
                Label gameStudio = new Label();
                Label gameRating = new Label();
                Label gameSold = new Label();
                Label gamePrice = new Label();
                //Label gameGenre = new Label();

                //make the labels
                gameFrame.Size = new Size(parentPanel.Size.Width - edgepad, panelheight);                          //length of the entire panel, and then the height
                gameFrame.Location = new Point(0, (i * (panelheight+2)));
                gameFrame.Margin = new Padding(0);
                gameFrame.Padding = new Padding(0);
                gameFrame.Name = StoreLibrary.FindIndex(a => a.saveInfo().Equals(gamelibrary[i].saveInfo())).ToString();
                gameFrame.BackColor = Color.FromArgb(10,18,29);
                gameFrame.DoubleClick += CustomItem_DoubleClick;
                gameFrame.MouseHover += CustomItem_Hover;
                gameFrame.MouseLeave += CustomItem_MouseLeave;


                gamePicture.Size = new Size(gameFrame.Size.Height, gameFrame.Size.Height);        //makes it a box using the workframe width, this makes a box
                gamePicture.BackColor = Color.FromArgb(50, 255, 255, 255);


                gameTitle.Text = (i+1)+". "+gamelibrary[i].Name;
                gameTitle.AutoSize = true;
                gameFrame.Controls.Add(gameTitle);
                //add it in so the size resizes
                gameTitle.Font = new Font(this.Font.FontFamily, 10,FontStyle.Underline);
                gameTitle.Location = new Point(gamePicture.Location.X + gamePicture.Width, 5);
                gameTitle.ForeColor = Color.FromArgb(255, 255, 255);
                gameTitle.BackColor = Color.FromArgb(0);
                gameTitle.MouseHover += Label_MouseHover;
                gameTitle.MouseLeave += Label_MouseLeave;


                gameStudio.Text = gamelibrary[i].Studio+"\n"+gamelibrary[i].Genre;
                gameStudio.AutoSize = true;
                gameFrame.Controls.Add(gameStudio);
                //add it in so the size resizes
                gameStudio.Font = new Font(this.Font.FontFamily, 8);
                gameStudio.Location = new Point((gameTitle.Location.X),
                    (gameTitle.Location.Y + gameTitle.Size.Height));
                gameStudio.ForeColor = Color.FromArgb(255, 255, 255);
                gameStudio.BackColor = Color.FromArgb(0);
                gameStudio.MouseHover += Label_MouseHover;
                gameStudio.MouseLeave += Label_MouseLeave;


                gameRating.Text = "rating: "+gamelibrary[i].Ratings + "%";
                gameRating.AutoSize = true;
                gameFrame.Controls.Add(gameRating);
                //add it in so the size resizes
                gameRating.Font = new Font(this.Font.FontFamily, 8);
                gameRating.Location = new Point((gameFrame.Location.X+gamePicture.Size.Width),
                    (gameFrame.Size.Height-gameRating.Size.Height));
                gameRating.ForeColor = Color.FromArgb(255, 255, 255);
                gameRating.BackColor = Color.FromArgb(0);


                gameSold.Text = gamelibrary[i].ItemSold + " units sold";
                gameSold.AutoSize = true;
                gameFrame.Controls.Add(gameSold);
                //add it in so the size resizes
                gameSold.Font = new Font(this.Font.FontFamily, 8);
                gameSold.Location = new Point((gameFrame.Location.X + (gameFrame.Size.Width/2)) - (0),
                    (gameFrame.Size.Height - gameRating.Size.Height));
                gameSold.ForeColor = Color.FromArgb(255, 255, 255);
                gameSold.BackColor = Color.FromArgb(0);


                gamePrice.Text = "$"+gamelibrary[i].Price;
                gamePrice.AutoSize = true;
                gameFrame.Controls.Add(gamePrice);
                //add it in so the size resizes
                gamePrice.Location = new Point((gameFrame.Location.X + gameFrame.Size.Width) - (gamePrice.Size.Width),
                                    (gameFrame.Size.Height - gamePrice.Size.Height));
                gamePrice.Font = new Font(this.Font.FontFamily, 8);
                gamePrice.ForeColor = Color.FromArgb(255, 255, 255);
                gamePrice.BackColor = Color.FromArgb(0);


                gameFrame.Controls.Add(gamePicture);

                //update Location



                parentPanel.Controls.Add(gameFrame);
            }
            // hide the scroll bar
            Panel hidePanel = new Panel();
            hidePanel.Size = new Size(edgepad, parentPanel.Height);
            hidePanel.Location = new Point((parentPanel.Location.X +parentPanel.Size.Width)-hidePanel.Size.Width,parentPanel.Location.Y);
            hidePanel.BackColor = this.BackColor;


            parentPanel.AutoScroll = true;
            parentPanel.VerticalScroll.Visible = false;
            parentPanel.HorizontalScroll.Visible = false;

            this.Controls.Add(hidePanel);
            hidePanel.BringToFront();

        }

        
        //Checkout Cart
        private void MakeCart(Form parent, User user, List<Game> cart)
        {
            GameCart checkout = new GameCart(parent);
            checkout.setItems(cart,user);


            checkout.Show();
        }



        //Listeners

                    //someone clicked the cart
        private void CartClick_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox suspect = (PictureBox)sender;


            }
            else if (sender is Label)
            {
                Label suspect = (Label)sender;

            }
        }



        private void UpdateSystem(object sender, MouseEventArgs e)
        {

        }


        private void Label_MouseHover(object sender, EventArgs e)
        {
            Label inuse = (Label)sender;
            inuse.BackColor = Color.FromArgb(50, 255, 255, 255);
            this.MostPopularPanel.VerticalScroll.Visible = false;


        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label inuse = (Label)sender;
            inuse.BackColor = Color.FromArgb(0);
            this.MostPopularPanel.VerticalScroll.Visible = false;

        }

        private void UserProfileLabel_DoubleClick(object sender, EventArgs e)
        {
            //Lets go to profile page
            UserProfile userProfile = new UserProfile(this,InCart);
            userProfile.setLoggedIn(LoggedIn);

            //Make sure the location is the same place
            userProfile.StartPosition = FormStartPosition.Manual;
            userProfile.Left = this.Location.X;
            userProfile.Top = this.Location.Y;
            userProfile.Location = this.Location;
            userProfile.SetDesktopLocation(this.Location.X, this.Location.Y);


            userProfile.Show();
            this.Hide();
        }

        private void BrowseStore_DoubleClick(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<BrowseStore>().Count() > 0)
            {
                Application.OpenForms.OfType<BrowseStore>().First().Close();
            }
            BrowseStore store = new BrowseStore();
            store.setItems(StoreLibrary, LoggedIn, InCart);
            store.Show();
        }




        private void CustomItem_DoubleClick(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel suspect = (Panel)sender;
                //Console.WriteLine(suspect.Name);
                if (Int32.TryParse(suspect.Name,out int x))     
                {
                    //USER HAS CLICKED ON A GAME PANEL
                    //we Go in the game library
                    //Console.WriteLine(StoreLibrary[x].myInfo());
                    if (Application.OpenForms.OfType<GamePage>().Count() >= 1)
                    {
                        Application.OpenForms.OfType<GamePage>().First().Close();
                    }
                    GamePage gamePage = new GamePage(StoreLibrary[x], LoggedIn,this,InCart);
                    gamePage.Show();
                }
                else
                {
                    Console.WriteLine("WelcomePage.  Other label");
                }
            }else if (sender is Label)
            {
                Label suspect = (Label)sender;
                if (suspect.Name.Equals(this.LogOutLabel.Name))
                {
                    mainform.SetDesktopLocation(this.Location.X,this.Location.Y);                    
                    mainform.Show();
                    CloseUp = false;
                    this.Close();
                }
                else if (suspect.Name.Equals(this.UserFunds.Name))
                {
                    //Going to add money
                    string answer = Microsoft.VisualBasic.Interaction.InputBox("Enter how much money you would like to add",
                       "Adding Funds",
                       "0.00",
                       MousePosition.X,
                       MousePosition.Y);
                    double addedmoney = 0;
                    try
                    {
                        addedmoney = Math.Round(Convert.ToDouble(answer), 2);
                    }
                    catch
                    {
                        Console.WriteLine("WelcomePage. Some error");
                    }
                    LoggedIn.Funds += addedmoney;
                    this.UserFunds.Text = string.Format("{0:C}", (LoggedIn.Funds));
                    FAM.saveUser(LoggedIn);
                }else if (suspect.Name.Equals(this.InCartLabel.Name))
                {
                    if (Application.OpenForms.OfType<GameCart>().Count() >= 1)
                    {
                        Application.OpenForms.OfType<GameCart>().First().Close();
                    }
                    MakeCart(this, LoggedIn, InCart);
                }
            }
        }

        private void CustomItem_Hover(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel suspect = (Panel)sender;
                suspect.BackColor = Color.FromArgb(80, 100, 120);
            }
            else if (sender is Label)
            {
                Label suspect = (Label)sender;
                suspect.BackColor = Color.FromArgb(80, 100, 120);

            }
        }

        private void CustomItem_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel suspect = (Panel)sender;
                suspect.BackColor = Color.FromArgb(10, 18, 29);
            }
            else if (sender is Label)
            {
                Label suspect = (Label)sender;
                suspect.BackColor = Color.FromArgb(10, 18, 29);

            }
        }

        private void Form_Focused(object sender, EventArgs e)
        {
            updatePage();
        }
    }
}

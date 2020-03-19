using System;
using InventoryProject.Classes;
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
    public partial class UserProfile : Form
    {

        //Consistent Properties
        private User LoggedIn;
        Form parentForm;
        FileAccessModule FAM = new FileAccessModule();
        List<Game> PersonalLibrary;
        //List<Game> InCart;
        Boolean CloseUp = true;

        private void initiatePage()
        {
            //PersonalLibrary.Sort((a, b) => b.Name.CompareTo(a.Name));      //sort alphabetically
            GamePanels(this.PersonalGamesPanel,PersonalLibrary);
        }

        internal void setLoggedIn(User logged )
        {
            LoggedIn = logged;
            //FAM.FromGameFile(FAM.FindUserLocation(LoggedIn.UserName) + "\\uGameLibrary.txt", LoggedIn.gameLibrary);
            this.WelcomeLabel.Text = "Welcome back, " + LoggedIn.IGName;
            this.UserFunds.Text = string.Format("{0:C}", (LoggedIn.Funds));
            this.UserFunds.DoubleClick += CustomItem_DoubleClick;

            PersonalLibrary = new List<Game>(LoggedIn.gameLibrary);
            initiatePage();
        }

        internal Boolean checkCart(Game game)
        {
            return (PersonalLibrary.Contains(game));
        }

        internal UserProfile(Form parent, List <Game> inCart)
        {
            InitializeComponent();
            parentForm = parent;
            //InCart = inCart;
            this.FormClosed += our_FormClosed;
        }


        private void our_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseUp)
            {
                Environment.Exit(0);
            }
        }



        //-------------------------------------------------------------------//
        //UI generators


        //For game profile
        private void GamePanels(Panel parentPanel, List<Game> gamelibrary)
        {
            //starting positions
            int panelheight = 60;
            int edgepad = 20;

            int max = gamelibrary.Count;
            if (max > 10)
            {
                max = 10;
            }else if (max < 10)
            {
                Console.WriteLine(max);
            }
            Console.WriteLine(max);
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


                //make the labels
                gameFrame.Size = new Size(parentPanel.Size.Width - edgepad, panelheight);                          //length of the entire panel, and then the height
                gameFrame.Location = new Point(0, (i * (panelheight + 2)));
                gameFrame.Margin = new Padding(0);
                gameFrame.Padding = new Padding(0);
                gameFrame.Name = PersonalLibrary.FindIndex(a => a.saveInfo().Equals(gamelibrary[i].saveInfo())).ToString();
                gameFrame.BackColor = Color.FromArgb(10, 18, 29);
                gameFrame.DoubleClick += CustomItem_DoubleClick;
                gameFrame.MouseHover += CustomItem_Hover;
                gameFrame.MouseLeave += CustomItem_MouseLeave;


                gamePicture.Size = new Size(gameFrame.Size.Height, gameFrame.Size.Height);        //makes it a box using the workframe width, this makes a box
                gamePicture.BackColor = Color.FromArgb(50, 255, 255, 255);


                gameTitle.Text = (i + 1) + ". " + gamelibrary[i].Name;
                gameTitle.AutoSize = true;
                gameFrame.Controls.Add(gameTitle);
                //add it in so the size resizes
                gameTitle.Font = new Font(this.Font.FontFamily, 10, FontStyle.Underline);
                gameTitle.Location = new Point(gamePicture.Location.X + gamePicture.Width, 5);
                gameTitle.ForeColor = Color.FromArgb(255, 255, 255);
                gameTitle.BackColor = Color.FromArgb(0);
                gameTitle.MouseHover += CustomItem_Hover;
                gameTitle.MouseLeave += CustomItem_MouseLeave;


                gameStudio.Text = gamelibrary[i].Studio;
                gameStudio.AutoSize = true;
                gameFrame.Controls.Add(gameStudio);
                //add it in so the size resizes
                gameStudio.Font = new Font(this.Font.FontFamily, 8);
                gameStudio.Location = new Point((gameTitle.Location.X),
                    (gameTitle.Location.Y + gameTitle.Size.Height));
                gameStudio.ForeColor = Color.FromArgb(255, 255, 255);
                gameStudio.BackColor = Color.FromArgb(0);
                gameStudio.MouseHover += CustomItem_Hover;
                gameStudio.MouseLeave += CustomItem_MouseLeave;


                gameRating.Text = "rating: " + gamelibrary[i].Ratings + "%";
                gameRating.AutoSize = true;
                gameFrame.Controls.Add(gameRating);
                //add it in so the size resizes
                gameRating.Font = new Font(this.Font.FontFamily, 8);
                gameRating.Location = new Point((gameFrame.Location.X + gamePicture.Size.Width),
                    (gameFrame.Size.Height - gameRating.Size.Height));
                gameRating.ForeColor = Color.FromArgb(255, 255, 255);
                gameRating.BackColor = Color.FromArgb(0);


                gameSold.Text = gamelibrary[i].ItemSold + " units sold";
                gameSold.AutoSize = true;
                gameFrame.Controls.Add(gameSold);
                //add it in so the size resizes
                gameSold.Font = new Font(this.Font.FontFamily, 8);
                gameSold.Location = new Point((gameFrame.Location.X + (gameFrame.Size.Width / 2)) - (0),
                    (gameFrame.Size.Height - gameRating.Size.Height));
                gameSold.ForeColor = Color.FromArgb(255, 255, 255);
                gameSold.BackColor = Color.FromArgb(0);


                gamePrice.Text = "$" + gamelibrary[i].Price;
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
            hidePanel.Location = new Point((parentPanel.Location.X + parentPanel.Size.Width) - hidePanel.Size.Width, parentPanel.Location.Y);
            hidePanel.BackColor = this.BackColor;


            parentPanel.AutoScroll = true;
            parentPanel.VerticalScroll.Visible = false;
            parentPanel.HorizontalScroll.Visible = false;

            this.Controls.Add(hidePanel);
            hidePanel.BringToFront();

        }


        //Listeners
                    //Listener for double clicking
        private void CustomItem_DoubleClick(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel suspect = (Panel)sender;
                Console.WriteLine(suspect.Name);
                if (Int32.TryParse(suspect.Name, out int x))
                {
                    //It's a game label, since its a number
                    //Console.WriteLine(PersonalLibrary[x].myInfo());
                    GamePage newPage = new GamePage(PersonalLibrary[x], LoggedIn,this,null);

                    //newPage.beOwned();      //game is owned by someone

                    newPage.Show();
                }
                else
                {
                    Console.WriteLine("Other label");
                }
            }
            else if (sender is Label)
            {
                Label suspect = (Label)sender;
                if (suspect.Name.Equals(this.UserFunds.Name))
                {
                    //Going to add money
                    string answer = Microsoft.VisualBasic.Interaction.InputBox("Enter how much money you would like to add",
                       "Adding Funds",
                       "Default",
                       MousePosition.X,
                       MousePosition.Y);
                    double addedmoney=0;
                    //hello there
                    try {
                        addedmoney = Math.Round(Convert.ToDouble(answer),2);
                    }
                    catch {
                        Console.WriteLine("Some error");
                    }
                    LoggedIn.Funds += addedmoney;
                    this.UserFunds.Text = string.Format("{0:C}", (LoggedIn.Funds));
                    FAM.saveUser(LoggedIn);
                }
                else if (suspect.Name.Equals(this.BackButtonLabel.Name))        
                {
                    //Go back to the previous page
                    parentForm.SetDesktopLocation(this.Location.X, this.Location.Y);
                    parentForm.Show();
                    CloseUp = false;
                    this.Close();
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
                suspect.BackColor = Color.FromArgb(0);
            }
        }

    }
}

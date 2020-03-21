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
    public partial class BrowseStore : Form
    {

        List<Game> StoreLibrary;
        List<Game> GameCart;
        User LoggedUser;
        RandomizeGame RAM = new RandomizeGame();


        public BrowseStore()
        {
            InitializeComponent();
            this.GameNameSearchBox.Size = new Size(this.Size.Width,(this.GameNameSearchBox.Font.Height*2));
        }

        internal void setItems(List<Game> GameLibrary, User Buyer, List<Game> gameCart)
        {
            LoggedUser = Buyer;
            StoreLibrary = GameLibrary;
            GameCart = gameCart;
            this.GenreCheckList.Items.Clear();
            this.GenreCheckList.Items.AddRange(RAM.Genres);
        }

        //Make Panels
        private void GamePanels(Panel parentPanel, List<Game> gamelibrary)
        {
            //starting positions
            int panelheight = 60;
            int edgepad = 20;
            parentPanel.Controls.Clear();
            //loop this thing
            for (int i = 0; i < gamelibrary.Count; i++)
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
                gameFrame.Name = StoreLibrary.FindIndex(a => a.saveInfo().Equals(gamelibrary[i].saveInfo())).ToString();
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
                /*                gameTitle.MouseHover += Label_MouseHover;
                                gameTitle.MouseLeave += Label_MouseLeave;*/


                gameStudio.Text = gamelibrary[i].Studio + "\n" + gamelibrary[i].Genre;
                gameStudio.AutoSize = true;
                gameFrame.Controls.Add(gameStudio);
                //add it in so the size resizes
                gameStudio.Font = new Font(this.Font.FontFamily, 8);
                gameStudio.Location = new Point((gameTitle.Location.X),
                    (gameTitle.Location.Y + gameTitle.Size.Height));
                gameStudio.ForeColor = Color.FromArgb(255, 255, 255);
                gameStudio.BackColor = Color.FromArgb(0);
/*                gameStudio.MouseHover += Label_MouseHover;
                gameStudio.MouseLeave += Label_MouseLeave;*/


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
            hidePanel.Name = "HideScroll";


            parentPanel.AutoScroll = true;
            parentPanel.VerticalScroll.Visible = false;
            parentPanel.HorizontalScroll.Visible = false;

            this.Controls.Add(hidePanel);
            hidePanel.BringToFront();

        }






        private void SearchGames(object sender, EventArgs e)
        {
            string SearchName = this.GameNameSearchBox.Text;
            String[] SearchIndex = this.GameNameSearchBox.Text.Split(' ');
            SearchIndex = SearchIndex.Select(s=>s.ToLower()).ToArray();
            List<Game> SearchLibrary = new List<Game>();
            List<Game> FinalSearchLibrary = new List<Game>();

            //LINQ set ups for making seeing if the typed thing is a studio name or a game name

            var Namesearched = StoreLibrary.Where(p => p.Name.ToLower().Contains(SearchName.ToLower())).ToList();
            var Studiosearched = StoreLibrary.Where(p => p.Studio.ToLower().Contains(SearchName.ToLower())).ToList();

            //Trying to do a cool index but didnt work out.
            /*            var Namesearched = StoreLibrary.Where(p => SearchIndex.Any(x=> p.Name.ToLower().Contains(x))).ToList();
                        var Studiosearched = StoreLibrary.Where(p => SearchIndex.Any(x => p.Studio.ToLower().Contains(x))).ToList();*/


            //var searched = StoreLibrary.Where(p => p.Name.Any(x => SearchName.Contains(x))).ToList();
            /*            foreach (var item in searched)
                        {
                            Console.WriteLine(item.Name);
                        }*/

            SearchLibrary.AddRange(Namesearched.Except(SearchLibrary));
            SearchLibrary.AddRange(Studiosearched.Except(SearchLibrary));
            List<String> SelectedGenre = GenreCheckList.CheckedItems.OfType<String>().ToList();
            if (SelectedGenre.Count ==0)
            {
                SelectedGenre = GenreCheckList.Items.OfType<String>().ToList();
            }
            if(SearchLibrary.Count == 0)    //Empty List
            {
                SearchLibrary.AddRange(StoreLibrary);
            }
            var Genres = SearchLibrary.Where(p => SelectedGenre.Any(l => p.Genre == l));

            FinalSearchLibrary.AddRange(Genres);

            //Determining the type of sort.
            /*               
                Alphabetical (A-Z)
                Alphabetical (Z-A)
                Price ($-$$$)
                Price ($$$-$)
                Publish Date (Old - New)
                Publish Date (New - Old)
                Most Liked
                Least Liked
                Most Popular
                Least Popular
             */
            String SelectedSort = this.FilterBox.Text;       //Get the sort type
            //Console.WriteLine("BrowseStore. Sort Type: " +SelectedSort );

            if (SelectedSort.Equals("Alphabetical (A-Z)"))
            {
                //copy.Sort((a, b) => b.ItemSold.CompareTo(a.ItemSold));
                //Console.WriteLine("BrowseStore. A-Z");
                //LINQ to compare item a (first item) vs b (2nd item)
                FinalSearchLibrary.Sort((a,b)=> a.Name.CompareTo(b.Name));
            }
            else if (SelectedSort.Equals("Alphabetical (Z-A)"))
            {
                //Console.WriteLine("BrowseStore. Z-A");
                //Same as above explanation but reversed
                FinalSearchLibrary.Sort((a, b) => b.Name.CompareTo(a.Name));

            }
            else if (SelectedSort.Equals("Price ($-$$$)"))
            {
                FinalSearchLibrary.Sort((a, b) => a.Price.CompareTo(b.Price));  

            }
            else if (SelectedSort.Equals("Price ($$$-$)"))
            {
                FinalSearchLibrary.Sort((a, b) => b.Price.CompareTo(a.Price));

            }
            else if (SelectedSort.Equals("Publish Date (Old - New)"))
            {
                FinalSearchLibrary.Sort((a, b) => a.DatePublished.CompareTo(b.DatePublished));

            }
            else if (SelectedSort.Equals("Publish Date (New - Old)"))
            {
                FinalSearchLibrary.Sort((a, b) => b.DatePublished.CompareTo(a.DatePublished));

            }
            else if (SelectedSort.Equals("Most Liked"))
            {
                FinalSearchLibrary.Sort((a, b) => b.Ratings.CompareTo(a.Ratings));

            }
            else if (SelectedSort.Equals("Least Liked"))
            {
                FinalSearchLibrary.Sort((a, b) => a.Ratings.CompareTo(b.Ratings));

            }
            else if (SelectedSort.Equals("Most Popular"))
            {
                FinalSearchLibrary.Sort((a, b) => b.ItemSold.CompareTo(a.ItemSold));

            }
            else if (SelectedSort.Equals("Least Popular"))
            {
                FinalSearchLibrary.Sort((a, b) => a.ItemSold.CompareTo(b.ItemSold));

            }


            GamePanels(this.GameResultsPanel, FinalSearchLibrary);
        }


        private void SearchBoxEnter(object sender, EventArgs e)
        {
            if(sender is TextBox)
            {
                TextBox suspect = (TextBox)sender;
                if (suspect.Name == this.GameNameSearchBox.Name)
                {
                    if (suspect.Text == "Search Game Title or Studio")
                    {
                        suspect.Text = "";
                        suspect.ForeColor = Color.Black;
                    }
                }
            }
        }
        private void SearchBoxLeave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox suspect = (TextBox)sender;
                if (suspect.Name == this.GameNameSearchBox.Name)
                {
                    if (suspect.Text == "")
                    {
                        suspect.Text = "Search Game Title or Studio";
                        suspect.ForeColor = Color.FromArgb(105,105,105);
                    }
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

        private void CustomItem_DoubleClick(object sender, EventArgs e)
        {

            if (sender is Panel)
            {
                Panel suspect = (Panel)sender;
                if (Int32.TryParse(suspect.Name, out int x))
                {
                    //USER HAS CLICKED ON A GAME PANEL
                    //we Go in the game library
                    //Console.WriteLine(StoreLibrary[x].myInfo());
                    if (Application.OpenForms.OfType<GamePage>().Count() >= 1)
                    {
                        Application.OpenForms.OfType<GamePage>().First().Close();
                    }
                    GamePage gamePage = new GamePage(StoreLibrary[x], LoggedUser, this, GameCart);
                    gamePage.Show();
                    Console.WriteLine("BrowseStore. Activate GamePage");

                }
                else
                {
                    Console.WriteLine("BrowseStore. Other label");
                }
            }
        }

        public void myScroll()
        {
            Console.WriteLine("BrowseStore. Beginning. Bar " + this.GameResultsPanel.VerticalScroll.Value + "/" + this.GameResultsPanel.VerticalScroll.Maximum);

            if (this.GameResultsPanel.Controls.Count > 0)
            {

                if (!this.Controls.ContainsKey("myScrollBar"))
                {
                    Panel myScrollbar = new Panel();
                    myScrollbar.Size = new Size(10, 2);
                    myScrollbar.Name = "myScrollBar";
                    myScrollbar.Location = new Point((this.GameResultsPanel.Location.X + this.GameResultsPanel.Size.Width) - this.GameResultsPanel.Size.Width, this.GameResultsPanel.Location.Y);
                    //myScrollbar.Location = new Point(this.SearchButton.Location.X-30, this.GameResultsPanel.Location.Y);
                    myScrollbar.BackColor = Color.FromArgb(255, 0, 0);
                    myScrollbar.Location = new Point((this.GameResultsPanel.Location.X + this.GameResultsPanel.Size.Width) - this.GameResultsPanel.Size.Width, this.GameResultsPanel.Location.Y);

                    Console.WriteLine("BrowseStore. Does not Exist. Bar " + this.GameResultsPanel.VerticalScroll.Value + "/" + this.GameResultsPanel.VerticalScroll.Maximum);
                    double si =(double) this.GameResultsPanel.VerticalScroll.Value / this.GameResultsPanel.VerticalScroll.Maximum;
                    int sixx = (int)Math.Round(si * this.GameResultsPanel.Size.Height);
                    Console.WriteLine("BrowseStore. "+ si +" "+ si*this.GameResultsPanel.Size.Height + " " + sixx);
                    myScrollbar.Size = new Size(5,sixx);
                    this.Controls.Add(myScrollbar);
                    myScrollbar.BringToFront();
                }
                else
                {
                    Panel myScrollbar = (Panel)this.Controls["myScrollBar"];
                    myScrollbar.Location = new Point((this.GameResultsPanel.Location.X + this.GameResultsPanel.Size.Width) - this.GameResultsPanel.Size.Width, this.GameResultsPanel.Location.Y);
                    //myScrollbar.Location = new Point(this.SearchButton.Location.X-30, this.GameResultsPanel.Location.Y);
                    Console.WriteLine("BrowseStore. Does Exist. Bar " + this.GameResultsPanel.VerticalScroll.Value + "/" + this.GameResultsPanel.VerticalScroll.Maximum);
                    double si = (double)this.GameResultsPanel.VerticalScroll.Value / this.GameResultsPanel.VerticalScroll.Maximum;
                    int sixx = (int)Math.Round(si * this.GameResultsPanel.Size.Height);
                    Console.WriteLine("BrowseStore. " + si + " " + si * this.GameResultsPanel.Size.Height + " " + sixx);
                    myScrollbar.Size = new Size(5, sixx);
                    myScrollbar.BringToFront();

                }
            }
        }

        private void GameResultsPanel_Scroll(object sender, ScrollEventArgs e)
        {
            myScroll();
        }

        private void GameResultsPanel_Scroll(object sender, EventArgs e)
        {
            myScroll();
        }
    }
}

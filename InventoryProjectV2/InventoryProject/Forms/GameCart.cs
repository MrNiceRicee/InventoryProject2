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
    public partial class GameCart : Form
    {

        List<Game> checkout;
        User loggedBuyer;
        Form parentForm;

        public GameCart(Form ParentForm)
        {
            InitializeComponent();
            parentForm = ParentForm;
        }       


        internal void setItems(List<Game> InCartGames, User Buyer)
        {
            checkout = InCartGames;
            loggedBuyer = Buyer;
            GamePanels(this.InCartPanel, checkout);
            this.InCartLabel.Text = "Cart(" + checkout.Count + ")";
            this.SubTotal.Text = string.Format("{0:C}", (checkout.Sum(a => a.Price)));
        }

        private void updatePage()
        {
            this.InCartPanel.Controls.Clear();
            GamePanels(this.InCartPanel, checkout);
            this.InCartLabel.Text = "Cart(" + checkout.Count + ")";
            this.SubTotal.Text = string.Format("{0:C}", (checkout.Sum(a => a.Price)));
        }


        //Generate Panels
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


                //make the labels
                gameFrame.Size = new Size(parentPanel.Size.Width - edgepad, panelheight);                          //length of the entire panel, and then the height
                gameFrame.Location = new Point(0, (i * (panelheight + 2)));
                gameFrame.Margin = new Padding(0);
                gameFrame.Padding = new Padding(0);
                gameFrame.Name = i.ToString();
                gameFrame.BackColor = Color.FromArgb(10, 18, 29);
                gameFrame.MouseHover += CustomItem_Hover;
                gameFrame.MouseLeave += CustomItem_MouseLeave;
                gameFrame.MouseDoubleClick += CustomItem_MouseClick;


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
                //gameTitle.MouseHover += Label_MouseHover;
                //gameTitle.MouseLeave += Label_MouseLeave;


                gameStudio.Text = gamelibrary[i].Studio;
                gameStudio.AutoSize = true;
                gameFrame.Controls.Add(gameStudio);
                //add it in so the size resizes
                gameStudio.Font = new Font(this.Font.FontFamily, 8);
                gameStudio.Location = new Point((gameTitle.Location.X),
                    (gameTitle.Location.Y + gameTitle.Size.Height));
                gameStudio.ForeColor = Color.FromArgb(255, 255, 255);
                gameStudio.BackColor = Color.FromArgb(0);
                //gameStudio.MouseHover += Label_MouseHover;
                //gameStudio.MouseLeave += Label_MouseLeave;


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



        private void CustomItem_Hover(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel suspect = (Panel)sender;
                if (Int32.TryParse(suspect.Name, out int x))
                {
                    suspect.BackColor = Color.FromArgb(145, 26, 26);

                }
                else
                {
                    suspect.BackColor = Color.FromArgb(80, 100, 120);
                }
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

        private void CustomItem_MouseClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button suspect = (Button)sender;
                if (suspect.Name.Equals(this.GameBuyButton.Name))
                {
                    DialogResult result = MessageBox.Show("Buy " + checkout.Count +" games?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Console.WriteLine("GameCart. Yes");

                        //LINQ testing
                        double total = checkout.Sum(a => a.Price);

/*                        double total = 0;
                        for (int i = 0; i < checkout.Count; i++)
                        {
                            total += checkout[i].Price;
                        }*/
                        if (loggedBuyer.Funds >= total)
                        {
                            loggedBuyer.Funds -= total;
                            loggedBuyer.gameLibrary.AddRange(checkout);
                            checkout.Clear();
                            GamePanels(this.InCartPanel,checkout);
                            FileAccessModule FAM = new FileAccessModule();
                            FAM.saveUser(loggedBuyer);
                            updatePage();
                        }else
                        {

                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        Console.WriteLine("GameCart. No");
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        Console.WriteLine("GameCart. Cancelled");
                    }
                }
            }
            else if (sender is Panel)
            {
                Panel suspect = (Panel)sender;
                if (Int32.TryParse(suspect.Name,out int x))
                {
                    checkout.Remove(checkout[x]);
                    updatePage();
                }
            }
        }


    }
}

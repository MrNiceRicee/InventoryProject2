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
    public partial class GamePage : Form
    {
        Game RegisteredGame;
        User LoggedUser;
        Form parentForm;
        List<Game> GameCart;
        RandomizeGame RG = new RandomizeGame();
        FileAccessModule FAM = new FileAccessModule();
        Boolean Owned = false;


                //set up the form
        internal GamePage(Game freshgame, User logged, Form ParentForm, List<Game> gameCart)
        {
            InitializeComponent();
            RegisteredGame = freshgame;
            LoggedUser = logged;
            parentForm = ParentForm;
            GameCart = gameCart;
            //if (LoggedUser.gameLibrary.Contains(freshgame))
            //if (LoggedUser.gameLibrary.Any(a => a.saveInfo().Equals(freshgame.saveInfo())))
            if (LoggedUser.gameLibrary.Any(a => a.GameID.Equals(freshgame.GameID))) 
            {
                Console.WriteLine("GamePage. Owned Game!");
                this.Owned = true;
            }
            initiateGamePage();
        }
        

            //Set up the page
        internal void initiateGamePage()
        {

            chekGameInfo();
            this.GameTitleLabel.Text = RegisteredGame.Name;
            this.GameStudioLabel.Text = RegisteredGame.Studio;
            this.GameRatingLabel.Text = RegisteredGame.Ratings + "%";
            this.GameGenreLabel.Text = RegisteredGame.Genre;
            this.GameDateLabel.Text = RegisteredGame.DatePublished.ToString();
            if (Owned)
            {
                this.GameBuyButton.Text = "Play Game";
                var SelectGame = LoggedUser.gameLibrary.Where(a => a.GameID.Equals(RegisteredGame.GameID)).FirstOrDefault();
                this.PlayCountLabel.Text = "Play Count: " + SelectGame.PlayCount;
                this.PlayCountLabel.Visible = true;
            }
        }

            //Make the game be owned
/*        internal void beOwned()
        {
            Owned = true;
            initiateGamePage();
        }*/

        private void chekGameInfo()
        {
            if (FAM.checkGameInfo(RegisteredGame))
            {
                this.GameDescriptionBox.DataSource = FAM.getGameDescription(RegisteredGame);
                this.GamePictureBox.BackgroundImage = FAM.getGameImage(RegisteredGame);
                this.GamePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            }else
            {
                FAM.generateGameInfo(RegisteredGame);
                this.GameDescriptionBox.DataSource = FAM.getGameDescription(RegisteredGame);
                this.GamePictureBox.BackgroundImage = FAM.getGameImage(RegisteredGame);
                this.GamePictureBox.BackgroundImageLayout = ImageLayout.Stretch;

            }
        }
                            //Listeners
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
            else if (sender is Button)
            {
                Button suspect = (Button)sender;
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
            else if (sender is Button)
            {
                Button suspect = (Button)sender;
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
                    if (Owned)
                    {

                        var SelectGame = LoggedUser.gameLibrary.Where(a=> a.GameID.Equals(RegisteredGame.GameID)).FirstOrDefault();
                        SelectGame.PlayCount++;
                        //Console.WriteLine("GamePage. Player Played Game: " + SelectGame.PlayCount);
                        FAM.UpdateUserGames(LoggedUser);
                        this.PlayCountLabel.Text = "Play Count: " + SelectGame.PlayCount;
                    }
                    else
                    {
                        Console.WriteLine("GamePage. Player does not own game.");
                        if (!GameCart.Contains(RegisteredGame))
                        {
                            Console.WriteLine("GamePage. Game is not in Cart. Adding to Cart");
                            GameCart.Add(RegisteredGame);
                        }
                    }
                }
            }
        }
    }
}

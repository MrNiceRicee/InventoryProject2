using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProject
{
    internal class Game
    {
        private String gameID;
        private String name;
        private String studio;
        private String genre;
        private double price;
        private DateTime datePublished;
        private int ratings;
        private int itemSold;
        private int playCount;
        private string seperate = "/,/";


        public string GameID { get => gameID; set => gameID = value; }

        public string Name { get => name; set => name = value; }
        public string Studio { get => studio; set => studio = value; }
        public string Genre { get => genre; set => genre = value; }
        public double Price { get => price; set => price = value; }
        public DateTime DatePublished { get => datePublished; set => datePublished = value; }

        public int Ratings { get => ratings; set => ratings = value; }
        public int ItemSold { get => itemSold; set => itemSold = value; }

        public int PlayCount { get => playCount; set => playCount = value; }




        public Game(string gameID, string name, string studio, string genre, double price,
            DateTime datePublished, int ratings, int itemSold, int playCount)
        {
            GameID = gameID;
            Name = name;
            Studio = studio;
            Genre = genre;
            Price = Convert.ToDouble(String.Format("{0:0.00}", price));
            DatePublished = datePublished;
            Ratings = ratings;
            ItemSold = itemSold;
            PlayCount = playCount;
        }

        public string myInfo()
        {
            return ("GameID: " +this.gameID+
            "\n\tGame: " + this.name +
            "\n\tStudio: " + this.studio +
            "\n\tGenre: " + this.genre +
            "\n\tPrice: " + this.price +
            "\n\tPublish Date: " + this.DatePublished.ToString("MMMM dd, yyyy")+
            "\n\tRatings"
            );
        }

        public string saveInfo()
        {
            return (this.gameID + seperate +
                this.name + seperate +
                this.studio + seperate +
                this.genre + seperate +
                this.price + seperate +
                this.DatePublished + seperate +
                this.ratings + seperate +
                this.itemSold + seperate +
                this.playCount) ;
        }
    }
}

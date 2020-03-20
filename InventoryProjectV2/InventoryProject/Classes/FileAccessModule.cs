using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryProject.Classes
{
    class FileAccessModule
    {
        //--------------------------------------------------------------//
        /*                        //OBJECTIVES//
            * Acess GameLibrary.
            * Implement unique GameID per game in GameID.txt 
            * Create new Games
            * Access Users.
            * Register Users
            * Check Users
            * 


        */
        //--------------------------------------------------------------//
                                //PROPERTIES//

        public String getLibrary(String specifics)
        {
            var parent = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;       //Get where we are in the system
            return (parent+specifics);
        }

        //--------------------------------------------------------------//


        //Access GameLibary.

        public List<Game> GetGameLibrary()        
        {
            /*
             * This method will get games from a file.
             * Return all of those games in a list
             * fileLocation is if there is a designated filelocation
             */


            List<Game> returnGame = new List<Game>();

            List<String> FileStrings = new List<String>();
            FileStrings = File.ReadAllLines(getLibrary("\\SaveFiles\\GameLibrary\\GameLibrary.txt")).ToList();



            //Check every line of the FileStrings
            for (int i = 0; i < FileStrings.Count; i++)
            {
                //We are in the line of the text file
                String[] SplitLine = Regex.Split(FileStrings[i],"/,/");
                //Split the line by /,/
                //Now we're in between those splits

                Game newGame = new Game(SplitLine[0],                       //gameID
                                        SplitLine[1],                       //name
                                        SplitLine[2],                       //studio
                                        SplitLine[3],                       //genre
                                        Convert.ToDouble(SplitLine[4]),     //price
                                        Convert.ToDateTime(SplitLine[5]),   //date
                                        Convert.ToInt32(SplitLine[6]),      //ratings
                                        Convert.ToInt32(SplitLine[7]),      //items sold
                                        Convert.ToInt32(SplitLine[8])       //playcount
                                        );
                returnGame.Add(newGame);            //Add game to the return List
            }

            return returnGame;
        }

        //Generate Games


        public int getGameID()
        {
            var Location = getLibrary("\\SaveFiles\\GameLibrary\\GameID.txt");
            List<String> TextStrings = new List<String>();
            TextStrings = File.ReadLines(Location).ToList();
            int gameIDCount = Convert.ToInt32(TextStrings[0]);
            return gameIDCount;
        }

        public List<Game> CreateGame(int AmountofGames)     //creates games and returns in a gamelist
        {
            List<Game> newGames = new List<Game>();
            RandomizeGame gameRandom = new RandomizeGame();
            for (int i = 0; i < AmountofGames; i++)
            {
                int GameIDCount = getGameID();
                int ratings = gameRandom.RandomRating();

                Game newGame = gameRandom.RandomGameOut();      //generate new game
                newGame.GameID = GameIDCount.ToString();        //Have to establish gameID

                newGames.Add(newGame);
                GameIDCount++;
                File.WriteAllText(getLibrary("\\SaveFiles\\GameLibrary\\GameID.txt"),GameIDCount.ToString());                
            }
            return newGames;
        }

        //Write to file as an Append. 

        public void ToGameFile(List<Game> games)
        {
            var gameLocation = getLibrary("\\SaveFiles\\GameLibrary\\GameLibrary.txt");
            //File.WriteAllText();

            for (int i = 0; i < games.Count; i++)
            {
                File.AppendAllText(gameLocation,games[i].saveInfo().ToString() + Environment.NewLine);
            }
        }


    }
}

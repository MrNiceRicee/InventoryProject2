﻿using System;
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
                GameIDCount++;                                  //Game Count Add
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

        public void ToGameFile(Game addGame)
        {
            var gameLocation = getLibrary("\\SaveFiles\\GameLibrary\\GameLibrary.txt");
            int GameIDCount = getGameID();  //Get current Game ID count
            addGame.GameID = GameIDCount.ToString();        //Add it to the game thats being added
            GameIDCount++;  //increment by one


            File.AppendAllText(gameLocation, addGame.saveInfo().ToString() + Environment.NewLine);  //write game to the public library
            File.WriteAllText(getLibrary("\\SaveFiles\\GameLibrary\\GameID.txt"), GameIDCount.ToString());  //change gameid count


        }


        public Boolean CheckGameStoryStatus(Game checkGame)
        {
            var gameLocation = getLibrary("\\SaveFiles\\GameLibrary\\GameStories.txt");
            List<String> TextStrings = new List<String>();

            TextStrings = File.ReadAllLines(gameLocation).ToList();

            for (int i = 0; i < TextStrings.Count; i++)
            {
                String[] SplitLine = Regex.Split(TextStrings[i], "/,/");

                if (checkGame.GameID.Equals(SplitLine[0]))
                {
                    return true;
                }
            }
            return false;
        }

        public List<String> GetGameStory(Game checkGame)
        {
            List<String> gameStory = new List<String>();

            var gameLocation = getLibrary("\\SaveFiles\\GameLibrary\\GameStories.txt");
            List<String> TextStrings = new List<String>();

            TextStrings = File.ReadAllLines(gameLocation).ToList();

            for (int i = 0; i < TextStrings.Count; i++)
            {
                String[] SplitLine = Regex.Split(TextStrings[i], "/,/");
                if (checkGame.GameID.Equals(SplitLine[0]))
                {
                    String[] SpaceStory = Regex.Split(SplitLine[1], "<p>");

                    for (int x = 0; x < SpaceStory.Length; x++)
                    {
                        gameStory.Add(SpaceStory[x]);
                    }
                }

            }
            return gameStory;
        }

        public void makeGameStory(Game selectedGame)
        {
            var gameLocation = getLibrary("\\SaveFiles\\GameLibrary\\GameStories.txt");

            RandomizeGame randogame = new RandomizeGame();

            String gameStory = selectedGame.GameID+"/,/";
            List<String> gatheredStory = randogame.RandomStory();
            for (int i = 0; i < gatheredStory.Count; i++)
            {
                gameStory += gatheredStory[i];
            }

            File.AppendAllText(gameLocation, gameStory + Environment.NewLine);  //write game to the public library

        }


        //--------------------------------------------------------------//
        //Access Users


        public Boolean checkUsernameExist(string Username)
        {
            var UserLocation = getLibrary("\\SaveFiles\\Users\\" + Username);       //grabs username and finds folder location
            if (Directory.Exists(UserLocation))                                     //Checks if that location exist
            {
                return true;
            }else
            {
                return false;
            }
        }


        public void saveUser(User newUser)
        {
            var UserLocation = getLibrary("\\SaveFiles\\Users\\" + newUser.UserName);       //grabs username and finds folder location

            if (Directory.Exists(UserLocation))
            {
                Console.WriteLine("FAM. SaveUser."+ newUser.UserName +"Already Exist");
                using (System.IO.FileStream fs = File.Create(UserLocation + "\\User.txt"))   //create the user txt initiate it
                {
                    Byte[] userinfo = new UTF8Encoding(true).GetBytes(newUser.SaveInfo());      //make the string to bytes
                    fs.Write(userinfo, 0, userinfo.Length);                                       //make the thing
                }
                using (System.IO.FileStream fs = File.Create(UserLocation + "\\uGameLibrary.txt"))   //create the gamelibrary txt initiate it
                {
                    String allgames = "";
                    for (int i = 0; i < newUser.gameLibrary.Count; i++)
                    {
                        allgames += newUser.gameLibrary[i].saveInfo() + "\n";
                    }
                    Byte[] gameinfo = new UTF8Encoding(true).GetBytes(allgames);      //make the string to bytes
                    fs.Write(gameinfo, 0, gameinfo.Length);                                       //make the thing
                }
            }else
            {
                Console.WriteLine("FAM. SaveUser."+ newUser.UserName +"Does Not Exist");
                Directory.CreateDirectory(UserLocation);                                     //making the folder                                      
                File.Create(UserLocation + "\\uGameLibrary.txt");                            //make the gamelibrary

                using (System.IO.FileStream fs = File.Create(UserLocation + "\\User.txt"))   //create the user txt initiate it
                {
                    Byte[] userinfo = new UTF8Encoding(true).GetBytes(newUser.SaveInfo());      //make the string to bytes
                    fs.Write(userinfo, 0, userinfo.Length);                                       //make the thing
                }
            }
        }

        public void UpdateUserGames(User user)
        {

            /*
             * Gather the game from the user
             * Get that list from User, compare it to the Global Inventory
             * Change the User gamelist to match the global inventory.
             * 
             */
            var UserLocation = getLibrary("\\SaveFiles\\Users\\" + user.UserName);       //grabs username and finds folder location
            if (Directory.Exists(UserLocation))
            {

                List<Game> PublicGameLibrary = GetGameLibrary();
                //user.gameLibrary = GetUserGameLibrary(user);

                var OwnedGames = PublicGameLibrary.Where(a => user.gameLibrary.Any(b => b.GameID.Equals(a.GameID))).ToList();       //Gather everything that matches gameID

                var query = (from x in OwnedGames
                             join y in user.gameLibrary
                             on x.GameID equals y.GameID
                             select new {x,y });

                foreach (var item in query)
                {
                    item.x.PlayCount = item.y.PlayCount;        //Keep playcount from user Library
                }

                //Console.WriteLine("Updating "+user.UserName+ " Game library: "+OwnedGames.Count); 

                using (System.IO.FileStream fs = File.Create(UserLocation + "\\uGameLibrary.txt"))   //create the gamelibrary txt initiate it
                {
                    String allgames = "";
                    for (int x = 0; x < OwnedGames.Count; x++)
                    {

                        allgames += OwnedGames[x].saveInfo()+"\n";
                    }
                    Byte[] gameinfo = new UTF8Encoding(true).GetBytes(allgames);      //make the string to bytes
                    fs.Write(gameinfo, 0, gameinfo.Length);                                       //make the thing
                }

                user.gameLibrary = GetUserGameLibrary(user);        //update memory
            }
        }

        public List<Game> GetUserGameLibrary(User user)
        {
            /*
             * Purpose
             * Go to the GameLibrary Txt from the user
             * Put all of them to a list
             */

            List<Game> returnGame = new List<Game>();

            List<String> FileStrings = new List<String>();
            Console.WriteLine(user.UserName + " USERNAME");
            var Location = getLibrary("\\SaveFiles\\Users\\" + user.UserName + "\\uGameLibrary.txt");       //grabs username and finds folder location

            FileStrings = File.ReadAllLines(Location).ToList();


            //Check every line of the FileStrings
            for (int i = 0; i < FileStrings.Count; i++)
            {
                //We are in the line of the text file
                String[] SplitLine = Regex.Split(FileStrings[i], "/,/");
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


        public Boolean checkUser(string username, string password)
        {
            var location = getLibrary("\\SaveFiles\\Users\\" + username);
            if (Directory.Exists(location))
            {
                var FileString = File.ReadAllLines(location+"\\User.txt");
                String[] Split = Regex.Split(FileString[0],"/,/");      //only first line because there is only one line

                Console.WriteLine("FileAccessModule. checkUser . checking user");

                foreach (var item in Split)
                {
                    Console.WriteLine(item);
                }

                if (Split[1].Equals(username,StringComparison.InvariantCultureIgnoreCase) &&
                    Split[2].Equals(password))
                {
                    Console.WriteLine("FileAccessModule. checkUser .User checks");
                    return true;
                }
            }
            Console.WriteLine("FileAccessModule. checkUser . Wrong information");

            return false;
        }

        public User readUserFile(string username, string password)
        {
            User newUser = new User("", "", ""); //make generic, because we're going to change it

            var location = getLibrary("\\SaveFiles\\Users\\" + username);
            if (Directory.Exists(location))
            {
                var FileString = File.ReadAllLines(location + "\\User.txt");
                String[] Split = Regex.Split(FileString[0], "/,/");      //only first line because there is only one line

                if (Split[1].Equals(username, StringComparison.InvariantCultureIgnoreCase) &&
                    Split[2].Equals(password))
                {
                    newUser.IGName = Split[0];
                    newUser.UserName = Split[1];
                    newUser.Password = Split[2];
                    newUser.Funds = Convert.ToDouble(Split[3]);
                }
            }
            return newUser;

        }

        public Boolean CheckUserAdmin(User selectUser)
        {
            var location = getLibrary("\\SaveFiles\\Users\\Admins.txt");

            var FileString = File.ReadAllLines(location);

            if (FileString.Any(a=> a.Equals(selectUser.UserName, StringComparison.InvariantCultureIgnoreCase)))
            {
                return true;
            }else
            {
                return false;
            }
        }

    }


}

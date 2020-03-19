using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProject
{
    class RandomizeGame
    {
        Random rando = new Random();

        private String[] PrefixName = { "First", "Second", "Alpha", "Zero", "One" , "Duex", "Mind","Grand",
                                           "Space", "King", "Queen", "Duke", "Legend of", "Arena", "Gauntlet","Golden",
                                            "QWERTY" , "Green"};

        private String[] SuffixName = { "Break" , "Horizon", "Hero", "AntiHero", "Villian", "Origins",
                                            "Clutch", "Crowd", "Theft", "Invaders", "Command", "Kong", "Hazards",
                                            "Bros"};

        internal String[] Genres = { "Action","FPS", "Adventure", "Simulator", "Puzzle", "Racing", "MMORPG", "RPG" };

        private String[] PreStudios = { "Unreal", "Red", "Black" , "Bloody", "Crimson", "Dark" , "Epic", "End",
                                            "Get", "Hello", "Level Up", "First"};

        private String[] SufStudios = { "Games", "Gaming" , "Studio", "Reality", "Final", "Go", "World"};


        //Generate Story

        private String[] StoryBeginning = {"Breeze Morning","One Day","In the morning", "At night fall","While at brunch",
                                        "While eating lunch" };

        private String[] StoryPrefix = {"Broken", "Shattered","Lost", "Forgotten", "Dark", "Deadly", 
                                                "Harrowing", "Scattered", "Fiendish","Foolish","Beginner",
                                        };
        private String[] StoryLocation = {"Dungeon","Lake","Backyard","Kitchen","Hills","Mountain","Lake","River"
                                        ,"Isle", "Creeperton", "Kingdom", "Island","Eva","Shrimp","Truck"};

        private String[] StoryLocationOf = {"Despair","Hope", "Lost Hope", "Death","Grim","Dawn","Dusk", "Sunrise", "Sunset",
                                            "Crimson","Moon", "Lunar"};

        private String[] StoryItem = { "Dagger","Paper","Towel","Chain","Wand","Pen","Sword","Mace", "Shoulder Pad",
                                        "Spam Musubi","Poke","Ring","Gauntlet","Glove","Scissor","Rock","Bottle"};

        private String[] StoryQuest = {"Gather","Kill","Retrieve","Clear out","Collect","Save","Befriend","Overthrow"
                                        ,"Sneak into"};

        private String[] StoryHeroName = {"Bart","Bob",};

        private String[] StoryVillianName = {"Killigan","Thanatos"};

        private String[] StoryLove = {"Pie","French Fries","Maiden","Lover Boy","Cinnamon Roll","Croissant"};


        public List<String> RandomStory()
        {
            List<String> FairyTale = new List<string>();
            string HeroName = StoryHeroName[rando.Next(0,StoryHeroName.Length)];
            string HeroLoves = StoryLove[rando.Next(0, StoryLove.Length)];
            string HeroItem = StoryItem[rando.Next(0, StoryItem.Length)];

            string Location = StoryPrefix[rando.Next(0, StoryPrefix.Length)] + " " + StoryLocation[rando.Next(0, StoryLocation.Length)] +
                                " of " + StoryLocationOf[rando.Next(0, StoryLocationOf.Length)];

            string Location2 = StoryPrefix[rando.Next(0, StoryPrefix.Length)] + " " + StoryLocation[rando.Next(0, StoryLocation.Length)] +
                        " of " + StoryLocationOf[rando.Next(0, StoryLocationOf.Length)];

            string VillianName = StoryVillianName[rando.Next(0, StoryVillianName.Length)];

            string Conflict = StoryQuest[rando.Next(0, StoryQuest.Length)];

            string storyBeginning = StoryBeginning[rando.Next(0, StoryBeginning.Length)];

            FairyTale.Add(storyBeginning + " the young Hero, " + HeroName + " Felt a sense of danger.");

            FairyTale.Add(HeroName + " walked outside and was transported to " + Location);

            FairyTale.Add(HeroName + " Looked at their hand and surprisingly held a " + HeroItem);
            FairyTale.Add("With the " + HeroItem + ", " + HeroName + " will have to  travel towards " + Location2);
            FairyTale.Add("Where "+HeroName + " will have to "+ Conflict + " the villinaous " + VillianName + ".");
            FairyTale.Add("All the while " + HeroName + " dearly misses their " + HeroLoves); 

            return FairyTale;
        }

        public string RandomizeName(string input)
        {
            String nameOut="";
            if (input.Equals("PreName",StringComparison.InvariantCultureIgnoreCase))
            {
                nameOut = PrefixName[rando.Next(0,PrefixName.Length)];
            }else if (input.Equals("SufName", StringComparison.InvariantCultureIgnoreCase))
            {
                nameOut = SuffixName[rando.Next(0, SuffixName.Length)];
            }
            else if (input.Equals("Genre", StringComparison.InvariantCultureIgnoreCase))
            {
                nameOut = Genres[rando.Next(0, Genres.Length)];
            }
            else if (input.Equals("PreStudio", StringComparison.InvariantCultureIgnoreCase))
            {
                nameOut = PreStudios[rando.Next(0, PreStudios.Length)];
            }
            else if (input.Equals("SufStudio", StringComparison.InvariantCultureIgnoreCase))
            {
                nameOut = SufStudios[rando.Next(0, SufStudios.Length)];
            }
            else if (input.Equals("FirstName", StringComparison.InvariantCultureIgnoreCase))
            {
                nameOut = SufStudios[rando.Next(0, SufStudios.Length)];
            }
            return nameOut;
        }

        public double RandomizePrice()
        {
            int baseprice = rando.Next(2, 8) *10;
            int secondprice = rando.Next(0, 1) * 5; //either 0 or 5
            return (Convert.ToDouble(baseprice+secondprice) + 0.99);
        }

        public DateTime RandomizeDate()
        {
           // DateTime newDate = new DateTime(2016, 3, 15);
            DateTime newDate = new DateTime(rando.Next(2000,2019),rando.Next(1, 12), rando.Next(1, 28));
            return newDate;
        }
        
        public int RandomRating()
        {
            return (rando.Next(1,100));
        }

        public int RandomSold(int ratings)
        {
            return Convert.ToInt32((rando.Next(100, 1000000)) * (Convert.ToDouble(ratings) / 100));
        }

    }
}

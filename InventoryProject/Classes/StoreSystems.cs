using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProject.Classes
{
         
    public class StoreSystems
    {
        internal User loggedUser;
        internal List<Game> InCart;
        internal Game SelectedGame;

        public StoreSystems()
        {
            loggedUser = new User("","","");
            InCart = new List<Game>();
            SelectedGame = new Game("","","","",20,new DateTime(2000,12,12),0,0,0);
        }


    }
}

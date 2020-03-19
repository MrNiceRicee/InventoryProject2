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
         
    internal class StoreSystems
    {
        internal User loggedIn;
        List<Game> InCart;

        public StoreSystems( User parentUser, List<Game> storedGames)
        {
            loggedIn = parentUser;
            InCart = storedGames;
        }


    }
}

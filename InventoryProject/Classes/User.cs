using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProject.Classes
{
    internal class User
    {
        private String iGName;
        private String userName;
        private String password;
        private Double funds;
        public List<Game> gameLibrary = new List<Game>();
        private string seperate = "/,/";


        public string IGName { get => iGName; set => iGName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public double Funds { get => funds; set => funds = Math.Round(value,2); }



        public User(string iGName, string userName, string password)
        {
            IGName = iGName;
            UserName = userName;
            Password = password;
        }

        public string SaveInfo()
        {
            return (this.IGName + seperate +
                this.UserName + seperate +
                this.Password + seperate +
                this.Funds);
        }
    }
}

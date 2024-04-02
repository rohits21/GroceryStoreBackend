using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Classes
{
    public class DataSeeder
    {
        public readonly GroceryStoreDBContext GroceryStoreDBContext;
        public DataSeeder(GroceryStoreDBContext groceryStoreDBContext)
        {
            GroceryStoreDBContext = groceryStoreDBContext;
        }

        public void Seed()
        {

            if (!GroceryStoreDBContext.Admins.Any())
            {
                var admins = new List<Admin>()
                {
                    new Admin()
                    {
                        Name = "admin",
                        Email = "admin@mail.com",
                        Number = "9876328911",
                        Password = "password"
                    },
                    new Admin()
                    {
                        Name = "admin2",
                        Email = "admin2@mail.com",
                        Number = "9876328911",
                        Password = "password"
                    }
                };

                GroceryStoreDBContext.Admins.AddRange(admins);
                GroceryStoreDBContext.SaveChanges();
            }

        }
    }

}

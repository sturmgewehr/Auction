using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Models;

namespace Data_Access_Layer.Initializer
{
    public class DbInitializer : DropCreateDatabaseAlways<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            //---USER 1
            CreditCard cc1 = new CreditCard { CreditCardNumber = 1020 };
            Profile p1 = new Profile { Name = "Jon", Surname = "Snow", PhoneNumber = 1488, Age = 21, CreditCard = cc1 };
            User u1 = new User { Login = "abc123", PropPassword = "qwe123", Profile = p1 };
            //---USER 2
            CreditCard cc2 = new CreditCard { CreditCardNumber = 1111 };
            Profile p2 = new Profile { Name = "Samuel", Surname = "Colt", Age = 44, PhoneNumber = 4570, CreditCard = cc2 };
            User u2 = new User { Login = "sam111", PropPassword = "passwd", Profile = p2 };
            //---USER 3
            CreditCard cc3 = new CreditCard { CreditCardNumber = 777 };
            Profile p3 = new Profile { Name = "Dovakin", Surname = "Skyrimovich", Age = 102, CreditCard = cc3 };
            User u3 = new User { Login = "fusroda", PropPassword = "skyrim", Profile = p3 };

            context.CreditCards.Add(cc1);
            context.CreditCards.Add(cc2);
            context.CreditCards.Add(cc3);
            context.Profiles.Add(p1);
            context.Profiles.Add(p2);
            context.Profiles.Add(p3);
            context.Users.Add(u1);
            context.Users.Add(u2);
            context.Users.Add(u3);

            context.SaveChanges();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Wow.Core.Interfaces;
using Wow.Core.Models;

namespace Wow.Infrastructure.UserAuth
{
    public class EFSqliteUserRepository : IUserRepository
    {
        GameDbContext db = new GameDbContext();


        public User GetPlayerById(Guid id)
        {
            using (db)
            {
                return db.Users.Find(id);
            }

        }


        public void SavePlayer(User user) {


            using (db)
            {
                if (user.UserId == Guid.Empty)
                    db.Users.Add(user);
                db.SaveChanges();
            }

        }


        public User LoadPlayer(string email, string password)
        {
            using (db)
            {
                var user = db.Users.FirstOrDefault(u => u.Email == email);
                if (user.Password == password)
                {
                    if (user != null)
                    {
                       
                        if (user.Password == password)
                        {
                            return user;
                        }
                    }
                }
            }
            return null;
        } 
    }
}

using OnlineForms.Shared.Models;
using System.Linq;

namespace OnlineForms.Server.Services
{
    public class AccountService : IAccountService
    {
        public readonly DataContext Db;

        public AccountService(DataContext db)
        {
            Db = db;
        }

        public int CreateUser(User user)
        {
            if (Db.UserEmails.Where(e => e.Email.ToLower() == user.Email.Email.ToLower()).FirstOrDefault() != null) {
                return 0;
            }

            Db.UserEmails.Add(user.Email);
            Db.SaveChanges();
            var email = Db.UserEmails.Where(e => e.Equals(user.Email)).FirstOrDefault();
            user.Email = email;
            Db.Users.Add(user);
            Db.SaveChanges();
            return 1;
        }

        public int DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            return Db.Users.Find(id);
        }

        public int UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}

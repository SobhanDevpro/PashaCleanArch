using System;
using System.Linq;
using PashaMarket.Data.Context;
using PashaMarket.Domain.Entities.Account;
using PashaMarket.Domain.IRepositories;

namespace PashaMarket.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        #region constructor

        private readonly PashaContext _context;

        public UserRepository(PashaContext context)
        {
            _context = context;
        }

        #endregion

        #region user

        public void AddUser(User user)
        {
            user.CreateDate = DateTime.Now;
            user.LastUpdateDate = user.CreateDate;
            _context.Add(user);
        }

        public void EditUser(User user)
        {
            user.LastUpdateDate = DateTime.Now;
            _context.Users.Update(user);
        }

        public bool IsUserExistsByEmail(string email)
        {
            return _context.Users.Any(s => s.Email == email.ToLower().Trim());
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(s => s.Email == email);
        }

        public User GetUserById(int id)
        {
            return _context.Users.SingleOrDefault(s => s.Id == id);
        }

        public User GetUserByActiveCode(string activeCode)
        {
            return _context.Users.SingleOrDefault(s => s.ActiveCode == activeCode);
        }

        #endregion

        #region save changes

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            user.IsDelete = true;
            EditUser(user);
        }

        public void DeleteUser(int id)
        {
            var user = GetUserById(id);
            if (user != null) DeleteUser(user);
        }

        public void DeletePermanent(User user)
        {
            _context.Remove(user);
        }

        public void DeletePermanent(int id)
        {
            var user = GetUserById(id);
            if (user != null) DeletePermanent(user);
        }

        public IQueryable<User> GetUsers()
        {
            return _context.Users.AsQueryable();
        }

        #endregion
    }
}

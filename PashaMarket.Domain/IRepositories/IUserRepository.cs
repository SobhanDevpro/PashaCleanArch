using System.Linq;
using PashaMarket.Domain.Entities.Account;

namespace PashaMarket.Domain.IRepositories
{
    public interface IUserRepository : ISaveChangesRepository
    {
        #region user

        IQueryable<User> GetUsers();
        void AddUser(User user);
        void EditUser(User user);
        bool IsUserExistsByEmail(string email);
        User GetUserByEmail(string email);
        User GetUserById(int id);
        User GetUserByActiveCode(string activeCode);

        void DeleteUser(User user);
        void DeleteUser(int id);

        void DeletePermanent(User user);
        void DeletePermanent(int id);



        #endregion
    }
}
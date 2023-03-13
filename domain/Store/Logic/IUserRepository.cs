using Store.Models;

namespace Store.Logic;

public interface IUserRepository : IRepository<User>
{
    User? SignIn(string email, string phone);
    User? SignUp(string fullName, string password, DateOnly birthDay, string phone, string email);
    bool SignOut();
    bool IsUserExist(string email);
    User? GetUserByEmail(string email);
    User? GetUserByPhone(string phone);
}
using Store.Models;

namespace Store.Logic;

public interface IUserRepository : IRepository<User>
{
    User? SignIn(string email, string phone);
    User? SignUp(User user);
    bool SignOut();
    bool IsUserExist(string email);
    User? GetUserByEmail(string email);
    User? GetUserByPhone(string phone);
}
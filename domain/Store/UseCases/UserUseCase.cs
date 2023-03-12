using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UseCases
{
    public class UserUseCase
    {
        public Result<User> SignIn(User user)
        {
            return Result.Ok(user);
        }

        public Result<User> SignUp(User user)
        {
            return Result.Ok(user);
        }

        public Result<User> SignOut(User user)
        {
            return Result.Ok(user);
        }

        public Result<bool> IsUserExists(string login)
        {
            return Result.Ok(true);
        }

        public Result<User> GetUserByLogin(User user)
        {
            return Result.Ok(user);
        }
    }
}

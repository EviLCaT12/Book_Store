using Store.Models;
using Store.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UseCases
{
    public class UserUseCase
    {
        private readonly IUserRepository _db;

        public UserUseCase(IUserRepository db)
        {
            _db = db;
        }

        public Result<User> SignIn(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                try
                {
                    var result = _db.GetUserByEmail(email);
                    return result is null ? Result.Fail<User>("No User with such mail") : Result.Ok(result);
                    //ToDo Здесь должен быть токен
                }
                catch (Exception e)
                {
                    return Result.Fail<User>("Error while reading: " + e.Message);
                } 
            }
            else
            {
                return Result.Fail<User>("Email can`t be empty");
            }
        }
        
        
    }
}

using Store;
using System.ComponentModel.DataAnnotations;

namespace Store;
class Test
{
    static void Main(string[] args)
    {
        CreateUser(123, "Pash", "asdfghhj", DateOnly.Parse("12.12.1212"), "791467232-27", "123@mail.com");
    }

    static bool CreateUser(int id, string fullName, string password, DateOnly birthday, string phone, string email)
    {
        User user = new User(id, fullName, password, birthday, phone, email);

        var context = new ValidationContext(user);
        var result = new List<ValidationResult>();

        if (!Validator.TryValidateObject(user, context, result, true))
        {
            Console.WriteLine("Failed to create object User");
            foreach (var error in result)
            {
                Console.WriteLine(error);
            }
            return false;
        }
        else
        {
            Console.WriteLine("Object User created success");

            //Add user to db

            return true;
        }
    }
}


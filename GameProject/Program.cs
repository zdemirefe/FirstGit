using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new UserValidation());
            userManager.Add(new User { FirstName = "Efe", LastName = "Özdemir", ID = 1, NationalId = "12345" });
        }
    }
}

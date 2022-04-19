using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserManager : IUserManager
    {
        IUserValidation userValidation;
        public UserManager(IUserValidation userValidation)
        {
            this.userValidation = userValidation;
        }

        public void Add(User user)
        {
            if(userValidation.Validate(user)==true)
            {
                Console.WriteLine("Doğrulama Başarılı. Kayıt başarılı.");
            }
            else
                Console.WriteLine("Doğrulama Başarısız. Kayıt başarısız");
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kullanıcı güncellendi");
        }
    }
}

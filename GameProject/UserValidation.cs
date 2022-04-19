using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidation : IUserValidation
    {
        public bool Validate(User user)
        {
            if (user.ID==1 && user.FirstName=="Efe" && user.LastName=="Özdemir"&& user.NationalId=="12345")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}

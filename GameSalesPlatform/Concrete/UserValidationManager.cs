using GameSalesPlatform.Abstract;
using GameSalesPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesPlatform.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.FirstName == "User" && user.lastName == "Lastname" && user.NationalityId == 123456)
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

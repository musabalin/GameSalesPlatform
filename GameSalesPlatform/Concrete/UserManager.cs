using GameSalesPlatform.Abstract;
using GameSalesPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesPlatform.Concrete
{
    public class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Create(User user)
        {
            //if (user.NationalityId == 123456)
            //{
            //    Console.WriteLine(user.FirstName + " İsimli Oyuncu kayıt edildi.");
            //}
            //else
            //{
            //    Console.WriteLine("Kayıtlı böyle birisi yoktur");
            //}
            if (_userValidationService.Validate(user)==true)
            {
                Console.WriteLine(user.FirstName + " İsimli Oyuncu kayıt edildi.");
            }
            else
            {
                Console.WriteLine("Kayıtlı böyle birisi yoktur");
            }
        }   


        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public void Uptade(User user)
        {
            throw new NotImplementedException();
        }
    }
}

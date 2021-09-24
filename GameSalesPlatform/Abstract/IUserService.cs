using GameSalesPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesPlatform.Abstract
{
    public interface IUserService
    {
        void Create(User user);
        void Delete(User user);
        void Uptade(User user);
    }
}

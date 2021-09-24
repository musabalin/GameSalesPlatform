using GameSalesPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesPlatform.Abstract
{
    public interface ISalesService
    {
        void Sales(User user, Campaign campaign,Game game);
    }
}

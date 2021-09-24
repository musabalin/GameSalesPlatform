using GameSalesPlatform.Abstract;
using GameSalesPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesPlatform.Concrete
{
    class SalesManager : ISalesService
    {
        public void Sales(User user, Campaign campaign,Game game)
        {
            Console.WriteLine(user.FirstName + " İsimli kullanıcı " + game.GameName + " oyununu almıştır");
            Console.WriteLine(campaign.CampaignName + " Kampanyası uygulanmıştır.");
            Console.WriteLine(game.GamePrice + "-" + campaign.Discount + "=" + (game.GamePrice - campaign.Discount)+"TL");
        }
    }
}

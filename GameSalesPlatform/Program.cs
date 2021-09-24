using GameSalesPlatform.Abstract;
using GameSalesPlatform.Concrete;
using GameSalesPlatform.Entities;
using System;

namespace GameSalesPlatform
{
    class Program
    {
        
        static void Main(string[] args)
        {
            User user1 = new User() { Id = 1, FirstName = "User", lastName = "Lastname", NationalityId = 123456 };
            User user2 = new User() { Id = 2, FirstName = "User2", lastName = "Lastname2", NationalityId = 456789 };
            Game game1 = new Game() { GameName = "Pes 2021", GameId = 1,GamePrice=25 };
            Campaign campaign1 = new Campaign() { CampaignName = "10TL indirim", CampaignId = 1,Discount=10 };
            UserManager userManager = new UserManager();
            userManager.Create(user1);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(user1, campaign1, game1);

       
        }
    }
}

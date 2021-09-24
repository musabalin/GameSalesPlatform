using GameSalesPlatform.Abstract;
using GameSalesPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesPlatform.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void DeleteCampign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya silindi.");
        }

        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya Oluşturuldu.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya Güncellendi.");
        }
    }
}

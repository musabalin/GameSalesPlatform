using GameSalesPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesPlatform.Abstract
{
    public interface ICampaignService
    {
        void NewCampaign(Campaign campaign);
        void DeleteCampign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
    }
}

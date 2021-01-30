using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService

    {
        void ICampaignService.Cadd(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + "Kampanyası eklendi");
        }

        void ICampaignService.Cdelete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + "Kampanyası Silindi");
        }

        void ICampaignService.Cupdate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + "Kampanyası Güncellendi");
        }

        
    }
}

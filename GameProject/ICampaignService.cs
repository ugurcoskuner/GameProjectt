using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Cadd(Campaign campaign);
        void Cdelete(Campaign campaign);
        void Cupdate(Campaign campaign);
    }
}

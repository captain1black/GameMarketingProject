using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketing
{
    class Campaign2 : ICampaigns
    {
        public string CampaignAdd()
        {
            return "Earn-as-you-go campaign";
        }

        public string CampaignDelete()
        {
            return "Our affectionate campaign has expired";
        }

        public string CampaignUpdate()
        {
            return "Continuous login event campaign update";
        }
    }
}

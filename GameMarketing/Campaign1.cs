using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketing
{
    class Campaign1 : ICampaigns
    {
        public string CampaignAdd()
        {
            return  "20% refund for a new game"; 
        }

        public string CampaignDelete()
        {
            return "24 hours in-game reward campaign expired";
        }

        public string CampaignUpdate()
        {
            return "Continuous login event campaign updated";
        }
    }
}

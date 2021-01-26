using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketing
{
    class GameOperationsManager
    {
        public void BuyGame(Game game, Player customer)
        {
            string operations = "1.Campaign1 \n +" + "2.Camaign2";
            Console.WriteLine(operations);

            Console.WriteLine("--------------------");

            Console.WriteLine("Select the action you want to do");

            string operation = Console.ReadLine();

            if (operation.Equals("1"))
            {
                Campaign1 campaign1 = new Campaign1();
                Console.WriteLine(game.Name + " Name game " + customer.FirstName + " Named customers " + campaign1.CampaignAdd());
            }
            else
            {
                Campaign2 campaign2 = new Campaign2();
                Console.WriteLine(game.Name + " Name game " + customer.FirstName + " Named customers " + campaign2.CampaignAdd());
            }

        }

        public void NewCampaignEntry(string newcampaign)
        {
            Console.WriteLine(newcampaign + " Campaign named ");
        }


        public void DeleteCampaign(string campaign)
        {
            Console.WriteLine(campaign + " Campaign named was deleted");
        }


        public void UpdateCampaign(string ncamaign)
        {
            Console.WriteLine(ncamaign + " The campaign named has been update  ");
        }
    }
}

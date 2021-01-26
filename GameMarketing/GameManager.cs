using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketing
{
    class GameManager
    {
        public void Register (Player player)
        {
            Console.WriteLine(player.FirstName +  "  :  Successfully Registered");
        }

        public void InformationUpdate(Player player)
        {
            Console.WriteLine(player + "  :   Update Successfully");
        }

        public void DeRegistration()
        {
            Console.WriteLine("Are you sure you want to delete your registration");
            string cevap = Console.ReadLine();
            if(cevap == "evet")
            {
                Console.WriteLine("Your registration has been successfully deleted");
            }
            else
            {
                Console.WriteLine("Your transaction has been canceled because you did not answer");
            }
        }
    }
}

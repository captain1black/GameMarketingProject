using System;
using System.Collections.Generic;

namespace GameMarketing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            string transactions = "1.creating customers\n" + "2.play operations";
            Console.WriteLine(transactions);
            while (true)
            {
                string selection = Console.ReadLine();

                if (selection.Equals("1"))
                {
                    string customerTypes = "1.Player(individual)" + "2.Shop(corporate)";
                    Console.WriteLine("Please select your customer type");

                    string selection2= Console.ReadLine();
                    if (selection2.Equals("1"))
                    {
                        Player p1 = new Player();
                        p1.FirstName = "Captain";
                        p1.LastName = "Black";
                        p1.DateOfBirth = "2002.3.4";
                        players.Add(p1);
                        Console.WriteLine(p1.FirstName + " : Created a user  ");
                    }

                    if (selection2.Equals("2"))
                    {
                        Shop s1 = new Shop();
                       
                        s1.ShopName = "MyShop";
                        s1.Piece = 1;
                        Console.WriteLine(s1.ShopName + " : Store named was created");

                        
                    }

                }

                if (selection.Equals("2"))
                {
                    Game g1 = new Game();
                    g1.Name = "My game";
                    g1.SizeOfTheGame = "20 GB";
                    g1.Language = "All Languages";
                    g1.Price = "100 Tl";

                    GameOperationsManager gameOperationsManager = new GameOperationsManager();
                    gameOperationsManager.BuyGame(g1, players[0]);
                    Console.WriteLine("----------------------------");

                    gameOperationsManager.NewCampaignEntry("A");
                    gameOperationsManager.UpdateCampaign("B");
                    gameOperationsManager.DeleteCampaign("C");


                }
            }

        }
    }
}

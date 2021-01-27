using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    class GameSalesManager
    {
        public void Sales(Gamer gamer, GameProduct gameProduct)
        {
            Console.WriteLine(gameProduct.Name + ", " + "sold to " + gamer.FirstName + "----Price: " + gameProduct.Price );
        }

        public void SalesWithCampaign(Gamer gamer, GameProduct gameProduct, Campaign campaign)
        {
            int newPrice = gameProduct.Price - campaign.Discount;
            Console.WriteLine(gameProduct.Name + ", " + "sold to " + gamer.FirstName + "----Price: " + newPrice);
        }
    }
}

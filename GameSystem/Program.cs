using System;

namespace GameSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yeni oyuncu tanımlama.
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.TcNo = "1987654123";
            gamer1.FirstName = "Hasan";
            gamer1.LastName = "Baskın";
            gamer1.YearOfBirtday = 1997;

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.TcNo = "1236587964";
            gamer2.FirstName = "Altar";
            gamer2.LastName = "Tunga";
            gamer2.YearOfBirtday = 1071;

            IGamerCheckService gamerCheckService = new EdevketCheckManager();

            //Oyuncuyu sisteme ekleme, silme ve güncelleme
            GamerManager gamerManager = new GamerManager();
            gamerManager.Save(gamer1, gamerCheckService);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer1);

            //--------------------//

            // Oyun Tanımlandı
            GameProduct game1 = new GameProduct();
            game1.Id = 1453;
            game1.Name = "Fetih Oyunu";
            game1.Price = 1500;

            

            //Kampanya Tanımla
            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Kışİndirimi";
            campaign1.Id = 1;
            campaign1.Discount = 30;

            //Kampanya Operasyonları
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign1);

            //Oyun satışı
            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.Sales(gamer1, game1);
            gameSalesManager.SalesWithCampaign(gamer2, game1, campaign1);





        }
    }




}



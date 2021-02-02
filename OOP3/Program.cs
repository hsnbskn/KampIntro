using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bunlar şubedeki arkadaşın ekranı

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();       
            IKrediManager tasitKrediManager = new TasitKrediManager();            
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService); //Burada direk new DatabaseLoggerService() diyebilriiz. Refersn no önemli

            //Ekrandan birden fazla kredi aynı anda seçilirse.
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
                            

        }
    }
}


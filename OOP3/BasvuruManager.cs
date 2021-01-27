using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection - depandency injection 
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvursan bilgilerini değerlendirme.
            //

            //Bu şekilde yaparsam tüm başvuruları konut kredisine yöneltmiş oldum. HATALI BURASI BÖYLE OLMAMALI ÇOOOK ÖNEMLİ !
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //

            krediManager.Hesapla(); //Neye gönderirsem bellekteki onun kredi hesaplması yapar.
            loggerService.Log(); //Sistemde hangi loglayıcı seçilmişse onu logla.
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler) //Listedei her bir kredinin hesaıbın yap.
            {
                kredi.Hesapla();

            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(List<ILoggerService> loggers, IKrediManager krediManager)
        {
            // Başvuran kişinin bilgilerini değerlendirme için bilgi alma alanımız.


            krediManager.Hesapla();

            foreach (var log in loggers)
            {
                log.Log();
                
            }

            
        }

        public void KrediOnBilgilendirmesiYap(List <IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }


       
    }
}

using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();                 //aşağıdaki commenti oku
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();                                             
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService  = new FileLoggerService();
            ILoggerService smsloggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService, fileLoggerService, smsloggerService };
            

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(loggers,ihtiyacKrediManager);
            

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            
        }
    }
}

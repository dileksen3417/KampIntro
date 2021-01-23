using InterfaceAndPolimorfizm;
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

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            //ihtiyacKrediManager1.Hesapla();

            //IKrediManager tasitKrediManager1 = new TasitKrediManager();
            //tasitKrediManager1.Hesapla();

            //IKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager1.Hesapla();

            // demekki interface onu inherit eden classın ref nosunu tutabiliyormuş.

            //*****************************//
            //Banka calısanı hangi kredi tipini secerse onun hesaplasını çalıştıralım;

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            //BasvuruManager basvuruManager = new BasvuruManager();
            //ihtiyac icin;
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //tasit icin;
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //konut icin;
            //basvuruManager.BasvuruYap(konutKrediManager);

            Console.WriteLine("Bir veya birden cok kredi basvurusu için hesaplama yapalım: ");

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.WriteLine("Kredi basvurusu yaparken loglama da yapalım: ");
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,databaseLoggerService);

            //birden fazla loglama yöntemi kullanmak istiyorsam;
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService> {new FileLoggerService(),new DatabaseLoggerService());
        }
    }
}

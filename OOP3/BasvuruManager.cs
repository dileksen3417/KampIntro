using InterfaceAndPolimorfizm;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Böyle tanımlarsam her kredi tipi için 100+ aynı işlemi yapmam lazım yanlıs!
            //KonutKrediManager.konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Bana istediğim kredi tipi için o kredi tipine ait Hesapla() fonksiyonunu cagıracak kod lazım
            //bunu da interface sınıfı sonucta ref no tutabiliyor onu kullanırım ve BasvuruYap imzamı değiştiriyorum.
            ///public void BasvuruYap(IKrediManager krediManager)

            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //banka personeli kac tane kredi secmişse bana krediler'' listesiyle gelir. 
            //listeyi gezip gelen her kredi için hesaplayı cagırmam lazım.
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

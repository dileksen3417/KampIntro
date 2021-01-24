using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> city = new List<string>();
            city.Add("İstanbul");
            //List<> içine ne tür verirsem List'in altındaki tüm operasyonlara da otipte değer yollamak zorundayim.
            //Bu kötü bir kullanım çünkü ben her tip için ayrı bir liste oluşturmak istemiyorum.
            //Bir liste olsun ona istediğim veri tipini int string class vs gönderip aynı işlemleri yaptırabileyim.
            //O zaman kendi listemizi yaratalım!

            MyList<string> city2 = new MyList<string>();
            city2.Add("Dersim");

            MyList<int> city3 = new MyList<int>();
            city3.Add(62);
            city3.Add(34);
            city3.Add(55);

            Console.WriteLine("List için dizi uzunluğunu soralım: " + city.Count);
            Console.WriteLine("MyList için dizi uzunluğunu soralım: " + city3.Count);

        }
    }

    class MyList<T> //Generic class yapmış olduk
    {
        T[] _array; //asıl array
        T[] _tempArray; //gecici array
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array; //mevcuttaki arrayimi ödünc verdim
            _array = new T[_array.Length + 1]; //array için daha geniş bir yer aldım

            //eski datalarımı geri alma zamanı: 
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }
        public int Count //dizi uzunluğunu göndereceğimiz için tipi int
        {
            get { return _array.Length; }   //sadece get var set yok cünkü dizi uzunluğu atamak diye bişey yapılmasını istemm.
        }

    }
}

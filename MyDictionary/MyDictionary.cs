using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1,T2>
    {
        //gercek arraylerim
        T1[] _arrayKey;
        T2[] _arrayValue;

        //gecici arraylerim
        T1[] _tempArrayKey;
        T2[] _tempArrayValue;

        bool check;

        public MyDictionary()
        {
            //gercek arraylerim için bellekte 0 uzunluğunda yer ayırdım.
            _arrayKey = new T1[0];
            _arrayValue = new T2[0];
        }
        public void Add(T1 item1, T2 item2)
        {
            //gercek arraylerime daha uzun yer almadan önce onları saklıyorum
            _tempArrayKey = _arrayKey;
            _tempArrayValue = _arrayValue;

            //gercek arrayime daha uzun bir yer alıyorum
            _arrayKey = new T1[_arrayKey.Length + 1];
            _arrayValue = new T2[_arrayValue.Length + 1];

            //gercek arraylerimin değerlerini geri çekiyorum
            for (int i = 0; i < _tempArrayKey.Length; i++)
            {
                _arrayKey[i] = _tempArrayKey[i];
                _arrayValue[i] = _tempArrayValue[i];
            }

            //Key değeri benzersiz olmalıydı...
            
            for (int i = 0; i < _arrayKey.Length; i++)
            {
                if ((item1.ToString()).Equals(_arrayKey[i].ToString()))
                {
                    check = false;
                    break;
                }
                else check = true;
            }
            
            if (check == true)
            {
                //yeni gelen değerleri arrayime ekliyorum
                _arrayKey[_arrayKey.Length - 1] = item1;
                _arrayValue[_arrayValue.Length - 1] = item2;
                Console.WriteLine("Değerler başarıyla eklendi!");
            }
            else
            {
                Console.WriteLine("Eklemek istediğiniz " + item1 + " değeri Dictionary - Key kısmında mevcuttur. " +
                    "Lütfen benzersiz bir değer giriniz!");
            }

            //basit bir yazdırma
            Console.WriteLine("Deneme : basit bir yazdırma.......");
            for (int i = 0; i < _arrayKey.Length; i++)
            {
                Console.WriteLine("Key: " + _arrayKey[i]);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //ben Mylist'imde T ile calısıcam, yani List<string> gibi. Bu T yerine istedigim seyi yazabilirim; class, string, int, bool vs..
                    //böyle ben ne yapıyorum, MyList'ten bir nesne yaratırsam nesnenin içine koyacağım değişkenlerin tipinin T olması 
                    //gerektiğini mecburi kılıyorum.
    {
        //string[] items = new string[] { }; Böyle dersem yanlış bir dizi tanımı yapmış olurum. 
        //Çünkü benim class'ımın tipi T yani buraya int değeri vs de gelebilir. 

        //*****Doğru şekilde tanımlayalım******
        T[] items; // T tipinde dizi tanımladım fakat new'lemedim yani bellekten yer ayırmadım. 
                   //Bu şekilde kullanmaya çalışırsam OufOfRange hatası alırım cünkü bu dizinin bellekte adreslediği bir yer yok şu an.
                   //Aşağıdaki şekilde CONSTRUCTOR ile yapacağım bu işi;

        public MyList() //constructor //ben bu MyList class'ını bir yerde new'lersem bu kod bloğu başlangıçta otomatik olarak çalışır.
                        //İlgili sınıftan yeni bir obje oluşturulduğunda ilk olarak çalışan fonksiyondur.
                        //Buradaki kullanımda items reference değişken olduğu için new keywordü kullanılmadan items değişkenini kullanamayız 
                        //null reference hatası alırız çünkü ramde bir adresi yoktur. 
                        //Bu yüzden sınıftan yeni bir obje oluşturulduğu ilk anda ramde bir yer verdik.
        {
            items = new T[0]; //newledim ve array'i 0 elemanlı olarak verdim. Çünkü arrayler ilk yaratıldığında eleman sayısı 0'dır. Boş array.

        }
        public void Add(T item) // ben sana T olarak ne verirsem, istediğim elemanın türü de O'dur. Yani MYList<T> demiştim, burda da o T'ye ne dersen
                                // buraya da o T değerinden gönder diyorum.
                                //MyList<string> isimler = new MyList<string>(); diye yaratırsam  benim T = string olmus olur. Yani orayı açık bırakıyorum.
                                //string yerine class int vs de verebilirdim.
        {
            T[] tempArray = items; //tempArray(geçiçi dizi) yani geçiçi dizinin referansı = items yani şu anki dizimin referansı olarak atadım yani al sen bu adresi tut dedim.
            items = new T[items.Length + 1]; // array'e yeni eleman ekleyeceğim için arrayin o anki eleman sayısını get yapıyorum ve ona +1 ekleyip newliyorum.
                                             // fakat sadece bu satırı yazarsam newlediğim için mecvuttaki referans numarasını kaybediyorum. 
                                             // bu yüzden array eziliyordu. Bu yüzden su anki referans numaramı birine tutturmam lazım. o da bir önceki satır(tempArray).

            // buraya kadar ilk önce su anki referansımı birine tutturdum, diziyi genişletmek için daha geniş bir referans aldım.
            //Şimdi dicem ki sana emanet olarak verdiğim elemanları bana geri ver.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //tempArray'e emanet verdigim degerleri sırasıyla itemsa geri alıyorum.
            }

            items[items.Length - 1] = item; //items.Length: items dizisinin eleman sayısını verir=6(dilek(0),güney(1),altug(2),umut(3),filiz(4),-bosYer-(5)
                                            //items.Length-1 dersem items dizinin son elemanını almıs olurum cünkü dizide index 0'dan başlar.
                                            //methoda gelen item elemanını dizinin son elemanına(bosYer) ekliyorum.
        }
    }
}

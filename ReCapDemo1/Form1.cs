using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //form uygulaması çalıştırıldığı anda çalışmasını istedigim kodlar
        {
            //for döngüsüyle direkt 64 tane button ekleyebilirdim ama bunlara ulasamazdım hepsi üst üste olurdu bu yüzden
            //aynı tip nesneden elimde birsürü varsa ne kullanmalıyım? Dizi!
            Button[,] buttons = new Button[8,8]; //Button sınıfından 8 x 8 lik (dama) toplam 64 tane buton oluşturdum. 
                                                 //Bu şekilde yaparsam [0][3] butonu diyerek cok rahat elemanlara ulasabilirim

            // her buton ayrı noktada olmak zorunda. Formun en sol köşesi 0'dır. aşağıdaki değişkenleri yaratarak her yeni buton ekledikten sonra
            // onu ekranda biraz kaydırıcaz
            int top = 0; //en köşe yükseklik   |"
            int left = 0;//en soldan genişlik  |--

            //her satır için 8 tane buton koyucaz.
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //0. boyut için en buyuk alabilecegi değeri ceker yani 7
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)//yani ilk i değeri için 0. satırın 0. sütünü, 0. satırın 1. sutunu diye gider
                {
                    buttons[i, j] = new Button(); // her buton bizim için yeni bir nesne, bunları yaratmam lazım
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50; //bir sonraki butonu biraz daha yana kaydırmak için değerini artırıyorum.

                    //damanın renklerini ayarlıyalım
                    if ((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    this.Controls.Add(buttons[i, j]); // butonu ekrana koy demek
                }
                top += 50; // her satır(j döngüsü) bittiğinde bir alt satıra geçsin 
                left = 0; // her satır bittiğinde en başa dönsün
            }
        }
    }
}

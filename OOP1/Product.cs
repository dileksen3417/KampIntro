using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Özellikleri olan sınıflara Entity(özellik) denir böyle adlandırılır. Ve bu sınıflara sadece
                    // özellikler yazılır.
    {
        public int Id { get; set; } //Primary Key
        public int CategoryId { get; set; } //Foreign Key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}

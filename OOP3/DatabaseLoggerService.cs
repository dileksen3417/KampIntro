using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndPolimorfizm
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı !");
        }
    }

}

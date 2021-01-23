using System;

namespace InterfaceAndPolimorfizm
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı :) ");
        }
    }


}

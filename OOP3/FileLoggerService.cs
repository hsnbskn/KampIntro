using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService   //Sen aslında ILoggerService alternatifisin.
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı !");
        }

    }
}

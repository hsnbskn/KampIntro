using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

    //şablonum loglama yapmak ama nasıl yapacağımı diğerleriyle belirleyeceğim. fileloggerservive ve databaseloggerservice
    //sadece imza olur için dolu olamaz !

    interface ILoggerService  
    {
        void Log();
    }
}



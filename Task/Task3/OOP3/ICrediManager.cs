using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICrediManager
    {
       //referans tutsun ,operasyonları tutsun ,şablon
       // birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır
       //loglama: kim,ne zamn, hangi operasyonu çağırdı- sms,mail,veritabanına yazım 
        void Hesapla();
        void BiSeyYap();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //kuralları içeren kısım
        //interface içinde olan kısımları diğer kredilerin içinde olması gerekiyor
        void Hesapla();
        void BiseyYap();
    }
}

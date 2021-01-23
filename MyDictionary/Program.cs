using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Recep");
            isimler.Add("Doğukan");
            isimler.Add("Naz");
            isimler.Add("Ahmet");
        }
    }
}

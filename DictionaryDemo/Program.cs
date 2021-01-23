using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1,"Recep");
            dictionary.Add(2,"Ahmet");
            dictionary.Add(3, "Doğukan");
            Console.WriteLine(dictionary.Count);

            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary.Key(i) + " : " + dictionary.Value(i));
            }

            dictionary.Add(3, "Hasan");
            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary.Key(i) + " : " + dictionary.Value(i));
            }
        }
    }
}

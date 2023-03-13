using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary obj1 = new Dictionary();
            obj1.AddWord("cat", "Кот/кошка");
            obj1.Print();
            Console.WriteLine(obj1.GetEnglishTranslate("cat"));
            Console.WriteLine(obj1.GetRussianTranslate("Кот/кошка"));
            Console.ReadKey();
        }
    }
}

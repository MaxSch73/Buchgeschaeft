using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Item> list = new List<Item>();
            Book Buch = new Book(1.99m, 10, "Harry Potter","JKR","1234", Category.Fantasy);
            Newspaper Zeitung = new Newspaper(2.99m, 20,"Krone", new DateTime(2021, 01, 19));
            Audiobook Audio = new Audiobook(3.99m, 30, "Tomturbo", "Thomas Brezina", "5678",23, Category.Chiildren);
            list.Add(Buch);
            list.Add(Zeitung);
            list.Add(Audio);

            

            Console.WriteLine(Buch.ToString());
            Console.WriteLine(Zeitung.ToString());
            Console.WriteLine(Audio.ToString());
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Индивидуальное_задание_2
{
    public class Book
    {
        private string title;
        private string autor;
        private int year;

        public Book() { }
        public void GetDescription(string t, string au, int y)
        {
            Console.WriteLine("Это книга {0}, написанная {1} в {2}", t, au, y);
        }
        public void GetDescription(string t, string au)
        {
            Console.WriteLine("Это книга {0}, написанная{1}", t, t);
        }
        public void GetDescription(string t)
        {
            Console.WriteLine("Это книга с названием: {0}", t);
        }
        public void GetDescription()
        { 
            Console.WriteLine("Это книга");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            book.GetDescription();
            book.GetDescription("Война и мир");
            book.GetDescription("Война и мир", "Лев Толстой");
            book.GetDescription("Война и мир", "Лев Толстой", 1869);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_3
{
    public class Zakaz
    {
        private string fam;
        private int size;
        private string comfort;

        public Zakaz(string fm, int sz, string cmf) {
        fam  = fm; size = sz; comfort = cmf;}
        public Zakaz(string fm, int sz)
        {
            fam = fm; size = sz;comfort = "стандарт";
        }
        public Zakaz(string fm)
        {
            fam = fm; size = 3; comfort = "стандарт";
        }
        public Zakaz()
        {
            fam = "неизвестный"; size = 3; comfort = "стандарт";
        }
        public void Show()
        {
            Console.WriteLine("{0} забронировал {1} местный номер класса {2}", 
                fam, size, comfort);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Zakaz z1 = new Zakaz("Иванов", 1, "Люкс");
            z1.Show();
            Zakaz z2 = new Zakaz("Петров", 2);
            z2.Show();
            Zakaz z3 = new Zakaz("Сидоров");
            z3.Show();
            Zakaz z4 = new Zakaz();
            z4.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛабР_8_ДубининР
{
    class Build
    {
        public string name;
        public double area;
        public int kvo;
        public int floor;

        public Build() { }
        public Build( string nm, double ar, int k, int fl)
        {
            this.name = nm; this.area = ar; this.kvo = k;
            this.floor = fl;
         }

        public void ShowInfo()
        {
            Console.WriteLine("В доме {0} площадью {1} на {2} этажейц живет {3} чел, на че ловека {3:f2}", 
                name, area,floor, kvo, area/kvo);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Build dom1 = new Build();
            dom1.name = "Дача"; dom1.area = 30; dom1.kvo = 4; dom1.floor = 1;
            dom1.ShowInfo(); 
            Build dom2 = new Build("Котедж", 80, 6, 2);
            dom2.ShowInfo();
        }
    }
}

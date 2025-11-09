using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Индивидульное_задание
{
    public class Employee
    {
        public string name;
        public string surname;
        public string jobTitle;
        public string startDate;

        public Employee() { }
        public Employee(string n, string sn, string jT, string sD)
        {
            this.name = n;
            this.surname = sn;
            this.jobTitle = jT;
            this.startDate = sD;
        }
        public void ShowInfo()
        {
            Console.WriteLine("{0} {1} занимает должность {2}, начал работать {3}",
                name, surname, jobTitle, startDate);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee worker1 = new Employee("Артем", "Тимошенко", "Руководитель отдела", "29 октября 2020");
            worker1.ShowInfo();
        }
    }
}

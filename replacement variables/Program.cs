using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replacement_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Иванов";
            string surname = "Иван";
            Console.WriteLine("Имя: " + name + ", фамилия: " + surname);
            string temporaryValue = name;
            name = surname;
            surname = temporaryValue;
            Console.WriteLine("Имя: " + name + ", фамилия: " + surname);
            Console.ReadKey();
        }
    }
}

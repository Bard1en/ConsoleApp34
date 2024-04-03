using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class bil
    {
        public string  märke;
        public string modell;
        public int årsmodell;
        public string färg;
        public int mil;
        public void metod1()
        {
            Console.WriteLine("Skriv in ditt bilmärke:");
            car.märke = Console.ReadLine();
            Console.WriteLine("Skriv in din bilmodell:");
            car.modell = Console.ReadLine();
            Console.WriteLine("Skriv in bilens årsmodell:");
            car.årsmodell = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in bilens färg:");
            car.färg = Console.ReadLine();
            Console.WriteLine("Skriv in bilens miltal:");
            car.mil = int.Parse(Console.ReadLine());
        }
        public void metod2()
        {
            Console.WriteLine(car.märke);
            Console.WriteLine(car.modell);
            Console.WriteLine(car.årsmodell);
            Console.WriteLine(car.färg);
            Console.WriteLine(car.mil);
        }
    }

}

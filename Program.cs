using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            double R1, R2, R3, R;
            Console.Write("Введите первое сопротивление: ");
            R1 =Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе сопротивление: ");
            R2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье сопротивление: ");
            R3 = Convert.ToDouble(Console.ReadLine());
            R = (R1*R2*R3)/(R2*R3+R1*R3+R1*R2); //Выводим из формулы параллельного соединения
            Console.Write("Общее сопротивление: {0}", R);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            Console.WriteLine("Введите значение первого элемента массива: ");
            numbers[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Первый элемент массива: " + numbers[0]);
            Console.ReadKey();
        }
    }
}

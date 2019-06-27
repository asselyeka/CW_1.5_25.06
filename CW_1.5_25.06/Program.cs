using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 5.	Дано двузначное число. Найти:
a.	число десятков в нем;
b.	число единиц в нем;
c.	сумму его цифр;
d.	произведение его цифр*/
namespace CW_1._5_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Введите двузначное число:");
            string textAsNum = Console.ReadLine();
            num = int.Parse(textAsNum);

            Console.Write("a.	число десятков в нем: ");
            Console.WriteLine(num/10);

            Console.Write("b.	число единиц в нем: ");
            Console.WriteLine(num % 10);

            Console.Write("c.	сумму его цифр: ");
            Console.WriteLine((num / 10) + (num % 10));

            Console.Write("d.	произведение его цифр: ");
            Console.WriteLine((num / 10) * (num % 10));

            Console.ReadKey();
        }
    }
}

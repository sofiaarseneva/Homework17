using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обобщенные типы - моделирование счета\n\n");
            try
            {
                Console.WriteLine("Тип номера счета - число!");
                Account<int> accountInt = new Account<int>();
                accountInt.setInfo();
                Console.WriteLine(accountInt.getInfo());
                Console.WriteLine("\nТип номера счета - строка!");
                Account<string> accountStr = new Account<string>();
                accountStr.setInfo();
                Console.WriteLine(accountStr.getInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!" + ex.Message);
            }
            Console.ReadKey();
        }
    }
}

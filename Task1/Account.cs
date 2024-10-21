using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Account<T>
    {
        T Num { get; set; }
        string Fio { get; set; }
        double Balance { get; set; }

        public void setInfo()
        {
            Console.WriteLine("Введите номер счета:");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО владельца:");
            Fio = Console.ReadLine();
            Console.WriteLine("Введите баланс счета:");
            Balance = Convert.ToDouble(Console.ReadLine());
        }

        public string getInfo()
        {
            return $"\nНомер счета - {Num}.\nФИО владельца - {Fio}.\nБаланс счета - {Balance}.";
        }
    }
}

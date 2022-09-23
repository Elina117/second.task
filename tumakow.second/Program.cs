using System;
using System.Reflection.Emit;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace tumakow.second
{
    class Program
    {
        enum schet
        {
            Сберегательный,
            Текущий
        }

        struct bank
        {
            public int number;
            public string type;
            public int balance;

            public void Print()
            {
                Console.WriteLine($"номер: {number}\nтип: {type}\nбаланс: {balance}");
            }
        }
        struct work
        {
            public string name;
            public string uni;

            public void Print()
            {
                Console.WriteLine($"имя: {name}\nвуз: {uni}");
            }
        }

        enum vuz
        {
            KGU,
            KAI,
            KHTI,
            UGATU
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            foreach (schet credit in Enum.GetValues(typeof(schet)))
            {
                Console.WriteLine($"Кредит - {0}, Номер - {1}", credit, (int)credit);
                Console.ReadKey();
            }

            Console.Write("Task 2\n");
            bank ban = new bank();
            ban.number = 022;
            ban.type = "savings";
            ban.balance = 2;

            ban.Print();
            Console.ReadKey();

            Console.Write("Task 3\n");
            work worker = new work();
            worker.name = "Elina";
            string un = Convert.ToString(vuz.UGATU);
            worker.uni = un;

            worker.Print();
            Console.ReadKey();




        }







    }
}

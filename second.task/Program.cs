using System;
using System.Reflection.Emit;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace second.task
{
    class Program
    {

        struct student
        {
            public string name;
            public string secondname;
            public int ind;
            public string data;
            public string alkocat;
            public double litr;

            public void Print()
            {
                Console.WriteLine($"имя = {name}\nфамилия = {secondname}\nидентификатор = {ind}\nдата рождения = {data}\nкатегория алкоголизма = {alkocat}\nобЬем выпитого = {litr}");
            }

        }

        struct user
        {
            public string name;
            public string town;
            public int age;
            public int pin;

            public void Print()
            {
                Console.WriteLine($"имя - {name}\nгород - {town}\nвозраст - {age}\nPin - {pin}");
            }

        }





        static void Main(string[] args)
        {
            //Console.WriteLine("Task 1");
            //student std1 = new student();
            //std1.name = "Petya";
            //std1.secondname = "Pupkin";
            //std1.ind = 1;
            //std1.data = "10.10.2002";
            //std1.alkocat = "a";
            //std1.litr = 2;
            //std1.Print();

            //student std2 = new student();
            //std2.name = "Nastya";
            //std2.secondname = "Stashkevich";
            //std2.ind = 12;
            //std2.data = "16.06.2005";
            //std2.alkocat = "b";
            //std2.litr = 4;
            //std2.Print();

            //student std3 = new student();
            //std3.name = "Maksim";
            //std3.secondname = "Vasiliev";
            //std3.ind = 123;
            //std3.data = "30.02.2002";
            //std3.alkocat = "c";
            //std3.litr = 6;
            //std3.Print();

            //student std4 = new student();
            //std4.name = "Gleb";
            //std4.secondname = "Matveev";
            //std4.ind = 1234;
            //std4.data = "08.06.2004";
            //std4.alkocat = "c";
            //std4.litr = 8;
            //std4.Print();

            //student std5 = new student();
            //std5.name = "Dasha";
            //std5.secondname = "Tretyakova";
            //std5.ind = 1234;
            //std5.data = "07.09.2003";
            //std5.alkocat = "d";
            //std5.litr = 2;
            //std5.Print();

            //double common = std1.litr + std2.litr + std3.litr + std4.litr + std5.litr;

            //double perc1 = Math.Round(std1.litr / 100 * common, 1);
            //double perc2 = Math.Round(std2.litr / 100 * common, 1);
            //double perc3 = Math.Round(std3.litr / 100 * common, 1);
            //double perc4 = Math.Round(std4.litr / 100 * common, 1);
            //double perc5 = Math.Round(std5.litr / 100 * common, 1);

            //Console.WriteLine($"Всего было выпито {common} литров" + "\n" +
            //    $"{std1.name} - {perc1}" + "\n" +
            //    $"{std2.name} - {perc2}" + "\n" +
            //    $"{std3.name} - {perc3}" + "\n" +
            //    $"{std4.name} - {perc4}" + "\n" +
            //    $"{std5.name} - {perc5}");




            //Console.WriteLine("Task 2");
            //Console.WriteLine($"sbyte: {sbyte.MinValue} ... {sbyte.MaxValue}");
            //Console.WriteLine($"byte: {byte.MinValue} ... {byte.MaxValue}");
            //Console.WriteLine($"short: {short.MinValue} ... {short.MaxValue}");
            //Console.WriteLine($"ushort: {ushort.MinValue} ... {ushort.MaxValue}");
            //Console.WriteLine($"int: {int.MinValue} ... {int.MaxValue}");
            //Console.WriteLine($"uint: {uint.MinValue} ... {uint.MaxValue}");
            //Console.WriteLine($"long: {long.MinValue} ... {long.MaxValue}");
            //Console.WriteLine($"ulong: {ulong.MinValue} ... {ulong.MaxValue}");
            //Console.WriteLine($"char: U+000 ... U+ffff");
            //Console.WriteLine($"float: {float.MinValue} ... {float.MaxValue}");
            //Console.WriteLine($"double: {double.MinValue} ... {double.MaxValue}");
            //Console.WriteLine("bool: true ... false");
            //Console.WriteLine($"decimal: {decimal.MinValue} ... {decimal.MaxValue}");
            //Console.WriteLine("string: неогрaниченно");
            //Console.WriteLine("object: Все, вышеперечисленное");



            //Console.WriteLine("Task 3");
            //user polzovatel = new user();
            //Console.WriteLine("Введите имя");
            //polzovatel.name = Console.ReadLine();
            //Console.WriteLine("Введите город");
            //polzovatel.town = Console.ReadLine();
            //Console.WriteLine("Введите возраст");
            //polzovatel.age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите PIN");
            //polzovatel.pin = int.Parse(Console.ReadLine());

            //polzovatel.Print();


            //Console.WriteLine("Task 4");
            //string[] fio = Console.ReadLine().Split(' ');
            //Console.WriteLine($"{fio[0][0].ToString().ToUpper()}.{fio[1][0].ToString().ToUpper()}");


            //Console.WriteLine("Task 5");
            //int otpusk = 0;
            //int sale = 0;
            //int price = 0;

            //Console.Write("Введите сумму отпускных денег дважды: ");
            //if (int.TryParse(Console.ReadLine(), out otpusk) == true)
            //{
            //    otpusk = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Введите стоимость бутылки виски дважды: ");
            //if (int.TryParse(Console.ReadLine(), out price) == true)
            //{
            //    price = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Введите сумму скидки для одной бутылки дважды: ");
            //if (int.TryParse(Console.ReadLine(), out sale) == true)
            //{
            //    sale = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"Нужно купить: {otpusk / (price*sale/100)}");



            //Console.WriteLine("Task 6");
            //Console.Write("Введите скорость таракана км/ч: ");
            //int kmch = int.Parse(Console.ReadLine());
            //int smsec = ((kmch * 1000 * 100) / (60 * 60));
            //Console.WriteLine(smsec);

            Console.WriteLine("Task 7");
            Console.Write("Введите строку: ");
            string str1 = Console.ReadLine();
            StringBuilder str2 = new StringBuilder();
            foreach (Char i in str1.ToCharArray())
            {
                if (Char.IsLower(i))
                {
                    str2.Append(Char.ToUpper(i));
                }
                else
                {
                    str2.Append(Char.ToLower(i));
                }
            }
                Console.WriteLine(str2);
        }


    }


    
}



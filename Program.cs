//***********************************************************
//* Практическая работа № 6                                 *
//* Выполнил: Кузин. Я. Н., группа 2ИСПд                    *
//* Задание: составить программу работы линейного алгоритма *
//***********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pr_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, t, m, k; // ввод переменных
            Console.WriteLine("Магазин");
            Console.Write("Здравствуйте!");
            Console.Write("\nЗаплатите за мороженое = "); // Ввод данных
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Заплатите за лимонад  = ");
            t = Int32.Parse(Console.ReadLine());
            switch(n)
                {
                case 1:
                    Console.WriteLine("Вы заплатили за мороженное, стоимость мороженного: 15 руб. \n");
                    n = 15;
                    break;
                case 2: Console.WriteLine("Вы заплатили за лимонад, стоимость лимонада: 20 руб. \n");
                    t = 20;
                    break;
                    Console.Write("Сколько стаканчиков мороженного?: ");
                    m = Int32.Parse(Console.ReadLine());
                    Console.Write("Сколько бутылок лимоанада?: ");
                    k = Int32.Parse(Console.ReadLine());
                    int sum1 = n * m, sum2 = t * k;
                    switch (sum1 >= 15)
                    {
                        case true:
                            Console.WriteLine("Спасибо за покупку");
                            break;
                            switch (sum2 >= 20)
                            {
                                case true:
                                    Console.WriteLine("Спасибо за покупку");

                            }
                    }
                    

        }
            Console.ReadKey();


        }
    }
}

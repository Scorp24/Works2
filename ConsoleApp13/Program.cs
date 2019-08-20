using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1
             * 
            int a = 4;
            int b = 6;
            int c = 8;

            Console.WriteLine("  {0}  {1}  {2}", a, b, c);
            Console.ReadLine();

            *2
            * 
            int a = 5;
            int b = 10;
            int c = 21;

            Console.WriteLine("{0}\n{1}\n{2}", a, b, c);
            Console.ReadLine();

            *3
            * 
            int sm = 800;
            int m = sm / 100;

            Console.WriteLine(m);

            Console.ReadLine();

            *4
            * 
            int day = 234;
            int week = day / 7;

            Console.WriteLine("Прошло недель: {0}", week);

            Console.ReadLine();
            
            *5
            *
            int number = 16;
            int ten = number / 10;
            int sum = number;

            Console.WriteLine("Десятки в нем: {0}\nСумма цифр: {1}", ten, sum);
            Console.ReadLine();

            *6
            * 
            bool a = true;
            bool b = false;
            bool c = false;

            Console.WriteLine("  {0}  {1}  {2}", a, b, c);
            
            *7
            * 
            int Curcle = (180 / 3) * 4;
            int kvadrat = 110 / 2;

            if (Curcle > kvadrat)
            {
                Console.WriteLine("Больше значение круга !");
            }
            else if (Curcle < kvadrat)
            {
                Console.WriteLine("Больше значение квадрата !");
            }
            Console.ReadLine();
             
            *8
            * 

            int MassaDesk = 12;
            int ObiemDesk = 13;
            int SquareDesk = MassaDesk + ObiemDesk;
            int MassaChair = 16;
            int ObiemChair = 15;
            int SquareChair = MassaChair + ObiemChair;

            if (SquareDesk > SquareChair)
            {
                Console.WriteLine("Больше площадь доски !");
            }
            else if (SquareDesk < SquareChair)
            {
                Console.WriteLine("Больше площадь стула !");
            }
            Console.ReadLine();

            *9
            * 
            
             int URed = 13; //напряженине
            int RRed = 4; //сопротивление
            int SquareIRed = URed / RRed;
            int UBlue = 14;//напряженине
            int RBlue = 6;//сопротивление
            int SquareIBlue = UBlue / RBlue;

            if (SquareIRed > SquareIBlue)
            {
                Console.WriteLine("По синему !");
            }
            else if (SquareIRed < SquareIBlue)
            {
                Console.WriteLine("По красному !");
            }
            Console.ReadLine();
             */

            //int number = 20;
            //int kvadrat = 10;
            //int pow = 50;
            //int numbers;
            Console.WriteLine("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            //for (int i = 20; i < 36; i++)
            //{
            //  Console.WriteLine(i);
            //}

            //for (int i = 10; i < b; i++)
            //{
            //Console.WriteLine(i*i);
            //}

            //for (int i = a; i < 50; i++)
            //{
            //   Console.WriteLine(a * a * a);
            //}

            //for (int i = a; i < b; i++)
            //{
            // Console.WriteLine(i);
            //}

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ол
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
                Console.WriteLine("Введите значение первого х:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение второго х:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение эпсилы (Если оно меньше 1, вводить рекомендуется через знак точки, например 0.1):");
                int epsila = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Значение Х методом половинного деления = {PolovinoeDelenie(a, b)} \n");
                Console.WriteLine($"Значение Х методом хорд = {MetodHord(a, b, epsila)}\n");
                Console.ReadKey();
            }
            static public int PolovinoeDelenie(int a, int b)
            {
                int x = 0;
                x = (a + b) / 2;
                double epsila = 0.001;
                while (b - a > epsila)
                {
                    x = (a + b) / 2;
                    if (FuncziaA(a, b) * FuncziaX(x, a, b) > 0)
                    {
                        a = x;
                    }
                    else
                    {
                        b = x;
                    }

                }

                return x;
            }
            static public int MetodHord(int a, int b, int epsila)
            {
                int x = 0;
                x = a - ((FuncziaA(a, b) / FuncziaB(b, a) - FuncziaA(a, b)) * (b - a));

                while (FuncziaX(x, a, b) < epsila)
                {
                    x = a - ((FuncziaA(a, b) / FuncziaB(b, a) - FuncziaA(a, b)) * (b - a));
                    if (FuncziaA(a, b) * FuncziaX(x, a, b) > 0)
                    {
                        a = x;
                    }
                    else
                    {
                        b = x;
                    }

                }

                return x;
            }
            static public int FuncziaA(int a, int b)
            {
                a = 0;
                return a;
            }
            static public int FuncziaB(int b, int a)
            {

                return b;
            }
            static public int FuncziaX(int x, int a, int b)
            {

                return x;
            }

        }
    }


    


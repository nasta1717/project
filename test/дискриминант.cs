using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a: ");
            string sta = Console.ReadLine();
            double a = Convert.ToInt32(sta);
            if (a == 0)
            {
                Console.WriteLine("Значение а не может быть равно 0");
            }
            else
            {
                Console.WriteLine("Введите значение b: ");
                string stb = Console.ReadLine();
                double b = Convert.ToInt32(stb);
                if (b == 0)
                {
                    Console.WriteLine("Значение b не может быть равно 0");
                }
                else
                {
                    Console.WriteLine("Введите значение c: ");
                    string stc = Console.ReadLine();
                    double c = Convert.ToInt32(stc);
                    if (c == 0)
                    {
                        Console.WriteLine("Значение c не может быть равно 0");
                    }
                    else
                    {
                        double dis = 0;
                        dis = ((Math.Pow(b, 2)) - (4 * a * c));

                        Console.WriteLine(dis);

                        if (dis > 0)
                        {
                            double x1 = ((-1 * b) - Math.Sqrt(dis)) / (2 * a);
                            double x2 = ((-1 * b) + Math.Sqrt(dis)) / (2 * a);
                            Console.WriteLine(x1);
                            Console.WriteLine(x2);

                        }
                        else
                        {
                            if (dis == 0)
                            {
                                double x1 = -b / (2 * a);
                                double x2 = -b / (2 * a);
                                Console.WriteLine(x1);
                                Console.WriteLine(x2);

                            }
                            else
                            {
                                if (dis < 0)
                                {
                                    Console.WriteLine("Нет ироцирнаотных корней, есть действительные корни");

                                }
                                else
                                {

                                    dis = -dis;
                                    double x1 = Math.Sqrt(dis) / (2 * a);
                                    double x2 = -Math.Sqrt(dis) / (2 * a);
                                    Console.WriteLine(x1 + " * i ");
                                    Console.WriteLine(x2 + " * i ");

                                }
                            }

                        }

                    }
                }
                Console.ReadKey();
            }
        }

    }
}
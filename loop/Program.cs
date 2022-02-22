using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Task 151
                       Console.WriteLine("Please entre the number...");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    sum += i;
                }

            }
            Console.WriteLine(sum);


            //Task 152
            Console.WriteLine("Please entre the number...");
            int b = int.Parse(Console.ReadLine());
            int multipal = 1;
            for (int i = 1; i < b; i++)
            {
                if (b % i == 0)
                {
                    multipal *= i;
                }

            }
            Console.WriteLine(multipal);



            //Task 153
            Console.WriteLine("Please entre the number...");
            int c = int.Parse(Console.ReadLine());
            int sum1 = 0;
            for (int i = 1; i < c; i++)
            {
                if (c % i == 2)
                {
                    sum1 += i;
                }

            }
            Console.WriteLine(sum1);

            //Task 154
            Console.WriteLine("Please entre the number...");
            int d = int.Parse(Console.ReadLine());
            int multipal1 = 1;
            for (int i = 1; i < d; i++)
            {
                if (d % i == 3)
                {
                    multipal1 *= i;
                }

            }
            Console.WriteLine(multipal1);



            //Task 155
            int sum2 = 0;
            for (int i = 10; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum2 += i;
                }
            }
            Console.WriteLine(sum2);

            //Task 156
            long mult = 1;
            for (int i = 10; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    mult *= i;
                }
            }
            Console.WriteLine(mult);

            //Task 157
            int sum3 = 0;
            for (int i = 100; i < 1000; i++)
            {
                if (i % 5 != 0)
                {
                    sum3 += i;
                }
            }
            Console.WriteLine(sum3);

            //Task 158
            long mult1 = 1;
            for (int i = 100; i < 1000; i++)
            {
                if (i % 2 != 0 && i % 3 != 0)
                {
                    mult1 *= i;
                }
            }
            Console.WriteLine(mult1);

            //Task 159

            int mult2 = 1;
            for (int i = 100; i < 1000; i++)
            {
                if (i % 3 == 1 && i % 4 == 2)
                {
                    mult2 *= i;
                }
            }
            Console.WriteLine(mult2);

            //Task 160
            int mult3;
            for (int i = 100; i < 1000; i++)
            {
                mult3 = i * 16;
                if (Math.Sqrt(mult3) % 1 == 0)
                {
                    Console.WriteLine(mult3);
                    break;
                }

            }
            //Task 161
            int mult4;
            for (int i = 1000; i < 10000; i++)
            {
                mult4 = i * 26;
                if (Math.Sqrt(mult4) % 1 == 0)
                {
                    Console.WriteLine(mult4);
                    break;
                }

            }
            //Task 162
            int mult5;
            for (int i = 10000; i > 999; i--)
            {
                mult5 = i * 14;
                if (Math.Sqrt(mult5) % 1 == 0)
                {
                    Console.WriteLine(mult5);
                    break;
                }

            }
            //Task 163

            int mult7;
            for (int i = 10000; i > 999; i--)
            {
                mult7 = i * 18;
                if (Math.Sqrt(mult7) % 1 == 0)
                {
                    Console.WriteLine(mult7);
                    break;
                }

            }

            //Task 164
            Console.WriteLine("Please entre the number...");
            int f = int.Parse(Console.ReadLine());

            for (int i = 100; i < 1000; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    if (Math.Sqrt(i) > f)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }

            //Task 165
            Console.WriteLine("Please entre the number...");
            int g = int.Parse(Console.ReadLine());
            if (g == 3 || g == 9)
            {
                Console.WriteLine("true");
            }
            else if (g % 3 == 0 && g % 9 == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            //Task 166
            Console.WriteLine("Please entre the number...");
            int h = int.Parse(Console.ReadLine());
            int y;
            if (h == 4 || h == 16)
            {
                y = 1;
                Console.WriteLine("y=" + y);
            }
            else if (h % 4 == 0 && h % 16 == 0)
            {
                y = 1;
                Console.WriteLine("y=" + y);
            }
            else
            {
                y = 0;
                Console.WriteLine("y=" + y);
            }

            //Task 191

            Console.WriteLine("Please entre the number...");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please entre the power...");
            int x = int.Parse(Console.ReadLine());
            double mult8; double sum10 = 0;
            for (int i = 0; i <= x; i++)
            {
                mult8 = Math.Pow(N, i);
                sum10 = sum10 + mult8;

            }
            Console.WriteLine(sum10);

            //Task 192
            Console.WriteLine("Please entre the number...");
            int NN = int.Parse(Console.ReadLine());
            Console.WriteLine("Please entre the power...");
            int xx = int.Parse(Console.ReadLine());
            double mult9; double sum11 = 1; int j = 1;
            for (int i = 1; i <= xx; i++)
            {
                mult9 = Math.Pow(NN, i);
                sum11 = sum11 - mult9 * j;
                j = j * (-1);

            }
            Console.WriteLine(sum11);

            //Task193
            Console.WriteLine("Please entre the number...");
            int ddd=int.Parse(Console.ReadLine());
            int sum12=0; int multt = 1;
            
                for (int o = 1; o <= ddd; o++)
                {
                    multt = multt * o;
                    sum12 = sum12 + multt;
                }

                Console.WriteLine(sum12);

            //Task 194
            Console.WriteLine("Please entre the number...");
            int bbb = int.Parse(Console.ReadLine());
            double sum14 = 0; int multtt = 1;

            for (int o = 1; o <= bbb; o++)
            {
                multtt = multtt * o;
                sum14 = sum14 + 1d/multtt; 
            }

            Console.WriteLine(1+sum14);

            //Task 195
            Console.WriteLine("Please entre the number...");
            int zzz = int.Parse(Console.ReadLine()); double summm = 0; int mlt = 1;
            for (int i = 1; i <= zzz; i++)
            {
                 mlt=mlt*i;
                summm = summm + (Math.Pow(zzz, i))/mlt;
            }
            Console.WriteLine(summm);




        }
    }




    
}

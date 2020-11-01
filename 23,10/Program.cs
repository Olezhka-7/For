using System;

namespace _23_10
{
    class Program
    {
        static void Main()
        {
            While4();
        }

        static public void For1()
        {
            int n = 7, k = 9;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(k);
            }
        }
        static public void For4()
        {
            int n = 7;
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine(n*i);
            }
        }
        static public void For8()
        {
            int a = 4, b = 9;
            int s = 1;
            for(int i =a; i <= b; i++)
            {
                s *= i;
            }
            Console.WriteLine(s);
        }
        static public void For12()
        {
            double n = 7, s=1;
            double m = 1.1;
            for (double i = 1; i <= n; i++,m+=0.1)
            {
                s *= m;
            }
            Console.WriteLine(s);
        }
        static public void For16()
        {
            double a = 7.7, n = 4;
            for(double i=0;i<n;i++)
            {
                Console.WriteLine(Math.Pow(a, i));
            }
        }
        static public void For20()
        {
            double n = 7, f = 1,s=1;
            for(double i = 1; i < n; i++)
            {
                f *= i;
                s += f;
                Console.WriteLine(s);
            }

        }
        static public void For24()
        {
            double x = 7;
            int n = 4;
            int d = 1;
            double s = 0; 
            for (int i = 0; i <= 2 * n; i += 2,d*=-1)
            {
                s += Math.Pow(x, i) / factorial(i);
            }
            Console.WriteLine(s);
        }
        static public double factorial(double x)
        {
            if (x== 0)
                return 1;
            else
                return x * factorial(x - 1);
        }
        static public void For17()
        {
            double a = 3, n = 7;
            double s = 1;
            for (int i = 1; i <= n; i++)
            {
                
                s += Math.Pow(a, i);
            }
            Console.WriteLine(s);
        }
        static public void While1()
        {
            int a = 15, b = 4;
            int s = 0;
            while (a > b)
            {
                 a = a - b;
                s++;
            }
            Console.WriteLine(s);
        }
        static public void While2()
        {
            int a = 15, b = 4;
            int s = 0;
            int r = 15;
            while (a > b)
            {
                s++;
                a = a - b;
            }
            a = r - b * s;
            Console.WriteLine(a);
        }
        static public void While3()
        {
            int n = 17, k = 3;
            int s = 0;
            int r = n;
            while (n >= k)
            {
                n = n - k;
                s++;
            }
            n = r - k * s;
            Console.WriteLine(n) ;
            Console.WriteLine(s);
        }
        static public void While4()
        {
            int n = 28, k=3,i=1;
            while (Math.Pow(k, i) < n)
            {
                i++;
            }
            if (Math.Pow(k, i) == n)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");

        }
    }
}

using System;

namespace LibClass
{
    public class For
    {
        public static int FromAtoB(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static double sumaN(double N)
        {
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += 1.0 / i;
            }
            return sum;
        }

        public static double power(double a, int N)
        {
            double sum = 1;
            for (int i = 1; i <= N; i++)
            {
                sum *= a;

            }
            return sum;
        }

        public static double Sumofsquares(int a, int b)
        {
            double sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        public static int factorial(int N)
        {
            int summa2 = 0;
            int suma = 1;
            for (int b = 1; b <= N; b++)
            {
                for (int i = 1; i <= b; i++)
                {
                    suma *= i;
                }
                summa2 += suma;
                suma = 1;
            }
            return summa2;
        }
    }

    public class While
    {
        public static double suma(double N)
        {
            int a = 1;
            double sum = 0;
            while (N > 0)
            {
                sum += Math.Pow(a, N);
                a++;
                N--;
            }
            return sum;
        }

        public static int find(int N)
        {
            int K = 1;
            int tmp = 3;
            if (N > 1)
            {
                while (tmp < N)
                {
                    tmp *= 3;
                    ++K;
                }
            }
            return K;
        }

        public static double percentDistance(double P)
        {
            double start = 10;
            while (start <= 200)
            {
                start += start * P / 100;
            }
            return start;
        }

        public static double day(double P)
        {
            double start = 10;
            int day = 1;
            while (start <= 200)
            {
                start += start * P / 100;
                day++;
            }
            return day;
        }
    }

    public class DoWhile
    {
        public static int sumDoWhile(int a)
        {
            int read = 0;
            do
            {
                read = Convert.ToInt32(Console.ReadLine());
                a += read;
            } while (read != 0);

            return a;
        }

    }
}

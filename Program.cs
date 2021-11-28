using System;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisible(483);

            int n = 3, m = 10;

            int odds = CountOdd(m, n);
            Console.WriteLine("Count of odd numbers is " + odds);

            int sum = OddSum(m, n);
            Console.WriteLine("Sum of odd natural numbers " +
                    "from n to m is " + OddSum(n, m));

            SimpleorComplex(12);

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            EvenSum(array);

        }
        //n ededinin 3 ve 7 ye bolunmesi methodu
        static void Divisible(int n)
        {

            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("Divisible by 3 and 7");

            }
            else
            {
                Console.WriteLine("Not Divisible by 3 and 7");
            }
        }
        // Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapan method
        static int CountOdd(int n, int m)
        {
            int i = (m - n) / 2;

            if (m % 2 != 0 || n % 2 != 0)

                i++;

            return i;

        }
        // Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapan method
        static int OddSum(int n, int m)
        {
            int sum = 0;
            if (n < 1 || m < 1)
            {
                Console.WriteLine("Enter the correct number");
            }

            else
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }

                }
            }
            return sum;
        }
        // Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapan method
        static void SimpleorComplex(int n)
        {
            int count = 0;
            if (n <= 1)
            {
                Console.WriteLine("Enter correct number");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }
                if (count > 2)
                {
                    Console.WriteLine("Complex");
                }
                else
                {
                    Console.WriteLine("Simple");
                }

            }
        }
        // Verilmish arrayin icindeki cut ededlerin cemini tapan method
        static void EvenSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}




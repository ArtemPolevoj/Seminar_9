using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_9
{
    internal class Value
    {
        public static int ValueOfN(int n)
        {
            Console.Write($"{n}, ");
            if (n == 1) return 1;
            else return n - ValueOfN(n - 1);
        }

        public static int SumFromMtoN(int m, int n, ref int sum)
        {
            // не забыть int sum = 0;
            sum += m;
            if (m == 0) return ((n * (n + 1)) / 2) + 1;
            else if (n == 0) return ((m * (m + 1)) / 2) + 1;
            else if (m == n) return 0;
            else if (m == n) SumFromMtoN(m - 1, n, ref sum);
            else SumFromMtoN(m + 1, n, ref sum);
            return sum;
        }

        public static int Akkermana(int n, int m)
        {
            if (n == 0)
                return m + 1;
            else
                if (m == 0)
                return Akkermana(n - 1, 1);
            else
                return Akkermana(n - 1, Akkermana(n, m - 1));
        }

        public static int getInt(string str)
        {
            int number = 0;
        checkNumber:
            Console.WriteLine(str);
            string? strNumber = Console.ReadLine();
            try
            {
                if (strNumber != null) number = int.Parse(strNumber);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ввели не целое число или не верный формат числа.");
                goto checkNumber;
            }
            catch (OverflowException ofe)
            {
                Console.WriteLine("Ввели большое число.");
                goto checkNumber;
            }

            return number;
        }
    }
}

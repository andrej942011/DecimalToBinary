using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Введите двоичное число");
            string st = Console.ReadLine();
            char[] arrCh = st.ToCharArray();//new[] {'1', '2'};
            int znach = gluing_number(arrCh);

            Console.WriteLine(convertToBinnary(znach));

            Console.ReadKey();
            return 0;
        }

        public static int gluing_number(char[] str)
        {
            int res = 0; //значение результата

            //склейка чисел
            for (int i = 0; i < str.Length; i++) //str[i] != '\0'
            {
                res = res * 10 + str[i] - '0';
            }

            return res;
        } 

        public static string convertToBinnary(int n)
        {
            int k = 0;
            string arr = "";

            while (n > 0)
            {
                //5%2 = 5-2=3-2=1, 1 < 2. Ответ 1.
                int znach = n;

                //проверка на остатток от деления
                while (znach > 1)
                    znach = znach - 2;

                arr += znach.ToString();

                n = n / 2;
            }

            return arr;
        }
    }
}

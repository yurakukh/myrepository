using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//11.Перевірити істинність вислову: "Дане чотиризначне число читається однаково зліва направо і справа наліво". 

namespace lab3
{
    class Program
    {
        static void Main()
        {
            int number;
            string numString;

            try
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                numString = number.ToString();
                if (numString.Length == 4)
                {
                    string reversedNumber = Reverse(numString);
                    if (numString == reversedNumber)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("There are < than 4 digits!");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

//Additional task
//17.Дані координати (як цілі від 1 до 8) двох різних полів шахівниці. 
//   Якщо тура за один хід може перейти з одного поля на інше, вивести логічне значення True, інакше вивести значення False. 

//namespace lab3
//{
//    class Program
//    {
//        static void Main()
//        {
//            int x1, y1, x2, y2;
//            Console.WriteLine("Coordinates can be in range [1;8]");
//            Console.WriteLine("Enter first point");
//            x1 = Input("x1");
//            y1 = Input("y1");

//            Console.WriteLine("Enter second point");
//            x2 = Input("x2");
//            y2 = Input("y2");


//            Console.WriteLine("\n({0};{1}) --- ({2};{3})", x1, y1, x2, y2);
//            if(x1 == x2 || y1 == y2)
//            {
//                Console.WriteLine("True");
//            }
//            else
//            {
//                Console.WriteLine("False");
//            }
//        }

//        static int Input(string coordinate)
//        {
//            int x;
//            do
//            {
//                Console.Write("{0} = ", coordinate);
//                x = Convert.ToInt32(Console.ReadLine());
//            } while (x < 1 || x > 8);

//            return x;
//        }
//    }
//}

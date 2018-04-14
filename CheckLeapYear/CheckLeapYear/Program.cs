using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai báo biến sử dụng trong chương trình
            int year;

            //Nhập vào năm cần kiểm tra 
            Console.Write("Please enter a year: ");
            year = Int32.Parse(Console.ReadLine());

            //Kiểm tra và hiển thị kết quả
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        Console.WriteLine("{0} is a leap year.", year);
                    else
                        Console.WriteLine("{0} is NOT a leap year.", year);
                }
                else
                    Console.WriteLine("{0} is a leap year.", year);
            }
            else
                Console.WriteLine("{0} is NOT a leap year.", year);

            Console.ReadLine();
        }
    }
}


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
            bool isLeapYear = false;

            //Nhập vào năm cần kiểm tra 
            Console.Write("Please enter a year: ");
            year = Int32.Parse(Console.ReadLine());

            //Kiểm tra và hiển thị kết quả
            bool isDivisibleBy4 = year % 4 == 0;
            if (isDivisibleBy4)
            {
                bool isDivisibleBy100 = year % 100 == 0;
                if (isDivisibleBy100)
                {
                    bool isDivisibleBy400 = year % 400 == 0;
                    if (isDivisibleBy400)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }

            if (isLeapYear)
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is NOT a leap year.", year);
            }

            Console.ReadLine();
        }
    }
}


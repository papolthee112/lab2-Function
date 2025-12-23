using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {


                void AnalyzeNumbers(int[] numbers)
                {
                    if (numbers.Length == 0)
                    {
                        Console.WriteLine("ไม่มีข้อมูลตัวเลข");
                        return;
                    }

                    // ค่าเฉลี่ย
                    double average = numbers.Average();

                    // ค่าสูงสุด และ ค่าต่ำสุด
                    int max = numbers.Max();
                    int min = numbers.Min();

                    // ค่ากลางข้อมูล (Median)
                    var sorted = numbers.OrderBy(n => n).ToArray();
                    double median;
                    int count = sorted.Length;

                    if (count % 2 == 1)
                        median = sorted[count / 2];
                    else
                        median = (sorted[count / 2 - 1] + sorted[count / 2]) / 2.0;

                    // เรียงข้อมูล
                    var descending = numbers.OrderByDescending(n => n);
                    var ascending = numbers.OrderBy(n => n);

                    // แสดงผล
                    Console.WriteLine("ข้อมูลตัวเลข: " + string.Join(", ", numbers));
                    Console.WriteLine("ค่าเฉลี่ย: " + average);
                    Console.WriteLine("ค่าสูงสุด: " + max);
                    Console.WriteLine("ค่าต่ำสุด: " + min);
                    Console.WriteLine("ค่ากลางข้อมูล: " + median);
                    Console.WriteLine("เรียงจากมากไปน้อย: " + string.Join(", ", descending));
                    Console.WriteLine("เรียงจากน้อยไปมาก: " + string.Join(", ", ascending));
                }

                {
                    int[] data = { 10, 5, 20, 15, 8 };
                    AnalyzeNumbers(data);
                }
            }

        }
    }
}






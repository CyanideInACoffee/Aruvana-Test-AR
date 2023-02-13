using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_Aruvana_Test
{
    class Program
    {
         static string timeConversion(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }


        static void Main(string[] args)
        {
            Console.WriteLine(timeConversion("00:12:34 AM"));
            Console.WriteLine(timeConversion("07:05:45 PM"));
            Console.Read();
        }
    }
    
}

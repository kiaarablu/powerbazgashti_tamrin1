using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powerbazgashti
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int pow (int number , int power)
            {
                if (power == 0)
                {
                    return 1; 
                }
                else
                {
                    int result = number * pow(number, power - 1);
                    return result;
                }
               
            }
            int a  = Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pow(a , b));
            Console.ReadKey();
        }
    }
}

//Lauren Watson
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4;
            num1 = 51;
            num2 = 785;
            num3 = 83;
            num4 = 98;

            //call methods
            double result = Add(num1, num2); //right hand side of equal sign because it returns something assigning value to variable
            Console.WriteLine($"{num1.ToString("N2")} + {num2} = {result}");
            
            result = Subtract(num3, num4);
            Console.WriteLine($"{num3} - {num4} = {result}");
          

            //call array method

            double[] allTheNumbers = new double[5];
            allTheNumbers[0] = 1;
            allTheNumbers[1] = 4;
            allTheNumbers[2] = 5;
            allTheNumbers[3] = 10;
            allTheNumbers[4] = 20;
            // allTheNumbers[5] = ERROR, INDEX OUT OF BOUNDS

            result = Add(allTheNumbers);
            Console.WriteLine(result);

            Console.ReadKey();
        }
       
        /// <summary>
        /// create method to add two numbers together
        /// </summary>
        /// <param name="val1">left hand operand</param>
        /// <param name="val2">right hand operand</param>
        /// <returns>sum of val1 and val2</returns>
        public static double Add(double val1, double val2)//need two numbers to perform
        {
            //rror return value means we must return a value with key word return
            double sum = val1 + val2;
            return sum;
        }

        static double Add(double[] values)//square brackets mean array
        {
            //need a loop because they keep entering values, need to iterate through
            //array or list, need a loop

            double sum = 0;
            int counter = 0; //need counting variable

            //while
            while (counter < values.Length)
            {
                sum += values[counter]; //+= same thing as saying sum = sum + values[counter]; keep adding values to itself
                counter++; 
            }

            //for
            sum = 0;
            for (counter = 0; counter < values.Length; counter++) //tab twice fills it for you
            {
                sum += values[counter];
            }

            //foreach
            sum = 0;
            foreach (var item in values)
            {
                sum += item;
            }

            return sum; //overloading - two methods same name but work different, can do this becuase signatures & return values are different
        }

        //subtraction
        public static double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }
    }
}

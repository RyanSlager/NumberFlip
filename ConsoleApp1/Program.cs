using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            // gets string of numbers from the user, assigns them to an array, and initializes an empty list object
            Console.WriteLine("Please enter a string of numbers");
            string numbersIn = Console.ReadLine();
            var digits = numbersIn.ToArray();
            var numbers = new List<int>();

            for (int i = 0; i < digits.Length; i++)
            {
                // tries to parse chars into ints and sets a bool based on the result
                bool result = Int32.TryParse(digits[i].ToString(), out int number);

                // if the char was parsed into an int, the int is added to the numbers list, if not, a message is displayed
                // to the user that the item was not a number, and will be dropped from the list
                if (result)
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("{0} is not a number and has been dropped from the list.", digits[i]);
                }

            }

            // converts the numbers list into an array and then reverses the array
            int[] numArray = numbers.ToArray();
            Array.Reverse(numArray);
            
            // prints the reversed numbers
            for(int i = 0; i < numArray.Length; i++)
            {
                Console.Write(numArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();



        }
    }
}

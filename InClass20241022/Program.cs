// Documentation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass20241022
{
    internal class Program
    {
        static void Main(string[] args) // Entry point
        {
            HelloWorld(); // Call or Invoke the method 
            // Invoke cube method
            Cube(4); // Invoke but discard
            int answer;
            answer = Cube(4); // Invoke and store as a var answer
            Console.WriteLine(answer);
            int EvenOrOddNum;
            EvenOrOddNum = 6;
            Console.WriteLine(CheckEven(EvenOrOddNum));

        }

        /// <summary>
        /// Print Hello World to the console. 
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        /// <summary>
        /// Compute the cube of an integer
        /// </summary>
        /// <param name="num">The number to be cubed</param>
        /// <returns>The cube of num</returns>
        static int Cube(int num)  // Method signature 
        {
            return num * num * num;
        }

        // Change order: If the number is negative, always false
        /// <summary>
        /// Check if an inputted number is even or odd, or negative
        /// </summary>
        /// <param name="input"> the number to be evaluated</param>
        /// <returns> True if even, false if odd or negative</returns>
        static bool CheckEven (int input)
        {
            if (input < 0) { return false; }
            if (input % 2 == 0) { return true; }
            else return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2900482#content
namespace ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Smith ";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
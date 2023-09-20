using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    public class UserInput : IUserInput
    {
        public int ChoosePlatform()
        {
            Console.WriteLine("Menu 1:");
            Console.WriteLine();
            Console.WriteLine("1. Window:");
            Console.WriteLine("2. Linux");
            Console.WriteLine("3. Exit App");
            Console.WriteLine("Select Option:");
            Console.WriteLine();

            int choice = int.Parse(Console.ReadLine());

            return choice;
        }

        public int ChooseOperation()
        {
            Console.WriteLine("Menu 2:");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Stop");
            Console.WriteLine("3. Return to Menu 1");
            Console.WriteLine("Select Option:");

            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}

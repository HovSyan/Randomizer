using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] objects;
            int index = 0;
            Random random = new Random();

            Console.WriteLine(StringOutputs.GREETING_MESSEGE);
            Console.WriteLine(StringOutputs.STYLE);
            Console.WriteLine(StringOutputs.OPERATING_GUIDE);
            Console.WriteLine(StringOutputs.STYLE);

            Console.Write("Number of objects: ");
            n = Convert.ToInt32(Console.ReadLine());
            objects = new string[n];

            for(int i = 1; i <= n; i++)
            {
                Console.Write(i.ToString() + ". ");
                objects[i - 1] = Console.ReadLine();
            }

            Console.WriteLine(StringOutputs.STYLE);

            index = random.Next(1, n) - 1;

            Console.WriteLine((index + 1).ToString() + ". " + objects[index]);

            Console.ReadLine();
        }
    }
}






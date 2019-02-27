using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickMan
{
    class Program
    {
        static void Main(string[] args)
        {
            int upward = 1;
            int downward = 1;
            int leftward = 1;
            int rightward = 1;

            moveStickMan(upward, downward, leftward, rightward);

            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                Console.Clear();
                if (info.Key == ConsoleKey.UpArrow)
                {
                    upward++;
                    moveStickMan(upward, downward, leftward, rightward);
                }
                else if (info.Key == ConsoleKey.DownArrow)
                {
                    downward++;
                    moveStickMan(upward, downward, leftward, rightward);
                }
                else if (info.Key == ConsoleKey.LeftArrow)
                {
                    leftward++;
                    moveStickMan(upward, downward, leftward, rightward);
                }
                else if (info.Key == ConsoleKey.RightArrow)
                {
                    rightward++;
                    moveStickMan(upward, downward, leftward, rightward);
                }
            }
        }

        public static void moveStickMan(int upward, int downward, int leftward, int rightward)
        {
            for (int i = 0; i < downward - upward; i++)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < rightward - leftward; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(" O ");

            for (int i = 0; i < rightward - leftward; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("/|\\");

            for (int i = 0; i < rightward - leftward; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("/ \\");
        }
    }
}

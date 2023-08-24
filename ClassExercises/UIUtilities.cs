using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    internal class UIUtilities
    {
        public static void MakeTextRedThenWhite(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void MakeTextYellowThenWhite(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DisplayPostsMenu()
        {
            Console.WriteLine("1) Create a post");
            Console.WriteLine("2) Upvote a post");
            Console.WriteLine("3) Downvote a post");
            Console.WriteLine("4) See the vote total of a post");
            Console.WriteLine("5) Exit");
        }
    }
}

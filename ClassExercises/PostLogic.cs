using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    internal class PostLogic
    {
        public static Post CreatePost()
        {
            var post = new Post();
            Console.Write("Please enter the TITLE: ");
            post.Title = Console.ReadLine();
            Console.Write("Please enter the DESCRIPTION: ");
            post.Description = Console.ReadLine();
            return post;
        }
    }
}

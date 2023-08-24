using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private readonly DateTime _created;
        public DateTime Created { get { return _created; } }

        private int _voteTotal;

        public int VoteTotal { get { return _voteTotal; } }

        public Post()
        {
            _created = DateTime.Now;
            _voteTotal = 1;
        }

        public int UpvotePost()
        {
            return _voteTotal++;
        }

        public int DownvotePost()
        {
            return _voteTotal--;
        }

    }
}

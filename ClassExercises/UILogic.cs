using System.Diagnostics;

namespace ClassExercises
{
    public static class UILogic
    {
        public static void RunStopwatch()
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine("Enter any character(s) to exit at any time.");
            DateTime startTime = DateTime.Now;
            bool runApp = true;
            while (runApp)
            {
                Console.WriteLine(stopwatch.running == false ? "Press enter to start the stopwatch." : "Press enter to stop the stopwatch.");
                var userInput = Console.ReadLine();
                if (userInput == "")
                {
                    if (stopwatch.running)
                    {
                        UIUtilities.MakeTextYellowThenWhite($"{StopwatchLogic.FormatElapsedTime(stopwatch.Stop(startTime))} seconds");
                    }
                    else
                    {
                        startTime = stopwatch.Start();
                        UIUtilities.MakeTextRedThenWhite("Running...");
                    }
                }
                else
                    Environment.Exit(0);
            }
        }

        public static void ManagePosts()
        {
            var posts = new List<Post>();
            UIUtilities.DisplayPostsMenu();
            bool runApp = true;
            while (runApp)
            {
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        posts.Add(PostLogic.CreatePost());
                        UIUtilities.MakeTextYellowThenWhite($"{posts[0].Title} created and saved");
                        break;

                    case "2":
                        posts[0].UpvotePost();
                        UIUtilities.MakeTextYellowThenWhite("Upvote recorded.");
                        break;

                    case "3":
                        posts[0].DownvotePost();
                        UIUtilities.MakeTextRedThenWhite("Downvote recorded.");
                        break;

                    case "4":
                        UIUtilities.MakeTextYellowThenWhite($"Vote total is {posts[0].VoteTotal}");
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default: break;
                }

                Console.WriteLine();
                UIUtilities.DisplayPostsMenu();
            }
        }
    }
}

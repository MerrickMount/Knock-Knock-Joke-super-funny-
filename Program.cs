using System.Runtime.CompilerServices;

namespace topic_4._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userResponse1, userResponse2;
            bool joke = true;
            while(joke = true)
            {
                Console.WriteLine("Knock Knock");
                userResponse1 = Console.ReadLine();
                if (userResponse1.ToLower() == "whos there" || userResponse1.ToLower() == "who's there?" || userResponse1.ToLower() == "whos there?" || userResponse1.ToLower() == "who's there")
                {
                    Console.WriteLine("Banana");
                    userResponse2 = Console.ReadLine();
                    if (userResponse2.ToLower() == "banana who" || userResponse2.ToLower() == "banana who?")
                    {
                        Console.WriteLine("Orange");
                        Thread.Sleep(2000);
                        Console.WriteLine("do you get it?");
                        Thread.Sleep(5000);
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("You aren't that good at knock knock jokes are you?");

                    }
                }
                else
                {
                    Console.WriteLine("You are supposed to say 'who's there?'");
                    Console.WriteLine("try again");
                }
            }
            if (joke = false)
            {
                System.Environment.Exit(0);
            }

        }
    }
}
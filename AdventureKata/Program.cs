using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             Atomic Coffee Proudly Presents THE ADVENTURE KATA ");
            Console.WriteLine("                    : created and written by Princie :         ");
            Console.WriteLine("                              with help from           ");
            Console.WriteLine("             http://www.lincolnli.com/text-adventure-game---c.html         ");
            Console.ReadLine();
            Console.Clear();

            // THE GAME BEGINS HERE YA'LL!
            Console.WriteLine("You, a wandering adventure with aspirations and stuff, find your way into the ruins of an ancient civilization deep underground.  " +  
                              "You think.  You're actually in an office.  No, you're in a cave.  When you enter the cave, a door behind you closes and you can" +
                              "no longer leave the cave.  You can't really see that far.  You hear water.");
            
            // in the words of Illidan Stormrage:  You are not prepared!
            while (true)
            {
                Console.WriteLine("Are you prepared?  Y/N");
                var prepared = Console.ReadLine().ToLower();

                if (prepared == "y")
                {
                    Console.Clear(); // clear console
                    break;
                }
                if (prepared == "n")
                {
                    Console.WriteLine("You are not prepared!");
                }
            }

            Console.Clear();
            Console.WriteLine("Ok.  So you actually came prepared.  You light a torch.");
            Console.WriteLine("Holy bazookas, batman!  You see a stream.");
            Console.WriteLine("And it's pretty much a straight path down a long cave beside the stream.");
            Console.WriteLine("Except for the hole in that wall...");
            while (true)
            {
                Console.WriteLine("What do you do?");
                var whatToDew = Console.ReadLine().ToLower(); // see google: tillerman

                if (whatToDew.StartsWith("look"))
                {
                    if (whatToDew == "look")
                        Console.WriteLine("What are you looking at?");
                    else if (whatToDew == "look stream")
                    {
                        Console.WriteLine("The stream appears to be made entirely of apple juice.");
                        Console.WriteLine("Mmm apples.  Oh, and it's about 2 feet deep.");
                    }
                    else if (whatToDew.StartsWith("look hole"))
                    {
                        Console.WriteLine("Yeah, that hole is like 8 feet up.  And it's rather horrifying");
                        Console.WriteLine("But 8 feet, man.  And it's person-sized.  Wonder what's inside?")
                    }
                }
                else if (whatToDew.StartsWith("look"))
                {
                    //look at stuff
                }
                else if (whatToDew.StartsWith("walk"))
                {
                    //walk
                }
                else if (whatToDew.StartsWith("climb"))
                {
                    //climb
                }
            }
        }
    }
}

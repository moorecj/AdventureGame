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
            Console.WriteLine("You, a wandering adventure with aspirations and stuff, find your way into the\n" +
                              "ruins of an ancient civilization deep underground.  You think.  You're\n" +  
                              "actually in an office.  No, you're in a cave.  When you enter the cave, a door\n" +
                              "behind you closes and you can no longer leave the cave.  You can't really see\n" +
                              "that far.  You hear water.");
            
            // in the words of Illidan:  You are not prepared!
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
            Console.WriteLine("And it's pretty much a straight path north down a long cave beside the stream.");
            Console.WriteLine("Except for the hole in that wall...");
            Console.WriteLine("What do you do?");
            while (true)
            {
                
                var whatToDew = Console.ReadLine().ToLower();
                Console.Clear();

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
                        Console.WriteLine("But 8 feet, man.  And it's person-sized.  Wonder what's inside?");
                    }
                }
                else if (whatToDew.StartsWith("jump"))
                {
                    Console.WriteLine("Good job!  You can jump.  That is, undoubtedly, impressive.");
                }
                else if (whatToDew.StartsWith("climb"))
                {
                    if (whatToDew == "climb")
                        Console.WriteLine("What are you climbing?  There are a lot of rocks.");
                    else if (whatToDew == "climb hole")
                    {
                        Console.WriteLine("You approach the hole in the wall. You begin to climb up.");
                        Console.WriteLine("You then begin to daydream about that apple juice behind you.");
                        Console.WriteLine("As it turns out, you are thirsty.  Mmm apple juice.");
                        Console.WriteLine("Oh yeah!  you're in the hole now.  It turns out it's a really big tunnel.");
                        Console.WriteLine("...with walls made of cheese.  Man that looks delicious.");
                        break;
                    }
                }
                else if (whatToDew.StartsWith("drink"))
                {
                    if (whatToDew == "drink")
                        Console.WriteLine("What are you trying to drink?");
                    else if (whatToDew == "drink apple juice")
                    {
                        Console.WriteLine("You approach the stream.  You take a cup that you somehow now possess and fill it with apple juice.");
                        Console.WriteLine("You drink it.  It is the most delicious apple juice you've ever had in a cave.");
                        Console.WriteLine("As you enjoy this tasty drink, the cave begins to get brighter, and brighter.");
                        Console.WriteLine("You suddenly find yourself on a boat.  Yes, you're on a boat.");
                        Console.WriteLine("The boat is going fast.  You obtained a a nautical themed pashmina afghan!");
                        break;
                    }
                }
                else if (whatToDew.StartsWith("go"))
                {
                    if (whatToDew == "go")
                        Console.WriteLine("Where are you going?");
                    else if (whatToDew == "go north")
                    {
                        Console.WriteLine("You slowly creep forward along the path, venturing forth into this deep, dark cave.");
                        Console.WriteLine("As you round the bend, you find a big, large room full of wackly inflatable arm flailing tube men!");
                        Console.WriteLine("Wacky inflatable arm flailing tube men!");
                        Console.WriteLine("Wacky inflatable arm flailing tube men!");
                        Console.WriteLine("Wacky inflatable arm flailing tube men!");
                        break;
                    }
                }
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You see a creature with 4 legs, a brown and white body.  Antlers.  It's eating moss.");
            Console.WriteLine("'BEAR!' you exclaim loudly in horror.  Suddenly the entire world fades away\n" +
                "into a similar looking area, but somehow, more generic.");
            Console.WriteLine("You're holding a sword.  The bear looks like it's about to charge!  What do you do?");

            var dew = Console.ReadLine().ToLower();

            Console.Clear();

            if (dew.StartsWith("attack"))
                Console.WriteLine("You take the Excalimune in your hands, lift it above your head, and\noff with the bear's head!  Hey!  It was actually a deer.");
            else
                Console.WriteLine("The bear eats you!");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Thanks so much for playing!  May the schwartz be with you.");
            Console.ReadLine();
        }
    }
}

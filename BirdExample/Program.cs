using System;
using System.Threading;
/*LISKOV PRINCIPLE
 *
 *The Liskov Substitution principle was introduced by Barbara Liskov in her conference keynote “Data abstraction” in 1987. Barbara Liskov and Jeannette Wing formulated the principle succinctly in a 1994 paper as follows:
 *
 *“Let φ(x) be a property provable about objects x of type T. Then φ(y) should be true for objects y of type S where S is a subtype of T.”
 *
 *Or in other words if S is a subtype of T. Objects of type S can replace objects of type T without introducing errors or modification of T
 * 
 * Extends the Open/Closed principle and enables you to replace objects of a parent class with objects of a subclass without breaking the application.
 */
namespace BirdExample
{
    class Program
    {
        abstract class Birds
        {
            public void eat()
            {
                Console.WriteLine("Eating...");
            }

            public void sleep()
            {
                Console.WriteLine("Sleeping...");
                Thread.Sleep(3000);
                Console.WriteLine("(*)>! *awake*");
            }

            public void walk()
            {
                Console.WriteLine("Walking...");
            }

            public virtual void fly()
            {
                Console.WriteLine("Flying...");
            }
        }

        class Penguin : Birds
        {
            public override void fly()
            {
                Console.WriteLine("ERROR: Penguins can't fly...");
            }

            public void slide()
            {
                Console.WriteLine("Penguin Sliding...");
            }

            public void happyFeet()
            {
                Console.WriteLine("HAPPY FEET...");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("\r>()<");
                    Thread.Sleep(500);
                    Console.Write("\r<()>");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
            }
        }

        class Eagle : Birds
        {
            public void eagleStuff()
            {
                Console.WriteLine("Doing Eagle Stuff...");
            }
        }

        static void Main()
        {
            Eagle Bald = new Eagle();
            Penguin Arctic = new Penguin();

            while (true)
            {
                Console.Write("Species: ");
                string species = Console.ReadLine();
                Console.Write("Preferred Method: ");
                string method = Console.ReadLine();

                if (species.ToLower() == "penguin")
                {
                    switch (method.ToLower())
                    {
                        case "eat":
                            Arctic.eat();
                            break;
                        case "sleep":
                            Arctic.sleep();
                            break;
                        case "walk":
                            Arctic.walk();
                            break;
                        case "fly":
                            Arctic.fly();
                            break;
                        case "dance":
                            Arctic.happyFeet();
                            break;
                        case "slide":
                            Arctic.slide();
                            break;
                        default:
                            Environment.Exit(1);
                            break;
                    }
                }
                else
                {
                    switch (method.ToLower())
                    {
                        case "eat":
                            Bald.eat();
                            break;
                        case "sleep":
                            Bald.sleep();
                            break;
                        case "walk":
                            Bald.walk();
                            break;
                        case "fly":
                            Bald.fly();
                            break;
                        case "eagle":
                            Bald.eagleStuff();
                            break;
                        default:
                            Environment.Exit(1);
                            break;
                    }
                }
                Console.WriteLine();
            }

            #region r1
            /*
            if(s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
            */
            #endregion
        }
    }
}

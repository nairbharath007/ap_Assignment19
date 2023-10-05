using DogDoorBarkAutoClose.Model;

namespace DogDoorBarkAutoClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            // Simulate the hardware hearing a bark
            Console.WriteLine("Fido barks to go outside...");
            recognizer.Recognize("Woof");

            Console.WriteLine("\nFido has gone outside...");
            Console.WriteLine("\nFido's all done...");

            /*try
            {
                Thread.Sleep(10000);
            }
            catch (InterruptedException e) { }*/

            Thread.Sleep(10000);
            Console.WriteLine("...but he's stuck outside!");

            Console.WriteLine("\nFido starts barking...");
            recognizer.Recognize("Woof");

            Console.WriteLine("\nFido's back inside...");
        }
    }
}

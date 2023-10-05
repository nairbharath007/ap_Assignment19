using DogDoorMaria.Models;

namespace DogDoorMaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            door.AddAllowedBark(new Bark("rowlf"));
            door.AddAllowedBark(new Bark("rooowlf"));
            door.AddAllowedBark(new Bark("rawlf"));
            door.AddAllowedBark(new Bark("woof"));
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            // Simulate the hardware hearing a bark
            Console.WriteLine("Bruce starts barking.");
            recognizer.Recognize(new Bark("Rowlf"));

            Console.WriteLine("\nBruce has gone outside...");

            System.Threading.Thread.Sleep(10000);

            Console.WriteLine("\nBruce all done...");
            Console.WriteLine("...but he's stuck outside!");

            // Simulate the hardware hearing a bark (not Bruce!)
            Bark smallDogBark = new Bark("yip");
            Console.WriteLine("A small dog starts barking.");
            recognizer.Recognize(smallDogBark);

            System.Threading.Thread.Sleep(5000);

            // Simulate the hardware hearing a bark again
            Console.WriteLine("\nBruce starts barking.");
            recognizer.Recognize(new Bark("Rowlf"));

            Console.WriteLine("\nBruce's back inside...");
        }
    }
}
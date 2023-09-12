using DogDoorFinal.Model;
//using DogDoorTimer.Model;

namespace DogDoorFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();

            Console.WriteLine("\nFido has gone outside...");
            Console.WriteLine("\nFido's all done...");

            try
            {
                Thread.Sleep(10000); // Sleep for 10 seconds (10000 milliseconds)
            }
            catch (ThreadInterruptedException)
            {
                // Handle InterruptedException if needed
            }

            Console.WriteLine("...but he's stuck outside!");

            Console.WriteLine("\nFido starts barking...");
            Console.WriteLine("...so Gina grabs the remote control.");
            remote.PressButton();

            Console.WriteLine("\nFido's back inside...");
        }
    }
    
}
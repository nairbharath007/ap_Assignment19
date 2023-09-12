using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace DogDoorFinal.Model
{
    internal class Remote
    {
        private DogDoor door;
        private Timer timer;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (door.IsOpen())
            {
                door.Close();
            }
            else
            {
                door.Open();

                timer = new Timer(5000); // 5000 milliseconds = 5 seconds
                timer.Elapsed += TimerElapsed;
                timer.AutoReset = false; // Ensures the timer only runs once
                timer.Start();
            }
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            door.Close();
            timer.Dispose(); // Dispose of the timer to release resources
        }
    }
}

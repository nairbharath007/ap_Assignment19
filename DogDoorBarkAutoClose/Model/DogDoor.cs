using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace DogDoorBarkAutoClose.Model
{
    public class DogDoor
    {
        private bool open;

        public DogDoor()
        {
            this.open = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            open = true;

            Timer timer = new Timer();
            timer.Elapsed += (sender, e) =>
            {
                Close();
                timer.Stop();
                timer.Dispose();
            };
            timer.Interval = 5000; // 5000 milliseconds (5 seconds)
            timer.Start();
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }
    }
}


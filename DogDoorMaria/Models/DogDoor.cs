using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Timers;

namespace DogDoorMaria.Models
{
    internal class DogDoor
    {
        private bool open;
        private List<Bark> allowedBarks;

        public DogDoor()
        {
            this.allowedBarks = new List<Bark>();
            open = false;
        }

        public void AddAllowedBark(Bark bark)
        {
            allowedBarks.Add(bark);
        }

        public List<Bark> GetAllowedBarks()
        {
            return allowedBarks;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            open = true;

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += (sender, e) =>
            {
                Close();
                timer.Stop();
            };
            timer.Interval = 5000;
            timer.AutoReset = false;
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

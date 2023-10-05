using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorMaria.Models
{
    internal class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void Recognize(Bark bark)
        {
            Console.WriteLine($"   BarkRecognizer: Heard a '{bark.GetSound()}'");
            List<Bark> allowedBarks = door.GetAllowedBarks();
            foreach (Bark allowedBark in allowedBarks)
            {
                if (allowedBark.Equals(bark))
                {
                    door.Open();
                    return;
                }
            }
            Console.WriteLine("This dog is not allowed.");
        }
    }
}

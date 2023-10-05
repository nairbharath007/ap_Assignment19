using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorMaria.Models
{
    internal class Bark
    {
        private string sound;

        public Bark(string sound)
        {
            this.sound = sound;
        }

        public string GetSound()
        {
            return sound;
        }

        public bool Equals(Bark bark)
        {
            if (bark is Bark otherBark)
            {
                if (string.Equals(this.sound, otherBark.sound, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

using CreateYourCharacter.Attacks;
using CreateYourCharacter.EnumAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourCharacter.Character.Race
{
    public abstract class Races
    {
        public Dictionary<Magical, Resistance> MagicalResistance { get; set; }
        public Dictionary<Physical, Resistance> PhysicalResistance { get; set; }

        public Races() 
        {
            MagicalResistance = new Dictionary<Magical, Resistance>();

            PhysicalResistance = new Dictionary<Physical, Resistance>();
        }
    }
}

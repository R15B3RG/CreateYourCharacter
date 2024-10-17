using CreateYourCharacter.EnumAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateYourCharacter.EnumAttacks;

namespace CreateYourCharacter.Character.CharacterClass
{
    public abstract class CharacterClass
    {

        public int HealthPoints { get; set; }

        public int MagicPoints { get; set; }

        public Dictionary<Magical, Resistance> MagicalResistance { get; set; }
        public Dictionary<Physical, Resistance> PhysicalResistance { get; set; }

        protected CharacterClass(int healthPoints, int magicPoints)
        {
            HealthPoints = healthPoints;
            MagicPoints = magicPoints;
        }

        public CharacterClass()
        {
            MagicalResistance = new Dictionary<Magical, Resistance>();

            PhysicalResistance = new Dictionary<Physical, Resistance>();
        }
    }
}

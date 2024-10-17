using CreateYourCharacter.EnumAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourCharacter.Character.Race
{
    internal class Human : Races
    {
        public Human()
        {
            MagicalResistance[Magical.Ice] = Resistance.BigResistance;
            PhysicalResistance[Physical.Sword] = Resistance.SmallResistance;

          
        }

        public override string ToString()
        {
            return "Human";
        }
    }
}

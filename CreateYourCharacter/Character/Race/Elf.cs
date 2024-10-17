using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateYourCharacter.EnumAttacks;

namespace CreateYourCharacter.Character.Race
{
    internal class Elf : Races
    {
        public Elf() 
        {
            MagicalResistance[Magical.Earth] = Resistance.BigResistance;
            MagicalResistance[Magical.Wind] = Resistance.BigResistance;
            

        }
    }
}

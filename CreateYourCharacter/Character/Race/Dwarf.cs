using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateYourCharacter.EnumAttacks;

namespace CreateYourCharacter.Character.Race
{
    internal class Dwarf : Races
    {
        public Dwarf()
        {
            PhysicalResistance[Physical.Axe] = Resistance.SmallResistance;
            PhysicalResistance[Physical.Sword] = Resistance.SmallResistance;
            PhysicalResistance[Physical.Bow] = Resistance.SmallResistance;

        }

        public override string ToString()
        {
            return "Dwarf";
        }
    }
}

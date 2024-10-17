using CreateYourCharacter.EnumAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourCharacter.Character.CharacterClass
{
    public class Ranger : CharacterClass
    {
        public Ranger() : base(20, 15) //20 HealthPoints, 15 MagicPoints
        {
            PhysicalResistance[Physical.Bow] = Resistance.BigResistance;

            MagicalResistance[Magical.Earth] = Resistance.SmallResistance;
            MagicalResistance[Magical.Wind] = Resistance.SmallResistance;
        }
    }
}

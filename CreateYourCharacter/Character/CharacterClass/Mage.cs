using CreateYourCharacter.EnumAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourCharacter.Character.CharacterClass
{
    public class Mage : CharacterClass
    {
        public Mage() : base(15, 30)//15 HealthPoints, 30 MagicPoints
        {
            MagicalResistance[Magical.Earth] = Resistance.SmallResistance;
            MagicalResistance[Magical.Wind] = Resistance.SmallResistance;
            MagicalResistance[Magical.Ice] = Resistance.SmallResistance;
            MagicalResistance[Magical.Fire] = Resistance.SmallResistance;
            
        }

        public override string ToString()
        {
            return "Mage";
        }
    }
}

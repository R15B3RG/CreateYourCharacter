using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CreateYourCharacter.EnumAttacks;

namespace CreateYourCharacter.Character.CharacterClass
{
    public class Knight : CharacterClass
    {
        public Knight() : base(30, 10)//30 HealthPoints, 10 MagicPoints
        {
            PhysicalResistance[Physical.Sword] = Resistance.BigResistance;
            PhysicalResistance[Physical.Axe] = Resistance.BigResistance;
            PhysicalResistance[Physical.Bow] = Resistance.SmallResistance;
        }

        public override string ToString()
        {
            return "Knight";
        }

    }
}

using CreateYourCharacter.EnumAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourCharacter.Attacks
{
    public abstract class Attacks //Abstrakta klasser är ALLTID enbart föräldrarklasser som andra klasser kan ärva utav och kan inte instansieras direkt
    {

        public Magical TypeMagic {  get; set; }

        public Physical TypePhys { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        protected Attacks() 
        { 
        }

    }
}

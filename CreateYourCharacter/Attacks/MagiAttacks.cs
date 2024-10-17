using CreateYourCharacter.EnumAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourCharacter.Attacks
{
    public class MagiAttacks : Attacks
    {

        private List<Magical> _magiTypes = new List<Magical>();

        public List<Magical> MagiTypes
        {
            get { return _magiTypes; }
            set { _magiTypes = value; }
        }
        

        public MagiAttacks(string name, params Magical[] types)
        {
            


        }
    }
}

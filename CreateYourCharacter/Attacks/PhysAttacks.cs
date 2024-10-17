using CreateYourCharacter.EnumAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourCharacter.Attacks
{
    public class PhysAttacks : Attacks
    {

        private List<Physical> _physTypes = new List<Physical>();

        public List<Physical> PhysTypes
        {
            get { return _physTypes; }

            set { _physTypes = value; }
        }
        public PhysAttacks(string name, params Physical[] types)
        {

            

        }
    }
}

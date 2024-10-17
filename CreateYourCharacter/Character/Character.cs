using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CreateYourCharacter.Character
{
    public class Character
    {

        private string _gender;

        public string Gender
        {
            get => _gender;
            set => _gender = value;
        }

        private string _characterName;

        public string CharacterName
        {
            get => _characterName;
            set => _characterName = value;
        }

        private int _exp = 0;

        public int Exp
        {
            get => _exp;
            set => _exp = value;
        }

        public CharacterClass.CharacterClass characterClass { get; set; }

        public Race.Races race { get; set; }

    }


}

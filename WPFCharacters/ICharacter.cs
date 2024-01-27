using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCharacters
{
    internal interface ICharacter
    {
        public int Strength
        { get; set; }
        public int Vitality
        { get; set; }
        public int Inteligence
        { get; set; }
        public int Dexterity
        { get; set; }
        public int Health
        { get; set; }
        public int MaxHealth
        { get; set; }
        public int Mana
        { get; set; }
        public int MaxMana
        { get; set; }
        public int PDmg
        { get; set; }
        public int Armor
        { get; set; }
        public int MDmg
        { get; set; }
        public int MDef
        { get; set; }
        public int CrtChance
        { get; set; }
        public int CrtDmg
        { get; set; }


        public void addVital(int points)
        {
            Vitality += points;
        }
    }
}

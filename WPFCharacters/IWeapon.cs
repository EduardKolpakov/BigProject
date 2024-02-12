using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCharacters
{
    internal interface IWeapon
    {
        public string Quality
        { get; set; }
        public string Name
        { get; set; }
        public int PDmg_b
        { get; set; }
        public int Mana_b
        { get; set; }
        public int Int_b
        { get; set; }
        public int CC_b
        { get; set; }
        public int CD_b
        { get; set; }
        public int Str_b
        { get; set; }
        public int Dex_b
        { get; set; }
        public bool Shield
        { get; set; }
        public int hp_b
        { get; set; }
    }
}

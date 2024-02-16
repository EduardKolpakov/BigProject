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
        public double PDmg_b
        { get; set; }
        public double Mana_b
        { get; set; }
        public double Int_b
        { get; set; }
        public int CC_b
        { get; set; }
        public int CD_b
        { get; set; }
        public double Str_b
        { get; set; }
        public double Dex_b
        { get; set; }
        public bool Shield
        { get; set; }
        public double hp_b
        { get; set; }
    }
}

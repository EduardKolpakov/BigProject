using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WPFCharacters
{
    internal class Staff : IWeapon
    {
        private string _qual;
        private string _name;
        private double _pdmg_b;
        private double _mana_b;
        private double _int_b;
        private int _cc_b;
        private int _cd_b;
        private double _str_b;
        private double _dex_b;
        private bool _shield;
        private double _hp_b;
        public Staff(string qual)
        {
            Quality = qual;
            Name = "Staff";
        }

        public string Quality
        {
            get { return _qual; }
            set
            {
                _qual = value;
                if (_qual == "common")
                {
                    PDmg_b = 1.05;
                    Mana_b = 1.5;
                    Int_b = 1.2;
                    CC_b = 5;
                    CD_b = 300;
                    Dex_b = 1;
                    hp_b = 1;
                    Str_b = 1;
                    Shield = false;
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double PDmg_b
        {
            get { return _pdmg_b; }
            set { _pdmg_b = value; }
        }
        public double Mana_b
        {
            get { return _mana_b; }
            set { _mana_b = value; }
        }
        public double Int_b
        {
            get {return _int_b; }
            set { _int_b = value; }
        }
        public int CC_b
        {
            get { return _cc_b; }
            set { _cc_b = value; }
        }
        public int CD_b 
        {
            get { return _cd_b; }
            set { _cd_b = value; }
        }
        public double Str_b
        {
            get { return _str_b; }
            set { _str_b = value; }
        }
        public double Dex_b 
        {
            get { return _dex_b; }
            set { _dex_b = value; }
        }
        public bool Shield
        {
            get { return _shield; }
            set { _shield = value; }
        }
        public double hp_b
        {
            get { return _hp_b; }
            set { _hp_b = value; }
        }
    }
}

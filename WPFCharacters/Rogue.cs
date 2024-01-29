using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCharacters
{
    internal class Rogue : ICharacter
    {
        private int _str;
        private int _vit;
        private int _int;
        private int _dex;
        private int _maxstr = 65;
        private int _maxvit = 80;
        private int _maxint = 70;
        private int _maxdex = 250;
        private int _health;
        private int _maxhealth;
        private int _mana;
        private int _maxmana;
        private int _pdmg;
        private int _armor;
        private int _mdef;
        private int _mdmg;
        private int _crtchance;
        private int _crtdmg;
        public Rogue()
        {
            Strength = 20;
            Dexterity = 30;
            Inteligence = 15;
            Vitality = 20;
            addVital();
        }
        public int Strength
        {
            get { return _str; }
            set
            {
                _str = value;
                if (_str > _maxstr)
                {
                    Strength = _maxstr;
                }
                addVital();
            }
        }
        public int Vitality
        {
            get { return _vit; }
            set
            {
                _vit = value;
                if (_vit > _maxvit)
                {
                    _vit = _maxvit;

                }
                addVital();
            }
        }
        public int Inteligence
        {
            get { return _int; }
            set 
            {
                _int = value;
                double manaleft = 0;
                int mp = 0;
                if (_int > _maxint)
                {
                    _int = _maxint;
                }
                for (int i = 0; i < _int; i++)
                {
                    mp += 1;
                    manaleft += 0.2;
                    if (manaleft >= 1)
                    {
                        mp += 1;
                        manaleft -= 1;
                    }
                }
                MaxMana = mp;
            }
        }
        public int Dexterity
        {
            get { return _dex; }
            set
            {
                _dex = value;
                if (_dex > _maxdex)
                {
                    _dex = _maxdex;
                }
            }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public int MaxHealth
        {
            get { return _maxhealth; }
            set
            {
                if (Health == MaxHealth)
                {
                    _maxhealth = value;
                    _health = value;
                }
                else
                    _maxhealth = value;
            }
        }
        public int Mana
        {
            get { return _mana; }
            set
            {
                _mana = value;
                if (_mana > _maxmana)
                    _mana = _maxmana;
            }
        }

        public int MaxMana
        {
            get { return _maxmana; }
            set
            {

                if (Mana == MaxMana)
                {
                    _maxmana = value;
                    _mana = _maxmana;
                }
                else
                    _maxmana = value;
            }
        }
        public int PDmg
        {
            get { return _pdmg; }
            set { _pdmg = value; }
        }
        public int Armor
        {
            get { return _armor; }
            set
            {
                _armor = value;
            }
        }
        public int MDef
        {
            get { return _mdef; }
            set
            {
                _mdef = value;
            }
        }
        public int MDmg
        {
            get { return _mdmg; }
            set { _mdmg = value; }
        }
        public int CrtChance
        {
            get { return _crtchance; }
            set { _crtchance = value; }
        }
        public int CrtDmg
        {
            get { return _crtdmg; }
            set
            {
                _crtdmg = value;
            }
        }
        public void addVital()
        {
            int hp = 0;
            double hpleft = 0;
            for (int i = 0; i < _vit; i++)
            {
                hp += 1;
                hpleft += 0.5;
                if (hpleft >= 1)
                {
                    hp += 1;
                    hpleft -= 1;
                }
            }
            for (int i = 0; i < _str; i++)
            {
                hpleft += 0.5;
                if (hpleft >= 1)
                {
                    hp += 1;
                    hpleft -= 1;
                }
            }
            MaxHealth = hp;
        }
    }
}


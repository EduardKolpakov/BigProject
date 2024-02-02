using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps.Serialization;

namespace WPFCharacters
{
    internal class Warrior : ICharacter
    {
        private int _str;
        private int _vit;
        private int _int;
        private int _dex;
        private int _maxstr = 250;
        private int _maxvit = 100;
        private int _maxint = 50;
        private int _maxdex = 80;
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
        public Warrior() 
            {
                Strength = 30;
                Dexterity = 15;
                Inteligence = 10;
                Vitality = 25;
                addVital();
            }
        public int Strength
        { 
            get { return _str; }
            set
            {
                _str = value;
                PDmg = value;
                if (_str > _maxstr)
                {
                    _str = _maxstr;
                }
                if (_str < 30)
                    _str = 30;
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
                if (_vit < 25)
                    _vit = 25;
                addVital();
            }
        }    
        public int Inteligence
        {
            get { return _int; }
            set
            {
                _int = value;
                int mp = 0;
                int mdmg = 0;
                double mdmg_b = 0;
                int mdef = 0;
                double mdef_b = 0;
                if (_int > _maxint)
                {
                    _int = _maxint;
                }
                if (_int < 10)
                    _int = 10;
                for (int i = 0; i < _int; i++)
                {
                    mp++;
                    mdmg_b += 0.2;
                    mdef_b += 0.5;
                    if (mdmg_b >= 1)
                    {
                        mdmg++;
                        mdmg_b--;
                    }
                    if (mdef_b >= 1)
                    {
                        mdef++;
                        mdef_b--;
                    }
                }
                MDef = mdef;
                MDmg = mdmg;
                MaxMana = mp;
            }
        }
        public int Dexterity
        {
            get { return _dex; }
            set
            {
                _dex = value;
                int crtch = 0;
                double crtch_b = 0;
                int crtdmg = 0;
                double crtdmg_b = 0;
                if (_dex > _maxdex)
                {
                    _dex = _maxdex;
                }
                if (_dex < 15)
                    _dex = 15;
                Armor = _dex;
                for (int i = 0; i <= _dex; i++)
                {
                    crtch_b += 0.2;
                    crtdmg_b += 0.1;
                    if (crtch_b >= 1)
                    {
                        crtch++;
                        crtch_b--;
                    }
                    if (crtdmg_b >= 1)
                    {
                        crtdmg++;
                        crtdmg_b--;
                    }
                }
                CrtChance = crtch;
                CrtDmg = crtdmg;
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
            for (int i = 0; i < _vit; i++)
            {
                hp += 2;
            }
            for (int i = 0; i < _str; i++)
            {
                hp++;
            }
            MaxHealth = hp;
        }
    }
}

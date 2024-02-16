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
        private int _exp;
        private int _lvl;
        private int _points;
        private int tStr;
        private int tDex;
        private int tInt;
        private IWeapon _weap = new NoWeapon();
        public Warrior() 
            {
                TStr = 30;
                TDex = 15;
                TInt = 10;
                Vitality = 25;
                exp = 0;
                StatsCalc();
            }
        public int Strength
        {
            get { return _str; }
            set
            {
                _str = value;

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
            }
        }
        public int Inteligence
        {
            get { return _int; }
            set
            {
                _int = value;

            }
        }
        public int Dexterity
        {
            get { return _dex; }
            set
            {
                _dex = value;

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
        public int level
        {
            get { return _lvl; }
            set
            {
                _lvl = value;
            }
        }
        public int exp
        {
            get { return _exp; }
            set
            {
                int oldlvl = level;
                _exp = value;
                level = _exp / 1000 + 1;
                if (level - oldlvl > 0)
                {
                    points += 5;
                }
            }
        }
        public int points
        {
            get { return _points; }
            set
            {
                _points = value;
                if (_points < 0)
                    _points = 0;
            }
        }
        public int TStr
        {
            get { return tStr; }
            set 
            {
                tStr = value;
                if (tStr > _maxstr)
                {
                    Strength = _maxstr;
                }
                if (tStr < 30)
                    tStr = 30;
                Strength = (int)Math.Floor(tStr * weapon.Str_b);
            }
        }
        public int TInt
        {
            get { return tInt; }
            set
            {
                tInt = value;
                if (tInt > _maxint)
                {
                    tInt = _maxint;
                }
                if (tInt < 15)
                    tInt = 15;
                Inteligence = (int)Math.Floor(tInt * weapon.Int_b);
            }
        }
        public int TDex
        {
            get { return tDex; }
            set 
            {
                tDex = value;
                if (tDex > _maxdex)
                {
                    tDex = _maxdex;
                }
                if (tDex < 15)
                    tDex = 15;
                Dexterity = (int)Math.Floor(tDex * weapon.Dex_b);
            }
        }
        public IWeapon weapon
        {
            get { return _weap; }
            set
            {
                _weap = value;
                StatsCalc();
            }
        }
        public void StatsCalc()
        {
            double hp_full = (Vitality * 2 + Strength) * weapon.hp_b;
            int hpr = (int)Math.Floor(hp_full);
            MaxHealth = hpr;
            double pdmb = Strength * weapon.PDmg_b;
            int pdm = (int)Math.Floor(pdmb);
            PDmg = pdm;
            int arm = Dexterity;
            Armor = arm;
            double manad = Inteligence * weapon.Mana_b + 0.00001;
            int mana = (int)Math.Floor(manad);
            MaxMana = mana;
            double crtc = Dexterity * 0.2;
            int crtch = (int)Math.Floor(crtc);
            CrtChance = crtch + weapon.CC_b;
            double crtd = Dexterity * 0.1;
            int crtdm = (int)Math.Floor(crtd);
            CrtDmg = crtdm + weapon.CD_b;
            double mdmg = Inteligence * 0.2;
            int mdm = (int)Math.Floor(mdmg);
            MDmg = mdm;
            double mdef = Inteligence * 0.5;
            int mdf = (int)Math.Floor(mdef);
            MDef = mdf;
        }
    }
}

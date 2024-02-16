using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFCharacters
{
    public partial class MainWindow : Window
    {
        ICharacter character;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_Initialized(object sender, EventArgs e)
        {
            class_select.Items.Add("Warrior");
            class_select.Items.Add("Rogue");
            class_select.Items.Add("Wizard");
        }

        private void class_select_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selected = class_select.SelectedValue.ToString();
            //class_select.Visibility = Visibility.Collapsed;
            classLabel.Content = $"Your character's class: {selected}";
            if (selected == "Rogue")
            {
                rogueImg.Visibility = Visibility.Visible;
                wizardImg.Visibility = Visibility.Hidden;
                warriorImg.Visibility = Visibility.Hidden;
                character = new Rogue();
            }
            else if (selected == "Warrior")
            {
                warriorImg.Visibility = Visibility.Visible;
                rogueImg.Visibility = Visibility.Hidden;
                wizardImg.Visibility = Visibility.Hidden;
                character = new Warrior();
            }
            else if (selected == "Wizard")
            {
                wizardImg.Visibility = Visibility.Visible;
                rogueImg.Visibility = Visibility.Hidden;
                warriorImg.Visibility = Visibility.Hidden;
                character = new Wizard();
            }
            curStr.Visibility = Visibility.Visible;
            curVit.Visibility = Visibility.Visible;
            curDex.Visibility = Visibility.Visible;
            curInt.Visibility = Visibility.Visible;
            curHp.Visibility = Visibility.Visible;
            curMp.Visibility = Visibility.Visible;
            phys_dmg.Visibility = Visibility.Visible;
            armor.Visibility = Visibility.Visible;
            mdmg.Visibility = Visibility.Visible;
            mdef.Visibility = Visibility.Visible;
            crtdmg.Visibility = Visibility.Visible;
            crtchance.Visibility = Visibility.Visible;
            statsUpdate();
            plusInt.Visibility = Visibility.Visible;
            plusDex.Visibility = Visibility.Visible;
            plusStr.Visibility = Visibility.Visible;
            plusVit.Visibility = Visibility.Visible;
            lvl_label.Visibility = Visibility.Visible;
            minusStr.Visibility = Visibility.Visible;
            minusVit.Visibility = Visibility.Visible;
            minusDex.Visibility = Visibility.Visible;
            minusInt.Visibility = Visibility.Visible;
            points.Visibility = Visibility.Visible;
            points_btn.Visibility = Visibility.Visible;
            points_btn1.Visibility = Visibility.Visible;
            points_btn2.Visibility = Visibility.Visible;
            exp_label.Visibility = Visibility.Visible;
            lvlupd();
            expupd();
            pointsUpd();

        }

        private void wizardImg_Initialized(object sender, EventArgs e)
        {
            wizardImg.Visibility = Visibility.Hidden;
        }

        private void curStr_Initialized(object sender, EventArgs e)
        {
            curStr.Visibility = Visibility.Hidden;
        }

        private void curVit_Initialized(object sender, EventArgs e)
        {
            curVit.Visibility = Visibility.Hidden;
        }

        private void curDex_Initialized(object sender, EventArgs e)
        {
            curDex.Visibility = Visibility.Hidden;
        }

        private void curInt_Initialized(object sender, EventArgs e)
        {
            curInt.Visibility = Visibility.Hidden;
        }

        private void curHp_Initialized(object sender, EventArgs e)
        {
            curHp.Visibility = Visibility.Hidden;
        }

        private void curMp_Initialized(object sender, EventArgs e)
        {
            curMp.Visibility = Visibility.Hidden;
        }

        private void plusStr_Initialized(object sender, EventArgs e)
        {
            plusStr.Visibility = Visibility.Hidden;
        }

        private void plusVit_Initialized(object sender, EventArgs e)
        {
            plusVit.Visibility = Visibility.Hidden;
        }

        private void plusDex_Initialized(object sender, EventArgs e)
        {
            plusDex.Visibility = Visibility.Hidden;
        }

        private void plusInt_initialized(object sender, EventArgs e)
        {
            plusInt.Visibility = Visibility.Hidden;
        }

        private void plusStr_Click(object sender, RoutedEventArgs e)
        {
            if (character.points > 0)
            {
                int oldstat = character.Strength;
                int dif;
                character.Strength++;
                dif = oldstat - character.Strength;
                character.points += dif;
                pointsUpd();
            }
            statsUpdate();
            
        }
        public void statsUpdate()
        {
            character.StatsCalc();
            Test.Content = $"test int: {character.it}\ntest int(raw): {character.it2}";
            curStr.Content = $"Your character's strength is {character.Strength}";
            curVit.Content = $"Your character's vitality is {character.Vitality}";
            curDex.Content = $"Your character's dexterity is {character.Dexterity}";
            curInt.Content = $"Your character's Inteligence is {character.Inteligence}";
            phys_dmg.Content = $"p.dmg: {character.PDmg}";
            armor.Content = $"armor: {character.Armor}";
            mdmg.Content = $"mdmg: {character.MDmg}";
            mdef.Content = $"mdef: {character.MDef}";
            crtchance.Content = $"Crt Chance: {character.CrtChance}";
            crtdmg.Content = $"Crt dmg: {character.CrtDmg}";
            curHp.Content = $"HP: {character.Health}";
            curMp.Content = $"MP: {character.Mana}";
        }

        private void plusVit_Click(object sender, RoutedEventArgs e)
        {
            if (character.points > 0)
            {
                int oldstat = character.Vitality;
                int dif;
                character.Vitality++;
                dif = oldstat - character.Vitality;
                character.points += dif;
                pointsUpd();
            }
            statsUpdate();
        }

        private void plusDex_Click(object sender, RoutedEventArgs e)
        {
            if (character.points > 0)
            {
                int oldstat = character.Dexterity;
                int dif;
                character.Dexterity++;
                dif = oldstat - character.Dexterity;
                character.points += dif;
                pointsUpd();
            }
            statsUpdate();
        }

        private void plusInt_Click(object sender, RoutedEventArgs e)
        {
            if (character.points > 0)
            {
                int oldstat = character.Inteligence;
                int dif;
                character.Inteligence++;
                dif = oldstat - character.Inteligence;
                character.points += dif;
                pointsUpd();
            }
            statsUpdate();
        }

        private void phys_dmg_Initialized(object sender, EventArgs e)
        {
            phys_dmg.Visibility = Visibility.Hidden;
        }

        private void armor_Initialized(object sender, EventArgs e)
        {
            armor.Visibility = Visibility.Hidden;
        }

        private void mdmg_initialized(object sender, EventArgs e)
        {
            mdmg.Visibility = Visibility.Hidden;
        }

        private void mdef_initialized(object sender, EventArgs e)
        {
            mdef.Visibility = Visibility.Hidden;
        }

        private void crtch_initialized(object sender, EventArgs e)
        {
            crtchance.Visibility = Visibility.Hidden;
        }

        private void crtdmg_initialized(object sender, EventArgs e)
        {
            crtdmg.Visibility= Visibility.Hidden;
        }

        private void minusStr_initialized(object sender, EventArgs e)
        {
            minusStr.Visibility = Visibility.Hidden;
        }

        private void minusStr_click(object sender, RoutedEventArgs e)
        {
            int oldstat = character.Strength;
            int diff;
            character.Strength--;
            diff = oldstat - character.Strength;
            character.points += diff;
            pointsUpd();
            statsUpdate();
        }

        private void minusVit_click(object sender, RoutedEventArgs e)
        {
            int oldstat = character.Vitality;
            int diff;
            character.Vitality--;
            diff = oldstat - character.Vitality;
            character.points += diff;
            pointsUpd();
            statsUpdate();
        }

        private void MinusDex_click(object sender, RoutedEventArgs e)
        {
            int oldstat = character.Dexterity;
            int diff;
            character.Dexterity--;
            diff = oldstat - character.Dexterity;
            character.points += diff;
            pointsUpd();
            statsUpdate();
        }

        private void minusInt_click(object sender, RoutedEventArgs e)
        {
            int oldstat = character.Inteligence;
            int diff;
            character.Inteligence--;
            diff = oldstat - character.Inteligence;
            character.points += diff;
            pointsUpd();
            statsUpdate();
        }

        private void points_Initialized(object sender, EventArgs e)
        {
            points.Visibility = Visibility.Hidden;
        }
        private void points_btn_Initialized(object sender, EventArgs e)
        {
            points_btn.Visibility = Visibility.Hidden;
        }

        private void points_btn_Click(object sender, RoutedEventArgs e)
        {
            character.exp += 100;
            lvlupd();
            expupd();
            pointsUpd();
        }

        private void MinusVit_initialized(object sender, EventArgs e)
        {
            minusVit.Visibility = Visibility.Hidden;
        }

        private void minusDex_initialized(object sender, EventArgs e)
        {
            minusDex.Visibility = Visibility.Hidden;
        }

        private void minusInt_initialized(object sender, EventArgs e)
        {
            minusInt.Visibility = Visibility.Hidden;
        }
        private void pointsUpd()
        {
            points.Content = $"Points: {character.points}";
        }

        private void points_btn2_Click(object sender, RoutedEventArgs e)
        {
            character.exp += 1000;
            lvlupd();
            expupd();
            pointsUpd();
        }

        private void points_btn1_Click(object sender, RoutedEventArgs e)
        {
            character.exp += 500;
            lvlupd();
            expupd();
            pointsUpd();
        }

        private void lvl_label_Initialized(object sender, EventArgs e)
        {
            lvl_label.Visibility = Visibility.Hidden;
        }

        private void points_btn1_Initialized(object sender, EventArgs e)
        {
            points_btn1.Visibility = Visibility.Hidden;
        }

        private void points_btn2_Initialized(object sender, EventArgs e)
        {
            points_btn2.Visibility = Visibility.Hidden;
        }
        private void lvlupd()
        {
            lvl_label.Content = $"Level: {character.level}";
        }

        private void exp_label_Initialized(object sender, EventArgs e)
        {
            exp_label.Visibility = Visibility.Hidden;
        }
        private void expupd()
        {
            exp_label.Content = $"exp: {character.exp}";
        }

        private void Test_Loaded(object sender, RoutedEventArgs e)
        {
            Test.Content = "Hi";
        }
    }
}
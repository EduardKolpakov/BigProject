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
        int p;
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
            class_select.Visibility = Visibility.Collapsed;
            classLabel.Content = $"Your character's class: {selected}";
            if (selected == "Rogue")
            {
                rogueImg.Visibility = Visibility.Visible;
                character = new Rogue();
            }
            else if (selected == "Warrior")
            {
                warriorImg.Visibility = Visibility.Visible;
                character = new Warrior();
            }
            else if (selected == "Wizard")
            {
                wizardImg.Visibility = Visibility.Visible;
                character = new Wizard();
            }
            curStr.Visibility = Visibility.Visible;
            curVit.Visibility = Visibility.Visible;
            curDex.Visibility = Visibility.Visible;
            curInt.Visibility = Visibility.Visible;
            curHp.Visibility = Visibility.Visible;
            curMp.Visibility = Visibility.Visible;
            statsUpdate();
            plusInt.Visibility = Visibility.Visible;
            plusDex.Visibility = Visibility.Visible;
            plusStr.Visibility = Visibility.Visible;
            plusVit.Visibility = Visibility.Visible;
            statpoint.Visibility = Visibility.Visible;

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
            character.Strength += Convert.ToInt32(statpoint.Text);
            statsUpdate();
            
        }
        public void statsUpdate()
        {
            curStr.Content = $"Your character's strength is {character.Strength.ToString()}";
            curVit.Content = $"Your character's vitality is {character.Vitality.ToString()}";
            curDex.Content = $"Your character's dexterity is {character.Dexterity.ToString()}";
            curInt.Content = $"Your character's Inteligence is {character.Inteligence.ToString()}";
            curHp.Content = $"HP: {character.Health}";
            curMp.Content = $"MP: {character.Mana}";
        }

        private void plusVit_Click(object sender, RoutedEventArgs e)
        {
            character.Vitality += Convert.ToInt32(statpoint.Text);
            statsUpdate();
        }

        private void plusDex_Click(object sender, RoutedEventArgs e)
        {
            character.Dexterity += Convert.ToInt32(statpoint.Text);
            statsUpdate();
        }

        private void plusInt_Click(object sender, RoutedEventArgs e)
        {
            character.Inteligence += Convert.ToInt32(statpoint.Text);
            statsUpdate();
        }

        private void statpoint_Initialized(object sender, EventArgs e)
        {
            statpoint.Visibility = Visibility.Hidden;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DungeonsAndDragons
{
    public partial class Form2 : Form
        
    {
        int diceSides = 0;
        int damage=0;
        int warriorHPmax;
        int mageHPmax;
        int lvl; //for future purposes
        int currentHP;
        int monsterHPmax;
        int monsterHPcurrent;
        int playerClass; //0 for mage, 1 for warrior (this is for damage modifiers);

        public Form2()
        {
            var random = new Random();
            InitializeComponent();
            lvl = 1;
            warriorHPmax = random.Next(120, 150);
            mageHPmax = random.Next(90, 130);
            monsterHPmax = random.Next(150, 200);
            monsterHPcurrent = monsterHPmax;
            warriorHP.Hide();
            mageHP.Hide();
            monsterImg.Hide();
            deadMonster.Hide();
            deadPlayer.Hide();
            diceBox.Hide();
            logs.Hide();
            currentDice.Hide();
        }
        private void hpCalculator(int playerdmg, int monsterdmg)
        {
            currentHP = currentHP - monsterdmg;
            monsterHPcurrent = monsterHPcurrent - playerdmg;
            monsterHP.Text = monsterHPcurrent.ToString() + "/" + monsterHPmax.ToString();
            warriorHP.Text = currentHP.ToString() + "/" + warriorHPmax.ToString();
            mageHP.Text = currentHP.ToString() + "/" + mageHPmax.ToString();
            
        }
        private void warriorImg_Click(object sender, EventArgs e)
        {
            mageImg.Hide();
            classLabel.Text = "You are now a Warrior.";
            currentHP = warriorHPmax;
            playerClass = 1;
            warriorHP.Text = currentHP.ToString() + "/" + warriorHPmax.ToString();
            warriorHP.Show();
            monsterImg.Show();
            monsterHP.Text = monsterHPcurrent.ToString() + "/" + monsterHPmax.ToString();
            monsterHP.Show();
            diceBox.Show();
            logs.Show();
        }

        private void mageImg_Click(object sender, EventArgs e)
        {
            warriorImg.Hide();
            classLabel.Text = "You are now a Mage.";
            currentHP = mageHPmax;
            playerClass = 0;
            mageHP.Text = currentHP.ToString() + "/" + mageHPmax.ToString();
            mageHP.Show();
            monsterImg.Show();
            monsterHP.Text = monsterHPcurrent.ToString() + "/" + monsterHPmax.ToString();
            monsterHP.Show();
            diceBox.Show();
            logs.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            rolls.Text = "your rolls: ";
            var random = new Random();
            int diceCount = int.Parse(numberOfDice.Text);
            
            
            for(int i = 0; i < diceCount; i++)
            {
                int temp = 0;
                temp = random.Next(1, diceSides);
                damage = temp+ damage;
                rolls.Text= rolls.Text + temp.ToString() + ", ";
            }
            
            
            int monsterdmg = random.Next(0, 20);

            output.Text="You have dealt " + damage.ToString() + " damage!!!";

            monsterOutput.Text = "The monster dealt " + monsterdmg.ToString() + " damage to you!";
            
            hpCalculator(damage, monsterdmg);
            
            
            if (monsterHPcurrent < 1)
            {
                deadMonster.Show();
                monsterOutput.Text = "Monster is now dead!";
                output.Text = "You Won!";
            } else if(currentHP < 1) 
            {
                deadPlayer.Show();
                monsterOutput.Text = "Monster came out victorious!";
                output.Text = "You Lost, take a big L!";
            }
            rollButton.Hide();
        }
        private void hideDice()
        {
            d6.Hide(); D6cur.Hide();
            d10.Hide(); D10cur.Hide();
            d12.Hide(); D12cur.Hide();
            d20.Hide(); D20cur.Hide();
            d4.Hide();  D4cur.Hide();
            diceChoose.Hide();
            currentDice.Show();
        }
        private void d4_Click(object sender, EventArgs e)
        {
            diceSides = 4;
            hideDice();
            D4cur.Show();
        }

        private void d6_Click(object sender, EventArgs e)
        {
            diceSides = 6;
            hideDice();
            D6cur.Show();
        }
            private void showDices()
        {
            d4.Show();
            d6.Show();
            d10.Show();
            d12.Show();
            d20.Show();
            currentDice.Hide();
            diceChoose.Show();
        }

        private void reRollButton_Click(object sender, EventArgs e)
        {
            rolls.Text = "";
            showDices();
            damage = 0;
            rollButton.Show();
        }

        private void d10_Click(object sender, EventArgs e)
        {
            diceSides = 10;
            hideDice();
            D10cur.Show();
        }

        private void d12_Click(object sender, EventArgs e)
        {
            diceSides = 12;
            hideDice();
            D12cur.Show();
        }

        private void d20_Click(object sender, EventArgs e)
        {
            diceSides = 20;
            hideDice();
            D20cur.Show();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

    }
}

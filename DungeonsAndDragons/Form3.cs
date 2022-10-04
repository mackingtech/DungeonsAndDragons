using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace DungeonsAndDragons
{
    public partial class Form3 : Form
    {
        int diceSides;
        int damage;
        public Form3()
        {
            InitializeComponent();
            damage = 0;
            diceNumGroup.Hide();
            reRollButton.Hide();
            
        }

        private void d4_Click(object sender, EventArgs e)
        {
            diceSides = 4;
            d6.Hide();
            d10.Hide();
            d12.Hide();
            d20.Hide();
            diceNumGroup.Show(); reRollButton.Show();
        }
        private void d6_Click_1(object sender, EventArgs e)
        {
            diceSides = 6;
            d4.Hide();
            d10.Hide();
            d12.Hide();
            d20.Hide();
            diceNumGroup.Show(); reRollButton.Show();
        }

        private void d10_Click(object sender, EventArgs e)
        {
            diceSides = 10;
            d12.Hide();
            d20.Hide();
            d4.Hide();
            d6.Hide();
            diceNumGroup.Show(); reRollButton.Show();
        }

        private void d12_Click(object sender, EventArgs e)
        {
            diceSides = 12;
            d10.Hide();
            d20.Hide();
            d4.Hide();
            d6.Hide();
            diceNumGroup.Show(); reRollButton.Show();
        }

        private void d20_Click(object sender, EventArgs e)
        {
            diceSides = 20;
            d12.Hide();
            d10.Hide();
            d4.Hide();
            d6.Hide();
            diceNumGroup.Show(); reRollButton.Show();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            rolls.Text = "your rolls: ";
            var rand = new Random();
            for (int i = 0; i < numberOfDice.Value; i++)
            {
                output.Text = "";
                int temp = 0;
                temp = rand.Next(0, diceSides)+1;
                damage = temp + damage;
                rolls.Text = rolls.Text + temp.ToString() + ", ";
            }
            output.Text = "You roll " + numberOfDice.Value+"D"+diceSides+ "\n Your result is: " + damage;
            rollButton.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void reRollButton_Click(object sender, EventArgs e)
        {
            rolls.Text = "";
            showDices();
            damage = 0;
            rollButton.Show();
            numberOfDice.Value = 0;
            diceNumGroup.Hide();
        }
        private void showDices()
        {
            d4.Show();
            d6.Show();
            d10.Show();
            d12.Show();
            d20.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}

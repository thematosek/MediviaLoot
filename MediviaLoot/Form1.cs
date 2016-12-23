using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediviaLoot
{
    
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
        }

    
    
        public void Refresher()
        {
           Globals.suma = Globals.vikinghelmetprice + Globals.maceprice + Globals.brasshelmetprice + Globals.chainarmorprice + Globals.swordprice + Globals.halberdprice + Globals.battleaxeprice + Globals.plateshieldprice + Globals.crossbowprice + Globals.brassarmorprie + Globals.hatchetprice + Globals.battleshieldprice + Globals.battlehammerprice + Globals.dwarvenshieldprice + Globals.goldcoinprice - Globals.uhprice;

          
               sum.Text = "Value: " + Globals.suma + "GP";
         
    
           
            
            
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Globals.chainarmorprice = Decimal.ToInt32(numericUpDown1.Value) * 70;
            Refresher();

            
            Globals.chainarmors = numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Globals.maceprice = Decimal.ToInt32(numericUpDown2.Value) * 30;
            Refresher();
            Globals.maces = numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
             Globals.brasshelmetprice = Decimal.ToInt32(numericUpDown3.Value) * 30;
             Refresher();
             Globals.brasshelmets = numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Globals.vikinghelmetprice = Decimal.ToInt32(numericUpDown4.Value) * 66;
            Refresher();
            Globals.vikinghelmets = numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            Globals.swordprice = Decimal.ToInt32(numericUpDown5.Value) * 25;
            Refresher();
            Globals.swords = numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            Globals.halberdprice = Decimal.ToInt32(numericUpDown6.Value) * 400;
            Refresher();
            Globals.halberds = numericUpDown6.Value;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            Globals.battleaxeprice = Decimal.ToInt32(numericUpDown7.Value) * 80;
            Refresher();
            Globals.battleaxes = numericUpDown7.Value;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            Globals.plateshieldprice = Decimal.ToInt32(numericUpDown8.Value) * 45;
            Refresher();
            Globals.plateshields = numericUpDown8.Value;
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            Globals.hatchetprice = Decimal.ToInt32(numericUpDown9.Value) * 25;
            Refresher();
            Globals.hatchets = numericUpDown9.Value; 
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            Globals.crossbowprice = Decimal.ToInt32(numericUpDown10.Value) * 160;
            Refresher();
            Globals.crossbows = numericUpDown10.Value; 
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            Globals.dwarvenshieldprice = Decimal.ToInt32(numericUpDown11.Value) * 100;
            Refresher();
            Globals.dwarvenshields = numericUpDown11.Value;
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            Globals.battlehammerprice = Decimal.ToInt32(numericUpDown12.Value) * 120;
            Refresher();
            Globals.battlehammers = numericUpDown12.Value; 
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            Globals.battleshieldprice = Decimal.ToInt32(numericUpDown13.Value) * 95;
            Refresher();
            Globals.battleshields = numericUpDown13.Value; 
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            Globals.brassarmorprie = Decimal.ToInt32(numericUpDown14.Value) * 150;
            Refresher();
            Globals.brassarmors = numericUpDown14.Value;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form2 counter = new Form2();
            counter.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label3.Visible = Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Globals.timer = Globals.timer + 1;
            Globals.perhour = Globals.suma / Globals.timer * 14480;
            label3.Text = Math.Round(Globals.perhour) +  "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown1.Value + 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = numericUpDown2.Value + 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            numericUpDown3.Value = numericUpDown3.Value + 1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            numericUpDown4.Value = numericUpDown4.Value + 1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            numericUpDown5.Value = numericUpDown5.Value + 1;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            numericUpDown6.Value = numericUpDown6.Value + 1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            numericUpDown7.Value = numericUpDown7.Value + 1;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            numericUpDown8.Value = numericUpDown8.Value + 1;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            numericUpDown9.Value = numericUpDown9.Value + 1;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            numericUpDown10.Value = numericUpDown10.Value + 1;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            numericUpDown11.Value = numericUpDown11.Value + 1;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            numericUpDown12.Value = numericUpDown12.Value + 1;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            numericUpDown13.Value = numericUpDown13.Value + 1;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            numericUpDown14.Value = numericUpDown14.Value + 1;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            numericUpDown15.Value = numericUpDown15.Value + 1;
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            Globals.goldcoinprice = Decimal.ToInt32(numericUpDown15.Value) * 100;
            Refresher();
            Globals.goldcoins = numericUpDown15.Value;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            numericUpDown16.Value = numericUpDown16.Value + 1;
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            Globals.uhprice = Decimal.ToInt32(numericUpDown16.Value) * 100;
            Refresher();
            Globals.uhs = numericUpDown16.Value;
        }

      

   
        

       

       
    }
    public static class Globals
    {
        public static int suma, vikinghelmetprice, maceprice, brasshelmetprice, chainarmorprice, swordprice, halberdprice, battleaxeprice, plateshieldprice, crossbowprice, brassarmorprie, hatchetprice, battleshieldprice, battlehammerprice, dwarvenshieldprice, goldcoinprice, uhprice;
        public static decimal vikinghelmets, maces, brasshelmets, chainarmors, swords, halberds, battleaxes, plateshields, crossbows, brassarmors, hatchets, battleshields, battlehammers, dwarvenshields, goldcoins, uhs, value;
        public static string sumvalue;
        public static float timer;
        public static float perhour;
    }
    
}

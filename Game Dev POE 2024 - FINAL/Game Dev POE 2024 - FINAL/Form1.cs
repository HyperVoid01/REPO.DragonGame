using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Dev_POE_2024___FINAL
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        //Player 1 & 2 Arrays
        //0 - Player Name, 1 - Dragon Name, 2 - Dragon Type
        public string[] p1Data = new string[3];
        public string[] p2Data = new string[3];
        //0 - Health Points, 1 - Attack Dmg, 2 - Special Attack Dmg, 3 - Block Dmg
        public int[] p1Values = new int[4];
        public int[] p2Values = new int[4];

        //Fire Dragon Constants
        const string FIRE_DRAG_NAME = "Fire";
        const int FIRE_DRAG_HP = 20;
        const int FIRE_DRAG_ATK = 5;
        const int FIRE_DRAG_SPATK = 12;
        const int FIRE_DRAG_BLOCK = 4;

        //Ice Dragon Constants
        const string ICE_DRAG_NAME = "Ice";
        const int ICE_DRAG_HP = 30;
        const int ICE_DRAG_ATK = 4;
        const int ICE_DRAG_SPATK = 9;
        const int ICE_DRAG_BLOCK = 5;

        //Wind Dragon Constants
        const string WIND_DRAG_NAME = "Wind";
        const int WIND_DRAG_HP = 40;
        const int WIND_DRAG_ATK = 3;
        const int WIND_DRAG_SPATK = 7;
        const int WIND_DRAG_BLOCK = 5;

        //Earth Dragon Constants
        const string EARTH_DRAG_NAME = "Earth";
        const int EARTH_DRAG_HP = 50;
        const int EARTH_DRAG_ATK = 2;
        const int EARTH_DRAG_SPATK = 5;
        const int EARTH_DRAG_BLOCK = 6;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        void SaveValues(string[] data, int[] values)
        {
            
            if (data[2] == FIRE_DRAG_NAME)
            {
                values[0] = FIRE_DRAG_HP;
                values[1] = FIRE_DRAG_ATK;
                values[2] = FIRE_DRAG_SPATK;
                values[3] = FIRE_DRAG_BLOCK;
            }
            else if (data[2] == ICE_DRAG_NAME)
            {
                values[0] = ICE_DRAG_HP;
                values[1] = ICE_DRAG_ATK;
                values[2] = ICE_DRAG_SPATK;
                values[3] = ICE_DRAG_BLOCK;
            }
            else if (data[2] == WIND_DRAG_NAME)
            {
                values[0] = WIND_DRAG_HP;
                values[1] = WIND_DRAG_ATK;
                values[2] = WIND_DRAG_SPATK;
                values[3] = WIND_DRAG_BLOCK;
            }
            else if (data[2] == EARTH_DRAG_NAME)
            {
                values[0] = EARTH_DRAG_HP;
                values[1] = EARTH_DRAG_ATK;
                values[2] = EARTH_DRAG_SPATK;
                values[3] = EARTH_DRAG_BLOCK;
            }

        }
        
        void btnPlayerSave1_Click(object sender, EventArgs e)
        {
            if (txtPlayerName1.Text != "" && txtDragonName1.Text != "")
            {
                if (p1Data[2] != "")
                {
                    SaveValues(p1Data,p1Values);
                    p1Data[0] = txtPlayerName1.Text;
                    p1Data[1] = txtDragonName1.Text;

                    btnPlayerSave1.Enabled = false;
                    txtPlayerName1.Enabled = false;
                    txtDragonName1.Enabled = false;
                    radEarthDragon1.Enabled = false;
                    radWindDragon1.Enabled = false;
                    radFireDragon1.Enabled = false;
                    radIceDragon1.Enabled = false;

                    if (btnPlayerSave1.Enabled == false && btnPlayerSave2.Enabled == false)
                        btnStartGame.Enabled = true;
                }
            }
        }

        private void btnPlayerSave2_Click(object sender, EventArgs e)
        {
            if (txtPlayerName2.Text != "" && txtDragonName2.Text != "")
            {
                if (p2Data[2] != "")
                {
                    SaveValues(p2Data,p2Values);
                    p2Data[0] = txtPlayerName2.Text;
                    p2Data[1] = txtDragonName2.Text;

                    btnPlayerSave2.Enabled = false;
                    txtPlayerName2.Enabled = false;
                    txtDragonName2.Enabled = false;
                    radEarthDragon2.Enabled = false;
                    radWindDragon2.Enabled = false;
                    radFireDragon2.Enabled = false;
                    radIceDragon2.Enabled = false;

                    if (btnPlayerSave1.Enabled == false && btnPlayerSave2.Enabled == false)
                        btnStartGame.Enabled = true;
                }
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void radFireDragon1_CheckedChanged(object sender, EventArgs e)
        {
            p1Data[2] = FIRE_DRAG_NAME;
        }

        private void radIceDragon1_CheckedChanged(object sender, EventArgs e)
        {
            p1Data[2] = ICE_DRAG_NAME;
        }

        private void radWindDragon1_CheckedChanged(object sender, EventArgs e)
        {
            p1Data[2] = WIND_DRAG_NAME;
        }

        private void radEarthDragon1_CheckedChanged(object sender, EventArgs e)
        {
            p1Data[2] = EARTH_DRAG_NAME;
        }

        private void radFireDragon2_CheckedChanged(object sender, EventArgs e)
        {
            p2Data[2] = FIRE_DRAG_NAME;
        }

        private void radIceDragon2_CheckedChanged(object sender, EventArgs e)
        {
            p2Data[2] = ICE_DRAG_NAME;
        }

        private void radWindDragon2_CheckedChanged(object sender, EventArgs e)
        {
            p2Data[2] = WIND_DRAG_NAME;
        }

        private void radEarthDragon2_CheckedChanged(object sender, EventArgs e)
        {
            p2Data[2] = EARTH_DRAG_NAME;
        }
    }
}

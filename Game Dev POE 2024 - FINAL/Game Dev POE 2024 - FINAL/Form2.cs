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
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        int playerturn; //1 - player1, 2 - player2
        int damage; //Used to display damage dealt, even after block
        int roundCounter = 1;
        bool blockFlag1 = false; //Player 1 block
        bool blockFlag2 = false; //Player 2 block
        public Form2()
        {
            InitializeComponent();
            Instance = this;
            TakeInitiative();
        }
        int RandomRoll()
        {
            Random Diceroll = new Random();
            int roll = Diceroll.Next(1,7);
            return roll;
        }

        void TakeInitiative()
        {
            int p1Roll = 0;
            int p2Roll = 0;
            while (p1Roll == p2Roll)
            {
                p1Roll = RandomRoll();
                p2Roll = RandomRoll();
            }
            if (p1Roll > p2Roll)
                Player1Customise();
            else if (p2Roll >  p1Roll)
                Player2Customise();
        }

        void Player1Customise() //Player 1 Initiative
        {
            playerturn = 1;
            rtbBattleLog.Text += $"\n***********************\n{Form1.instance.p1Data[0]}'s Turn:";
            gbxPlayerTurn.Text = $"{Form1.instance.p1Data[1]}, the {Form1.instance.p1Data[2]} Dragon's Turn"; //Dragon Name, Dragon Type
            Form2.Instance.Text = $"{Form1.instance.p1Data[0]}'s Turn"; //Player Name
            lblPlayerTurnHp.Text = $"HP: {Form1.instance.p1Values[0]}"; //HP
            lblOpponentDragon.Text = $"{Form1.instance.p2Data[1]}, the {Form1.instance.p2Data[2]} Dragon"; //Opponent Dragon Name, Dragon Type
            gbxOpponent.Text = $"Opponent: {Form1.instance.p2Data[0]}"; //Opponent Player Name
            lblOpponentHp.Text = $"HP: {Form1.instance.p2Values[0]}"; //Opponent HP
        }

        void Player2Customise() //Player 2 Initiative
        {
            playerturn = 2;
            rtbBattleLog.Text += $"\n***********************\n{Form1.instance.p2Data[0]}'s Turn:";
            gbxPlayerTurn.Text = $"{Form1.instance.p2Data[1]}, the {Form1.instance.p2Data[2]} Dragon's Turn"; //Dragon Name, Dragon Type
            Form2.Instance.Text = $"{Form1.instance.p2Data[0]}'s Turn"; //Player Name
            lblPlayerTurnHp.Text = $"HP: {Form1.instance.p2Values[0]}"; //HP
            lblOpponentDragon.Text = $"{Form1.instance.p1Data[1]}, the {Form1.instance.p1Data[2]} Dragon"; //Opponent Dragon Name, Dragon Type
            gbxOpponent.Text = $"Opponent: {Form1.instance.p1Data[0]}"; //Opponent Player Name
            lblOpponentHp.Text = $"HP: {Form1.instance.p1Values[0]}"; //Opponent HP
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (playerturn == 1)
                Player1Attack();
            else if (playerturn == 2)
                Player2Attack();
        }

        private void btnSpecialAttack_Click(object sender, EventArgs e)
        {

        }

        private void btnBlock_Click(object sender, EventArgs e)
        {

        }

        void Player1Attack()
        {
            if (blockFlag2 == false)
            {
                damage = Form1.instance.p1Values[1];
                Form1.instance.p2Values[0] -= damage;
                rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} attacks {Form1.instance.p2Data[1]} for {damage} damage!";
                rtbBattleLog.Text += $"\n***********************\n";
            }
            else if (blockFlag2 == true)
            {
                if (Form1.instance.p2Values[3] > Form1.instance.p1Values[1])
                {
                    damage = 0;
                    rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} blocks {Form1.instance.p1Data[1]}'s whole attacks!";
                    rtbBattleLog.Text += $"\n***********************\n";
                }
                else damage = Form1.instance.p1Values[1] - Form1.instance.p2Values[3];
                Form1.instance.p2Values[0] -= damage;
                rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} attacks {Form1.instance.p2Data[1]} for {damage} damage!";
                rtbBattleLog.Text += $"\n***********************\n";
            }
        }
        void Player2Attack()
        {
            if (blockFlag1 == false)
            {
                damage = Form1.instance.p2Values[1];
                Form1.instance.p1Values[0] -= damage;
                rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} attacks {Form1.instance.p1Data[1]} for {damage} damage!";
                rtbBattleLog.Text += $"\n***********************\n";
            }
            else if (blockFlag1 == true)
            {
                if (Form1.instance.p1Values[3] > Form1.instance.p2Values[1])
                {
                    damage = 0;
                    rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} blocks {Form1.instance.p2Data[1]}'s whole attacks!";
                    rtbBattleLog.Text += $"\n***********************\n";
                }
                else damage = Form1.instance.p2Values[1] - Form1.instance.p1Values[3];
                Form1.instance.p1Values[0] -= damage;
                rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} attacks {Form1.instance.p1Data[1]} for {damage} damage!";
                rtbBattleLog.Text += $"\n***********************\n";
            }
        }
    }
}

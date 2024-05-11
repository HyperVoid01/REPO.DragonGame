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
        int playerturn; //Helps determine who has initiative
        int damage; //Used to display damage dealt, includes blocked attacks
        int roundCounter = 0; //Counts how many turns have gone by
        bool blockFlag1 = false; //Player 1 block
        bool blockFlag2 = false; //Player 2 block
        bool rest1 = false; //If dragon 1 chooses to special atk
        bool rest2 = false; //If dragon 2 chooses to special atk
        public Form2()
        {
            InitializeComponent();
            Instance = this;
            TakeInitiative();
        }

        void Rounds() //Rerolls for initiative every round or every 2 turns
        {
            roundCounter++;
            if (roundCounter == 2)
            {
                roundCounter = 0;
                TakeInitiative();
            }
            else if (playerturn == 1)
                Player2Customise();
            else if (playerturn == 2)
                Player1Customise();
        }
        int RandomRoll() //Rolls dice of 6
        {
            Random Diceroll = new Random();
            int roll = Diceroll.Next(1,7);
            return roll;
        }

        void TakeInitiative() // Rolls 2 dice and determines which player takes initiative
        {
            int p1Roll = 0;
            int p2Roll = 0;
            while (p1Roll == p2Roll)
            {
                p1Roll = RandomRoll();
                p2Roll = RandomRoll();
            }
            if (p1Roll > p2Roll) // Player 1 takes initiative
                Player1Customise();
            else if (p2Roll >  p1Roll) //Player 2 takes initiative
                Player2Customise();
        }

        void Player1Customise() //Player 1 Initiative - switches info to player 1's turn
        {
            playerturn = 1;
            rtbBattleLog.Text += $"\n{Form1.instance.p1Data[0]}'s Turn:";
            gbxPlayerTurn.Text = $"{Form1.instance.p1Data[1]}, the {Form1.instance.p1Data[2]} Dragon's Turn"; //Dragon Name, Dragon Type
            Form2.Instance.Text = $"{Form1.instance.p1Data[0]}'s Turn"; //Player Name
            lblPlayerTurnHp.Text = $"HP: {Form1.instance.p1Values[0]}"; //HP
            lblOpponentDragon.Text = $"{Form1.instance.p2Data[1]}, the {Form1.instance.p2Data[2]} Dragon"; //Opponent Dragon Name, Dragon Type
            gbxOpponent.Text = $"Opponent: {Form1.instance.p2Data[0]}"; //Opponent Player Name
            lblOpponentHp.Text = $"HP: {Form1.instance.p2Values[0]}"; //Opponent HP

            if (rest1 == true)
            {
                btnRest.Enabled = true;
                btnRest.Visible = true;
                btnAttack.Enabled = false;
                btnAttack.Visible = false;
                btnSpecialAttack.Enabled = false;
                btnSpecialAttack.Visible = false;
                btnBlock.Enabled = false;
                btnBlock.Visible = false;
            }
        }

        void Player2Customise() //Player 2 Initiative - switches info to player 2's turn
        {
            playerturn = 2;
            rtbBattleLog.Text += $"\n{Form1.instance.p2Data[0]}'s Turn:";
            gbxPlayerTurn.Text = $"{Form1.instance.p2Data[1]}, the {Form1.instance.p2Data[2]} Dragon's Turn"; //Dragon Name, Dragon Type
            Form2.Instance.Text = $"{Form1.instance.p2Data[0]}'s Turn"; //Player Name
            lblPlayerTurnHp.Text = $"HP: {Form1.instance.p2Values[0]}"; //HP
            lblOpponentDragon.Text = $"{Form1.instance.p1Data[1]}, the {Form1.instance.p1Data[2]} Dragon"; //Opponent Dragon Name, Dragon Type
            gbxOpponent.Text = $"Opponent: {Form1.instance.p1Data[0]}"; //Opponent Player Name
            lblOpponentHp.Text = $"HP: {Form1.instance.p1Values[0]}"; //Opponent HP

            if (rest2 == true)
            {
                btnRest.Enabled = true;
                btnRest.Visible = true;
                btnAttack.Enabled = false;
                btnAttack.Visible = false;
                btnSpecialAttack.Enabled = false;
                btnSpecialAttack.Visible = false;
                btnBlock.Enabled = false;
                btnBlock.Visible = false;
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (playerturn == 1)
                Player1Attack();
            else if (playerturn == 2)
                Player2Attack();
            Rounds();
        }

        private void btnSpecialAttack_Click(object sender, EventArgs e)
        {
            if (playerturn == 1)
                Player1Special();
            else if (playerturn == 2)
                Player2Special();
            Rounds();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (playerturn == 1)
                Player1Block();
            else if (playerturn == 2)
                Player2Block();
            Rounds();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (playerturn == 1)
                Player1Rest();
            else if (playerturn == 2)
                Player2Rest();
            Rounds();
        }

        void Player1Attack()
        {
            if (blockFlag2 == false) //If player 2 doesn't block
            {
                damage = Form1.instance.p1Values[1];
                Form1.instance.p2Values[0] -= damage;
                rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} attacks {Form1.instance.p2Data[1]} for {damage} damage!";
                rtbBattleLog.Text += $"\n***********************\n";
            }
            else if (blockFlag2 == true) //If player 2 blocks
            {
                if (Form1.instance.p2Values[3] > Form1.instance.p1Values[1]) //If block is greater than attack
                {
                    damage = 0;
                    rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} blocks {Form1.instance.p1Data[1]}'s whole attacks!";
                    rtbBattleLog.Text += $"\n***********************\n";
                }
                else //Attack greater than block
                {
                    damage = Form1.instance.p1Values[1] - Form1.instance.p2Values[3];
                    Form1.instance.p2Values[0] -= damage;
                    rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} attacks {Form1.instance.p2Data[1]} for {damage} damage!";
                    rtbBattleLog.Text += $"\n***********************\n";
                }
            }
            blockFlag2 = false;
        }
        void Player2Attack()
        {
            if (blockFlag1 == false) //If player 1 doesn't block
            {
                damage = Form1.instance.p2Values[1];
                Form1.instance.p1Values[0] -= damage;
                rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} attacks {Form1.instance.p1Data[1]} for {damage} damage!";
                rtbBattleLog.Text += $"\n***********************\n";
            }
            else if (blockFlag1 == true) //If player 1 blocks
            {
                if (Form1.instance.p1Values[3] > Form1.instance.p2Values[1]) //Block greater than attack
                {
                    damage = 0;
                    rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} blocks {Form1.instance.p2Data[1]}'s whole attacks!";
                    rtbBattleLog.Text += $"\n***********************\n";
                }
                else //Attack greater than block
                {
                    damage = Form1.instance.p2Values[1] - Form1.instance.p1Values[3];
                    Form1.instance.p1Values[0] -= damage;
                    rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} attacks {Form1.instance.p1Data[1]} for {damage} damage!";
                    rtbBattleLog.Text += $"\n***********************\n";
                }
            }
            blockFlag1 = false;
        }

        void Player1Block()
        {
            blockFlag1 = true;
            blockFlag2 = false;
            rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} chooses to block!";
            rtbBattleLog.Text += $"\n***********************\n";
        }
        void Player2Block()
        {
            blockFlag2 = true;
            blockFlag1 = false;
            rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} chooses to block!";
            rtbBattleLog.Text += $"\n***********************\n";
        }
        void Player1Special()
        {
            if (blockFlag2 == false) //If player 2 doesn't block
            {
                damage = Form1.instance.p1Values[2];
                Form1.instance.p2Values[0] -= damage;
                rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} special attacks {Form1.instance.p2Data[1]} for {damage} damage!";
                rtbBattleLog.Text += $"\n***********************\n";
            }
            else if (blockFlag2 == true) //If player 2 blocks
            {
                if (Form1.instance.p2Values[3] > Form1.instance.p1Values[2]) //If block is greater than attack
                {
                    damage = 0;
                    rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} blocks {Form1.instance.p1Data[1]}'s whole attacks!";
                    rtbBattleLog.Text += $"\n***********************\n";
                }
                else //Attack greater than block
                {
                    damage = Form1.instance.p1Values[2] - Form1.instance.p2Values[3];
                    Form1.instance.p2Values[0] -= damage;
                    rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} special attacks {Form1.instance.p2Data[1]} for {damage} damage!";
                    rtbBattleLog.Text += $"\n***********************\n";
                }
            }
            blockFlag2 = false;
            rest1 = true;
        }
        void Player2Special()
        {
            if (blockFlag1 == false) //If player 1 doesn't block
            {
                damage = Form1.instance.p2Values[2];
                Form1.instance.p1Values[0] -= damage;
                rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} attacks {Form1.instance.p1Data[1]} for {damage} damage!";
                rtbBattleLog.Text += $"\n***********************\n";
            }
            else if (blockFlag1 == true) //If player 1 blocks
            {
                if (Form1.instance.p1Values[3] > Form1.instance.p2Values[2]) //Block greater than attack
                {
                    damage = 0;
                    rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} blocks {Form1.instance.p2Data[1]}'s whole attacks!";
                    rtbBattleLog.Text += $"\n***********************\n";
                }
                else //Attack greater than block
                {
                    damage = Form1.instance.p2Values[2] - Form1.instance.p1Values[3];
                    Form1.instance.p1Values[0] -= damage;
                    rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} attacks {Form1.instance.p1Data[1]} for {damage} damage!";
                    rtbBattleLog.Text += $"\n***********************\n";
                }
            }
            blockFlag1 = false;
            rest2 = true;
        }
        void Player1Rest() //Player 1 rest - resets all booleans
        {
            rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} is too tired to fight, and rests for a while.";
            rest1 = false;
            btnRest.Enabled = false;
            btnRest.Visible = false;
            btnAttack.Enabled = true;
            btnAttack.Visible = true;
            btnSpecialAttack.Enabled = true;
            btnSpecialAttack.Visible = true;
            btnBlock.Enabled = true;
            btnBlock.Visible = true;
        }
        void Player2Rest() //Player 2 rest - resets all booleans
        {
            rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} is too tired to fight, and rests for a while.";
            rest2 = false;
            btnRest.Enabled = false;
            btnRest.Visible = false;
            btnAttack.Enabled = true;
            btnAttack.Visible = true;
            btnSpecialAttack.Enabled = true;
            btnSpecialAttack.Visible = true;
            btnBlock.Enabled = true;
            btnBlock.Visible = true;
        }

    }
}

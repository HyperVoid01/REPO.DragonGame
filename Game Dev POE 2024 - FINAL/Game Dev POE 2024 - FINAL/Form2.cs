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
        public Form2()
        {
            InitializeComponent();
            Instance = this;
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
            gbxPlayerTurn.Text = $"{Form1.instance.p1Data[1]}, the {Form1.instance.p1Data[2]} Dragon's Turn"; //Dragon Name, Dragon Type
            Form2.Instance.Text = $"{Form1.instance.p1Data[0]}'s Turn"; //Player Name
            lblPlayerTurnHp.Text = $"HP: {Form1.instance.p1Values[0]}"; //HP
            lblOpponentDragon.Text = $"{Form1.instance.p2Data[1]}, the {Form1.instance.p2Data[2]} Dragon"; //Opponent Dragon Name, Dragon Type
            gbxOpponent.Text = $"Opponent: {Form1.instance.p2Data[0]}"; //Opponent Player Name
            lblOpponentHp.Text = $"HP: {Form1.instance.p2Values[0]}"; //Opponent HP
        }

        void Player2Customise() //Player 2 Initiative
        {
            gbxPlayerTurn.Text = $"{Form1.instance.p2Data[1]}, the {Form1.instance.p2Data[2]} Dragon's Turn"; //Dragon Name, Dragon Type
            Form2.Instance.Text = $"{Form1.instance.p2Data[0]}'s Turn"; //Player Name
            lblPlayerTurnHp.Text = $"HP: {Form1.instance.p2Values[0]}"; //HP
            lblOpponentDragon.Text = $"{Form1.instance.p1Data[1]}, the {Form1.instance.p1Data[2]} Dragon"; //Opponent Dragon Name, Dragon Type
            gbxOpponent.Text = $"Opponent: {Form1.instance.p1Data[0]}"; //Opponent Player Name
            lblOpponentHp.Text = $"HP: {Form1.instance.p1Values[0]}"; //Opponent HP
        }
    }
}

namespace Game_Dev_POE_2024___FINAL
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gbxBattleBox = new System.Windows.Forms.GroupBox();
            this.rtbBattleLog = new System.Windows.Forms.RichTextBox();
            this.gbxOpponent = new System.Windows.Forms.GroupBox();
            this.lblOpponentDragon = new System.Windows.Forms.Label();
            this.lblOpponentHp = new System.Windows.Forms.Label();
            this.gbxPlayerTurn = new System.Windows.Forms.GroupBox();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnSpecialAttack = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblPlayerTurnHp = new System.Windows.Forms.Label();
            this.gbxBattleBox.SuspendLayout();
            this.gbxOpponent.SuspendLayout();
            this.gbxPlayerTurn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBattleBox
            // 
            this.gbxBattleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxBattleBox.BackColor = System.Drawing.Color.Transparent;
            this.gbxBattleBox.Controls.Add(this.rtbBattleLog);
            this.gbxBattleBox.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBattleBox.ForeColor = System.Drawing.Color.White;
            this.gbxBattleBox.Location = new System.Drawing.Point(15, 256);
            this.gbxBattleBox.Name = "gbxBattleBox";
            this.gbxBattleBox.Size = new System.Drawing.Size(605, 181);
            this.gbxBattleBox.TabIndex = 5;
            this.gbxBattleBox.TabStop = false;
            this.gbxBattleBox.Text = "Battle Log";
            // 
            // rtbBattleLog
            // 
            this.rtbBattleLog.BackColor = System.Drawing.Color.Firebrick;
            this.rtbBattleLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbBattleLog.Location = new System.Drawing.Point(10, 19);
            this.rtbBattleLog.Name = "rtbBattleLog";
            this.rtbBattleLog.ReadOnly = true;
            this.rtbBattleLog.Size = new System.Drawing.Size(589, 156);
            this.rtbBattleLog.TabIndex = 0;
            this.rtbBattleLog.Text = "";
            // 
            // gbxOpponent
            // 
            this.gbxOpponent.BackColor = System.Drawing.Color.Transparent;
            this.gbxOpponent.Controls.Add(this.lblOpponentDragon);
            this.gbxOpponent.Controls.Add(this.lblOpponentHp);
            this.gbxOpponent.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpponent.ForeColor = System.Drawing.Color.White;
            this.gbxOpponent.Location = new System.Drawing.Point(341, 66);
            this.gbxOpponent.Name = "gbxOpponent";
            this.gbxOpponent.Size = new System.Drawing.Size(279, 122);
            this.gbxOpponent.TabIndex = 4;
            this.gbxOpponent.TabStop = false;
            this.gbxOpponent.Text = "Opponent: X";
            // 
            // lblOpponentDragon
            // 
            this.lblOpponentDragon.AutoSize = true;
            this.lblOpponentDragon.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentDragon.Location = new System.Drawing.Point(89, 31);
            this.lblOpponentDragon.Name = "lblOpponentDragon";
            this.lblOpponentDragon.Size = new System.Drawing.Size(107, 25);
            this.lblOpponentDragon.TabIndex = 2;
            this.lblOpponentDragon.Text = "X, the X Dragon";
            this.lblOpponentDragon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOpponentHp
            // 
            this.lblOpponentHp.AutoSize = true;
            this.lblOpponentHp.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentHp.Location = new System.Drawing.Point(105, 64);
            this.lblOpponentHp.Name = "lblOpponentHp";
            this.lblOpponentHp.Size = new System.Drawing.Size(59, 34);
            this.lblOpponentHp.TabIndex = 1;
            this.lblOpponentHp.Text = "HP: X";
            // 
            // gbxPlayerTurn
            // 
            this.gbxPlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.gbxPlayerTurn.Controls.Add(this.btnRest);
            this.gbxPlayerTurn.Controls.Add(this.btnBlock);
            this.gbxPlayerTurn.Controls.Add(this.btnSpecialAttack);
            this.gbxPlayerTurn.Controls.Add(this.btnAttack);
            this.gbxPlayerTurn.Controls.Add(this.lblPlayerTurnHp);
            this.gbxPlayerTurn.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPlayerTurn.ForeColor = System.Drawing.Color.White;
            this.gbxPlayerTurn.Location = new System.Drawing.Point(25, 21);
            this.gbxPlayerTurn.Name = "gbxPlayerTurn";
            this.gbxPlayerTurn.Size = new System.Drawing.Size(279, 229);
            this.gbxPlayerTurn.TabIndex = 3;
            this.gbxPlayerTurn.TabStop = false;
            this.gbxPlayerTurn.Text = "X, the X Dragon\'s Turn";
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.Firebrick;
            this.btnRest.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ForeColor = System.Drawing.Color.Black;
            this.btnRest.Location = new System.Drawing.Point(7, 45);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(266, 178);
            this.btnRest.TabIndex = 4;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Visible = false;
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.Color.Firebrick;
            this.btnBlock.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.ForeColor = System.Drawing.Color.Black;
            this.btnBlock.Location = new System.Drawing.Point(7, 168);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(266, 55);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = false;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnSpecialAttack
            // 
            this.btnSpecialAttack.BackColor = System.Drawing.Color.Firebrick;
            this.btnSpecialAttack.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecialAttack.ForeColor = System.Drawing.Color.Black;
            this.btnSpecialAttack.Location = new System.Drawing.Point(7, 106);
            this.btnSpecialAttack.Name = "btnSpecialAttack";
            this.btnSpecialAttack.Size = new System.Drawing.Size(266, 55);
            this.btnSpecialAttack.TabIndex = 2;
            this.btnSpecialAttack.Text = "Special Attack";
            this.btnSpecialAttack.UseVisualStyleBackColor = false;
            this.btnSpecialAttack.Click += new System.EventHandler(this.btnSpecialAttack_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Firebrick;
            this.btnAttack.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.Color.Black;
            this.btnAttack.Location = new System.Drawing.Point(7, 45);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(266, 55);
            this.btnAttack.TabIndex = 1;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblPlayerTurnHp
            // 
            this.lblPlayerTurnHp.AutoSize = true;
            this.lblPlayerTurnHp.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurnHp.Location = new System.Drawing.Point(105, 13);
            this.lblPlayerTurnHp.Name = "lblPlayerTurnHp";
            this.lblPlayerTurnHp.Size = new System.Drawing.Size(55, 31);
            this.lblPlayerTurnHp.TabIndex = 0;
            this.lblPlayerTurnHp.Text = "HP: X";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.gbxBattleBox);
            this.Controls.Add(this.gbxOpponent);
            this.Controls.Add(this.gbxPlayerTurn);
            this.Name = "Form2";
            this.Text = "X\'s Turn";
            this.gbxBattleBox.ResumeLayout(false);
            this.gbxOpponent.ResumeLayout(false);
            this.gbxOpponent.PerformLayout();
            this.gbxPlayerTurn.ResumeLayout(false);
            this.gbxPlayerTurn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBattleBox;
        private System.Windows.Forms.GroupBox gbxOpponent;
        private System.Windows.Forms.Label lblOpponentDragon;
        private System.Windows.Forms.Label lblOpponentHp;
        private System.Windows.Forms.GroupBox gbxPlayerTurn;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnSpecialAttack;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblPlayerTurnHp;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.RichTextBox rtbBattleLog;
    }
}
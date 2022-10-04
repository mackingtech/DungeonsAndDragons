namespace DungeonsAndDragons
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
            this.classLabel = new System.Windows.Forms.Label();
            this.diceChoose = new System.Windows.Forms.Label();
            this.diceCount = new System.Windows.Forms.Label();
            this.numberOfDice = new System.Windows.Forms.TextBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.rolls = new System.Windows.Forms.Label();
            this.reRollButton = new System.Windows.Forms.Button();
            this.warriorHP = new System.Windows.Forms.Label();
            this.mageHP = new System.Windows.Forms.Label();
            this.monsterHP = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.monsterOutput = new System.Windows.Forms.Label();
            this.logs = new System.Windows.Forms.GroupBox();
            this.diceBox = new System.Windows.Forms.GroupBox();
            this.d20 = new System.Windows.Forms.PictureBox();
            this.d12 = new System.Windows.Forms.PictureBox();
            this.d10 = new System.Windows.Forms.PictureBox();
            this.d6 = new System.Windows.Forms.PictureBox();
            this.d4 = new System.Windows.Forms.PictureBox();
            this.deadPlayer = new System.Windows.Forms.PictureBox();
            this.deadMonster = new System.Windows.Forms.PictureBox();
            this.monsterImg = new System.Windows.Forms.PictureBox();
            this.warriorImg = new System.Windows.Forms.PictureBox();
            this.mageImg = new System.Windows.Forms.PictureBox();
            this.currentDice = new System.Windows.Forms.GroupBox();
            this.D4cur = new System.Windows.Forms.PictureBox();
            this.D6cur = new System.Windows.Forms.PictureBox();
            this.D10cur = new System.Windows.Forms.PictureBox();
            this.D12cur = new System.Windows.Forms.PictureBox();
            this.D20cur = new System.Windows.Forms.PictureBox();
            this.logs.SuspendLayout();
            this.diceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warriorImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mageImg)).BeginInit();
            this.currentDice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D4cur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D6cur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D10cur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D12cur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D20cur)).BeginInit();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(12, 9);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(180, 27);
            this.classLabel.TabIndex = 2;
            this.classLabel.Text = "Choose a Class";
            this.classLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diceChoose
            // 
            this.diceChoose.AutoSize = true;
            this.diceChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceChoose.Location = new System.Drawing.Point(29, 17);
            this.diceChoose.Name = "diceChoose";
            this.diceChoose.Size = new System.Drawing.Size(144, 20);
            this.diceChoose.TabIndex = 3;
            this.diceChoose.Text = "Choose Dice Sides";
            // 
            // diceCount
            // 
            this.diceCount.AutoSize = true;
            this.diceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceCount.Location = new System.Drawing.Point(215, 3);
            this.diceCount.Name = "diceCount";
            this.diceCount.Size = new System.Drawing.Size(72, 20);
            this.diceCount.TabIndex = 9;
            this.diceCount.Text = "# of Dice";
            // 
            // numberOfDice
            // 
            this.numberOfDice.Location = new System.Drawing.Point(219, 40);
            this.numberOfDice.Name = "numberOfDice";
            this.numberOfDice.Size = new System.Drawing.Size(100, 20);
            this.numberOfDice.TabIndex = 10;
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rollButton.Location = new System.Drawing.Point(242, 66);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 11;
            this.rollButton.Text = "ROLL!";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(6, 121);
            this.output.MaximumSize = new System.Drawing.Size(0, 50);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(2, 27);
            this.output.TabIndex = 12;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rolls
            // 
            this.rolls.AutoSize = true;
            this.rolls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolls.Location = new System.Drawing.Point(6, 251);
            this.rolls.Name = "rolls";
            this.rolls.Size = new System.Drawing.Size(2, 26);
            this.rolls.TabIndex = 13;
            // 
            // reRollButton
            // 
            this.reRollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reRollButton.Location = new System.Drawing.Point(242, 162);
            this.reRollButton.Name = "reRollButton";
            this.reRollButton.Size = new System.Drawing.Size(77, 32);
            this.reRollButton.TabIndex = 14;
            this.reRollButton.Text = "Re-Roll";
            this.reRollButton.UseVisualStyleBackColor = true;
            this.reRollButton.Click += new System.EventHandler(this.reRollButton_Click);
            // 
            // warriorHP
            // 
            this.warriorHP.AutoSize = true;
            this.warriorHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.warriorHP.Location = new System.Drawing.Point(13, 151);
            this.warriorHP.Name = "warriorHP";
            this.warriorHP.Size = new System.Drawing.Size(76, 25);
            this.warriorHP.TabIndex = 15;
            this.warriorHP.Text = "label1";
            // 
            // mageHP
            // 
            this.mageHP.AutoSize = true;
            this.mageHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.mageHP.Location = new System.Drawing.Point(133, 151);
            this.mageHP.Name = "mageHP";
            this.mageHP.Size = new System.Drawing.Size(76, 25);
            this.mageHP.TabIndex = 16;
            this.mageHP.Text = "label1";
            // 
            // monsterHP
            // 
            this.monsterHP.AutoSize = true;
            this.monsterHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterHP.Location = new System.Drawing.Point(483, 167);
            this.monsterHP.Name = "monsterHP";
            this.monsterHP.Size = new System.Drawing.Size(0, 25);
            this.monsterHP.TabIndex = 18;
            // 
            // newGame
            // 
            this.newGame.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.Location = new System.Drawing.Point(534, 542);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(120, 42);
            this.newGame.TabIndex = 20;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // monsterOutput
            // 
            this.monsterOutput.AutoSize = true;
            this.monsterOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monsterOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.monsterOutput.Location = new System.Drawing.Point(6, 16);
            this.monsterOutput.MaximumSize = new System.Drawing.Size(300, 0);
            this.monsterOutput.Name = "monsterOutput";
            this.monsterOutput.Size = new System.Drawing.Size(2, 27);
            this.monsterOutput.TabIndex = 21;
            // 
            // logs
            // 
            this.logs.Controls.Add(this.monsterOutput);
            this.logs.Controls.Add(this.output);
            this.logs.Location = new System.Drawing.Point(353, 336);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(309, 185);
            this.logs.TabIndex = 23;
            this.logs.TabStop = false;
            this.logs.Text = "LOGS";
            // 
            // diceBox
            // 
            this.diceBox.Controls.Add(this.currentDice);
            this.diceBox.Controls.Add(this.numberOfDice);
            this.diceBox.Controls.Add(this.diceCount);
            this.diceBox.Controls.Add(this.d20);
            this.diceBox.Controls.Add(this.d12);
            this.diceBox.Controls.Add(this.d10);
            this.diceBox.Controls.Add(this.d6);
            this.diceBox.Controls.Add(this.d4);
            this.diceBox.Controls.Add(this.diceChoose);
            this.diceBox.Controls.Add(this.rollButton);
            this.diceBox.Controls.Add(this.reRollButton);
            this.diceBox.Controls.Add(this.rolls);
            this.diceBox.Location = new System.Drawing.Point(12, 230);
            this.diceBox.Name = "diceBox";
            this.diceBox.Size = new System.Drawing.Size(335, 291);
            this.diceBox.TabIndex = 24;
            this.diceBox.TabStop = false;
            this.diceBox.Text = "DICE BOX";
            // 
            // d20
            // 
            this.d20.Image = global::DungeonsAndDragons.Properties.Resources.noun_d20_2453700;
            this.d20.Location = new System.Drawing.Point(103, 106);
            this.d20.Name = "d20";
            this.d20.Size = new System.Drawing.Size(64, 59);
            this.d20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d20.TabIndex = 8;
            this.d20.TabStop = false;
            this.d20.Click += new System.EventHandler(this.d20_Click);
            // 
            // d12
            // 
            this.d12.Image = global::DungeonsAndDragons.Properties.Resources.noun_d12_2453697;
            this.d12.Location = new System.Drawing.Point(33, 106);
            this.d12.Name = "d12";
            this.d12.Size = new System.Drawing.Size(64, 59);
            this.d12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d12.TabIndex = 7;
            this.d12.TabStop = false;
            this.d12.Click += new System.EventHandler(this.d12_Click);
            // 
            // d10
            // 
            this.d10.Image = global::DungeonsAndDragons.Properties.Resources.noun_d10_2453698;
            this.d10.Location = new System.Drawing.Point(143, 40);
            this.d10.Name = "d10";
            this.d10.Size = new System.Drawing.Size(64, 59);
            this.d10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d10.TabIndex = 6;
            this.d10.TabStop = false;
            this.d10.Click += new System.EventHandler(this.d10_Click);
            // 
            // d6
            // 
            this.d6.Image = global::DungeonsAndDragons.Properties.Resources.noun_d6_2453695;
            this.d6.Location = new System.Drawing.Point(73, 40);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(64, 59);
            this.d6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d6.TabIndex = 5;
            this.d6.TabStop = false;
            this.d6.Click += new System.EventHandler(this.d6_Click);
            // 
            // d4
            // 
            this.d4.Image = global::DungeonsAndDragons.Properties.Resources.noun_d4_2453696;
            this.d4.Location = new System.Drawing.Point(3, 40);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(64, 60);
            this.d4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d4.TabIndex = 4;
            this.d4.TabStop = false;
            this.d4.Click += new System.EventHandler(this.d4_Click);
            // 
            // deadPlayer
            // 
            this.deadPlayer.Image = global::DungeonsAndDragons.Properties.Resources.deadPlayer;
            this.deadPlayer.Location = new System.Drawing.Point(62, 52);
            this.deadPlayer.Name = "deadPlayer";
            this.deadPlayer.Size = new System.Drawing.Size(114, 96);
            this.deadPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deadPlayer.TabIndex = 22;
            this.deadPlayer.TabStop = false;
            // 
            // deadMonster
            // 
            this.deadMonster.Image = global::DungeonsAndDragons.Properties.Resources.dead;
            this.deadMonster.Location = new System.Drawing.Point(488, 37);
            this.deadMonster.Name = "deadMonster";
            this.deadMonster.Size = new System.Drawing.Size(166, 127);
            this.deadMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deadMonster.TabIndex = 19;
            this.deadMonster.TabStop = false;
            // 
            // monsterImg
            // 
            this.monsterImg.Image = global::DungeonsAndDragons.Properties.Resources.dbyyqvq_f9671878_2f71_4cca_bc68_579535b1f31d;
            this.monsterImg.Location = new System.Drawing.Point(488, 37);
            this.monsterImg.Name = "monsterImg";
            this.monsterImg.Size = new System.Drawing.Size(166, 127);
            this.monsterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monsterImg.TabIndex = 17;
            this.monsterImg.TabStop = false;
            // 
            // warriorImg
            // 
            this.warriorImg.Image = global::DungeonsAndDragons.Properties.Resources.warrior;
            this.warriorImg.Location = new System.Drawing.Point(12, 55);
            this.warriorImg.Name = "warriorImg";
            this.warriorImg.Size = new System.Drawing.Size(115, 93);
            this.warriorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.warriorImg.TabIndex = 1;
            this.warriorImg.TabStop = false;
            this.warriorImg.Click += new System.EventHandler(this.warriorImg_Click);
            // 
            // mageImg
            // 
            this.mageImg.Image = global::DungeonsAndDragons.Properties.Resources.mage;
            this.mageImg.Location = new System.Drawing.Point(133, 55);
            this.mageImg.Name = "mageImg";
            this.mageImg.Size = new System.Drawing.Size(115, 93);
            this.mageImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mageImg.TabIndex = 0;
            this.mageImg.TabStop = false;
            this.mageImg.Click += new System.EventHandler(this.mageImg_Click);
            // 
            // currentDice
            // 
            this.currentDice.Controls.Add(this.D20cur);
            this.currentDice.Controls.Add(this.D12cur);
            this.currentDice.Controls.Add(this.D10cur);
            this.currentDice.Controls.Add(this.D6cur);
            this.currentDice.Controls.Add(this.D4cur);
            this.currentDice.Location = new System.Drawing.Point(6, 40);
            this.currentDice.Name = "currentDice";
            this.currentDice.Size = new System.Drawing.Size(201, 154);
            this.currentDice.TabIndex = 21;
            this.currentDice.TabStop = false;
            this.currentDice.Text = "Current Dice";
            // 
            // D4cur
            // 
            this.D4cur.Image = global::DungeonsAndDragons.Properties.Resources.noun_d4_2453696;
            this.D4cur.Location = new System.Drawing.Point(24, 23);
            this.D4cur.Name = "D4cur";
            this.D4cur.Size = new System.Drawing.Size(156, 125);
            this.D4cur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.D4cur.TabIndex = 5;
            this.D4cur.TabStop = false;
            // 
            // D6cur
            // 
            this.D6cur.Image = global::DungeonsAndDragons.Properties.Resources.noun_d6_2453695;
            this.D6cur.Location = new System.Drawing.Point(24, 23);
            this.D6cur.Name = "D6cur";
            this.D6cur.Size = new System.Drawing.Size(156, 125);
            this.D6cur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.D6cur.TabIndex = 15;
            this.D6cur.TabStop = false;
            // 
            // D10cur
            // 
            this.D10cur.Image = global::DungeonsAndDragons.Properties.Resources.noun_d10_2453698;
            this.D10cur.Location = new System.Drawing.Point(24, 23);
            this.D10cur.Name = "D10cur";
            this.D10cur.Size = new System.Drawing.Size(156, 125);
            this.D10cur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.D10cur.TabIndex = 16;
            this.D10cur.TabStop = false;
            // 
            // D12cur
            // 
            this.D12cur.Image = global::DungeonsAndDragons.Properties.Resources.noun_d12_2453697;
            this.D12cur.Location = new System.Drawing.Point(24, 23);
            this.D12cur.Name = "D12cur";
            this.D12cur.Size = new System.Drawing.Size(156, 125);
            this.D12cur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.D12cur.TabIndex = 17;
            this.D12cur.TabStop = false;
            // 
            // D20cur
            // 
            this.D20cur.Image = global::DungeonsAndDragons.Properties.Resources.noun_d20_2453700;
            this.D20cur.Location = new System.Drawing.Point(24, 23);
            this.D20cur.Name = "D20cur";
            this.D20cur.Size = new System.Drawing.Size(156, 125);
            this.D20cur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.D20cur.TabIndex = 18;
            this.D20cur.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(666, 595);
            this.Controls.Add(this.diceBox);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.deadPlayer);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.deadMonster);
            this.Controls.Add(this.monsterHP);
            this.Controls.Add(this.monsterImg);
            this.Controls.Add(this.mageHP);
            this.Controls.Add(this.warriorHP);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.warriorImg);
            this.Controls.Add(this.mageImg);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.logs.ResumeLayout(false);
            this.logs.PerformLayout();
            this.diceBox.ResumeLayout(false);
            this.diceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warriorImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mageImg)).EndInit();
            this.currentDice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.D4cur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D6cur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D10cur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D12cur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D20cur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mageImg;
        private System.Windows.Forms.PictureBox warriorImg;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label diceChoose;
        private System.Windows.Forms.PictureBox d4;
        private System.Windows.Forms.PictureBox d6;
        private System.Windows.Forms.PictureBox d10;
        private System.Windows.Forms.PictureBox d12;
        private System.Windows.Forms.PictureBox d20;
        private System.Windows.Forms.Label diceCount;
        private System.Windows.Forms.TextBox numberOfDice;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label rolls;
        private System.Windows.Forms.Button reRollButton;
        private System.Windows.Forms.Label warriorHP;
        private System.Windows.Forms.Label mageHP;
        private System.Windows.Forms.PictureBox monsterImg;
        private System.Windows.Forms.Label monsterHP;
        private System.Windows.Forms.PictureBox deadMonster;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Label monsterOutput;
        private System.Windows.Forms.PictureBox deadPlayer;
        private System.Windows.Forms.GroupBox logs;
        private System.Windows.Forms.GroupBox diceBox;
        private System.Windows.Forms.GroupBox currentDice;
        private System.Windows.Forms.PictureBox D20cur;
        private System.Windows.Forms.PictureBox D12cur;
        private System.Windows.Forms.PictureBox D10cur;
        private System.Windows.Forms.PictureBox D6cur;
        private System.Windows.Forms.PictureBox D4cur;
    }
}
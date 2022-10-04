namespace DungeonsAndDragons
{
    partial class Form3
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
            this.diceBox = new System.Windows.Forms.GroupBox();
            this.diceChoose = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.reRollButton = new System.Windows.Forms.Button();
            this.rolls = new System.Windows.Forms.Label();
            this.logs = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.Label();
            this.numberOfDice = new System.Windows.Forms.NumericUpDown();
            this.diceNumGroup = new System.Windows.Forms.GroupBox();
            this.d20 = new System.Windows.Forms.PictureBox();
            this.d12 = new System.Windows.Forms.PictureBox();
            this.d10 = new System.Windows.Forms.PictureBox();
            this.d6 = new System.Windows.Forms.PictureBox();
            this.d4 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Button();
            this.diceBox.SuspendLayout();
            this.logs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDice)).BeginInit();
            this.diceNumGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).BeginInit();
            this.SuspendLayout();
            // 
            // diceBox
            // 
            this.diceBox.Controls.Add(this.diceNumGroup);
            this.diceBox.Controls.Add(this.d20);
            this.diceBox.Controls.Add(this.d12);
            this.diceBox.Controls.Add(this.d10);
            this.diceBox.Controls.Add(this.d6);
            this.diceBox.Controls.Add(this.d4);
            this.diceBox.Controls.Add(this.diceChoose);
            this.diceBox.Controls.Add(this.reRollButton);
            this.diceBox.Controls.Add(this.rolls);
            this.diceBox.Location = new System.Drawing.Point(12, 12);
            this.diceBox.Name = "diceBox";
            this.diceBox.Size = new System.Drawing.Size(335, 248);
            this.diceBox.TabIndex = 25;
            this.diceBox.TabStop = false;
            this.diceBox.Text = "DICE BOX";
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
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rollButton.Location = new System.Drawing.Point(20, 49);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 11;
            this.rollButton.Text = "ROLL!";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
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
            // rolls
            // 
            this.rolls.AutoSize = true;
            this.rolls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolls.Location = new System.Drawing.Point(6, 214);
            this.rolls.Name = "rolls";
            this.rolls.Size = new System.Drawing.Size(2, 26);
            this.rolls.TabIndex = 13;
            // 
            // logs
            // 
            this.logs.Controls.Add(this.output);
            this.logs.Location = new System.Drawing.Point(362, 21);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(424, 222);
            this.logs.TabIndex = 26;
            this.logs.TabStop = false;
            this.logs.Text = "LOGS";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(6, 24);
            this.output.MaximumSize = new System.Drawing.Size(1000, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(2, 27);
            this.output.TabIndex = 12;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfDice
            // 
            this.numberOfDice.Location = new System.Drawing.Point(0, 26);
            this.numberOfDice.Name = "numberOfDice";
            this.numberOfDice.Size = new System.Drawing.Size(120, 22);
            this.numberOfDice.TabIndex = 15;
            // 
            // diceNumGroup
            // 
            this.diceNumGroup.Controls.Add(this.numberOfDice);
            this.diceNumGroup.Controls.Add(this.rollButton);
            this.diceNumGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceNumGroup.Location = new System.Drawing.Point(208, 19);
            this.diceNumGroup.Name = "diceNumGroup";
            this.diceNumGroup.Size = new System.Drawing.Size(127, 136);
            this.diceNumGroup.TabIndex = 16;
            this.diceNumGroup.TabStop = false;
            this.diceNumGroup.Text = "# of Dice";
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
            this.d6.Click += new System.EventHandler(this.d6_Click_1);
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
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(666, 249);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(120, 42);
            this.menu.TabIndex = 27;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 296);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.diceBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.diceBox.ResumeLayout(false);
            this.diceBox.PerformLayout();
            this.logs.ResumeLayout(false);
            this.logs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDice)).EndInit();
            this.diceNumGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.d20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox diceBox;
        private System.Windows.Forms.PictureBox d20;
        private System.Windows.Forms.PictureBox d12;
        private System.Windows.Forms.PictureBox d10;
        private System.Windows.Forms.PictureBox d6;
        private System.Windows.Forms.PictureBox d4;
        private System.Windows.Forms.Label diceChoose;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button reRollButton;
        private System.Windows.Forms.Label rolls;
        private System.Windows.Forms.GroupBox logs;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.NumericUpDown numberOfDice;
        private System.Windows.Forms.GroupBox diceNumGroup;
        private System.Windows.Forms.Button menu;
    }
}
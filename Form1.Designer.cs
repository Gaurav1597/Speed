using System;

namespace Speed
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VickyBet = new System.Windows.Forms.Label();
            this.AnmolBet = new System.Windows.Forms.Label();
            this.AviBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.DogNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.VickyButton = new System.Windows.Forms.RadioButton();
            this.AnmolButton = new System.Windows.Forms.RadioButton();
            this.AviButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.Racetrack = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.VickyBet);
            this.groupBox1.Controls.Add(this.AnmolBet);
            this.groupBox1.Controls.Add(this.AviBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.DogNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BettingAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.VickyButton);
            this.groupBox1.Controls.Add(this.AnmolButton);
            this.groupBox1.Controls.Add(this.AviButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-1, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1226, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Place Bet Here";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // VickyBet
            // 
            this.VickyBet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VickyBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VickyBet.Location = new System.Drawing.Point(675, 91);
            this.VickyBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VickyBet.Name = "VickyBet";
            this.VickyBet.Size = new System.Drawing.Size(386, 21);
            this.VickyBet.TabIndex = 13;
            this.VickyBet.Text = "label6";
            this.VickyBet.Click += new System.EventHandler(this.VickyBet_Click);
            // 
            // AnmolBet
            // 
            this.AnmolBet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AnmolBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnmolBet.Location = new System.Drawing.Point(675, 56);
            this.AnmolBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnmolBet.Name = "AnmolBet";
            this.AnmolBet.Size = new System.Drawing.Size(386, 24);
            this.AnmolBet.TabIndex = 12;
            this.AnmolBet.Text = "label5";
            this.AnmolBet.Click += new System.EventHandler(this.AnmolBet_Click);
            // 
            // AviBet
            // 
            this.AviBet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AviBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AviBet.Location = new System.Drawing.Point(675, 21);
            this.AviBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AviBet.Name = "AviBet";
            this.AviBet.Size = new System.Drawing.Size(386, 23);
            this.AviBet.TabIndex = 11;
            this.AviBet.Text = "label4";
            this.AviBet.Click += new System.EventHandler(this.AviBet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.Color.HotPink;
            this.race.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.race.FlatAppearance.BorderSize = 5;
            this.race.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.ForeColor = System.Drawing.Color.White;
            this.race.Location = new System.Drawing.Point(797, 119);
            this.race.Margin = new System.Windows.Forms.Padding(4);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(114, 65);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.Race_Click);
            // 
            // DogNumber
            // 
            this.DogNumber.Location = new System.Drawing.Point(515, 135);
            this.DogNumber.Margin = new System.Windows.Forms.Padding(4);
            this.DogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogNumber.Name = "DogNumber";
            this.DogNumber.Size = new System.Drawing.Size(85, 24);
            this.DogNumber.TabIndex = 8;
            this.DogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogNumber.ValueChanged += new System.EventHandler(this.DogNumber_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dog number";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // BettingAmount
            // 
            this.BettingAmount.Location = new System.Drawing.Point(502, 62);
            this.BettingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(84, 24);
            this.BettingAmount.TabIndex = 6;
            this.BettingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.ValueChanged += new System.EventHandler(this.BettingAmount_ValueChanged);
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.Color.HotPink;
            this.Bets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Bets.FlatAppearance.BorderSize = 5;
            this.Bets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bets.ForeColor = System.Drawing.Color.White;
            this.Bets.Location = new System.Drawing.Point(9, 80);
            this.Bets.Margin = new System.Windows.Forms.Padding(4);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(141, 44);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // VickyButton
            // 
            this.VickyButton.AutoSize = true;
            this.VickyButton.Checked = true;
            this.VickyButton.Location = new System.Drawing.Point(172, 142);
            this.VickyButton.Margin = new System.Windows.Forms.Padding(4);
            this.VickyButton.Name = "VickyButton";
            this.VickyButton.Size = new System.Drawing.Size(69, 22);
            this.VickyButton.TabIndex = 3;
            this.VickyButton.TabStop = true;
            this.VickyButton.Text = "Vicky";
            this.VickyButton.UseVisualStyleBackColor = true;
            // 
            // AnmolButton
            // 
            this.AnmolButton.AutoSize = true;
            this.AnmolButton.Location = new System.Drawing.Point(172, 108);
            this.AnmolButton.Margin = new System.Windows.Forms.Padding(4);
            this.AnmolButton.Name = "AnmolButton";
            this.AnmolButton.Size = new System.Drawing.Size(76, 22);
            this.AnmolButton.TabIndex = 2;
            this.AnmolButton.Text = "Anmol";
            this.AnmolButton.UseVisualStyleBackColor = true;
            // 
            // AviButton
            // 
            this.AviButton.AutoSize = true;
            this.AviButton.Location = new System.Drawing.Point(172, 78);
            this.AviButton.Margin = new System.Windows.Forms.Padding(4);
            this.AviButton.Name = "AviButton";
            this.AviButton.Size = new System.Drawing.Size(68, 22);
            this.AviButton.TabIndex = 1;
            this.AviButton.Text = "Amrit";
            this.AviButton.UseVisualStyleBackColor = true;
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(327, 63);
            this.MaximumBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(120, 20);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            // 
            // Dog4
            // 
            this.Dog4.Image = global::Speed.Resource1.Dog4;
            this.Dog4.Location = new System.Drawing.Point(23, 310);
            this.Dog4.Margin = new System.Windows.Forms.Padding(4);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(96, 52);
            this.Dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog4.TabIndex = 4;
            this.Dog4.TabStop = false;
            this.Dog4.Click += new System.EventHandler(this.Dog4_Click);
            // 
            // Dog3
            // 
            this.Dog3.Image = global::Speed.Resource1.Dog3;
            this.Dog3.Location = new System.Drawing.Point(23, 222);
            this.Dog3.Margin = new System.Windows.Forms.Padding(4);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(96, 58);
            this.Dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog3.TabIndex = 3;
            this.Dog3.TabStop = false;
            this.Dog3.Click += new System.EventHandler(this.Dog3_Click);
            // 
            // Dog2
            // 
            this.Dog2.Image = global::Speed.Resource1.Dog2;
            this.Dog2.Location = new System.Drawing.Point(23, 137);
            this.Dog2.Margin = new System.Windows.Forms.Padding(4);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(96, 48);
            this.Dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog2.TabIndex = 2;
            this.Dog2.TabStop = false;
            this.Dog2.Click += new System.EventHandler(this.Dog2_Click);
            // 
            // Dog1
            // 
            this.Dog1.Image = global::Speed.Resource1.Dog1;
            this.Dog1.Location = new System.Drawing.Point(23, 40);
            this.Dog1.Margin = new System.Windows.Forms.Padding(4);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(96, 67);
            this.Dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog1.TabIndex = 1;
            this.Dog1.TabStop = false;
            this.Dog1.Click += new System.EventHandler(this.Dog1_Click);
            // 
            // Racetrack
            // 
            this.Racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.Racetrack.Image = global::Speed.Resource1.GrassFin;
            this.Racetrack.Location = new System.Drawing.Point(-39, 1);
            this.Racetrack.Margin = new System.Windows.Forms.Padding(4);
            this.Racetrack.Name = "Racetrack";
            this.Racetrack.Size = new System.Drawing.Size(1264, 661);
            this.Racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Racetrack.TabIndex = 0;
            this.Racetrack.TabStop = false;
            this.Racetrack.Click += new System.EventHandler(this.Racetrack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.Racetrack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Race";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racetrack)).EndInit();
            this.ResumeLayout(false);

        }

        private void AviBet_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AviButton_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void vickyButton_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AnmolButton_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox Racetrack;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton VickyButton;
        private System.Windows.Forms.RadioButton AnmolButton;
        private System.Windows.Forms.RadioButton AviButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown DogNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AviBet;
        private System.Windows.Forms.Label VickyBet;
        private System.Windows.Forms.Label AnmolBet;
    }
}

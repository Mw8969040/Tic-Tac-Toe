namespace Tic_Tac_Toe
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player_Case = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WinnerName = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 57);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tic-Tac-Toe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andalus", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 54);
            this.label2.TabIndex = 10;
            this.label2.Text = "Turn";
            // 
            // Player_Case
            // 
            this.Player_Case.AutoSize = true;
            this.Player_Case.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Case.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player_Case.Location = new System.Drawing.Point(26, 173);
            this.Player_Case.Name = "Player_Case";
            this.Player_Case.Size = new System.Drawing.Size(136, 40);
            this.Player_Case.TabIndex = 11;
            this.Player_Case.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(27, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Winner";
            // 
            // WinnerName
            // 
            this.WinnerName.AutoSize = true;
            this.WinnerName.Font = new System.Drawing.Font("NSimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerName.ForeColor = System.Drawing.Color.Lime;
            this.WinnerName.Location = new System.Drawing.Point(24, 299);
            this.WinnerName.Name = "WinnerName";
            this.WinnerName.Size = new System.Drawing.Size(191, 33);
            this.WinnerName.TabIndex = 13;
            this.WinnerName.Text = "In Progress";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button10.Location = new System.Drawing.Point(30, 367);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 34);
            this.button10.TabIndex = 14;
            this.button10.Text = "Restart Game";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Tic_Tac_Toe.Properties.Resources.questionmark;
            this.button9.Location = new System.Drawing.Point(512, 332);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 93);
            this.button9.TabIndex = 8;
            this.button9.Tag = "questionmark";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::Tic_Tac_Toe.Properties.Resources.questionmark;
            this.button8.Location = new System.Drawing.Point(378, 332);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 93);
            this.button8.TabIndex = 7;
            this.button8.Tag = "questionmark";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::Tic_Tac_Toe.Properties.Resources.questionmark;
            this.button7.Location = new System.Drawing.Point(249, 332);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 93);
            this.button7.TabIndex = 6;
            this.button7.Tag = "questionmark";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Tic_Tac_Toe.Properties.Resources.questionmark;
            this.button6.Location = new System.Drawing.Point(512, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 93);
            this.button6.TabIndex = 5;
            this.button6.Tag = "questionmark";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Tic_Tac_Toe.Properties.Resources.questionmark;
            this.button5.Location = new System.Drawing.Point(378, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 93);
            this.button5.TabIndex = 4;
            this.button5.Tag = "questionmark";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Tic_Tac_Toe.Properties.Resources.questionmark;
            this.button4.Location = new System.Drawing.Point(249, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 93);
            this.button4.TabIndex = 3;
            this.button4.Tag = "questionmark";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::Tic_Tac_Toe.Properties.Resources.questionmark;
            this.button3.Location = new System.Drawing.Point(512, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 93);
            this.button3.TabIndex = 2;
            this.button3.Tag = "questionmark";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = global::Tic_Tac_Toe.Properties.Resources.questionmark;
            this.button2.Location = new System.Drawing.Point(378, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 93);
            this.button2.TabIndex = 1;
            this.button2.Tag = "questionmark";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Tic_Tac_Toe.Properties.Resources.questionmark;
            this.button1.Location = new System.Drawing.Point(249, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 93);
            this.button1.TabIndex = 0;
            this.button1.Tag = "questionmark";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe.Properties.Resources.XO;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(660, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = " ";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.WinnerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Player_Case);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Player_Case;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WinnerName;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
    }
}


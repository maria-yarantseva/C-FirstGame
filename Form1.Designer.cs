namespace ProjectGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monster = new System.Windows.Forms.PictureBox();
            this.monster2 = new System.Windows.Forms.PictureBox();
            this.monster3 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(934, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Energy: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2144, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1580, 382);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kills: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(409, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "Health:";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.GhostWhite;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBar1.Location = new System.Drawing.Point(515, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(290, 35);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Tag = "progressBar1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.Game);
            // 
            // monster
            // 
            this.monster.Image = ((System.Drawing.Image)(resources.GetObject("monster.Image")));
            this.monster.Location = new System.Drawing.Point(759, 208);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(94, 81);
            this.monster.TabIndex = 9;
            this.monster.TabStop = false;
            this.monster.Tag = "monster";
            // 
            // monster2
            // 
            this.monster2.Image = ((System.Drawing.Image)(resources.GetObject("monster2.Image")));
            this.monster2.Location = new System.Drawing.Point(137, 426);
            this.monster2.Name = "monster2";
            this.monster2.Size = new System.Drawing.Size(82, 87);
            this.monster2.TabIndex = 8;
            this.monster2.TabStop = false;
            this.monster2.Tag = "monster";
            // 
            // monster3
            // 
            this.monster3.Image = ((System.Drawing.Image)(resources.GetObject("monster3.Image")));
            this.monster3.Location = new System.Drawing.Point(220, 183);
            this.monster3.Name = "monster3";
            this.monster3.Size = new System.Drawing.Size(72, 85);
            this.monster3.TabIndex = 7;
            this.monster3.TabStop = false;
            this.monster3.Tag = "monster";
            // 
            // player
            // 
            this.player.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(1124, 130);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(81, 79);
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(253, 170);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(1107, 237);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ты проиграл";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(432, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(671, 40);
            this.label7.TabIndex = 11;
            this.label7.Text = "Нажмите вверх, чтобы завершить игру\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1239, 644);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monster);
            this.Controls.Add(this.monster2);
            this.Controls.Add(this.monster3);
            this.Controls.Add(this.player);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "MonsterShooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox monster3;
        private System.Windows.Forms.PictureBox monster2;
        private System.Windows.Forms.PictureBox monster;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


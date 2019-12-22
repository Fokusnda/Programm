namespace WindowsFormsApp1
{
    partial class KrestikiNoliki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KrestikiNoliki));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PVP = new System.Windows.Forms.RadioButton();
            this.PVE = new System.Windows.Forms.RadioButton();
            this.NewGame = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PVP
            // 
            this.PVP.AutoSize = true;
            this.PVP.Checked = true;
            this.PVP.Location = new System.Drawing.Point(12, 264);
            this.PVP.Name = "PVP";
            this.PVP.Size = new System.Drawing.Size(46, 17);
            this.PVP.TabIndex = 1;
            this.PVP.TabStop = true;
            this.PVP.Text = "PVP";
            this.PVP.UseVisualStyleBackColor = true;
            this.PVP.CheckedChanged += new System.EventHandler(this.NewGame_Click);
            // 
            // PVE
            // 
            this.PVE.AutoSize = true;
            this.PVE.Location = new System.Drawing.Point(190, 264);
            this.PVE.Name = "PVE";
            this.PVE.Size = new System.Drawing.Size(46, 17);
            this.PVE.TabIndex = 2;
            this.PVE.Text = "PVE";
            this.PVE.UseVisualStyleBackColor = true;
            this.PVE.CheckedChanged += new System.EventHandler(this.NewGame_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(12, 288);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(228, 23);
            this.NewGame.TabIndex = 5;
            this.NewGame.Text = "Новая игра";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.ForeColor = System.Drawing.Color.Black;
            this.lb1.Location = new System.Drawing.Point(14, 39);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(70, 70);
            this.lb1.TabIndex = 6;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb1.Click += new System.EventHandler(this.lb_Click);
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.Location = new System.Drawing.Point(90, 39);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(70, 70);
            this.lb2.TabIndex = 7;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb2.Click += new System.EventHandler(this.lb_Click);
            // 
            // lb3
            // 
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.Location = new System.Drawing.Point(163, 39);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(70, 70);
            this.lb3.TabIndex = 8;
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb3.Click += new System.EventHandler(this.lb_Click);
            // 
            // lb4
            // 
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4.Location = new System.Drawing.Point(14, 114);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(70, 70);
            this.lb4.TabIndex = 9;
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb4.Click += new System.EventHandler(this.lb_Click);
            // 
            // lb5
            // 
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5.Location = new System.Drawing.Point(89, 113);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(70, 70);
            this.lb5.TabIndex = 10;
            this.lb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb5.Click += new System.EventHandler(this.lb_Click);
            // 
            // lb6
            // 
            this.lb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb6.Location = new System.Drawing.Point(163, 113);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(70, 70);
            this.lb6.TabIndex = 11;
            this.lb6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb6.Click += new System.EventHandler(this.lb_Click);
            // 
            // lb7
            // 
            this.lb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb7.Location = new System.Drawing.Point(16, 188);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(70, 70);
            this.lb7.TabIndex = 12;
            this.lb7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb7.Click += new System.EventHandler(this.lb_Click);
            // 
            // lb8
            // 
            this.lb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb8.Location = new System.Drawing.Point(89, 188);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(70, 70);
            this.lb8.TabIndex = 13;
            this.lb8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb8.Click += new System.EventHandler(this.lb_Click);
            // 
            // lb9
            // 
            this.lb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb9.Location = new System.Drawing.Point(163, 188);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(70, 70);
            this.lb9.TabIndex = 14;
            this.lb9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb9.Click += new System.EventHandler(this.lb_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ходит игрок 1 (    )";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(185, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "O";
            // 
            // KrestikiNoliki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(248, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb9);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.PVE);
            this.Controls.Add(this.PVP);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KrestikiNoliki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Крестики Нолики";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KrestikiNoliki_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton PVP;
        private System.Windows.Forms.RadioButton PVE;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
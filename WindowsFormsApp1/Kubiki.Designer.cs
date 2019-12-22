namespace WindowsFormsApp1
{
    partial class Kubiki
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbUser5 = new System.Windows.Forms.PictureBox();
            this.pbUser4 = new System.Windows.Forms.PictureBox();
            this.pbUser3 = new System.Windows.Forms.PictureBox();
            this.pbUser2 = new System.Windows.Forms.PictureBox();
            this.pbUser1 = new System.Windows.Forms.PictureBox();
            this.pbAI4 = new System.Windows.Forms.PictureBox();
            this.pbAI5 = new System.Windows.Forms.PictureBox();
            this.pbAI3 = new System.Windows.Forms.PictureBox();
            this.pbAI2 = new System.Windows.Forms.PictureBox();
            this.pbAI1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Бросить кости";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Игрок:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(130, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Компьютер:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Играть заново";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbAI1);
            this.groupBox1.Controls.Add(this.pbAI2);
            this.groupBox1.Controls.Add(this.pbAI3);
            this.groupBox1.Controls.Add(this.pbAI5);
            this.groupBox1.Controls.Add(this.pbAI4);
            this.groupBox1.Controls.Add(this.pbUser1);
            this.groupBox1.Controls.Add(this.pbUser2);
            this.groupBox1.Controls.Add(this.pbUser3);
            this.groupBox1.Controls.Add(this.pbUser4);
            this.groupBox1.Controls.Add(this.pbUser5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(246, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 280);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Игрок: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Компьютер: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(133, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Осталось попыток: 5";
            // 
            // pbUser5
            // 
            this.pbUser5.Location = new System.Drawing.Point(10, 40);
            this.pbUser5.Name = "pbUser5";
            this.pbUser5.Size = new System.Drawing.Size(75, 75);
            this.pbUser5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser5.TabIndex = 8;
            this.pbUser5.TabStop = false;
            // 
            // pbUser4
            // 
            this.pbUser4.Location = new System.Drawing.Point(91, 40);
            this.pbUser4.Name = "pbUser4";
            this.pbUser4.Size = new System.Drawing.Size(75, 75);
            this.pbUser4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser4.TabIndex = 9;
            this.pbUser4.TabStop = false;
            // 
            // pbUser3
            // 
            this.pbUser3.Location = new System.Drawing.Point(10, 117);
            this.pbUser3.Name = "pbUser3";
            this.pbUser3.Size = new System.Drawing.Size(75, 75);
            this.pbUser3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser3.TabIndex = 10;
            this.pbUser3.TabStop = false;
            // 
            // pbUser2
            // 
            this.pbUser2.Location = new System.Drawing.Point(91, 117);
            this.pbUser2.Name = "pbUser2";
            this.pbUser2.Size = new System.Drawing.Size(75, 75);
            this.pbUser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser2.TabIndex = 11;
            this.pbUser2.TabStop = false;
            // 
            // pbUser1
            // 
            this.pbUser1.Location = new System.Drawing.Point(50, 195);
            this.pbUser1.Name = "pbUser1";
            this.pbUser1.Size = new System.Drawing.Size(75, 75);
            this.pbUser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser1.TabIndex = 12;
            this.pbUser1.TabStop = false;
            // 
            // pbAI4
            // 
            this.pbAI4.Location = new System.Drawing.Point(278, 40);
            this.pbAI4.Name = "pbAI4";
            this.pbAI4.Size = new System.Drawing.Size(75, 75);
            this.pbAI4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAI4.TabIndex = 8;
            this.pbAI4.TabStop = false;
            // 
            // pbAI5
            // 
            this.pbAI5.Location = new System.Drawing.Point(197, 40);
            this.pbAI5.Name = "pbAI5";
            this.pbAI5.Size = new System.Drawing.Size(75, 75);
            this.pbAI5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAI5.TabIndex = 13;
            this.pbAI5.TabStop = false;
            // 
            // pbAI3
            // 
            this.pbAI3.Location = new System.Drawing.Point(197, 117);
            this.pbAI3.Name = "pbAI3";
            this.pbAI3.Size = new System.Drawing.Size(75, 75);
            this.pbAI3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAI3.TabIndex = 14;
            this.pbAI3.TabStop = false;
            // 
            // pbAI2
            // 
            this.pbAI2.Location = new System.Drawing.Point(278, 117);
            this.pbAI2.Name = "pbAI2";
            this.pbAI2.Size = new System.Drawing.Size(75, 75);
            this.pbAI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAI2.TabIndex = 15;
            this.pbAI2.TabStop = false;
            // 
            // pbAI1
            // 
            this.pbAI1.Location = new System.Drawing.Point(237, 195);
            this.pbAI1.Name = "pbAI1";
            this.pbAI1.Size = new System.Drawing.Size(75, 75);
            this.pbAI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAI1.TabIndex = 16;
            this.pbAI1.TabStop = false;
            // 
            // Kubiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(617, 304);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Kubiki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kubiki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kubiki_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbAI1;
        private System.Windows.Forms.PictureBox pbAI2;
        private System.Windows.Forms.PictureBox pbAI3;
        private System.Windows.Forms.PictureBox pbAI5;
        private System.Windows.Forms.PictureBox pbAI4;
        private System.Windows.Forms.PictureBox pbUser1;
        private System.Windows.Forms.PictureBox pbUser2;
        private System.Windows.Forms.PictureBox pbUser3;
        private System.Windows.Forms.PictureBox pbUser4;
        private System.Windows.Forms.PictureBox pbUser5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
    }
}
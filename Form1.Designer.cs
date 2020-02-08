namespace _2048_Game
{
    partial class Form1
    {
    
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UpDate = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scores = new System.Windows.Forms.Label();
            this.GameOwer = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOwer)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.DarkSlateGray;
            this.start.Location = new System.Drawing.Point(375, 29);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(246, 92);
            this.start.TabIndex = 3;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(497, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liczba punktów:";
            // 
            // scores
            // 
            this.scores.AutoSize = true;
            this.scores.BackColor = System.Drawing.Color.Black;
            this.scores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scores.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scores.ForeColor = System.Drawing.Color.IndianRed;
            this.scores.Location = new System.Drawing.Point(556, 302);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(41, 44);
            this.scores.TabIndex = 5;
            this.scores.Text = "0";
            // 
            // GameOwer
            // 
            this.GameOwer.BackColor = System.Drawing.Color.Transparent;
            this.GameOwer.BackgroundImage = global::_2048_Game.Properties.Resources.gm1;
            this.GameOwer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameOwer.Enabled = false;
            this.GameOwer.Location = new System.Drawing.Point(12, 414);
            this.GameOwer.Name = "GameOwer";
            this.GameOwer.Size = new System.Drawing.Size(284, 132);
            this.GameOwer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GameOwer.TabIndex = 6;
            this.GameOwer.TabStop = false;
            this.GameOwer.Visible = false;
            this.GameOwer.Click += new System.EventHandler(this.GameOwer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(392, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zacznij/resetuj";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(505, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yurii Brovko ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(505, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "W58899";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::_2048_Game.Properties.Resources._1561182942_2;
            this.ClientSize = new System.Drawing.Size(647, 558);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameOwer);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.K_D);
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOwer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer UpDate;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scores;
        private System.Windows.Forms.PictureBox GameOwer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


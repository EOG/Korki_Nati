namespace Korki15
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Meta = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.Zaklad3 = new System.Windows.Forms.RadioButton();
            this.Zaklad2 = new System.Windows.Forms.RadioButton();
            this.Zaklad1 = new System.Windows.Forms.RadioButton();
            this.wyscig = new System.Windows.Forms.Timer(this.components);
            this.AudioPlayer = new System.ComponentModel.BackgroundWorker();
            this.zawodnik3 = new Korki15.Zawodnik();
            this.zawodnik2 = new Korki15.Zawodnik();
            this.zawodnik1 = new Korki15.Zawodnik();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Korki15.Properties.Resources.meta;
            this.pictureBox1.Location = new System.Drawing.Point(100, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Meta
            // 
            this.Meta.Image = global::Korki15.Properties.Resources.meta;
            this.Meta.Location = new System.Drawing.Point(699, 127);
            this.Meta.Name = "Meta";
            this.Meta.Size = new System.Drawing.Size(20, 284);
            this.Meta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Meta.TabIndex = 4;
            this.Meta.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Controls.Add(this.Zaklad3);
            this.groupBox1.Controls.Add(this.Zaklad2);
            this.groupBox1.Controls.Add(this.Zaklad1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 109);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obstawianie";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(88, 14);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(266, 71);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Zaklad3
            // 
            this.Zaklad3.AutoSize = true;
            this.Zaklad3.Location = new System.Drawing.Point(7, 68);
            this.Zaklad3.Name = "Zaklad3";
            this.Zaklad3.Size = new System.Drawing.Size(78, 17);
            this.Zaklad3.TabIndex = 2;
            this.Zaklad3.TabStop = true;
            this.Zaklad3.Text = "Zawodnik3";
            this.Zaklad3.UseVisualStyleBackColor = true;
            // 
            // Zaklad2
            // 
            this.Zaklad2.AutoSize = true;
            this.Zaklad2.Location = new System.Drawing.Point(7, 44);
            this.Zaklad2.Name = "Zaklad2";
            this.Zaklad2.Size = new System.Drawing.Size(78, 17);
            this.Zaklad2.TabIndex = 1;
            this.Zaklad2.TabStop = true;
            this.Zaklad2.Text = "Zawodnik2";
            this.Zaklad2.UseVisualStyleBackColor = true;
            // 
            // Zaklad1
            // 
            this.Zaklad1.AutoSize = true;
            this.Zaklad1.Location = new System.Drawing.Point(7, 20);
            this.Zaklad1.Name = "Zaklad1";
            this.Zaklad1.Size = new System.Drawing.Size(78, 17);
            this.Zaklad1.TabIndex = 0;
            this.Zaklad1.TabStop = true;
            this.Zaklad1.Text = "Zawodnik1";
            this.Zaklad1.UseVisualStyleBackColor = true;
            // 
            // wyscig
            // 
            this.wyscig.Interval = 30;
            this.wyscig.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AudioPlayer
            // 
            this.AudioPlayer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AudioPlayer_DoWork);
            // 
            // zawodnik3
            // 
            this.zawodnik3.Location = new System.Drawing.Point(35, 334);
            this.zawodnik3.Name = "zawodnik3";
            this.zawodnik3.Pozyzja = 35;
            this.zawodnik3.Size = new System.Drawing.Size(59, 67);
            this.zawodnik3.TabIndex = 7;
            // 
            // zawodnik2
            // 
            this.zawodnik2.Location = new System.Drawing.Point(35, 238);
            this.zawodnik2.Name = "zawodnik2";
            this.zawodnik2.Pozyzja = 35;
            this.zawodnik2.Size = new System.Drawing.Size(59, 67);
            this.zawodnik2.TabIndex = 6;
            // 
            // zawodnik1
            // 
            this.zawodnik1.Location = new System.Drawing.Point(35, 137);
            this.zawodnik1.Name = "zawodnik1";
            this.zawodnik1.Pozyzja = 35;
            this.zawodnik1.Size = new System.Drawing.Size(59, 67);
            this.zawodnik1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zawodnik3);
            this.Controls.Add(this.zawodnik2);
            this.Controls.Add(this.zawodnik1);
            this.Controls.Add(this.Meta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Biegacze";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Meta;
        private Zawodnik zawodnik1;
        private Zawodnik zawodnik2;
        private Zawodnik zawodnik3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Zaklad3;
        private System.Windows.Forms.RadioButton Zaklad2;
        private System.Windows.Forms.RadioButton Zaklad1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Timer wyscig;
        private System.ComponentModel.BackgroundWorker AudioPlayer;
        private System.Windows.Forms.Button button1;
    }
}


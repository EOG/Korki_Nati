namespace Korki14
{
    partial class Przedmiot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nazwa = new System.Windows.Forms.GroupBox();
            this.Oceny = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Srednia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Najlepsza = new System.Windows.Forms.Label();
            this.Nazwa.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nazwa
            // 
            this.Nazwa.Controls.Add(this.Najlepsza);
            this.Nazwa.Controls.Add(this.label2);
            this.Nazwa.Controls.Add(this.Srednia);
            this.Nazwa.Controls.Add(this.label1);
            this.Nazwa.Controls.Add(this.Oceny);
            this.Nazwa.Location = new System.Drawing.Point(3, 3);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(169, 166);
            this.Nazwa.TabIndex = 0;
            this.Nazwa.TabStop = false;
            this.Nazwa.Text = "groupBox1";
            // 
            // Oceny
            // 
            this.Oceny.FormattingEnabled = true;
            this.Oceny.Location = new System.Drawing.Point(6, 19);
            this.Oceny.Name = "Oceny";
            this.Oceny.Size = new System.Drawing.Size(157, 108);
            this.Oceny.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Średnia";
            // 
            // Srednia
            // 
            this.Srednia.AutoSize = true;
            this.Srednia.Location = new System.Drawing.Point(100, 130);
            this.Srednia.Name = "Srednia";
            this.Srednia.Size = new System.Drawing.Size(35, 13);
            this.Srednia.TabIndex = 2;
            this.Srednia.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Najlepsza ocena";
            // 
            // Najlepsza
            // 
            this.Najlepsza.AutoSize = true;
            this.Najlepsza.Location = new System.Drawing.Point(101, 147);
            this.Najlepsza.Name = "Najlepsza";
            this.Najlepsza.Size = new System.Drawing.Size(35, 13);
            this.Najlepsza.TabIndex = 4;
            this.Najlepsza.Text = "label3";
            // 
            // Przedmiot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Nazwa);
            this.Name = "Przedmiot";
            this.Size = new System.Drawing.Size(175, 175);
            this.Nazwa.ResumeLayout(false);
            this.Nazwa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label Najlepsza;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label Srednia;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox Oceny;
        public System.Windows.Forms.GroupBox Nazwa;
    }
}

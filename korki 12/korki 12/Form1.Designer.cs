namespace korki_12
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
            this.Produkt = new System.Windows.Forms.TextBox();
            this.Dodajprodukt = new System.Windows.Forms.Button();
            this.Listazakupow = new System.Windows.Forms.CheckedListBox();
            this.zapisz = new System.Windows.Forms.Button();
            this.wczytaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Produkt
            // 
            this.Produkt.Location = new System.Drawing.Point(45, 44);
            this.Produkt.Name = "Produkt";
            this.Produkt.Size = new System.Drawing.Size(180, 20);
            this.Produkt.TabIndex = 0;
            // 
            // Dodajprodukt
            // 
            this.Dodajprodukt.Location = new System.Drawing.Point(71, 114);
            this.Dodajprodukt.Name = "Dodajprodukt";
            this.Dodajprodukt.Size = new System.Drawing.Size(105, 43);
            this.Dodajprodukt.TabIndex = 1;
            this.Dodajprodukt.Text = "Dodaj produkt";
            this.Dodajprodukt.UseVisualStyleBackColor = true;
            this.Dodajprodukt.Click += new System.EventHandler(this.Dodajprodukt_Click);
            // 
            // Listazakupow
            // 
            this.Listazakupow.FormattingEnabled = true;
            this.Listazakupow.Location = new System.Drawing.Point(287, 12);
            this.Listazakupow.Name = "Listazakupow";
            this.Listazakupow.Size = new System.Drawing.Size(273, 319);
            this.Listazakupow.TabIndex = 2;
            // 
            // zapisz
            // 
            this.zapisz.Location = new System.Drawing.Point(71, 187);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(105, 39);
            this.zapisz.TabIndex = 3;
            this.zapisz.Text = "Zapisz";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // wczytaj
            // 
            this.wczytaj.Location = new System.Drawing.Point(71, 249);
            this.wczytaj.Name = "wczytaj";
            this.wczytaj.Size = new System.Drawing.Size(105, 40);
            this.wczytaj.TabIndex = 4;
            this.wczytaj.Text = "Wczytaj ostatnią";
            this.wczytaj.UseVisualStyleBackColor = true;
            this.wczytaj.Click += new System.EventHandler(this.wczytaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 352);
            this.Controls.Add(this.wczytaj);
            this.Controls.Add(this.zapisz);
            this.Controls.Add(this.Listazakupow);
            this.Controls.Add(this.Dodajprodukt);
            this.Controls.Add(this.Produkt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Produkt;
        private System.Windows.Forms.Button Dodajprodukt;
        private System.Windows.Forms.CheckedListBox Listazakupow;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.Button wczytaj;
    }
}


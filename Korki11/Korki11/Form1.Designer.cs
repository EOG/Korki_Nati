namespace Korki11
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
            this.lewa = new System.Windows.Forms.CheckedListBox();
            this.prawa = new System.Windows.Forms.CheckedListBox();
            this.przenies = new System.Windows.Forms.Button();
            this.odprzenies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lewa
            // 
            this.lewa.FormattingEnabled = true;
            this.lewa.Items.AddRange(new object[] {
            "Nati",
            "Monika",
            "Piotr",
            "Sacz"});
            this.lewa.Location = new System.Drawing.Point(12, 12);
            this.lewa.Name = "lewa";
            this.lewa.Size = new System.Drawing.Size(245, 259);
            this.lewa.TabIndex = 0;
            // 
            // prawa
            // 
            this.prawa.FormattingEnabled = true;
            this.prawa.Location = new System.Drawing.Point(344, 12);
            this.prawa.Name = "prawa";
            this.prawa.Size = new System.Drawing.Size(264, 259);
            this.prawa.TabIndex = 1;
            // 
            // przenies
            // 
            this.przenies.Location = new System.Drawing.Point(263, 161);
            this.przenies.Name = "przenies";
            this.przenies.Size = new System.Drawing.Size(75, 27);
            this.przenies.TabIndex = 2;
            this.przenies.Text = ">>";
            this.przenies.UseVisualStyleBackColor = true;
            this.przenies.Click += new System.EventHandler(this.przenies_Click);
            // 
            // odprzenies
            // 
            this.odprzenies.Location = new System.Drawing.Point(263, 224);
            this.odprzenies.Name = "odprzenies";
            this.odprzenies.Size = new System.Drawing.Size(75, 23);
            this.odprzenies.TabIndex = 3;
            this.odprzenies.Text = "<<";
            this.odprzenies.UseVisualStyleBackColor = true;
            this.odprzenies.Click += new System.EventHandler(this.odprzenies_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 304);
            this.Controls.Add(this.odprzenies);
            this.Controls.Add(this.przenies);
            this.Controls.Add(this.prawa);
            this.Controls.Add(this.lewa);
            this.Name = "Form1";
            this.Text = "Okno przenoszenia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lewa;
        private System.Windows.Forms.CheckedListBox prawa;
        private System.Windows.Forms.Button przenies;
        private System.Windows.Forms.Button odprzenies;
    }
}


namespace zadanie_1
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
            this.checklista = new System.Windows.Forms.CheckedListBox();
            this.przycisk = new System.Windows.Forms.Button();
            this.tekst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checklista
            // 
            this.checklista.FormattingEnabled = true;
            this.checklista.Location = new System.Drawing.Point(262, 12);
            this.checklista.Name = "checklista";
            this.checklista.Size = new System.Drawing.Size(193, 244);
            this.checklista.TabIndex = 0;
            // 
            // przycisk
            // 
            this.przycisk.Location = new System.Drawing.Point(76, 182);
            this.przycisk.Name = "przycisk";
            this.przycisk.Size = new System.Drawing.Size(110, 39);
            this.przycisk.TabIndex = 1;
            this.przycisk.Text = "przenies";
            this.przycisk.UseVisualStyleBackColor = true;
            this.przycisk.Click += new System.EventHandler(this.tekst_TextChanged);
            // 
            // tekst
            // 
            this.tekst.Location = new System.Drawing.Point(38, 49);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(198, 20);
            this.tekst.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 273);
            this.Controls.Add(this.tekst);
            this.Controls.Add(this.przycisk);
            this.Controls.Add(this.checklista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checklista;
        private System.Windows.Forms.Button przycisk;
        private System.Windows.Forms.TextBox tekst;
    }
}


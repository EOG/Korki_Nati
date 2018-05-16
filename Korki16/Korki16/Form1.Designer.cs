namespace Korki16
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
            this.Przez3 = new System.Windows.Forms.ListBox();
            this.Przez5 = new System.Windows.Forms.ListBox();
            this.Przez15 = new System.Windows.Forms.ListBox();
            this.iloscWynikow3 = new System.Windows.Forms.Label();
            this.iloscWynikow5 = new System.Windows.Forms.Label();
            this.iloscWynikow15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Przez3
            // 
            this.Przez3.FormattingEnabled = true;
            this.Przez3.Location = new System.Drawing.Point(12, 13);
            this.Przez3.Name = "Przez3";
            this.Przez3.Size = new System.Drawing.Size(262, 420);
            this.Przez3.TabIndex = 0;
            // 
            // Przez5
            // 
            this.Przez5.FormattingEnabled = true;
            this.Przez5.Location = new System.Drawing.Point(280, 13);
            this.Przez5.Name = "Przez5";
            this.Przez5.Size = new System.Drawing.Size(260, 420);
            this.Przez5.TabIndex = 2;
            // 
            // Przez15
            // 
            this.Przez15.FormattingEnabled = true;
            this.Przez15.Location = new System.Drawing.Point(546, 13);
            this.Przez15.Name = "Przez15";
            this.Przez15.Size = new System.Drawing.Size(242, 420);
            this.Przez15.TabIndex = 3;
            // 
            // iloscWynikow3
            // 
            this.iloscWynikow3.AutoSize = true;
            this.iloscWynikow3.Location = new System.Drawing.Point(112, 470);
            this.iloscWynikow3.Name = "iloscWynikow3";
            this.iloscWynikow3.Size = new System.Drawing.Size(35, 13);
            this.iloscWynikow3.TabIndex = 4;
            this.iloscWynikow3.Text = "label1";
            // 
            // iloscWynikow5
            // 
            this.iloscWynikow5.AutoSize = true;
            this.iloscWynikow5.Location = new System.Drawing.Point(386, 470);
            this.iloscWynikow5.Name = "iloscWynikow5";
            this.iloscWynikow5.Size = new System.Drawing.Size(35, 13);
            this.iloscWynikow5.TabIndex = 5;
            this.iloscWynikow5.Text = "label2";
            // 
            // iloscWynikow15
            // 
            this.iloscWynikow15.AutoSize = true;
            this.iloscWynikow15.Location = new System.Drawing.Point(641, 470);
            this.iloscWynikow15.Name = "iloscWynikow15";
            this.iloscWynikow15.Size = new System.Drawing.Size(35, 13);
            this.iloscWynikow15.TabIndex = 6;
            this.iloscWynikow15.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 501);
            this.Controls.Add(this.iloscWynikow15);
            this.Controls.Add(this.iloscWynikow5);
            this.Controls.Add(this.iloscWynikow3);
            this.Controls.Add(this.Przez15);
            this.Controls.Add(this.Przez5);
            this.Controls.Add(this.Przez3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Przez3;
        private System.Windows.Forms.ListBox Przez5;
        private System.Windows.Forms.ListBox Przez15;
        private System.Windows.Forms.Label iloscWynikow3;
        private System.Windows.Forms.Label iloscWynikow5;
        private System.Windows.Forms.Label iloscWynikow15;
    }
}


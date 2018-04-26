namespace Korki14
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
            this.Matematyka = new Korki14.Przedmiot();
            this.Fizyka = new Korki14.Przedmiot();
            this.Informatyka = new Korki14.Przedmiot();
            this.SuspendLayout();
            // 
            // Matematyka
            // 
            this.Matematyka.Location = new System.Drawing.Point(13, 13);
            this.Matematyka.Name = "Matematyka";
            this.Matematyka.Size = new System.Drawing.Size(175, 175);
            this.Matematyka.TabIndex = 0;
            // 
            // Fizyka
            // 
            this.Fizyka.Location = new System.Drawing.Point(194, 13);
            this.Fizyka.Name = "Fizyka";
            this.Fizyka.Size = new System.Drawing.Size(175, 175);
            this.Fizyka.TabIndex = 1;
            // 
            // Informatyka
            // 
            this.Informatyka.Location = new System.Drawing.Point(375, 13);
            this.Informatyka.Name = "Informatyka";
            this.Informatyka.Size = new System.Drawing.Size(175, 175);
            this.Informatyka.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 189);
            this.Controls.Add(this.Informatyka);
            this.Controls.Add(this.Fizyka);
            this.Controls.Add(this.Matematyka);
            this.Name = "Form1";
            this.Text = "Dzienniczek";
            this.ResumeLayout(false);

        }

        #endregion

        private Przedmiot Matematyka;
        private Przedmiot Fizyka;
        private Przedmiot Informatyka;
    }
}


namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSayi1 = new System.Windows.Forms.TextBox();
            this.textSayi2 = new System.Windows.Forms.TextBox();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2:";
            // 
            // textSayi1
            // 
            this.textSayi1.Location = new System.Drawing.Point(308, 114);
            this.textSayi1.Name = "textSayi1";
            this.textSayi1.Size = new System.Drawing.Size(125, 27);
            this.textSayi1.TabIndex = 2;
            // 
            // textSayi2
            // 
            this.textSayi2.Location = new System.Drawing.Point(318, 221);
            this.textSayi2.Name = "textSayi2";
            this.textSayi2.Size = new System.Drawing.Size(125, 27);
            this.textSayi2.TabIndex = 3;
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(574, 162);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(94, 29);
            this.buttonHesapla.TabIndex = 4;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.textSayi2);
            this.Controls.Add(this.textSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textSayi1;
        private TextBox textSayi2;
        private Button buttonHesapla;
    }
}
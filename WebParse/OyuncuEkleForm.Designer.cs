namespace WebParse
{
    partial class OyuncuEkleForm
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
            this.txtOyuncuAdSoyad = new System.Windows.Forms.TextBox();
            this.txtOyuncuTelefon = new System.Windows.Forms.TextBox();
            this.txtOyuncuAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOyuncuEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOyuncuAdSoyad
            // 
            this.txtOyuncuAdSoyad.Location = new System.Drawing.Point(90, 33);
            this.txtOyuncuAdSoyad.Name = "txtOyuncuAdSoyad";
            this.txtOyuncuAdSoyad.Size = new System.Drawing.Size(218, 23);
            this.txtOyuncuAdSoyad.TabIndex = 0;
            // 
            // txtOyuncuTelefon
            // 
            this.txtOyuncuTelefon.Location = new System.Drawing.Point(90, 94);
            this.txtOyuncuTelefon.Name = "txtOyuncuTelefon";
            this.txtOyuncuTelefon.Size = new System.Drawing.Size(218, 23);
            this.txtOyuncuTelefon.TabIndex = 1;
            // 
            // txtOyuncuAdres
            // 
            this.txtOyuncuAdres.Location = new System.Drawing.Point(90, 144);
            this.txtOyuncuAdres.Multiline = true;
            this.txtOyuncuAdres.Name = "txtOyuncuAdres";
            this.txtOyuncuAdres.Size = new System.Drawing.Size(218, 109);
            this.txtOyuncuAdres.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adres";
            // 
            // btnOyuncuEkle
            // 
            this.btnOyuncuEkle.Location = new System.Drawing.Point(200, 273);
            this.btnOyuncuEkle.Name = "btnOyuncuEkle";
            this.btnOyuncuEkle.Size = new System.Drawing.Size(108, 23);
            this.btnOyuncuEkle.TabIndex = 6;
            this.btnOyuncuEkle.Text = "Oyuncu Ekle";
            this.btnOyuncuEkle.UseVisualStyleBackColor = true;
            this.btnOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkle_Click);
            // 
            // OyuncuEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 321);
            this.Controls.Add(this.btnOyuncuEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOyuncuAdres);
            this.Controls.Add(this.txtOyuncuTelefon);
            this.Controls.Add(this.txtOyuncuAdSoyad);
            this.Name = "OyuncuEkleForm";
            this.Text = "OyuncuEkleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtOyuncuAdSoyad;
        private TextBox txtOyuncuTelefon;
        private TextBox txtOyuncuAdres;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnOyuncuEkle;
    }
}
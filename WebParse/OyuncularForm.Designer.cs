namespace WebParse
{
    partial class OyuncularForm
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
            this.dgvOyuncular = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOyuncular
            // 
            this.dgvOyuncular.AllowUserToAddRows = false;
            this.dgvOyuncular.AllowUserToDeleteRows = false;
            this.dgvOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOyuncular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AdSoyAd,
            this.Adres,
            this.Telefon});
            this.dgvOyuncular.Location = new System.Drawing.Point(12, 99);
            this.dgvOyuncular.Name = "dgvOyuncular";
            this.dgvOyuncular.ReadOnly = true;
            this.dgvOyuncular.RowTemplate.Height = 25;
            this.dgvOyuncular.Size = new System.Drawing.Size(462, 339);
            this.dgvOyuncular.TabIndex = 0;
            this.dgvOyuncular.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOyuncular_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // AdSoyAd
            // 
            this.AdSoyAd.HeaderText = "Adı Soyadı";
            this.AdSoyAd.Name = "AdSoyAd";
            this.AdSoyAd.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // OyuncularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOyuncular);
            this.Name = "OyuncularForm";
            this.Text = "OyuncularForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvOyuncular;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn AdSoyAd;
        private DataGridViewTextBoxColumn Adres;
        private DataGridViewTextBoxColumn Telefon;
    }
}
namespace WebParse
{
    partial class MainForm
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
            this.dvg_Filmler = new System.Windows.Forms.DataGridView();
            this.pbx_Poster = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_FilmBul = new System.Windows.Forms.TextBox();
            this.cmb_FilmBul = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yıl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdbPuanı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oyuncular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Filmler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Poster)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvg_Filmler
            // 
            this.dvg_Filmler.AllowUserToAddRows = false;
            this.dvg_Filmler.AllowUserToDeleteRows = false;
            this.dvg_Filmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Filmler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ad,
            this.Poster,
            this.Yıl,
            this.imdbPuanı,
            this.imdbId,
            this.Tur,
            this.Oyuncular});
            this.dvg_Filmler.Location = new System.Drawing.Point(12, 185);
            this.dvg_Filmler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvg_Filmler.Name = "dvg_Filmler";
            this.dvg_Filmler.ReadOnly = true;
            this.dvg_Filmler.RowHeadersWidth = 51;
            this.dvg_Filmler.RowTemplate.Height = 29;
            this.dvg_Filmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_Filmler.Size = new System.Drawing.Size(1024, 224);
            this.dvg_Filmler.TabIndex = 0;
            this.dvg_Filmler.SelectionChanged += new System.EventHandler(this.dvg_Filmler_SelectionChanged);
            // 
            // pbx_Poster
            // 
            this.pbx_Poster.Location = new System.Drawing.Point(372, 26);
            this.pbx_Poster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbx_Poster.Name = "pbx_Poster";
            this.pbx_Poster.Size = new System.Drawing.Size(221, 128);
            this.pbx_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Poster.TabIndex = 1;
            this.pbx_Poster.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmlerToolStripMenuItem,
            this.türlerToolStripMenuItem,
            this.fimEkleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1048, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmlerToolStripMenuItem
            // 
            this.filmlerToolStripMenuItem.Name = "filmlerToolStripMenuItem";
            this.filmlerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.filmlerToolStripMenuItem.Text = "Oyuncular";
            // 
            // türlerToolStripMenuItem
            // 
            this.türlerToolStripMenuItem.Name = "türlerToolStripMenuItem";
            this.türlerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.türlerToolStripMenuItem.Text = "Türler";
            // 
            // fimEkleToolStripMenuItem
            // 
            this.fimEkleToolStripMenuItem.Name = "fimEkleToolStripMenuItem";
            this.fimEkleToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fimEkleToolStripMenuItem.Text = "Fim Ekle";
            // 
            // txt_FilmBul
            // 
            this.txt_FilmBul.Location = new System.Drawing.Point(12, 158);
            this.txt_FilmBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FilmBul.Name = "txt_FilmBul";
            this.txt_FilmBul.Size = new System.Drawing.Size(304, 23);
            this.txt_FilmBul.TabIndex = 3;
            // 
            // cmb_FilmBul
            // 
            this.cmb_FilmBul.FormattingEnabled = true;
            this.cmb_FilmBul.Location = new System.Drawing.Point(627, 158);
            this.cmb_FilmBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_FilmBul.Name = "cmb_FilmBul";
            this.cmb_FilmBul.Size = new System.Drawing.Size(306, 23);
            this.cmb_FilmBul.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.HeaderText = "Film ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "AD";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            this.Ad.Width = 125;
            // 
            // Poster
            // 
            this.Poster.HeaderText = "Poster";
            this.Poster.MinimumWidth = 6;
            this.Poster.Name = "Poster";
            this.Poster.ReadOnly = true;
            this.Poster.Width = 125;
            // 
            // Yıl
            // 
            this.Yıl.HeaderText = "Yıl";
            this.Yıl.MinimumWidth = 6;
            this.Yıl.Name = "Yıl";
            this.Yıl.ReadOnly = true;
            this.Yıl.Width = 125;
            // 
            // imdbPuanı
            // 
            this.imdbPuanı.HeaderText = "Imdb Puanı";
            this.imdbPuanı.MinimumWidth = 6;
            this.imdbPuanı.Name = "imdbPuanı";
            this.imdbPuanı.ReadOnly = true;
            this.imdbPuanı.Width = 125;
            // 
            // imdbId
            // 
            this.imdbId.HeaderText = "imdb ID";
            this.imdbId.MinimumWidth = 6;
            this.imdbId.Name = "imdbId";
            this.imdbId.ReadOnly = true;
            this.imdbId.Width = 125;
            // 
            // Tur
            // 
            this.Tur.HeaderText = "TurAdı";
            this.Tur.MinimumWidth = 6;
            this.Tur.Name = "Tur";
            this.Tur.ReadOnly = true;
            this.Tur.Width = 125;
            // 
            // Oyuncular
            // 
            this.Oyuncular.HeaderText = "Oyuncular";
            this.Oyuncular.MinimumWidth = 6;
            this.Oyuncular.Name = "Oyuncular";
            this.Oyuncular.ReadOnly = true;
            this.Oyuncular.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 420);
            this.Controls.Add(this.cmb_FilmBul);
            this.Controls.Add(this.txt_FilmBul);
            this.Controls.Add(this.pbx_Poster);
            this.Controls.Add(this.dvg_Filmler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Filmler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Poster)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dvg_Filmler;
        private PictureBox pbx_Poster;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filmlerToolStripMenuItem;
        private TextBox txt_FilmBul;
        private ComboBox cmb_FilmBul;
        private ToolStripMenuItem türlerToolStripMenuItem;
        private ToolStripMenuItem fimEkleToolStripMenuItem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ad;
        private DataGridViewTextBoxColumn Poster;
        private DataGridViewTextBoxColumn Yıl;
        private DataGridViewTextBoxColumn imdbPuanı;
        private DataGridViewTextBoxColumn imdbId;
        private DataGridViewTextBoxColumn Tur;
        private DataGridViewTextBoxColumn Oyuncular;
    }
}
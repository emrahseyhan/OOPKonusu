
namespace WindowsFormsAppileOPP
{
    partial class FrmGiris
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOgrenci = new System.Windows.Forms.TabPage();
            this.listBoxOgrenciler = new System.Windows.Forms.ListBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.cmbBoxOgrCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtOgrTel = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrTc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageOgretmen = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPageOgrenci.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOgrenci);
            this.tabControl1.Controls.Add(this.tabPageOgretmen);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageOgrenci
            // 
            this.tabPageOgrenci.Controls.Add(this.listBoxOgrenciler);
            this.tabPageOgrenci.Controls.Add(this.btnOgrenciEkle);
            this.tabPageOgrenci.Controls.Add(this.cmbBoxOgrCinsiyet);
            this.tabPageOgrenci.Controls.Add(this.txtOgrTel);
            this.tabPageOgrenci.Controls.Add(this.txtOgrSoyad);
            this.tabPageOgrenci.Controls.Add(this.txtOgrAd);
            this.tabPageOgrenci.Controls.Add(this.txtOgrTc);
            this.tabPageOgrenci.Controls.Add(this.label4);
            this.tabPageOgrenci.Controls.Add(this.label5);
            this.tabPageOgrenci.Controls.Add(this.label3);
            this.tabPageOgrenci.Controls.Add(this.label2);
            this.tabPageOgrenci.Controls.Add(this.label1);
            this.tabPageOgrenci.Location = new System.Drawing.Point(4, 25);
            this.tabPageOgrenci.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOgrenci.Name = "tabPageOgrenci";
            this.tabPageOgrenci.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOgrenci.Size = new System.Drawing.Size(927, 397);
            this.tabPageOgrenci.TabIndex = 0;
            this.tabPageOgrenci.Text = "Öğrenci Kayıt İşlemleri";
            this.tabPageOgrenci.UseVisualStyleBackColor = true;
            // 
            // listBoxOgrenciler
            // 
            this.listBoxOgrenciler.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxOgrenciler.FormattingEnabled = true;
            this.listBoxOgrenciler.ItemHeight = 16;
            this.listBoxOgrenciler.Location = new System.Drawing.Point(505, 41);
            this.listBoxOgrenciler.Name = "listBoxOgrenciler";
            this.listBoxOgrenciler.Size = new System.Drawing.Size(400, 276);
            this.listBoxOgrenciler.TabIndex = 4;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciEkle.Location = new System.Drawing.Point(46, 277);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(435, 42);
            this.btnOgrenciEkle.TabIndex = 6;
            this.btnOgrenciEkle.Text = "KAYIT ET";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // cmbBoxOgrCinsiyet
            // 
            this.cmbBoxOgrCinsiyet.FormattingEnabled = true;
            this.cmbBoxOgrCinsiyet.Location = new System.Drawing.Point(145, 179);
            this.cmbBoxOgrCinsiyet.Name = "cmbBoxOgrCinsiyet";
            this.cmbBoxOgrCinsiyet.Size = new System.Drawing.Size(336, 24);
            this.cmbBoxOgrCinsiyet.TabIndex = 4;
            // 
            // txtOgrTel
            // 
            this.txtOgrTel.Location = new System.Drawing.Point(145, 226);
            this.txtOgrTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrTel.Name = "txtOgrTel";
            this.txtOgrTel.Size = new System.Drawing.Size(336, 23);
            this.txtOgrTel.TabIndex = 5;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(145, 133);
            this.txtOgrSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(336, 23);
            this.txtOgrSoyad.TabIndex = 3;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(145, 87);
            this.txtOgrAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(336, 23);
            this.txtOgrAd.TabIndex = 2;
            // 
            // txtOgrTc
            // 
            this.txtOgrTc.Location = new System.Drawing.Point(145, 41);
            this.txtOgrTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrTc.Name = "txtOgrTc";
            this.txtOgrTc.Size = new System.Drawing.Size(336, 23);
            this.txtOgrTc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyadınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adınız:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKimlik:";
            // 
            // tabPageOgretmen
            // 
            this.tabPageOgretmen.Location = new System.Drawing.Point(4, 25);
            this.tabPageOgretmen.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOgretmen.Name = "tabPageOgretmen";
            this.tabPageOgretmen.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOgretmen.Size = new System.Drawing.Size(927, 397);
            this.tabPageOgretmen.TabIndex = 1;
            this.tabPageOgretmen.Text = "Öğretmen Kayıt İşlemleri";
            this.tabPageOgretmen.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 426);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiris";
            this.Text = "KAYIT İŞLEM FORMU";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOgrenci.ResumeLayout(false);
            this.tabPageOgrenci.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOgrenci;
        private System.Windows.Forms.TextBox txtOgrTel;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageOgretmen;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.ComboBox cmbBoxOgrCinsiyet;
        private System.Windows.Forms.ListBox listBoxOgrenciler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}


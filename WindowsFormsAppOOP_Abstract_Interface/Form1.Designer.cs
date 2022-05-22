
namespace WindowsFormsAppOOP_Abstract_Interface
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
            this.grpBoxIslemler = new System.Windows.Forms.GroupBox();
            this.btnCevreHesapla = new System.Windows.Forms.Button();
            this.btnAlanHesapla = new System.Windows.Forms.Button();
            this.txtKenar2 = new System.Windows.Forms.TextBox();
            this.txtSekilAd = new System.Windows.Forms.TextBox();
            this.txtKenar1 = new System.Windows.Forms.TextBox();
            this.lblSekilAdi = new System.Windows.Forms.Label();
            this.lblKenar2 = new System.Windows.Forms.Label();
            this.lblKenar1 = new System.Windows.Forms.Label();
            this.checkBoxKare = new System.Windows.Forms.CheckBox();
            this.checkBoxDikdortgen = new System.Windows.Forms.CheckBox();
            this.grpBoxIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxIslemler
            // 
            this.grpBoxIslemler.Controls.Add(this.btnCevreHesapla);
            this.grpBoxIslemler.Controls.Add(this.btnAlanHesapla);
            this.grpBoxIslemler.Controls.Add(this.txtKenar2);
            this.grpBoxIslemler.Controls.Add(this.txtSekilAd);
            this.grpBoxIslemler.Controls.Add(this.txtKenar1);
            this.grpBoxIslemler.Controls.Add(this.lblSekilAdi);
            this.grpBoxIslemler.Controls.Add(this.lblKenar2);
            this.grpBoxIslemler.Controls.Add(this.lblKenar1);
            this.grpBoxIslemler.Location = new System.Drawing.Point(46, 64);
            this.grpBoxIslemler.Name = "grpBoxIslemler";
            this.grpBoxIslemler.Size = new System.Drawing.Size(371, 282);
            this.grpBoxIslemler.TabIndex = 2;
            this.grpBoxIslemler.TabStop = false;
            // 
            // btnCevreHesapla
            // 
            this.btnCevreHesapla.Location = new System.Drawing.Point(46, 203);
            this.btnCevreHesapla.Name = "btnCevreHesapla";
            this.btnCevreHesapla.Size = new System.Drawing.Size(277, 38);
            this.btnCevreHesapla.TabIndex = 3;
            this.btnCevreHesapla.Text = "ÇEVRE HESAPLA";
            this.btnCevreHesapla.UseVisualStyleBackColor = true;
            // 
            // btnAlanHesapla
            // 
            this.btnAlanHesapla.Location = new System.Drawing.Point(46, 149);
            this.btnAlanHesapla.Name = "btnAlanHesapla";
            this.btnAlanHesapla.Size = new System.Drawing.Size(277, 38);
            this.btnAlanHesapla.TabIndex = 3;
            this.btnAlanHesapla.Text = "ALAN HESAPLA";
            this.btnAlanHesapla.UseVisualStyleBackColor = true;
        
            // 
            // txtKenar2
            // 
            this.txtKenar2.Location = new System.Drawing.Point(139, 108);
            this.txtKenar2.Name = "txtKenar2";
            this.txtKenar2.Size = new System.Drawing.Size(179, 24);
            this.txtKenar2.TabIndex = 3;
            // 
            // txtSekilAd
            // 
            this.txtSekilAd.Location = new System.Drawing.Point(139, 23);
            this.txtSekilAd.Name = "txtSekilAd";
            this.txtSekilAd.Size = new System.Drawing.Size(179, 24);
            this.txtSekilAd.TabIndex = 3;
            // 
            // txtKenar1
            // 
            this.txtKenar1.Location = new System.Drawing.Point(139, 65);
            this.txtKenar1.Name = "txtKenar1";
            this.txtKenar1.Size = new System.Drawing.Size(179, 24);
            this.txtKenar1.TabIndex = 3;
            // 
            // lblSekilAdi
            // 
            this.lblSekilAdi.AutoSize = true;
            this.lblSekilAdi.Location = new System.Drawing.Point(19, 26);
            this.lblSekilAdi.Name = "lblSekilAdi";
            this.lblSekilAdi.Size = new System.Drawing.Size(91, 18);
            this.lblSekilAdi.TabIndex = 0;
            this.lblSekilAdi.Text = "ŞEKLİN ADI:";
            // 
            // lblKenar2
            // 
            this.lblKenar2.AutoSize = true;
            this.lblKenar2.Location = new System.Drawing.Point(38, 108);
            this.lblKenar2.Name = "lblKenar2";
            this.lblKenar2.Size = new System.Drawing.Size(63, 18);
            this.lblKenar2.TabIndex = 0;
            this.lblKenar2.Text = "KENAR:";
            // 
            // lblKenar1
            // 
            this.lblKenar1.AutoSize = true;
            this.lblKenar1.Location = new System.Drawing.Point(38, 68);
            this.lblKenar1.Name = "lblKenar1";
            this.lblKenar1.Size = new System.Drawing.Size(63, 18);
            this.lblKenar1.TabIndex = 0;
            this.lblKenar1.Text = "KENAR:";
            // 
            // checkBoxKare
            // 
            this.checkBoxKare.AutoSize = true;
            this.checkBoxKare.Location = new System.Drawing.Point(118, 27);
            this.checkBoxKare.Name = "checkBoxKare";
            this.checkBoxKare.Size = new System.Drawing.Size(67, 22);
            this.checkBoxKare.TabIndex = 3;
            this.checkBoxKare.Text = "KARE";
            this.checkBoxKare.UseVisualStyleBackColor = true;
            this.checkBoxKare.CheckedChanged += new System.EventHandler(this.checkBoxKare_CheckedChanged);
            // 
            // checkBoxDikdortgen
            // 
            this.checkBoxDikdortgen.AutoSize = true;
            this.checkBoxDikdortgen.Location = new System.Drawing.Point(212, 27);
            this.checkBoxDikdortgen.Name = "checkBoxDikdortgen";
            this.checkBoxDikdortgen.Size = new System.Drawing.Size(127, 22);
            this.checkBoxDikdortgen.TabIndex = 3;
            this.checkBoxDikdortgen.Text = "DİKDÖRTGEN";
            this.checkBoxDikdortgen.UseVisualStyleBackColor = true;
            this.checkBoxDikdortgen.CheckedChanged += new System.EventHandler(this.checkBoxDikdortgen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 382);
            this.Controls.Add(this.checkBoxDikdortgen);
            this.Controls.Add(this.checkBoxKare);
            this.Controls.Add(this.grpBoxIslemler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxIslemler.ResumeLayout(false);
            this.grpBoxIslemler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBoxIslemler;
        private System.Windows.Forms.Button btnCevreHesapla;
        private System.Windows.Forms.Button btnAlanHesapla;
        private System.Windows.Forms.TextBox txtKenar2;
        private System.Windows.Forms.TextBox txtSekilAd;
        private System.Windows.Forms.TextBox txtKenar1;
        private System.Windows.Forms.Label lblSekilAdi;
        private System.Windows.Forms.Label lblKenar2;
        private System.Windows.Forms.Label lblKenar1;
        private System.Windows.Forms.CheckBox checkBoxKare;
        private System.Windows.Forms.CheckBox checkBoxDikdortgen;
    }
}


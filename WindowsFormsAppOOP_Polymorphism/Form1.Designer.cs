
namespace WindowsFormsAppOOP_Polymorphism
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
            this.components = new System.ComponentModel.Container();
            this.radioBtnAkbil = new System.Windows.Forms.RadioButton();
            this.radioBtnOgrenci = new System.Windows.Forms.RadioButton();
            this.radioBtnMaviKart = new System.Windows.Forms.RadioButton();
            this.btnAkbilBas = new System.Windows.Forms.Button();
            this.groupBoxBakiye = new System.Windows.Forms.GroupBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblAkbilUcreti = new System.Windows.Forms.Label();
            this.lblOncekiBakiye = new System.Windows.Forms.Label();
            this.timerSistemSaati = new System.Windows.Forms.Timer(this.components);
            this.timerRenkDegisimi = new System.Windows.Forms.Timer(this.components);
            this.groupBoxBakiye.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnAkbil
            // 
            this.radioBtnAkbil.AutoSize = true;
            this.radioBtnAkbil.Location = new System.Drawing.Point(53, 31);
            this.radioBtnAkbil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnAkbil.Name = "radioBtnAkbil";
            this.radioBtnAkbil.Size = new System.Drawing.Size(127, 24);
            this.radioBtnAkbil.TabIndex = 0;
            this.radioBtnAkbil.TabStop = true;
            this.radioBtnAkbil.Text = "Standart Akbil";
            this.radioBtnAkbil.UseVisualStyleBackColor = true;
            // 
            // radioBtnOgrenci
            // 
            this.radioBtnOgrenci.AutoSize = true;
            this.radioBtnOgrenci.Location = new System.Drawing.Point(209, 31);
            this.radioBtnOgrenci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnOgrenci.Name = "radioBtnOgrenci";
            this.radioBtnOgrenci.Size = new System.Drawing.Size(123, 24);
            this.radioBtnOgrenci.TabIndex = 1;
            this.radioBtnOgrenci.TabStop = true;
            this.radioBtnOgrenci.Text = "Öğrenci Akbili";
            this.radioBtnOgrenci.UseVisualStyleBackColor = true;
            // 
            // radioBtnMaviKart
            // 
            this.radioBtnMaviKart.AutoSize = true;
            this.radioBtnMaviKart.Location = new System.Drawing.Point(370, 31);
            this.radioBtnMaviKart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnMaviKart.Name = "radioBtnMaviKart";
            this.radioBtnMaviKart.Size = new System.Drawing.Size(92, 24);
            this.radioBtnMaviKart.TabIndex = 2;
            this.radioBtnMaviKart.TabStop = true;
            this.radioBtnMaviKart.Text = "Mavi Kart";
            this.radioBtnMaviKart.UseVisualStyleBackColor = true;
            // 
            // btnAkbilBas
            // 
            this.btnAkbilBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAkbilBas.Location = new System.Drawing.Point(53, 86);
            this.btnAkbilBas.Name = "btnAkbilBas";
            this.btnAkbilBas.Size = new System.Drawing.Size(409, 95);
            this.btnAkbilBas.TabIndex = 3;
            this.btnAkbilBas.Text = "AKBİL BAS";
            this.btnAkbilBas.UseVisualStyleBackColor = true;
            this.btnAkbilBas.Click += new System.EventHandler(this.btnAkbilBas_Click);
            // 
            // groupBoxBakiye
            // 
            this.groupBoxBakiye.Controls.Add(this.lblBakiye);
            this.groupBoxBakiye.Controls.Add(this.lblAkbilUcreti);
            this.groupBoxBakiye.Controls.Add(this.lblOncekiBakiye);
            this.groupBoxBakiye.Location = new System.Drawing.Point(493, 31);
            this.groupBoxBakiye.Name = "groupBoxBakiye";
            this.groupBoxBakiye.Size = new System.Drawing.Size(200, 150);
            this.groupBoxBakiye.TabIndex = 4;
            this.groupBoxBakiye.TabStop = false;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(15, 112);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(24, 20);
            this.lblBakiye.TabIndex = 7;
            this.lblBakiye.Text = "---";
            // 
            // lblAkbilUcreti
            // 
            this.lblAkbilUcreti.AutoSize = true;
            this.lblAkbilUcreti.Location = new System.Drawing.Point(15, 67);
            this.lblAkbilUcreti.Name = "lblAkbilUcreti";
            this.lblAkbilUcreti.Size = new System.Drawing.Size(24, 20);
            this.lblAkbilUcreti.TabIndex = 6;
            this.lblAkbilUcreti.Text = "---";
            // 
            // lblOncekiBakiye
            // 
            this.lblOncekiBakiye.AutoSize = true;
            this.lblOncekiBakiye.Location = new System.Drawing.Point(15, 22);
            this.lblOncekiBakiye.Name = "lblOncekiBakiye";
            this.lblOncekiBakiye.Size = new System.Drawing.Size(24, 20);
            this.lblOncekiBakiye.TabIndex = 5;
            this.lblOncekiBakiye.Text = "---";
            // 
            // timerSistemSaati
            // 
            this.timerSistemSaati.Tick += new System.EventHandler(this.timerSistemSaati_Tick);
            // 
            // timerRenkDegisimi
            // 
            this.timerRenkDegisimi.Tick += new System.EventHandler(this.timerRenkDegisimi_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 230);
            this.Controls.Add(this.groupBoxBakiye);
            this.Controls.Add(this.btnAkbilBas);
            this.Controls.Add(this.radioBtnMaviKart);
            this.Controls.Add(this.radioBtnOgrenci);
            this.Controls.Add(this.radioBtnAkbil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxBakiye.ResumeLayout(false);
            this.groupBoxBakiye.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnAkbil;
        private System.Windows.Forms.RadioButton radioBtnOgrenci;
        private System.Windows.Forms.RadioButton radioBtnMaviKart;
        private System.Windows.Forms.Button btnAkbilBas;
        private System.Windows.Forms.GroupBox groupBoxBakiye;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblAkbilUcreti;
        private System.Windows.Forms.Label lblOncekiBakiye;
        private System.Windows.Forms.Timer timerSistemSaati;
        private System.Windows.Forms.Timer timerRenkDegisimi;
    }
}


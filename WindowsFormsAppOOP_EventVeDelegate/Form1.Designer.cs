
namespace WindowsFormsAppOOP_EventVeDelegate
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
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.radioBtnMasterKart = new System.Windows.Forms.RadioButton();
            this.radioBtnVisaKart = new System.Windows.Forms.RadioButton();
            this.btnOde = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKartSahibi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(79, 215);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(311, 24);
            this.txtTutar.TabIndex = 0;
            // 
            // radioBtnMasterKart
            // 
            this.radioBtnMasterKart.AutoSize = true;
            this.radioBtnMasterKart.Location = new System.Drawing.Point(75, 37);
            this.radioBtnMasterKart.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnMasterKart.Name = "radioBtnMasterKart";
            this.radioBtnMasterKart.Size = new System.Drawing.Size(142, 22);
            this.radioBtnMasterKart.TabIndex = 1;
            this.radioBtnMasterKart.TabStop = true;
            this.radioBtnMasterKart.Text = "MASTER KART";
            this.radioBtnMasterKart.UseVisualStyleBackColor = true;
            this.radioBtnMasterKart.CheckedChanged += new System.EventHandler(this.radioBtnMasterKart_CheckedChanged);
            // 
            // radioBtnVisaKart
            // 
            this.radioBtnVisaKart.AutoSize = true;
            this.radioBtnVisaKart.Location = new System.Drawing.Point(281, 37);
            this.radioBtnVisaKart.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnVisaKart.Name = "radioBtnVisaKart";
            this.radioBtnVisaKart.Size = new System.Drawing.Size(109, 22);
            this.radioBtnVisaKart.TabIndex = 1;
            this.radioBtnVisaKart.TabStop = true;
            this.radioBtnVisaKart.Text = "VİSA KART";
            this.radioBtnVisaKart.UseVisualStyleBackColor = true;
            this.radioBtnVisaKart.CheckedChanged += new System.EventHandler(this.radioBtnVisaKart_CheckedChanged);
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(75, 273);
            this.btnOde.Margin = new System.Windows.Forms.Padding(4);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(315, 49);
            this.btnOde.TabIndex = 2;
            this.btnOde.Text = "ÖDEMEYİ YAP";
            this.btnOde.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "ALIŞVERİŞ TUTARINIZI GİRİNİZ: ";
            // 
            // txtKartSahibi
            // 
            this.txtKartSahibi.Location = new System.Drawing.Point(79, 127);
            this.txtKartSahibi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKartSahibi.Name = "txtKartSahibi";
            this.txtKartSahibi.Size = new System.Drawing.Size(311, 24);
            this.txtKartSahibi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "KART SAHİBİ AD SOYAD:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.radioBtnVisaKart);
            this.Controls.Add(this.txtKartSahibi);
            this.Controls.Add(this.radioBtnMasterKart);
            this.Controls.Add(this.txtTutar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.RadioButton radioBtnMasterKart;
        private System.Windows.Forms.RadioButton radioBtnVisaKart;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKartSahibi;
        private System.Windows.Forms.Label label2;
    }
}


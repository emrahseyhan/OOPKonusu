
namespace WindowsFormsAppOOP_StructVeClassFarklari
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgr1 = new System.Windows.Forms.TextBox();
            this.txtOgr2 = new System.Windows.Forms.TextBox();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnStruct = new System.Windows.Forms.Button();
            this.richTextBoxSonuc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birinci Öğrenci Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "İkinci Öğrenci Ad Soyad:";
            // 
            // txtOgr1
            // 
            this.txtOgr1.Location = new System.Drawing.Point(37, 48);
            this.txtOgr1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOgr1.Name = "txtOgr1";
            this.txtOgr1.Size = new System.Drawing.Size(429, 24);
            this.txtOgr1.TabIndex = 2;
            // 
            // txtOgr2
            // 
            this.txtOgr2.Location = new System.Drawing.Point(37, 117);
            this.txtOgr2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOgr2.Name = "txtOgr2";
            this.txtOgr2.Size = new System.Drawing.Size(429, 24);
            this.txtOgr2.TabIndex = 3;
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(56, 168);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(173, 67);
            this.btnClass.TabIndex = 4;
            this.btnClass.Text = "CLASSTAN ÖĞRENCİ OLUŞTUR";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnStruct
            // 
            this.btnStruct.Location = new System.Drawing.Point(277, 168);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(173, 67);
            this.btnStruct.TabIndex = 5;
            this.btnStruct.Text = "STRUCTAN ÖĞRENCİ OLUŞTUR";
            this.btnStruct.UseVisualStyleBackColor = true;
            this.btnStruct.Click += new System.EventHandler(this.btnStruct_Click);
            // 
            // richTextBoxSonuc
            // 
            this.richTextBoxSonuc.Location = new System.Drawing.Point(509, 37);
            this.richTextBoxSonuc.Name = "richTextBoxSonuc";
            this.richTextBoxSonuc.Size = new System.Drawing.Size(361, 198);
            this.richTextBoxSonuc.TabIndex = 6;
            this.richTextBoxSonuc.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 283);
            this.Controls.Add(this.richTextBoxSonuc);
            this.Controls.Add(this.btnStruct);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.txtOgr2);
            this.Controls.Add(this.txtOgr1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgr1;
        private System.Windows.Forms.TextBox txtOgr2;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnStruct;
        private System.Windows.Forms.RichTextBox richTextBoxSonuc;
    }
}


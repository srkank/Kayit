namespace ilk
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lstAD = new System.Windows.Forms.ListBox();
            this.lstSoyad = new System.Windows.Forms.ListBox();
            this.lstTelefon = new System.Windows.Forms.ListBox();
            this.lstEmail = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(69, 57);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(185, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(325, 57);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(185, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(583, 56);
            this.mtxtTelefon.Mask = "(999) 000-0000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(191, 20);
            this.mtxtTelefon.TabIndex = 2;
            // 
            // lstAD
            // 
            this.lstAD.FormattingEnabled = true;
            this.lstAD.Location = new System.Drawing.Point(69, 153);
            this.lstAD.Name = "lstAD";
            this.lstAD.Size = new System.Drawing.Size(120, 173);
            this.lstAD.TabIndex = 3;
            this.lstAD.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstSoyad
            // 
            this.lstSoyad.FormattingEnabled = true;
            this.lstSoyad.Location = new System.Drawing.Point(241, 153);
            this.lstSoyad.Name = "lstSoyad";
            this.lstSoyad.Size = new System.Drawing.Size(120, 173);
            this.lstSoyad.TabIndex = 4;
            // 
            // lstTelefon
            // 
            this.lstTelefon.FormattingEnabled = true;
            this.lstTelefon.Location = new System.Drawing.Point(444, 153);
            this.lstTelefon.Name = "lstTelefon";
            this.lstTelefon.Size = new System.Drawing.Size(120, 173);
            this.lstTelefon.TabIndex = 5;
            // 
            // lstEmail
            // 
            this.lstEmail.FormattingEnabled = true;
            this.lstEmail.Location = new System.Drawing.Point(654, 153);
            this.lstEmail.Name = "lstEmail";
            this.lstEmail.Size = new System.Drawing.Size(120, 173);
            this.lstEmail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TELEFON";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEmail);
            this.Controls.Add(this.lstTelefon);
            this.Controls.Add(this.lstSoyad);
            this.Controls.Add(this.lstAD);
            this.Controls.Add(this.mtxtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.ListBox lstAD;
        private System.Windows.Forms.ListBox lstSoyad;
        private System.Windows.Forms.ListBox lstTelefon;
        private System.Windows.Forms.ListBox lstEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}


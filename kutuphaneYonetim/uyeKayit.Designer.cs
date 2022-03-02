namespace kutuphaneYonetim
{
    partial class uyeKayit
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.tcNoTBox = new System.Windows.Forms.TextBox();
            this.adSadTBox = new System.Windows.Forms.TextBox();
            this.telTBox = new System.Windows.Forms.TextBox();
            this.ePosTbox = new System.Windows.Forms.TextBox();
            this.uyeTarihDTPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Posta :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Üyelik Tarihi :";
            // 
            // kaydetButton
            // 
            this.kaydetButton.Location = new System.Drawing.Point(217, 166);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(75, 23);
            this.kaydetButton.TabIndex = 12;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tcNoTBox
            // 
            this.tcNoTBox.Location = new System.Drawing.Point(92, 29);
            this.tcNoTBox.Name = "tcNoTBox";
            this.tcNoTBox.Size = new System.Drawing.Size(200, 20);
            this.tcNoTBox.TabIndex = 13;
            // 
            // adSadTBox
            // 
            this.adSadTBox.Location = new System.Drawing.Point(92, 55);
            this.adSadTBox.Name = "adSadTBox";
            this.adSadTBox.Size = new System.Drawing.Size(200, 20);
            this.adSadTBox.TabIndex = 14;
            // 
            // telTBox
            // 
            this.telTBox.Location = new System.Drawing.Point(92, 81);
            this.telTBox.Name = "telTBox";
            this.telTBox.Size = new System.Drawing.Size(200, 20);
            this.telTBox.TabIndex = 15;
            // 
            // ePosTbox
            // 
            this.ePosTbox.Location = new System.Drawing.Point(92, 107);
            this.ePosTbox.Name = "ePosTbox";
            this.ePosTbox.Size = new System.Drawing.Size(200, 20);
            this.ePosTbox.TabIndex = 16;
            // 
            // uyeTarihDTPicker
            // 
            this.uyeTarihDTPicker.Location = new System.Drawing.Point(92, 133);
            this.uyeTarihDTPicker.Name = "uyeTarihDTPicker";
            this.uyeTarihDTPicker.Size = new System.Drawing.Size(200, 20);
            this.uyeTarihDTPicker.TabIndex = 17;
            // 
            // uyeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 201);
            this.Controls.Add(this.uyeTarihDTPicker);
            this.Controls.Add(this.ePosTbox);
            this.Controls.Add(this.telTBox);
            this.Controls.Add(this.adSadTBox);
            this.Controls.Add(this.tcNoTBox);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "uyeKayit";
            this.Text = "Üye Kayıt Sayfası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.TextBox tcNoTBox;
        private System.Windows.Forms.TextBox adSadTBox;
        private System.Windows.Forms.TextBox telTBox;
        private System.Windows.Forms.TextBox ePosTbox;
        private System.Windows.Forms.DateTimePicker uyeTarihDTPicker;
    }
}
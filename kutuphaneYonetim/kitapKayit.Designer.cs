namespace kutuphaneYonetim
{
    partial class kitapKayit
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
            this.ktpKydtButton = new System.Windows.Forms.Button();
            this.kitapAdTbox = new System.Windows.Forms.TextBox();
            this.yzrEkleButton = new System.Windows.Forms.Button();
            this.yynEvEkle = new System.Windows.Forms.Button();
            this.kitapTurCbox = new System.Windows.Forms.ComboBox();
            this.yazarAdCbox = new System.Windows.Forms.ComboBox();
            this.yayinEviCbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yayınevi Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap Türü";
            // 
            // ktpKydtButton
            // 
            this.ktpKydtButton.Location = new System.Drawing.Point(289, 145);
            this.ktpKydtButton.Name = "ktpKydtButton";
            this.ktpKydtButton.Size = new System.Drawing.Size(94, 23);
            this.ktpKydtButton.TabIndex = 7;
            this.ktpKydtButton.Text = "Kaydet";
            this.ktpKydtButton.UseVisualStyleBackColor = true;
            this.ktpKydtButton.Click += new System.EventHandler(this.ktpKydtButton_Click);
            // 
            // kitapAdTbox
            // 
            this.kitapAdTbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kitapAdTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kitapAdTbox.Location = new System.Drawing.Point(104, 31);
            this.kitapAdTbox.Name = "kitapAdTbox";
            this.kitapAdTbox.Size = new System.Drawing.Size(200, 20);
            this.kitapAdTbox.TabIndex = 9;
            // 
            // yzrEkleButton
            // 
            this.yzrEkleButton.Location = new System.Drawing.Point(310, 57);
            this.yzrEkleButton.Name = "yzrEkleButton";
            this.yzrEkleButton.Size = new System.Drawing.Size(83, 21);
            this.yzrEkleButton.TabIndex = 13;
            this.yzrEkleButton.Text = "Yazar Ekle";
            this.yzrEkleButton.UseVisualStyleBackColor = true;
            this.yzrEkleButton.Click += new System.EventHandler(this.yzrEkleButton_Click);
            // 
            // yynEvEkle
            // 
            this.yynEvEkle.Location = new System.Drawing.Point(310, 84);
            this.yynEvEkle.Name = "yynEvEkle";
            this.yynEvEkle.Size = new System.Drawing.Size(83, 21);
            this.yynEvEkle.TabIndex = 14;
            this.yynEvEkle.Text = "Yayınevi Ekle";
            this.yynEvEkle.UseVisualStyleBackColor = true;
            this.yynEvEkle.Click += new System.EventHandler(this.yynEvEkle_Click);
            // 
            // kitapTurCbox
            // 
            this.kitapTurCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kitapTurCbox.FormattingEnabled = true;
            this.kitapTurCbox.Items.AddRange(new object[] {
            "Roman",
            "Şiir",
            "Deneme",
            "Biyografi",
            "Masal",
            "Bilim",
            "Eğitim",
            "Araştırma",
            "Tarih"});
            this.kitapTurCbox.Location = new System.Drawing.Point(104, 109);
            this.kitapTurCbox.Name = "kitapTurCbox";
            this.kitapTurCbox.Size = new System.Drawing.Size(200, 21);
            this.kitapTurCbox.TabIndex = 15;
            // 
            // yazarAdCbox
            // 
            this.yazarAdCbox.BackColor = System.Drawing.Color.White;
            this.yazarAdCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yazarAdCbox.FormattingEnabled = true;
            this.yazarAdCbox.Location = new System.Drawing.Point(104, 57);
            this.yazarAdCbox.Name = "yazarAdCbox";
            this.yazarAdCbox.Size = new System.Drawing.Size(200, 21);
            this.yazarAdCbox.TabIndex = 16;
            // 
            // yayinEviCbox
            // 
            this.yayinEviCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yayinEviCbox.FormattingEnabled = true;
            this.yayinEviCbox.Location = new System.Drawing.Point(104, 83);
            this.yayinEviCbox.Name = "yayinEviCbox";
            this.yayinEviCbox.Size = new System.Drawing.Size(200, 21);
            this.yayinEviCbox.TabIndex = 17;
            // 
            // kitapKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(411, 180);
            this.Controls.Add(this.yayinEviCbox);
            this.Controls.Add(this.yazarAdCbox);
            this.Controls.Add(this.kitapTurCbox);
            this.Controls.Add(this.yynEvEkle);
            this.Controls.Add(this.yzrEkleButton);
            this.Controls.Add(this.kitapAdTbox);
            this.Controls.Add(this.ktpKydtButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "kitapKayit";
            this.Text = "Kitap Kaydetme Sayfası";
            this.Load += new System.EventHandler(this.kitapKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ktpKydtButton;
        private System.Windows.Forms.TextBox kitapAdTbox;
        private System.Windows.Forms.Button yzrEkleButton;
        private System.Windows.Forms.Button yynEvEkle;
        private System.Windows.Forms.ComboBox kitapTurCbox;
        private System.Windows.Forms.ComboBox yazarAdCbox;
        private System.Windows.Forms.ComboBox yayinEviCbox;
    }
}
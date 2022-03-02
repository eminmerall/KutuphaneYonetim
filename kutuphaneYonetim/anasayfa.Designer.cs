namespace kutuphaneYonetim
{
    partial class anasayfa
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Image = global::kutuphaneYonetim.Properties.Resources.icons8_book_40;
            this.button6.Location = new System.Drawing.Point(261, 118);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 81);
            this.button6.TabIndex = 5;
            this.button6.Text = "Emanet Listele";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = global::kutuphaneYonetim.Properties.Resources.icons8_book_40;
            this.button5.Location = new System.Drawing.Point(261, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 81);
            this.button5.TabIndex = 4;
            this.button5.Text = "Emanet Ekle";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = global::kutuphaneYonetim.Properties.Resources.icons8_user_40;
            this.button4.Location = new System.Drawing.Point(137, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 81);
            this.button4.TabIndex = 3;
            this.button4.Text = "Üye Listele";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::kutuphaneYonetim.Properties.Resources.icons8_user_40;
            this.button3.Location = new System.Drawing.Point(137, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "Üye Ekle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::kutuphaneYonetim.Properties.Resources.icons8_book_shelf_40;
            this.button2.Location = new System.Drawing.Point(22, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kitap Listele";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::kutuphaneYonetim.Properties.Resources.icons8_book_shelf_40;
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kitap Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 236);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "anasayfa";
            this.Text = "Kütüphane Yönetim Platformu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
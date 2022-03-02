namespace kutuphaneYonetim
{
    partial class yazarKayit
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
            this.button1 = new System.Windows.Forms.Button();
            this.yazarAdTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yzrDTarihDTPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yazarAdTbox
            // 
            this.yazarAdTbox.Location = new System.Drawing.Point(88, 36);
            this.yazarAdTbox.Name = "yazarAdTbox";
            this.yazarAdTbox.Size = new System.Drawing.Size(200, 20);
            this.yazarAdTbox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doğum Tarihi";
            // 
            // yzrDTarihDTPicker
            // 
            this.yzrDTarihDTPicker.Location = new System.Drawing.Point(88, 71);
            this.yzrDTarihDTPicker.Name = "yzrDTarihDTPicker";
            this.yzrDTarihDTPicker.Size = new System.Drawing.Size(200, 20);
            this.yzrDTarihDTPicker.TabIndex = 4;
            // 
            // yazarKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 156);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yzrDTarihDTPicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yazarAdTbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "yazarKayit";
            this.Text = "Yazar Kaydetme Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox yazarAdTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker yzrDTarihDTPicker;
    }
}
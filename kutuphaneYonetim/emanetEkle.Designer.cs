namespace kutuphaneYonetim
{
    partial class emanetEkle
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
            this.uyeAdTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullanicilarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneBilgiDataSet4 = new kutuphaneYonetim.kutuphaneBilgiDataSet4();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneBilgiDataSet2 = new kutuphaneYonetim.kutuphaneBilgiDataSet2();
            this.kullanicilarTableAdapter = new kutuphaneYonetim.kutuphaneBilgiDataSet2TableAdapters.kullanicilarTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uyeTelTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kitapAdTbox = new System.Windows.Forms.TextBox();
            this.yazarAdTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneBilgiDataSet3 = new kutuphaneYonetim.kutuphaneBilgiDataSet3();
            this.kitaplarTableAdapter = new kutuphaneYonetim.kutuphaneBilgiDataSet3TableAdapters.kitaplarTableAdapter();
            this.kullanicilarTableAdapter1 = new kutuphaneYonetim.kutuphaneBilgiDataSet4TableAdapters.kullanicilarTableAdapter();
            this.kutuphaneBilgiDataSet5 = new kutuphaneYonetim.kutuphaneBilgiDataSet5();
            this.kullanicilarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarTableAdapter2 = new kutuphaneYonetim.kutuphaneBilgiDataSet5TableAdapters.kullanicilarTableAdapter();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uyeIdTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kitapIdTbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uyeAdTbox
            // 
            this.uyeAdTbox.Location = new System.Drawing.Point(84, 32);
            this.uyeAdTbox.Name = "uyeAdTbox";
            this.uyeAdTbox.Size = new System.Drawing.Size(150, 20);
            this.uyeAdTbox.TabIndex = 0;
            this.uyeAdTbox.TextChanged += new System.EventHandler(this.uyeAdTbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciID,
            this.adSoyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullanicilarBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(313, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(363, 131);
            this.dataGridView1.TabIndex = 2;
            // 
            // kullanicilarBindingSource1
            // 
            this.kullanicilarBindingSource1.DataMember = "kullanicilar";
            this.kullanicilarBindingSource1.DataSource = this.kutuphaneBilgiDataSet4;
            // 
            // kutuphaneBilgiDataSet4
            // 
            this.kutuphaneBilgiDataSet4.DataSetName = "kutuphaneBilgiDataSet4";
            this.kutuphaneBilgiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.kutuphaneBilgiDataSet2;
            // 
            // kutuphaneBilgiDataSet2
            // 
            this.kutuphaneBilgiDataSet2.DataSetName = "kutuphaneBilgiDataSet2";
            this.kutuphaneBilgiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarTableAdapter
            // 
            this.kullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uyeTelTbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.uyeAdTbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri";
            // 
            // uyeTelTbox
            // 
            this.uyeTelTbox.Location = new System.Drawing.Point(84, 64);
            this.uyeTelTbox.Name = "uyeTelTbox";
            this.uyeTelTbox.Size = new System.Drawing.Size(150, 20);
            this.uyeTelTbox.TabIndex = 5;
            this.uyeTelTbox.TextChanged += new System.EventHandler(this.uyeTelTbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefon      :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kitapAdTbox);
            this.groupBox2.Controls.Add(this.yazarAdTbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 125);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgileri";
            // 
            // kitapAdTbox
            // 
            this.kitapAdTbox.Location = new System.Drawing.Point(84, 30);
            this.kitapAdTbox.Name = "kitapAdTbox";
            this.kitapAdTbox.Size = new System.Drawing.Size(150, 20);
            this.kitapAdTbox.TabIndex = 5;
            this.kitapAdTbox.TextChanged += new System.EventHandler(this.kitapAdTbox_TextChanged);
            // 
            // yazarAdTbox
            // 
            this.yazarAdTbox.Location = new System.Drawing.Point(84, 56);
            this.yazarAdTbox.Name = "yazarAdTbox";
            this.yazarAdTbox.Size = new System.Drawing.Size(150, 20);
            this.yazarAdTbox.TabIndex = 5;
            this.yazarAdTbox.TextChanged += new System.EventHandler(this.yazarAdTbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kitap Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar Adı :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapID,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarAdiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.kitaplarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(313, 173);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(363, 125);
            this.dataGridView2.TabIndex = 5;
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "kitaplar";
            this.kitaplarBindingSource.DataSource = this.kutuphaneBilgiDataSet3;
            // 
            // kutuphaneBilgiDataSet3
            // 
            this.kutuphaneBilgiDataSet3.DataSetName = "kutuphaneBilgiDataSet3";
            this.kutuphaneBilgiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // kullanicilarTableAdapter1
            // 
            this.kullanicilarTableAdapter1.ClearBeforeFill = true;
            // 
            // kutuphaneBilgiDataSet5
            // 
            this.kutuphaneBilgiDataSet5.DataSetName = "kutuphaneBilgiDataSet5";
            this.kutuphaneBilgiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarBindingSource2
            // 
            this.kullanicilarBindingSource2.DataMember = "kullanicilar";
            this.kullanicilarBindingSource2.DataSource = this.kutuphaneBilgiDataSet5;
            // 
            // kullanicilarTableAdapter2
            // 
            this.kullanicilarTableAdapter2.ClearBeforeFill = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "adSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "Adı Soyadı";
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            // 
            // kullaniciID
            // 
            this.kullaniciID.DataPropertyName = "kullaniciID";
            this.kullaniciID.HeaderText = "ID";
            this.kullaniciID.Name = "kullaniciID";
            this.kullaniciID.ReadOnly = true;
            // 
            // kitapID
            // 
            this.kitapID.DataPropertyName = "kitapID";
            this.kitapID.HeaderText = "ID";
            this.kitapID.Name = "kitapID";
            this.kitapID.ReadOnly = true;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "kitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // yazarAdiDataGridViewTextBoxColumn
            // 
            this.yazarAdiDataGridViewTextBoxColumn.DataPropertyName = "yazarAdi";
            this.yazarAdiDataGridViewTextBoxColumn.HeaderText = "Yazar Adı";
            this.yazarAdiDataGridViewTextBoxColumn.Name = "yazarAdiDataGridViewTextBoxColumn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 286);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtreleme Bölümü";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.kitapIdTbox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.uyeIdTbox);
            this.groupBox4.Location = new System.Drawing.Point(12, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(563, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Emanet Ekleme Bölümü";
            // 
            // uyeIdTbox
            // 
            this.uyeIdTbox.Location = new System.Drawing.Point(15, 44);
            this.uyeIdTbox.Name = "uyeIdTbox";
            this.uyeIdTbox.Size = new System.Drawing.Size(61, 20);
            this.uyeIdTbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Üye ID";
            // 
            // kitapIdTbox
            // 
            this.kitapIdTbox.Location = new System.Drawing.Point(107, 44);
            this.kitapIdTbox.Name = "kitapIdTbox";
            this.kitapIdTbox.Size = new System.Drawing.Size(61, 20);
            this.kitapIdTbox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kitap ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tarih";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emanetEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 428);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "emanetEkle";
            this.Text = "Emanet Ekleme Formu";
            this.Load += new System.EventHandler(this.emanetEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox uyeAdTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kutuphaneBilgiDataSet2 kutuphaneBilgiDataSet2;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private kutuphaneBilgiDataSet2TableAdapters.kullanicilarTableAdapter kullanicilarTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox uyeTelTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox kitapAdTbox;
        private System.Windows.Forms.TextBox yazarAdTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private kutuphaneBilgiDataSet3 kutuphaneBilgiDataSet3;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private kutuphaneBilgiDataSet3TableAdapters.kitaplarTableAdapter kitaplarTableAdapter;
        private kutuphaneBilgiDataSet4 kutuphaneBilgiDataSet4;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource1;
        private kutuphaneBilgiDataSet4TableAdapters.kullanicilarTableAdapter kullanicilarTableAdapter1;
        private kutuphaneBilgiDataSet5 kutuphaneBilgiDataSet5;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource2;
        private kutuphaneBilgiDataSet5TableAdapters.kullanicilarTableAdapter kullanicilarTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kitapIdTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uyeIdTbox;
    }
}
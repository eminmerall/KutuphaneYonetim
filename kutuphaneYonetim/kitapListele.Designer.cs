namespace kutuphaneYonetim
{
    partial class kitapListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinEviAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneBilgiDataSet1 = new kutuphaneYonetim.kutuphaneBilgiDataSet1();
            this.kitaplarTableAdapter = new kutuphaneYonetim.kutuphaneBilgiDataSet1TableAdapters.kitaplarTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.turCbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yayinEvTbox = new System.Windows.Forms.TextBox();
            this.yazarAdTbox = new System.Windows.Forms.TextBox();
            this.kitapAdTbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapIDDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarAdiDataGridViewTextBoxColumn,
            this.yayinEviAdiDataGridViewTextBoxColumn,
            this.kitapTurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitaplarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            this.kitapIDDataGridViewTextBoxColumn.DataPropertyName = "kitapID";
            this.kitapIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            this.kitapIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.yazarAdiDataGridViewTextBoxColumn.HeaderText = "Yazar";
            this.yazarAdiDataGridViewTextBoxColumn.Name = "yazarAdiDataGridViewTextBoxColumn";
            // 
            // yayinEviAdiDataGridViewTextBoxColumn
            // 
            this.yayinEviAdiDataGridViewTextBoxColumn.DataPropertyName = "yayinEviAdi";
            this.yayinEviAdiDataGridViewTextBoxColumn.HeaderText = "Yayın Evi";
            this.yayinEviAdiDataGridViewTextBoxColumn.Name = "yayinEviAdiDataGridViewTextBoxColumn";
            // 
            // kitapTurDataGridViewTextBoxColumn
            // 
            this.kitapTurDataGridViewTextBoxColumn.DataPropertyName = "kitapTur";
            this.kitapTurDataGridViewTextBoxColumn.HeaderText = "Tür";
            this.kitapTurDataGridViewTextBoxColumn.Name = "kitapTurDataGridViewTextBoxColumn";
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "kitaplar";
            this.kitaplarBindingSource.DataSource = this.kutuphaneBilgiDataSet1;
            // 
            // kutuphaneBilgiDataSet1
            // 
            this.kutuphaneBilgiDataSet1.DataSetName = "kutuphaneBilgiDataSet1";
            this.kutuphaneBilgiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.turCbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.yayinEvTbox);
            this.groupBox1.Controls.Add(this.yazarAdTbox);
            this.groupBox1.Controls.Add(this.kitapAdTbox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme";
            // 
            // turCbox
            // 
            this.turCbox.FormattingEnabled = true;
            this.turCbox.Items.AddRange(new object[] {
            "Roman",
            "Şiir",
            "Deneme",
            "Biyografi",
            "Masal",
            "Bilim",
            "Eğitim",
            "Araştırma",
            "Tarih",
            " "});
            this.turCbox.Location = new System.Drawing.Point(80, 97);
            this.turCbox.Name = "turCbox";
            this.turCbox.Size = new System.Drawing.Size(121, 21);
            this.turCbox.TabIndex = 8;
            this.turCbox.SelectedIndexChanged += new System.EventHandler(this.turCbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yayınevi Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yazar Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı";
            // 
            // yayinEvTbox
            // 
            this.yayinEvTbox.Location = new System.Drawing.Point(80, 71);
            this.yayinEvTbox.Name = "yayinEvTbox";
            this.yayinEvTbox.Size = new System.Drawing.Size(120, 20);
            this.yayinEvTbox.TabIndex = 2;
            this.yayinEvTbox.TextChanged += new System.EventHandler(this.yayinEvTbox_TextChanged);
            // 
            // yazarAdTbox
            // 
            this.yazarAdTbox.Location = new System.Drawing.Point(80, 45);
            this.yazarAdTbox.Name = "yazarAdTbox";
            this.yazarAdTbox.Size = new System.Drawing.Size(120, 20);
            this.yazarAdTbox.TabIndex = 1;
            this.yazarAdTbox.TextChanged += new System.EventHandler(this.yazarAdTbox_TextChanged);
            // 
            // kitapAdTbox
            // 
            this.kitapAdTbox.Location = new System.Drawing.Point(80, 19);
            this.kitapAdTbox.Name = "kitapAdTbox";
            this.kitapAdTbox.Size = new System.Drawing.Size(120, 20);
            this.kitapAdTbox.TabIndex = 0;
            this.kitapAdTbox.TextChanged += new System.EventHandler(this.kitapAdTbox_TextChanged_1);
            // 
            // kitapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kitapListele";
            this.Text = "kitapListele";
            this.Load += new System.EventHandler(this.kitapListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kutuphaneBilgiDataSet1 kutuphaneBilgiDataSet1;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private kutuphaneBilgiDataSet1TableAdapters.kitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinEviAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yayinEvTbox;
        private System.Windows.Forms.TextBox yazarAdTbox;
        private System.Windows.Forms.TextBox kitapAdTbox;
        private System.Windows.Forms.ComboBox turCbox;
    }
}
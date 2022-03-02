namespace kutuphaneYonetim
{
    partial class emanetListe
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
            this.kutuphaneBilgiDataSet6 = new kutuphaneYonetim.kutuphaneBilgiDataSet6();
            this.emanetlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emanetlerTableAdapter = new kutuphaneYonetim.kutuphaneBilgiDataSet6TableAdapters.emanetlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emanetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetVermeTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetTeslimTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kutuphaneBilgiDataSet6
            // 
            this.kutuphaneBilgiDataSet6.DataSetName = "kutuphaneBilgiDataSet6";
            this.kutuphaneBilgiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emanetlerBindingSource
            // 
            this.emanetlerBindingSource.DataMember = "emanetler";
            this.emanetlerBindingSource.DataSource = this.kutuphaneBilgiDataSet6;
            // 
            // emanetlerTableAdapter
            // 
            this.emanetlerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emanetIDDataGridViewTextBoxColumn,
            this.kitapIDDataGridViewTextBoxColumn,
            this.kullaniciIDDataGridViewTextBoxColumn,
            this.emanetVermeTarihDataGridViewTextBoxColumn,
            this.emanetTeslimTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emanetlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // emanetIDDataGridViewTextBoxColumn
            // 
            this.emanetIDDataGridViewTextBoxColumn.DataPropertyName = "emanetID";
            this.emanetIDDataGridViewTextBoxColumn.HeaderText = "emanetID";
            this.emanetIDDataGridViewTextBoxColumn.Name = "emanetIDDataGridViewTextBoxColumn";
            this.emanetIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            this.kitapIDDataGridViewTextBoxColumn.DataPropertyName = "kitapID";
            this.kitapIDDataGridViewTextBoxColumn.HeaderText = "kitapID";
            this.kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "kullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "kullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            // 
            // emanetVermeTarihDataGridViewTextBoxColumn
            // 
            this.emanetVermeTarihDataGridViewTextBoxColumn.DataPropertyName = "emanetVermeTarih";
            this.emanetVermeTarihDataGridViewTextBoxColumn.HeaderText = "emanetVermeTarih";
            this.emanetVermeTarihDataGridViewTextBoxColumn.Name = "emanetVermeTarihDataGridViewTextBoxColumn";
            // 
            // emanetTeslimTarihDataGridViewTextBoxColumn
            // 
            this.emanetTeslimTarihDataGridViewTextBoxColumn.DataPropertyName = "emanetTeslimTarih";
            this.emanetTeslimTarihDataGridViewTextBoxColumn.HeaderText = "emanetTeslimTarih";
            this.emanetTeslimTarihDataGridViewTextBoxColumn.Name = "emanetTeslimTarihDataGridViewTextBoxColumn";
            // 
            // emanetListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 258);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "emanetListe";
            this.Text = "Emanet Kitap Listesi";
            this.Load += new System.EventHandler(this.emanetListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBilgiDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private kutuphaneBilgiDataSet6 kutuphaneBilgiDataSet6;
        private System.Windows.Forms.BindingSource emanetlerBindingSource;
        private kutuphaneBilgiDataSet6TableAdapters.emanetlerTableAdapter emanetlerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanetVermeTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanetTeslimTarihDataGridViewTextBoxColumn;
    }
}
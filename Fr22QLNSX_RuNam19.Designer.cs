namespace G119NHKQ_SaleRuNam
{
    partial class Fr22QLNSX_RuNam19
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
            this.g119KQSaleNSXRNDS = new G119NHKQ_SaleRuNam.G119KQSaleNSXRNDS();
            this.nhaSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaSanXuatTableAdapter = new G119NHKQ_SaleRuNam.G119KQSaleNSXRNDSTableAdapters.NhaSanXuatTableAdapter();
            this.maNSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matHangSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119KQSaleNSXRNDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaSanXuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNSXDataGridViewTextBoxColumn,
            this.tenNSXDataGridViewTextBoxColumn,
            this.matHangSXDataGridViewTextBoxColumn,
            this.ngaySanXuatDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhaSanXuatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // g119KQSaleNSXRNDS
            // 
            this.g119KQSaleNSXRNDS.DataSetName = "G119KQSaleNSXRNDS";
            this.g119KQSaleNSXRNDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaSanXuatBindingSource
            // 
            this.nhaSanXuatBindingSource.DataMember = "NhaSanXuat";
            this.nhaSanXuatBindingSource.DataSource = this.g119KQSaleNSXRNDS;
            // 
            // nhaSanXuatTableAdapter
            // 
            this.nhaSanXuatTableAdapter.ClearBeforeFill = true;
            // 
            // maNSXDataGridViewTextBoxColumn
            // 
            this.maNSXDataGridViewTextBoxColumn.DataPropertyName = "MaNSX";
            this.maNSXDataGridViewTextBoxColumn.HeaderText = "MaNSX";
            this.maNSXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNSXDataGridViewTextBoxColumn.Name = "maNSXDataGridViewTextBoxColumn";
            this.maNSXDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNSXDataGridViewTextBoxColumn
            // 
            this.tenNSXDataGridViewTextBoxColumn.DataPropertyName = "TenNSX";
            this.tenNSXDataGridViewTextBoxColumn.HeaderText = "TenNSX";
            this.tenNSXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNSXDataGridViewTextBoxColumn.Name = "tenNSXDataGridViewTextBoxColumn";
            this.tenNSXDataGridViewTextBoxColumn.Width = 125;
            // 
            // matHangSXDataGridViewTextBoxColumn
            // 
            this.matHangSXDataGridViewTextBoxColumn.DataPropertyName = "MatHangSX";
            this.matHangSXDataGridViewTextBoxColumn.HeaderText = "MatHangSX";
            this.matHangSXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matHangSXDataGridViewTextBoxColumn.Name = "matHangSXDataGridViewTextBoxColumn";
            this.matHangSXDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySanXuatDataGridViewTextBoxColumn
            // 
            this.ngaySanXuatDataGridViewTextBoxColumn.DataPropertyName = "NgaySanXuat";
            this.ngaySanXuatDataGridViewTextBoxColumn.HeaderText = "NgaySanXuat";
            this.ngaySanXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySanXuatDataGridViewTextBoxColumn.Name = "ngaySanXuatDataGridViewTextBoxColumn";
            this.ngaySanXuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.Width = 125;
            // 
            // Fr22QLNSX_RuNam19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fr22QLNSX_RuNam19";
            this.Text = "Fr22QLNSX_RuNam19";
            this.Load += new System.EventHandler(this.Fr22QLNSX_RuNam19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119KQSaleNSXRNDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaSanXuatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private G119KQSaleNSXRNDS g119KQSaleNSXRNDS;
        private System.Windows.Forms.BindingSource nhaSanXuatBindingSource;
        private G119KQSaleNSXRNDSTableAdapters.NhaSanXuatTableAdapter nhaSanXuatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matHangSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}
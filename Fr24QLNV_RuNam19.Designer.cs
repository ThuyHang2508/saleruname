namespace G119NHKQ_SaleRuNam
{
    partial class Fr24QLNV_RuNam19
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
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaoLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g119NHKQNVRuNamNDS = new G119NHKQ_SaleRuNam.G119NHKQNVRuNamNDS();
            this.dMNVTableAdapter = new G119NHKQ_SaleRuNam.G119NHKQNVRuNamNDSTableAdapters.DMNVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119NHKQNVRuNamNDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewCheckBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.ngayVaoLamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dMNVBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(790, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewCheckBoxColumn
            // 
            this.gioiTinhDataGridViewCheckBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewCheckBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewCheckBoxColumn.Name = "gioiTinhDataGridViewCheckBoxColumn";
            this.gioiTinhDataGridViewCheckBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayVaoLamDataGridViewTextBoxColumn
            // 
            this.ngayVaoLamDataGridViewTextBoxColumn.DataPropertyName = "NgayVaoLam";
            this.ngayVaoLamDataGridViewTextBoxColumn.HeaderText = "NgayVaoLam";
            this.ngayVaoLamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayVaoLamDataGridViewTextBoxColumn.Name = "ngayVaoLamDataGridViewTextBoxColumn";
            this.ngayVaoLamDataGridViewTextBoxColumn.Width = 125;
            // 
            // dMNVBindingSource
            // 
            this.dMNVBindingSource.DataMember = "DMNV";
            this.dMNVBindingSource.DataSource = this.g119NHKQNVRuNamNDS;
            // 
            // g119NHKQNVRuNamNDS
            // 
            this.g119NHKQNVRuNamNDS.DataSetName = "G119NHKQNVRuNamNDS";
            this.g119NHKQNVRuNamNDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMNVTableAdapter
            // 
            this.dMNVTableAdapter.ClearBeforeFill = true;
            // 
            // Fr24QLNV_RuNam19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fr24QLNV_RuNam19";
            this.Text = "Fr24QLNV_RuNam19";
            this.Load += new System.EventHandler(this.Fr24QLNV_RuNam19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119NHKQNVRuNamNDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private G119NHKQNVRuNamNDS g119NHKQNVRuNamNDS;
        private System.Windows.Forms.BindingSource dMNVBindingSource;
        private G119NHKQNVRuNamNDSTableAdapters.DMNVTableAdapter dMNVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaoLamDataGridViewTextBoxColumn;
    }
}
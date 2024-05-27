namespace G119NHKQ_SaleRuNam
{
    partial class Fr21QLNhom_RuNam19
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
            this.g119KQSaleNhomRNDS = new G119NHKQ_SaleRuNam.G119KQSaleNhomRNDS();
            this.thuocNhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuocNhomTableAdapter = new G119NHKQ_SaleRuNam.G119KQSaleNhomRNDSTableAdapters.ThuocNhomTableAdapter();
            this.maNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119KQSaleNhomRNDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocNhomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhomDataGridViewTextBoxColumn,
            this.tenNhomDataGridViewTextBoxColumn,
            this.motaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thuocNhomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // g119KQSaleNhomRNDS
            // 
            this.g119KQSaleNhomRNDS.DataSetName = "G119KQSaleNhomRNDS";
            this.g119KQSaleNhomRNDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuocNhomBindingSource
            // 
            this.thuocNhomBindingSource.DataMember = "ThuocNhom";
            this.thuocNhomBindingSource.DataSource = this.g119KQSaleNhomRNDS;
            // 
            // thuocNhomTableAdapter
            // 
            this.thuocNhomTableAdapter.ClearBeforeFill = true;
            // 
            // maNhomDataGridViewTextBoxColumn
            // 
            this.maNhomDataGridViewTextBoxColumn.DataPropertyName = "MaNhom";
            this.maNhomDataGridViewTextBoxColumn.HeaderText = "MaNhom";
            this.maNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhomDataGridViewTextBoxColumn.Name = "maNhomDataGridViewTextBoxColumn";
            this.maNhomDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            this.tenNhomDataGridViewTextBoxColumn.Width = 125;
            // 
            // motaDataGridViewTextBoxColumn
            // 
            this.motaDataGridViewTextBoxColumn.DataPropertyName = "Mota";
            this.motaDataGridViewTextBoxColumn.HeaderText = "Mota";
            this.motaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motaDataGridViewTextBoxColumn.Name = "motaDataGridViewTextBoxColumn";
            this.motaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Fr21QLNhom_RuNam19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fr21QLNhom_RuNam19";
            this.Text = "Fr21QLNhom_RuNam19";
            this.Load += new System.EventHandler(this.Fr21QLNhom_RuNam19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119KQSaleNhomRNDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocNhomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private G119KQSaleNhomRNDS g119KQSaleNhomRNDS;
        private System.Windows.Forms.BindingSource thuocNhomBindingSource;
        private G119KQSaleNhomRNDSTableAdapters.ThuocNhomTableAdapter thuocNhomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
    }
}
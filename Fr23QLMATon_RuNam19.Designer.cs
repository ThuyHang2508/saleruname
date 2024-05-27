namespace G119NHKQ_SaleRuNam
{
    partial class Fr23QLMATon_RuNam19
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
            this.g119QSaleMATonRNDS = new G119NHKQ_SaleRuNam.G119QSaleMATonRNDS();
            this.monAnTonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monAnTonTableAdapter = new G119NHKQ_SaleRuNam.G119QSaleMATonRNDSTableAdapters.MonAnTonTableAdapter();
            this.maChiNhanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119QSaleMATonRNDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monAnTonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChiNhanhDataGridViewTextBoxColumn,
            this.maMonAnDataGridViewTextBoxColumn,
            this.tenMonAnDataGridViewTextBoxColumn,
            this.soLuongTonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.monAnTonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // g119QSaleMATonRNDS
            // 
            this.g119QSaleMATonRNDS.DataSetName = "G119QSaleMATonRNDS";
            this.g119QSaleMATonRNDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monAnTonBindingSource
            // 
            this.monAnTonBindingSource.DataMember = "MonAnTon";
            this.monAnTonBindingSource.DataSource = this.g119QSaleMATonRNDS;
            // 
            // monAnTonTableAdapter
            // 
            this.monAnTonTableAdapter.ClearBeforeFill = true;
            // 
            // maChiNhanhDataGridViewTextBoxColumn
            // 
            this.maChiNhanhDataGridViewTextBoxColumn.DataPropertyName = "MaChiNhanh";
            this.maChiNhanhDataGridViewTextBoxColumn.HeaderText = "MaChiNhanh";
            this.maChiNhanhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maChiNhanhDataGridViewTextBoxColumn.Name = "maChiNhanhDataGridViewTextBoxColumn";
            this.maChiNhanhDataGridViewTextBoxColumn.Width = 125;
            // 
            // maMonAnDataGridViewTextBoxColumn
            // 
            this.maMonAnDataGridViewTextBoxColumn.DataPropertyName = "MaMonAn";
            this.maMonAnDataGridViewTextBoxColumn.HeaderText = "MaMonAn";
            this.maMonAnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMonAnDataGridViewTextBoxColumn.Name = "maMonAnDataGridViewTextBoxColumn";
            this.maMonAnDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenMonAnDataGridViewTextBoxColumn
            // 
            this.tenMonAnDataGridViewTextBoxColumn.DataPropertyName = "TenMonAn";
            this.tenMonAnDataGridViewTextBoxColumn.HeaderText = "TenMonAn";
            this.tenMonAnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonAnDataGridViewTextBoxColumn.Name = "tenMonAnDataGridViewTextBoxColumn";
            this.tenMonAnDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongTonDataGridViewTextBoxColumn
            // 
            this.soLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.HeaderText = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongTonDataGridViewTextBoxColumn.Name = "soLuongTonDataGridViewTextBoxColumn";
            this.soLuongTonDataGridViewTextBoxColumn.Width = 125;
            // 
            // Fr23QLMATon_RuNam19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fr23QLMATon_RuNam19";
            this.Text = "Fr23QLMATon_RuNam19";
            this.Load += new System.EventHandler(this.Fr23QLMATon_RuNam19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119QSaleMATonRNDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monAnTonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private G119QSaleMATonRNDS g119QSaleMATonRNDS;
        private System.Windows.Forms.BindingSource monAnTonBindingSource;
        private G119QSaleMATonRNDSTableAdapters.MonAnTonTableAdapter monAnTonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChiNhanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn;
    }
}
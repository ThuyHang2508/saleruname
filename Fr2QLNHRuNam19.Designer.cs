namespace G119NHKQ_SaleRuNam
{
    partial class _2FrQLNHRuNam19
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxNhasx = new System.Windows.Forms.ComboBox();
            this.dMMonAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g119NHKQSaleRNDS = new G119NHKQ_SaleRuNam.G119NHKQSaleRNDS();
            this.nhaSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g119NHKQNSXRuNamDS = new G119NHKQ_SaleRuNam.G119NHKQNSXRuNamDS();
            this.checkBoxConma = new System.Windows.Forms.CheckBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txttenma = new System.Windows.Forms.TextBox();
            this.txtmma = new System.Windows.Forms.TextBox();
            this.lbmota = new System.Windows.Forms.Label();
            this.lbdvt = new System.Windows.Forms.Label();
            this.lbgiaban = new System.Windows.Forms.Label();
            this.lbtenma = new System.Windows.Forms.Label();
            this.lbmma = new System.Windows.Forms.Label();
            this.lbnsx = new System.Windows.Forms.Label();
            this.openFileDialogPic = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewMonAn = new System.Windows.Forms.DataGridView();
            this.maMonAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conMonAnDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBoxDMMA = new System.Windows.Forms.GroupBox();
            this.pictureBoxHinh = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.comboBoxThuocNhom = new System.Windows.Forms.ComboBox();
            this.thuocNhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g119KQSalTNhomRNDS = new G119NHKQ_SaleRuNam.G119KQSalTNhomRNDS();
            this.lbthuocnhom = new System.Windows.Forms.Label();
            this.dMMonAnTableAdapter = new G119NHKQ_SaleRuNam.G119NHKQSaleRNDSTableAdapters.DMMonAnTableAdapter();
            this.thuocNhomTableAdapter = new G119NHKQ_SaleRuNam.G119KQSalTNhomRNDSTableAdapters.ThuocNhomTableAdapter();
            this.nhaSanXuatTableAdapter = new G119NHKQ_SaleRuNam.G119NHKQNSXRuNamDSTableAdapters.NhaSanXuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dMMonAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119NHKQSaleRNDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaSanXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119NHKQNSXRuNamDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).BeginInit();
            this.groupBoxDMMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocNhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119KQSalTNhomRNDS)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxNhasx
            // 
            this.comboBoxNhasx.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dMMonAnBindingSource, "MaNSX", true));
            this.comboBoxNhasx.DataSource = this.nhaSanXuatBindingSource;
            this.comboBoxNhasx.DisplayMember = "TenNSX";
            this.comboBoxNhasx.Enabled = false;
            this.comboBoxNhasx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNhasx.FormattingEnabled = true;
            this.comboBoxNhasx.Location = new System.Drawing.Point(395, 42);
            this.comboBoxNhasx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNhasx.Name = "comboBoxNhasx";
            this.comboBoxNhasx.Size = new System.Drawing.Size(123, 24);
            this.comboBoxNhasx.TabIndex = 8;
            this.comboBoxNhasx.ValueMember = "MaNSX";
            // 
            // dMMonAnBindingSource
            // 
            this.dMMonAnBindingSource.DataMember = "DMMonAn";
            this.dMMonAnBindingSource.DataSource = this.g119NHKQSaleRNDS;
            // 
            // g119NHKQSaleRNDS
            // 
            this.g119NHKQSaleRNDS.DataSetName = "G119NHKQSaleRNDS";
            this.g119NHKQSaleRNDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaSanXuatBindingSource
            // 
            this.nhaSanXuatBindingSource.DataMember = "NhaSanXuat";
            this.nhaSanXuatBindingSource.DataSource = this.g119NHKQNSXRuNamDS;
            // 
            // g119NHKQNSXRuNamDS
            // 
            this.g119NHKQNSXRuNamDS.DataSetName = "G119NHKQNSXRuNamDS";
            this.g119NHKQNSXRuNamDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxConma
            // 
            this.checkBoxConma.AutoSize = true;
            this.checkBoxConma.Enabled = false;
            this.checkBoxConma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxConma.Location = new System.Drawing.Point(316, 117);
            this.checkBoxConma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxConma.Name = "checkBoxConma";
            this.checkBoxConma.Size = new System.Drawing.Size(106, 21);
            this.checkBoxConma.TabIndex = 7;
            this.checkBoxConma.Text = "Còn món ăn";
            this.checkBoxConma.UseVisualStyleBackColor = true;
            // 
            // txtmota
            // 
            this.txtmota.Enabled = false;
            this.txtmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmota.Location = new System.Drawing.Point(867, 120);
            this.txtmota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(212, 23);
            this.txtmota.TabIndex = 10;
            // 
            // txtdvt
            // 
            this.txtdvt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMMonAnBindingSource, "Dvt", true));
            this.txtdvt.Enabled = false;
            this.txtdvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdvt.Location = new System.Drawing.Point(199, 114);
            this.txtdvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(72, 23);
            this.txtdvt.TabIndex = 4;
            // 
            // txtgiaban
            // 
            this.txtgiaban.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMMonAnBindingSource, "GiaBan", true));
            this.txtgiaban.Enabled = false;
            this.txtgiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiaban.Location = new System.Drawing.Point(102, 114);
            this.txtgiaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(73, 23);
            this.txtgiaban.TabIndex = 3;
            this.txtgiaban.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttenma
            // 
            this.txttenma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMMonAnBindingSource, "TenMonAn", true));
            this.txttenma.Enabled = false;
            this.txttenma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenma.Location = new System.Drawing.Point(103, 77);
            this.txttenma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenma.Name = "txttenma";
            this.txttenma.Size = new System.Drawing.Size(173, 23);
            this.txttenma.TabIndex = 2;
            // 
            // txtmma
            // 
            this.txtmma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMMonAnBindingSource, "MaMonAn", true));
            this.txtmma.Enabled = false;
            this.txtmma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmma.ForeColor = System.Drawing.Color.Black;
            this.txtmma.Location = new System.Drawing.Point(102, 42);
            this.txtmma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmma.Name = "txtmma";
            this.txtmma.Size = new System.Drawing.Size(174, 23);
            this.txtmma.TabIndex = 1;
            // 
            // lbmota
            // 
            this.lbmota.AutoSize = true;
            this.lbmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmota.Location = new System.Drawing.Point(763, 120);
            this.lbmota.Name = "lbmota";
            this.lbmota.Size = new System.Drawing.Size(98, 17);
            this.lbmota.TabIndex = 0;
            this.lbmota.Text = "Mô tả món ăn:";
            // 
            // lbdvt
            // 
            this.lbdvt.AutoSize = true;
            this.lbdvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdvt.Location = new System.Drawing.Point(181, 120);
            this.lbdvt.Name = "lbdvt";
            this.lbdvt.Size = new System.Drawing.Size(12, 17);
            this.lbdvt.TabIndex = 0;
            this.lbdvt.Text = "/";
            // 
            // lbgiaban
            // 
            this.lbgiaban.AutoSize = true;
            this.lbgiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgiaban.Location = new System.Drawing.Point(9, 118);
            this.lbgiaban.Name = "lbgiaban";
            this.lbgiaban.Size = new System.Drawing.Size(62, 17);
            this.lbgiaban.TabIndex = 0;
            this.lbgiaban.Text = "Giá bán:";
            // 
            // lbtenma
            // 
            this.lbtenma.AutoSize = true;
            this.lbtenma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenma.Location = new System.Drawing.Point(9, 79);
            this.lbtenma.Name = "lbtenma";
            this.lbtenma.Size = new System.Drawing.Size(88, 17);
            this.lbtenma.TabIndex = 0;
            this.lbtenma.Text = "Tên món ăn:";
            // 
            // lbmma
            // 
            this.lbmma.AutoSize = true;
            this.lbmma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmma.Location = new System.Drawing.Point(9, 42);
            this.lbmma.Name = "lbmma";
            this.lbmma.Size = new System.Drawing.Size(82, 17);
            this.lbmma.TabIndex = 0;
            this.lbmma.Text = "Mã món ăn:";
            // 
            // lbnsx
            // 
            this.lbnsx.AutoSize = true;
            this.lbnsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnsx.Location = new System.Drawing.Point(293, 42);
            this.lbnsx.Name = "lbnsx";
            this.lbnsx.Size = new System.Drawing.Size(40, 17);
            this.lbnsx.TabIndex = 0;
            this.lbnsx.Text = "NSX:";
            // 
            // dataGridViewMonAn
            // 
            this.dataGridViewMonAn.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonAnDataGridViewTextBoxColumn,
            this.tenMonAnDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.dvtDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.conMonAnDataGridViewCheckBoxColumn,
            this.maNhomDataGridViewTextBoxColumn,
            this.Hinh});
            this.dataGridViewMonAn.DataSource = this.dMMonAnBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMonAn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMonAn.Location = new System.Drawing.Point(3, 233);
            this.dataGridViewMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMonAn.Name = "dataGridViewMonAn";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMonAn.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMonAn.RowHeadersWidth = 62;
            this.dataGridViewMonAn.RowTemplate.Height = 28;
            this.dataGridViewMonAn.Size = new System.Drawing.Size(1173, 229);
            this.dataGridViewMonAn.TabIndex = 19;
            // 
            // maMonAnDataGridViewTextBoxColumn
            // 
            this.maMonAnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maMonAnDataGridViewTextBoxColumn.DataPropertyName = "MaMonAn";
            this.maMonAnDataGridViewTextBoxColumn.HeaderText = "Mã Món Ăn";
            this.maMonAnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMonAnDataGridViewTextBoxColumn.Name = "maMonAnDataGridViewTextBoxColumn";
            this.maMonAnDataGridViewTextBoxColumn.Width = 103;
            // 
            // tenMonAnDataGridViewTextBoxColumn
            // 
            this.tenMonAnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tenMonAnDataGridViewTextBoxColumn.DataPropertyName = "TenMonAn";
            this.tenMonAnDataGridViewTextBoxColumn.HeaderText = "Tên Món Ăn";
            this.tenMonAnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonAnDataGridViewTextBoxColumn.Name = "tenMonAnDataGridViewTextBoxColumn";
            this.tenMonAnDataGridViewTextBoxColumn.Width = 108;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            this.giaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.Width = 83;
            // 
            // dvtDataGridViewTextBoxColumn
            // 
            this.dvtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dvtDataGridViewTextBoxColumn.DataPropertyName = "Dvt";
            this.dvtDataGridViewTextBoxColumn.HeaderText = "Dvt";
            this.dvtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dvtDataGridViewTextBoxColumn.Name = "dvtDataGridViewTextBoxColumn";
            this.dvtDataGridViewTextBoxColumn.Width = 56;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.moTaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.Width = 69;
            // 
            // conMonAnDataGridViewCheckBoxColumn
            // 
            this.conMonAnDataGridViewCheckBoxColumn.DataPropertyName = "ConMonAn";
            this.conMonAnDataGridViewCheckBoxColumn.HeaderText = "Còn món ăn";
            this.conMonAnDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.conMonAnDataGridViewCheckBoxColumn.Name = "conMonAnDataGridViewCheckBoxColumn";
            this.conMonAnDataGridViewCheckBoxColumn.Width = 125;
            // 
            // maNhomDataGridViewTextBoxColumn
            // 
            this.maNhomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maNhomDataGridViewTextBoxColumn.DataPropertyName = "MaNhom";
            this.maNhomDataGridViewTextBoxColumn.HeaderText = "Mã nhóm";
            this.maNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhomDataGridViewTextBoxColumn.Name = "maNhomDataGridViewTextBoxColumn";
            this.maNhomDataGridViewTextBoxColumn.Width = 91;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình mẫu";
            this.Hinh.MinimumWidth = 6;
            this.Hinh.Name = "Hinh";
            this.Hinh.Width = 125;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbTitle.Location = new System.Drawing.Point(27, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(458, 25);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "G119_NHKQ: QUẢN LÝ DANH MỤC MÓN ĂN";
            // 
            // groupBoxDMMA
            // 
            this.groupBoxDMMA.Controls.Add(this.pictureBoxHinh);
            this.groupBoxDMMA.Controls.Add(this.btnXoa);
            this.groupBoxDMMA.Controls.Add(this.btnThem);
            this.groupBoxDMMA.Controls.Add(this.btnExit);
            this.groupBoxDMMA.Controls.Add(this.btnSua);
            this.groupBoxDMMA.Controls.Add(this.btnMain);
            this.groupBoxDMMA.Controls.Add(this.comboBoxThuocNhom);
            this.groupBoxDMMA.Controls.Add(this.comboBoxNhasx);
            this.groupBoxDMMA.Controls.Add(this.checkBoxConma);
            this.groupBoxDMMA.Controls.Add(this.txtmota);
            this.groupBoxDMMA.Controls.Add(this.txtdvt);
            this.groupBoxDMMA.Controls.Add(this.txtgiaban);
            this.groupBoxDMMA.Controls.Add(this.txttenma);
            this.groupBoxDMMA.Controls.Add(this.txtmma);
            this.groupBoxDMMA.Controls.Add(this.lbthuocnhom);
            this.groupBoxDMMA.Controls.Add(this.lbnsx);
            this.groupBoxDMMA.Controls.Add(this.lbmota);
            this.groupBoxDMMA.Controls.Add(this.lbdvt);
            this.groupBoxDMMA.Controls.Add(this.lbgiaban);
            this.groupBoxDMMA.Controls.Add(this.lbtenma);
            this.groupBoxDMMA.Controls.Add(this.lbmma);
            this.groupBoxDMMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDMMA.Location = new System.Drawing.Point(3, 45);
            this.groupBoxDMMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDMMA.Name = "groupBoxDMMA";
            this.groupBoxDMMA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDMMA.Size = new System.Drawing.Size(1173, 184);
            this.groupBoxDMMA.TabIndex = 18;
            this.groupBoxDMMA.TabStop = false;
            this.groupBoxDMMA.Text = "CHI TIẾT THÔNG TIN MÓN ĂN";
            // 
            // pictureBoxHinh
            // 
            this.pictureBoxHinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHinh.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.dMMonAnBindingSource, "Hinh", true));
            this.pictureBoxHinh.Location = new System.Drawing.Point(578, 24);
            this.pictureBoxHinh.Name = "pictureBoxHinh";
            this.pictureBoxHinh.Size = new System.Drawing.Size(167, 155);
            this.pictureBoxHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHinh.TabIndex = 16;
            this.pictureBoxHinh.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(428, 109);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 33);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa Món Ăn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(785, 37);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(146, 32);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm Món Ăn Mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(937, 73);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát chương trình";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(785, 73);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(146, 35);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa Món Ăn";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(937, 37);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(142, 32);
            this.btnMain.TabIndex = 14;
            this.btnMain.Text = "Về màn hình chính";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click_1);
            // 
            // comboBoxThuocNhom
            // 
            this.comboBoxThuocNhom.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dMMonAnBindingSource, "MaNhom", true));
            this.comboBoxThuocNhom.DataSource = this.thuocNhomBindingSource;
            this.comboBoxThuocNhom.DisplayMember = "TenNhom";
            this.comboBoxThuocNhom.Enabled = false;
            this.comboBoxThuocNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxThuocNhom.FormattingEnabled = true;
            this.comboBoxThuocNhom.Location = new System.Drawing.Point(395, 76);
            this.comboBoxThuocNhom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxThuocNhom.Name = "comboBoxThuocNhom";
            this.comboBoxThuocNhom.Size = new System.Drawing.Size(123, 24);
            this.comboBoxThuocNhom.TabIndex = 9;
            this.comboBoxThuocNhom.ValueMember = "MaNhom";
            // 
            // thuocNhomBindingSource
            // 
            this.thuocNhomBindingSource.DataMember = "ThuocNhom";
            this.thuocNhomBindingSource.DataSource = this.g119KQSalTNhomRNDS;
            // 
            // g119KQSalTNhomRNDS
            // 
            this.g119KQSalTNhomRNDS.DataSetName = "G119KQSalTNhomRNDS";
            this.g119KQSalTNhomRNDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbthuocnhom
            // 
            this.lbthuocnhom.AutoSize = true;
            this.lbthuocnhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthuocnhom.Location = new System.Drawing.Point(293, 85);
            this.lbthuocnhom.Name = "lbthuocnhom";
            this.lbthuocnhom.Size = new System.Drawing.Size(91, 17);
            this.lbthuocnhom.TabIndex = 0;
            this.lbthuocnhom.Text = "Thuộc nhóm:";
            // 
            // dMMonAnTableAdapter
            // 
            this.dMMonAnTableAdapter.ClearBeforeFill = true;
            // 
            // thuocNhomTableAdapter
            // 
            this.thuocNhomTableAdapter.ClearBeforeFill = true;
            // 
            // nhaSanXuatTableAdapter
            // 
            this.nhaSanXuatTableAdapter.ClearBeforeFill = true;
            // 
            // _2FrQLNHRuNam19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 566);
            this.Controls.Add(this.dataGridViewMonAn);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.groupBoxDMMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "_2FrQLNHRuNam19";
            this.Text = "G119_NHKQ QUẢN LÝ DANH MỤC CÁC MÓN ĂN";
            this.Load += new System.EventHandler(this._2FrQLNHRuNam19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dMMonAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119NHKQSaleRNDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaSanXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119NHKQNSXRuNamDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).EndInit();
            this.groupBoxDMMA.ResumeLayout(false);
            this.groupBoxDMMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocNhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g119KQSalTNhomRNDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNhasx;
        private System.Windows.Forms.CheckBox checkBoxConma;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txttenma;
        private System.Windows.Forms.TextBox txtmma;
        private System.Windows.Forms.Label lbmota;
        private System.Windows.Forms.Label lbdvt;
        private System.Windows.Forms.Label lbgiaban;
        private System.Windows.Forms.Label lbtenma;
        private System.Windows.Forms.Label lbmma;
        private System.Windows.Forms.Label lbnsx;
        private System.Windows.Forms.OpenFileDialog openFileDialogPic;
        private System.Windows.Forms.DataGridView dataGridViewMonAn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn conhh;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBoxDMMA;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox comboBoxThuocNhom;
        private System.Windows.Forms.Label lbthuocnhom;
        private G119NHKQSaleRNDS g119NHKQSaleRNDS;
        private System.Windows.Forms.BindingSource dMMonAnBindingSource;
        private G119NHKQSaleRNDSTableAdapters.DMMonAnTableAdapter dMMonAnTableAdapter;
        private G119KQSalTNhomRNDS g119KQSalTNhomRNDS;
        private System.Windows.Forms.BindingSource thuocNhomBindingSource;
        private G119KQSalTNhomRNDSTableAdapters.ThuocNhomTableAdapter thuocNhomTableAdapter;
        private G119NHKQNSXRuNamDS g119NHKQNSXRuNamDS;
        private System.Windows.Forms.BindingSource nhaSanXuatBindingSource;
        private G119NHKQNSXRuNamDSTableAdapters.NhaSanXuatTableAdapter nhaSanXuatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn conMonAnDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.PictureBox pictureBoxHinh;
    }
}
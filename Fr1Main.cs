using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace G119NHKQ_SaleRuNam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Thủ tục này = tự động chạy mỗi khi form này được mở ( tải = load )
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLbdate.Text = lbdate.Text = System.DateTime.Now.ToShortDateString();
        }// private void Form1_Load(object sender, EventArgs e)

        /// <summary>
        /// Nhảy đồng hồ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLbTime.Text = lbTime.Text = System.DateTime.Now.ToLongTimeString();
        }// private void timer1_Tick(object sender, EventArgs e)


        /// <summary>
        /// Thoát khỏi chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thoátKhỏiChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt thoát không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit(); // thoát chương trình
            }

        }
        /// <summary>
        ///  Lập phiếu tính tiền
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lậpPhiếuTínhTiềnBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _3FrInBill_RuNam19 fr = new _3FrInBill_RuNam19();
            fr.ShowDialog(); // Form lập phiếu tính tiền Bill được mở ra: form con của màn hình chính
        } // private void lậpPhiếuTínhTiềnBillToolStripMenuItem_Click(object sender, EventArgs e)


        /// <summary>
        /// Lập phiếu hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lậpHóaĐơnInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4FrOInvoiceRuNam19 fr = new _4FrOInvoiceRuNam19();
            fr.ShowDialog(); 
        }// private void lậpHóaĐơnInvoiceToolStripMenuItem_Click(object sender, EventArgs e)



        /// <summary>
        /// Quản lý danh mục món ăn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void danhMụcMónĂnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _2FrQLNHRuNam19 fr = new _2FrQLNHRuNam19();
            fr.ShowDialog();
        }//private void danhMụcMónĂnToolStripMenuItem1_Click(object senderl, EventArgs e)

      
        /// <summary>
        /// Quản lý thuộc nhóm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void danhMụcMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr21QLNhom_RuNam19 fr = new Fr21QLNhom_RuNam19();
            fr.ShowDialog();
        }// private void danhMụcMónĂnToolStripMenuItem_Click(object sender, EventArgs e)



        /// <summary>
        /// Quản lý nhà sản xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr22QLNSX_RuNam19 fr = new Fr22QLNSX_RuNam19();
            fr.ShowDialog();
        }// private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        /// <summary>
        /// Quản lý danh mục Các món ăn tồn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void danhMụcMónĂnTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr23QLMATon_RuNam19 fr = new Fr23QLMATon_RuNam19();
            fr.ShowDialog();
        }//private void danhMụcMónĂnTồnToolStripMenuItem_Click(object sender, EventArgs e)


        /// <summary>
        /// Quản lý danh mục nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr24QLNV_RuNam19 fr = new Fr24QLNV_RuNam19();
            fr.ShowDialog();
        }//private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
    }//public partial class Form1 : Form 
} // namespace G119NHKQ_SaleRuNam

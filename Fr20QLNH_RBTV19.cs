using G119NHKQ_SaleRuNam.G119NHKQsaleCTBillTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace G119NHKQ_SaleRuNam
{
    public partial class Fr20QLNH_RBTV19 : Form
    {
        static string mama, tenma; //

      /// <summary>
      /// Hàm thiết lập 
      /// </summary>
      /// <param name="ms"></param>
      /// <param name="ten"></param>
        public Fr20QLNH_RBTV19(string ms, string ten)
        {
       
            InitializeComponent();
            mama = ms; //lấy mã món ăn từ tham số xuống
            tenma = ten; //lấy tên món ăn từ tham số xuống
        }

        private void Fr20QLNH_RBTV19_Load(object sender, EventArgs e)
        {
            TonHang_Load();
            ctBill_Load();
            ctHD_Load();


            // TODO: This line of code loads data into the 'g119NHKQsaleCTHD.CT_HD' table. You can move, or remove it, as needed.
            this.cT_HDTableAdapter.Fill(this.g119NHKQsaleCTHD.CT_HD, mama);
            // TODO: This line of code loads data into the 'g119NHKQsaleCTBill.CT_Bill' table. You can move, or remove it, as needed.
            this.cT_BillTableAdapter.Fill(this.g119NHKQsaleCTBill.CT_Bill, mama);
            // TODO: This line of code loads data into the 'g119NHKQSaleDSTon.MonAnTon' table. You can move, or remove it, as needed.
            this.monAnTonTableAdapter.Fill(this.g119NHKQSaleDSTon.MonAnTon, mama);
            lbTitle.Text = "G119_NHKQ: XỬ LÝ RÀNG BUỘC TOÀN VẸN DỮ LIỆU KHI KHÔNG BÁN MÓN ĂN CỦA NHÀ HÀNG RUNAM:" + mama + ": " + tenma;
            gBTon.Text = "Mon An: " + mama + " = " + tenma + " CẦN 'XÓA' ĐANG CÒN TỒN TRONG CÁC KHO SAU";
            gBBill.Text = "Mon An: " + mama + " = " + tenma + " CẦN 'XÓA' ĐANG CÒN TRÊN CÁC PHIẾU 'CT_Bill' SAU ";
            gBInvoice.Text = "Mon An: " + mama + " = " + tenma + " CẦN 'XÓA' ĐANG CÒN TRÊN CÁC PHIẾU 'CT_HD' SAU ";
            MessageBox.Show("Quý vị đang muốn XÓA món ăn có mã:" + mama + " tên:" + tenma + " => nhưng món ăn này còn RBTV sau cần phải xử lý trước kho Xóa.");

            btn1Bill.Enabled = false;
            btn1Invoice.Enabled = false;
            btn1Ton.Enabled = false;    

        }// private void Fr20QLNH_RBTV19_Load(object sender, EventArgs e)


        ///////////////////////////////////////
        ///CHỌN 1 CHI TIẾT / CÁC DATAGRIDVIEW///////////////
        //////////////////////////////////////

        /// <summary>
        /// THỦ TỤC CHỌN TỒN HÀNG ......CẦN THANH LÝ
        /// </summary>
        static int vtton = 0; //Biến toàn cục static lưu vị trí Tồn món ăn đang chọn để Thanh lý
        static string machinhanh = "";//Biến toàn cục static mã Chi nhánh tồn món ăn đang chọn để Thanh lý
        private void dataGridViewTon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vtton = e.RowIndex;//vị trí chọn
            machinhanh = dataGridViewTon.Rows[vtton].Cells[0].Value.ToString().Trim();
            btn1Ton.Enabled = true; //cho Hủy 1...
        }//private void dataGridViewTon_CellContentClick


        /// <summary>
        /// THỦ TỤC CHỌN CHI TIẾT BILL ......CẦN HỦY
        /// </summary>
        static int vtctbill = 0; //Biến toàn cục static lưu vị trí CT BILL đang chọn để Hủy
        static string mab = "";//Biến toàn cục static mã Phiếu tính tiền đang chọn để Hủy
        private void dataGridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vtctbill = e.RowIndex;//vị trí chọn
            mab = dataGridViewBill.Rows[vtctbill].Cells[0].Value.ToString().Trim();
            btn1Bill.Enabled = true; //cho Hủy 1...
        }//private void dataGridViewBill_CellContentClick
        /// <summary>
        /// THỦ TỤC CHỌN CHI TIẾT HÓA ĐƠN.....CẦN HỦY
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static int vtcthoadon = 0; //Biến toàn cục static lưu vị trí CT HD đang chọn để Hủy
        static string h = "";//Biến toàn cục static mã Phiếu tính tiền đang chọn để Hủy
        private void dataGridViewInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vtcthoadon = e.RowIndex;//vị trí chọn
            h = dataGridViewInvoice.Rows[vtctbill].Cells[0].Value.ToString().Trim();
            btn1Invoice.Enabled = true; //cho Hủy 1...
        }



        ///////////////////////////////////////
        ///LOAD CÁC DATAGRIDVIEW///////////////
        ///////////////////////////////////////

        /// <summary>
        /// LOAD TỒN HÀNG
        /// </summary>
        private void TonHang_Load()
        {
            try
            {
                // TODO: This line of code loads data into the 'g119NHKQsaleCTHD.CT_HD' table. You can move, or remove it, as needed.
                this.cT_HDTableAdapter.Fill(this.g119NHKQsaleCTHD.CT_HD, mama);
            }
            catch (System.Exception) { }

            if (dataGridViewTon.Rows.Count < 2) //luôn có 1 dòng "chờ", nên phải từ 2 rows trở lên = xem là có dữ liệu
            {
                btn1Ton.Enabled = false; //khóa lại
                btnATon.Enabled = false;
            }
            else
            {
                btn1Ton.Enabled = true; //mở ra
                btnATon.Enabled = true;
            }
        }//private void TonHang_Load()

        /// <summary>
        /// LOAD CHI TIẾT PHIẾU TÍNH TIỀN (BILL)
        /// </summary>
        private void ctBill_Load()
        {
            try
            {
                // TODO: This line of code loads data into the 'g119NHKQsaleCTBill.CT_Bill' table. You can move, or remove it, as needed.
                this.cT_BillTableAdapter.Fill(this.g119NHKQsaleCTBill.CT_Bill, mama);
            }
            catch (System.Exception) { }

            if (dataGridViewBill.Rows.Count < 2)
            {
                btn1Bill.Enabled = false; //khóa lại
                btnABill.Enabled = false;
            }
            else
            {
                btn1Bill.Enabled = true; //Mởlại
                btnABill.Enabled = true;
            }
        }//private void ctBill_Load()



        /// <summary>
        /// LOAD CHI TIẾT HÓA ĐƠN (INVOICE)
        /// </summary>
        private void ctHD_Load()
        {
            try
            {
                // TODO: This line of code loads data into the 'g119NHKQsaleCTHD.CT_HD' table. You can move, or remove it, as needed.
                this.cT_HDTableAdapter.Fill(this.g119NHKQsaleCTHD.CT_HD, mama);
            }
            catch (System.Exception) { }

            if (dataGridViewInvoice.Rows.Count < 2)
            {
                btn1Invoice.Enabled = false; //khóa lại
                btnAInvoice.Enabled = false;
            }
            else
            {
                btn1Invoice.Enabled = true; //Mở
                btnAInvoice.Enabled = true;
            }
        }//private void ctHD_Load()
 

        /// <summary>
        /// Thanh lý (xóa) 1 món ăn tồn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1Ton_Click(object sender, EventArgs e)
        {
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Thiệt Thanh lý tồn kho của món ăn: " + tenma + ": tại cơ sở bán hàng có mã: " + machinhanh + ": đúng không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    monAnTonTableAdapter.Delete(machinhanh, mama);
                    MessageBox.Show("Xóa xong rồi, xem đi !");
                }
                catch (System.Exception ex) { MessageBox.Show("Lỗi Thanh lý 1 món ăn tồn: " + ex.Message); }
            }
            //B3: Tải BD lên DataGridView sau khi xóa

            try
            {
                this.monAnTonTableAdapter.Fill(this.g119NHKQSaleDSTon.MonAnTon, mama);
            }
            catch (System.Exception) { }
            btn1Ton.Enabled = false; //khóa lại

        }//   private void btn1Ton_Click(object sender, EventArgs e)

   

        /// <summary>
        /// HỦY 1 CHI TIẾT BILL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1Bill_Click(object sender, EventArgs e)
        {
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Thiệt Hủy chi tiết Bill của món ăn: " + tenma + ": trên Bill có mã: " + mab + ": đúng không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    cT_BillTableAdapter.Delete(mab, mama);
                    MessageBox.Show("Xóa xong rồi, xem đi !");
                }
                catch (System.Exception ex) { MessageBox.Show("Lỗi Hủy 1 chi tiết: " + ex.Message); }
            }
            //B3: Tải BD lên DataGridView sau khi xóa
            ctBill_Load();
            btn1Bill.Enabled = false; //khóa lại

        }// private void btn1Bill_Click(object sender, EventArgs e)

        /// <summary>
        /// HỦY 1 HÓA ĐƠN 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1Invoice_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt Hủy hóa đơn của món ăn: " + tenma + ": có mã: " + mama + ": đúng không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    cT_HDTableAdapter.Delete(h, mama);
                    MessageBox.Show("Xóa xong rồi, xem đi !");
                }
                catch (System.Exception ex) { MessageBox.Show("Lỗi Hủy 1 chi tiết tồn kho: " + ex.Message); }
            }

            //B3: Tải BD lên DataGridView sau khi xóa
            try
            {
               
                this.cT_HDTableAdapter.Fill(this.g119NHKQsaleCTHD.CT_HD, mama);
            }
            catch (System.Exception) { }
            btn1Invoice.Enabled = false; //khóa lại
        }// private void btn1Invoice_Click(object sender, EventArgs e)

        ///////////////////////////////////////
        ///CÁC THỦ TỤC EVENT: HỦY/ THANH LÝ ALL ....////////////
        //////////////////////////////////////

        /// <summary>
        /// THANH LÝ ALL TỒN MÓN ĂN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnATon_Click_1(object sender, EventArgs e)
        {
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Thiệt Thanh lý tồn kho của món ăn: " + tenma + ": tại TẤT CẢ các cơ sở bán hàng đúng không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {

                    monAnTonTableAdapter.Delete_ATon(mama);
                    MessageBox.Show("Xóa xong rồi, xem đi !");
                }
                catch (System.Exception ex) { MessageBox.Show("Lỗi Thanh lý ALL tồn món ăn: " + ex.Message); }
            }
            //B3: Tải BD lên DataGridView sau khi xóa
            TonHang_Load();
            btnATon.Enabled = false; //khóa lại
        }//private void btnATon_Click_1(object sender, EventArgs e)

      

        /// <summary>
        /// HỦY ALL CHI TIẾT BILL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnABill_Click_1(object sender, EventArgs e)
        {
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Thiệt Hủy TẤT CẢ chi tiết Bill của món ăn: " + tenma + ": đúng không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    cT_BillTableAdapter.Delete_ACTBill(mama);
                    MessageBox.Show("Xóa xong rồi, xem đi !");
                }
                catch (System.Exception ex) { MessageBox.Show("Lỗi Hủy ALL chi tiết: " + ex.Message); }
            }
            //B3: Tải BD lên DataGridView sau khi xóa
            ctBill_Load();
            btnABill.Enabled = false; //khóa lại
        }// private void btnABill_Click_1(object sender, EventArgs e)

      

        /// <summary>
        /// HỦY ALL CHI TIẾT INVOICE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAInvoice_Click(object sender, EventArgs e)
        {
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Thiệt Hủy TẤT CẢ chi tiết Invoice của món ăn: " + tenma + ": đúng không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    cT_HDTableAdapter.Delete_ACTInVoice(mama);
                    MessageBox.Show("Xóa xong rồi, xem đi !");
                }
                catch (System.Exception ex) { MessageBox.Show("Lỗi Hủy ALL chi tiết: " + ex.Message); }
            }
            //B3: Tải BD lên DataGridView sau khi xóa
            ctBill_Load();
            btnAInvoice.Enabled = false; //khóa lại
        }// private void btnAInvoice_Click(object sender, EventArgs e)


    


    }// public partial class Fr20QLNH_RBTV19 : Form
}//namespace G119NHKQ_SaleRuNam



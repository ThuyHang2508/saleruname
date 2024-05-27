using G119NHKQ_SaleRuNam.G119NHKQNVRuNamNDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace G119NHKQ_SaleRuNam
{
    public partial class _2FrQLNHRuNam19 : Form
    {
        public _2FrQLNHRuNam19()
        {
            InitializeComponent();
        }

        //KHAI BÁO CÁC THAM SỐ TOÀN CỤC 
        static string name = "", pass = ""; //liên quan đăng nhập (Login)
        string apppath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) + "\\Images\\";  //BIẾN TOÀN CỤC LƯU ĐƯỜNG DẪN ĐẾ THƯ MỤC LƯU APP BÀI LÀM NAY
                                                                                                                                    //string apppath = "D:\G119NHKQ_SaleRuNam\\Images\\"; 
                                                                                                                                    //BIẾN TOÀN CỤC LƯU ĐƯỜNG DẪN ĐẾ THƯ MỤC LƯU APP BÀI LÀM NAY
        /// <summary>
        /// Tự động chạy khi form quản lý này được mở lên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _2FrQLNHRuNam19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g119NHKQNSXRuNamDS.NhaSanXuat' table. You can move, or remove it, as needed.
            this.nhaSanXuatTableAdapter.Fill(this.g119NHKQNSXRuNamDS.NhaSanXuat);
            // TODO: This line of code loads data into the 'g119KQSalTNhomRNDS.ThuocNhom' table. You can move, or remove it, as needed.
            this.thuocNhomTableAdapter.Fill(this.g119KQSalTNhomRNDS.ThuocNhom);
            // TODO: This line of code loads data into the 'g119NHKQSaleRNDS.DMMonAn' table. You can move, or remove it, as needed.
            this.dMMonAnTableAdapter.Fill(this.g119NHKQSaleRNDS.DMMonAn);

        }///private void _2FrQLNHRuNam19_Load(object sender, EventArgs e)


        //CHỌN HÌNH MẪU CHO SẢN PHẨM
        static string oldimage, imagechoose = "";//Biến toàn cục Lưu tên file hình mà NSD đã chọn (Thêm/Sửa) đối với PictureBox, oldimage 

        private void ChonHinh(object sender, EventArgs e)
        {
            DialogResult ch = openFileDialogPic.ShowDialog();//Mở hộp thoại cho phép NSD chọn hình cho sản phẩm
            if (ch == DialogResult.OK)//NSD đồng ý với hình đã chọn
            {
                //1. Lưu tên file của hình vừa copy nêu trên vào biến toàn cục để sau này (Thêm/Sửa)  sẽ cập nhật vào 2 thuộc tính hinh(Win Acc) và hinhweb(của Web) trong Table MH của DB
                imagechoose = System.IO.Path.GetFileName(openFileDialogPic.FileName);
                //chỉ lấy tên file ko lấy đường dẫn

                //2. Copy hình vừa chọn vào thư mục hình Images của App   (để sau này Copy App đi nơi khác thư mục hình sẽ tự đi theo)
                try
                {
                    System.IO.File.Copy(openFileDialogPic.FileName, apppath + txtmma.Text.Trim() + imagechoose, true); // chồng lên hình cũ nếu đã có
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi sao chép hình vào thư mục của App" + ex.Message); }
            }

        }// private void ChonHinh(object sender, EventArgs e)

        /// <summary>
        /// Xóa món ăn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Thiệt muốn xóa món ăn không: " + txtmma.Text.Trim() + " : " + txttenma.Text.Trim() + " đúng không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    dMMonAnTableAdapter.Delete(txtmma.Text.Trim());
                    MessageBox.Show("Xóa xong rồi, xem đi !");

                    DialogResult c = MessageBox.Show("Có xóa luôn hình không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (c == DialogResult.No)
                    {
                        try
                        {
                           
                            System.IO.File.Copy(pictureBoxHinh.ImageLocation, apppath + "z\\" + System.IO.Path.GetFileName(pictureBoxHinh.ImageLocation));
                            MessageBox.Show("hình cũ copy vao thu muc ...\\z nha !");
                        }
                        catch (System.Exception ex) { MessageBox.Show("Lỗi xóa hình ra khỏi hệ thống" + ex.Message); }
                    }
                    else
                    {
                        MessageBox.Show("Xóa hình cũ nha !");
                    }
                    System.IO.File.Delete(pictureBoxHinh.ImageLocation);//picturebox, imagelocation

                }
                catch (System.Exception ex)// KHÔNG XÓA ĐƯỢC DO CÒN RBTV DL
                {
                     MessageBox.Show("Có lỗi xóa món ăn: " + ex.Message);
                    //gọi Form xử lý RBTV trước khi Xóa
                    Fr20QLNH_RBTV19 fr = new Fr20QLNH_RBTV19 (txtmma.Text.Trim(), txttenma.Text.Trim());//TRUYỀN msmma và tenma SANG FORM XL RBTV
                   fr.ShowDialog();
                }
            }
            //B3: Tải BD lên DataGridView sau khi xóa
            try
            {
                // TODO: This line of code loads data into the 'g119NHKQSaleRNDS.DMMH' table. You can move, or remove it, as needed.
                this.dMMonAnTableAdapter.Fill(this.g119NHKQSaleRNDS.DMMonAn);
            }
            catch (System.Exception) { }
        }// private void btnXoa_Click(object sender, EventArgs e)


        /// <summary>
        /// Thêm món ăn mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            {//B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC THAY ĐỔI CÁC TEXTBOX THÔNG TIN MẶT HÀNG
                txtmma.Enabled = !txtmma.Enabled;
                txttenma.Enabled = !txttenma.Enabled;
                txtgiaban.Enabled = !txtgiaban.Enabled;
                txtdvt.Enabled = !txtdvt.Enabled;
                txtmota.Enabled = !txtmota.Enabled;
                comboBoxNhasx.Enabled = !comboBoxNhasx.Enabled;
                comboBoxThuocNhom.Enabled = !comboBoxThuocNhom.Enabled;
                checkBoxConma.Enabled = !checkBoxConma.Enabled;

                //khóa các nút lệnh khác (ngoại trừ được Đóng form)
                btnSua.Enabled = !btnSua.Enabled;
                btnXoa.Enabled = !btnXoa.Enabled;
                btnExit.Enabled = !btnExit.Enabled;
                if (btnThem.Text == "Thêm Món Ăn Mới")//CHUẨN BỊ Thêm Món Ăn mới
                {//MỞ CHẾ ĐỘ CHO NSD CHỌN HÌNH CHO SP MỚI
                    pictureBoxHinh.ImageLocation = apppath + "chonhinh.png";
                    //hiện hình ảnh thông báo NSD chọn hình
                   pictureBoxHinh.Click += new EventHandler(ChonHinh);  // cho phép NSD click vào PictureBox để chọn hình (Gán Event Click vào PictureBox Hình)
                    //XÓA CÁC Ô TEXTBOX TRONG CHI TIẾT Ơ BÊN PHẢI ĐỂ CHUẨN BỊ CHO NSD NHẬP THÔNG TIN SP MỚI
                    txtmma.Text = "";
                    txttenma.Text = "";
                    txtgiaban.Text = "";
                    txtdvt.Text = "";
                    txtmota.Text = "";
                    btnThem.Text = "Lưu (Thêm)";
                    //đổi nhãn Thêm => Lưu (sau khi NSD đã nhập đủ các thông tin MH mới)
                }
                else //THÊM MÓN ĂN MỚI VÀO DATABASE VÀ HIỆN LÊN DATAGRIDVIEW
                {//1. THÊM MÓN ĂN MỚI VÀO DB 
                    try
                    {//nếu NSD ko chọn hình thì biến toàn cục imagechoose = "" và  có nghĩa là món ăn mới chưa có hình ảnh & ComboBox...ValueMenber = msnhom
                        dMMonAnTableAdapter.Insert(txtmma.Text.Trim(), txttenma.Text, double.Parse(txtgiaban.Text.Trim()), txtdvt.Text, txtmota.Text, comboBoxNhasx.SelectedValue.ToString(), checkBoxConma.Checked, comboBoxThuocNhom.SelectedValue.ToString(), apppath + txtmma.Text.Trim() + imagechoose);
                    

                        MessageBox.Show("THÊM XONG, XEM ĐI");
                    } catch(System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM MÓN ĂN MỚI " + ex.Message); }

                    //2. TẢI LẠI DL SAU KHI THÊM SP MỚI TỪ DB LÊN DATAGRIDWIEW ĐỂ NSD BIẾT KQ  [COPY code TỪ form_load OR Combobox_selectIndexChanhe]
                    try
                    {
                        // Tai ds cac MH vao DataGridView ben duoi theo Nhom MH da chon trong ComboBox phia tren
                        this.dMMonAnTableAdapter.Fill(this.g119NHKQSaleRNDS.DMMonAn);

                    }
                    catch (System.Exception) { } //bat moi he thong = tranh truong hop ctr bi dung  dot ngot

                    //3. THAY ĐỔI TRANG THÁI THÊM MỚI ĂN MỚI
                     //  pictureBoxHinh.Click -= pictureBoxHinh_Click;//KHÔNG CHO NSD click vào PictureBoX hình  (Xóa Event Click của PictureBox Hình)
                    // pictureBoxHinh.ImageLocation = ""; //GỠ BỎ hình ảnh thông báo chọn hình
                    btnThem.Text = "Thêm Món Ăn Mới";//đổi nhãn trả lại Lưu => Thêm (thêm thêm mới món ăn khác)
                }
            }
        }//  private void btnThem_Click(object sender, EventArgs e)


        /// <summary>
        /// Sửa món ăn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {//B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC SỬA
          //txtmma.Enabled = !txtmma.Enabled; = không được sửa PK
            txttenma.Enabled = !txttenma.Enabled;
            txtgiaban.Enabled = !txtgiaban.Enabled;
            txtmota.Enabled = !txtmota.Enabled;
            txtdvt.Enabled = !txtdvt.Enabled;
            comboBoxNhasx.Enabled = !comboBoxNhasx.Enabled;
            comboBoxThuocNhom.Enabled = !comboBoxThuocNhom.Enabled;
            checkBoxConma.Enabled = !checkBoxConma.Enabled;

            //khóa các thao tác khác
            btnThem.Enabled = !btnThem.Enabled;
            btnXoa.Enabled = !btnXoa.Enabled;
            btnExit.Enabled = !btnExit.Enabled;

            if (btnSua.Text == "Sửa Món Ăn")//Bắt đầu sửa
            {   //MỞ CHẾ ĐỘ CHO NSD CHỌN HÌNH MỚI CHO MÓN ĂN
                oldimage = pictureBoxHinh.ImageLocation; // giữ lại tên và path của hình cũ
                pictureBoxHinh.ImageLocation = apppath + "chonhinh.png";  //hiện hình ảnh thông báo NSD chọn hình
                  pictureBoxHinh.Click += new EventHandler(ChonHinh);  // cho phép NSD click vào PictureBox để chọn hình (Gán Event Click vào PictureBox Hình)
                //B2: HƯỚNG DẪN CÁCH SỬA
                MessageBox.Show("Quý vị SỬA trong các ô Text bên phải, CHỌN LẠI HÌNH BẰNG CÁCH CLICK VÀO HÌNH ĐỂ CHỌN HÌNH MỚI THAY THẾ");
               
                btnSua.Text = "Lưu (Sửa)";
            }
            else //LƯU SAU KHI SỬA XONG
            {//KIỂM TRA NSD CÓ THAY ĐỔI HÌNH HAY KHÔNG: NẾU CHỌN HÌNH MỚI THÌ THAY; NẾU KHÔNG THÌ GIỮ LẠI HÌNH CŨ
                if (imagechoose == "") imagechoose = oldimage;  //NSD KHÔNG THAY ĐỔI HÌNH (NÊN giữa lại hình cũ)
                DialogResult c = MessageBox.Show("Có giữ lại hình cũ không ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //NSD KHÔNG THAY ĐỔI HÌNH (NÊN giữa lại hình cũ)
                if (c == DialogResult.Yes)
                {
                    System.IO.File.Copy(oldimage, apppath + "z\\" + System.IO.Path.GetFileName(oldimage));
                    MessageBox.Show("hình cũ được copy vào thư mục ..... \\ z nha !");
                }
                else
                {
                    MessageBox.Show("Xóa hình cũ nha !");
                }
                System.IO.File.Delete(oldimage);

                try
                { //B3: lưu DB
                    dMMonAnTableAdapter.Update(txttenma.Text, double.Parse(txtgiaban.Text.Trim()), txtdvt.Text, txtmota.Text, comboBoxNhasx.SelectedValue.ToString(), checkBoxConma.Checked, comboBoxThuocNhom.SelectedValue.ToString(), apppath + txtmma.Text.Trim() + imagechoose, txtmma.Text.Trim());
                    MessageBox.Show("Sửa xong rồi, xem đi !");

                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi sửa chữa thông tin món ăn " + ex.Message); }
                //B4: ĐỔI NHÃN 
                btnSua.Text = "Sửa Món Ăn";
                // pictureBoxHinh.Click -= pictureHinh;
                //KHÔNG CHO NSD click vào PictureBoX hình (Xóa Event Click của PictureBox Hình)
                //pictureBoxHinh.ImageLocation = ""; //GỠ BỎ hình ảnh thông báo chọn hình

                //B5: Tải BD lên DataGridView sau khi xóa
                try
                {
                    // Tai ds cac Món Ăn vao DataGridView ben duoi theo Nhom MA da chon trong ComboBox phia tren
                    this.dMMonAnTableAdapter.Fill(this.g119NHKQSaleRNDS.DMMonAn);
                }
                catch (System.Exception) { } //bat moi he thong = tranh truong hop ctr bi dung  dot ngot
            }
        }//  private void btnSua_Click(object sender, EventArgs e)

        
      /// <summary>
      /// Thoát chương trình
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có thật sự muốn thoát (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }// private void btnExit_Click_1(object sender, EventArgs e)

        /// <summary>
        /// Về màn hình chính
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMain_Click_1(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn về màn hình chính (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }//private void btnMain_Click_1(object sender, EventArgs e)

    }//public partial class _2FrQLNHRuNam19 : Form
}//namespace G119NHKQ_SaleRuNam

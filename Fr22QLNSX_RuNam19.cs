using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G119NHKQ_SaleRuNam
{
    public partial class Fr22QLNSX_RuNam19 : Form
    {
        public Fr22QLNSX_RuNam19()
        {
            InitializeComponent();
        }

        private void Fr22QLNSX_RuNam19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g119KQSaleNSXRNDS.NhaSanXuat' table. You can move, or remove it, as needed.
            this.nhaSanXuatTableAdapter.Fill(this.g119KQSaleNSXRNDS.NhaSanXuat);

        }
    }
}

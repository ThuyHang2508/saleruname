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
    public partial class Fr21QLNhom_RuNam19 : Form
    {
        public Fr21QLNhom_RuNam19()
        {
            InitializeComponent();
        }

        private void Fr21QLNhom_RuNam19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g119KQSaleNhomRNDS.ThuocNhom' table. You can move, or remove it, as needed.
            this.thuocNhomTableAdapter.Fill(this.g119KQSaleNhomRNDS.ThuocNhom);

        }
    }
}

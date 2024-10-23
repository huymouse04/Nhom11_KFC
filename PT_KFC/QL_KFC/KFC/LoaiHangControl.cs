using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC
{
    public partial class LoaiHangControl : UserControl
    {
        public LoaiHangControl()
        {
            InitializeComponent();
        }

        public string MaLH
        {
            get { return lblMaLoaiHang.Text; }
            set { lblMaLoaiHang.Text = value; }
        }
        public string TenLH
        {
            get { return lblTenLoaiHang.Text; }
            set { lblTenLoaiHang.Text = value; }
        }
    }
}

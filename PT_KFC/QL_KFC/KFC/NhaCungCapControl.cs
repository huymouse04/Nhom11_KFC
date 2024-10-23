using KFC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC
{
    public partial class NhaCungCapControl : UserControl
    {
        public NhaCungCapControl()
        {
            InitializeComponent();
        }

        public string TenNCC { get { return lblTenNCC.Text; } set { lblTenNCC.Text = value; } }
        public string SDT
        {
            get
            {
                return lblSDT.Text;
            }
            set
            {
                lblSDT.Text = $"SDT: {value}";
            }
        }
        public string ImagePath
        {
            get { return pbNCC.ImageLocation; }
            set
            {
                if (File.Exists(value))
                {
                    using (var imgStream = new FileStream(value, FileMode.Open, FileAccess.Read))
                    {
                        pbNCC.Image = Image.FromStream(imgStream);
                    }
                }
                else
                {
                    pbNCC.Image = Resources.logo; // Hiển thị ảnh trống nếu không tìm thấy
                }
            }
        }
    }
}

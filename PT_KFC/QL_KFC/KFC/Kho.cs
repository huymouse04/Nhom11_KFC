﻿using System;
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
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            LoaiHang lh = new LoaiHang();
            lh.ShowDialog();
        }
    }
}

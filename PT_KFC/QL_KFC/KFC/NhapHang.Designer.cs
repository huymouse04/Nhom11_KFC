namespace KFC
{
    partial class NhapHang
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
            this.cbbMNCC = new System.Windows.Forms.ComboBox();
            this.lbMNCC = new System.Windows.Forms.Label();
            this.lbMLH = new System.Windows.Forms.Label();
            this.pnBET = new System.Windows.Forms.Panel();
            this.vbButton4 = new CustomButton.VBButton();
            this.vbButton1 = new CustomButton.VBButton();
            this.vbButton2 = new CustomButton.VBButton();
            this.vbButton3 = new CustomButton.VBButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMLH = new System.Windows.Forms.ComboBox();
            this.dtpNN = new System.Windows.Forms.DateTimePicker();
            this.cbbMSP = new System.Windows.Forms.ComboBox();
            this.tbDVT = new System.Windows.Forms.TextBox();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.tbMNH = new System.Windows.Forms.TextBox();
            this.lbNN = new System.Windows.Forms.Label();
            this.lbDVT = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbMSP = new System.Windows.Forms.Label();
            this.lbMNH = new System.Windows.Forms.Label();
            this.lblNH = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.dtGVNH = new System.Windows.Forms.DataGridView();
            this.vbButton5 = new CustomButton.VBButton();
            this.pnBET.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNH)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMNCC
            // 
            this.cbbMNCC.FormattingEnabled = true;
            this.cbbMNCC.Location = new System.Drawing.Point(709, 223);
            this.cbbMNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMNCC.Name = "cbbMNCC";
            this.cbbMNCC.Size = new System.Drawing.Size(259, 24);
            this.cbbMNCC.TabIndex = 23;
            // 
            // lbMNCC
            // 
            this.lbMNCC.AutoSize = true;
            this.lbMNCC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMNCC.Location = new System.Drawing.Point(491, 223);
            this.lbMNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMNCC.Name = "lbMNCC";
            this.lbMNCC.Size = new System.Drawing.Size(194, 27);
            this.lbMNCC.TabIndex = 22;
            this.lbMNCC.Text = "Mã nhà cung cấp :";
            // 
            // lbMLH
            // 
            this.lbMLH.AutoSize = true;
            this.lbMLH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMLH.Location = new System.Drawing.Point(529, 166);
            this.lbMLH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMLH.Name = "lbMLH";
            this.lbMLH.Size = new System.Drawing.Size(156, 27);
            this.lbMLH.TabIndex = 20;
            this.lbMLH.Text = "Mã loại hàng :";
            this.lbMLH.Click += new System.EventHandler(this.lbMLH_Click);
            // 
            // pnBET
            // 
            this.pnBET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBET.Controls.Add(this.vbButton5);
            this.pnBET.Controls.Add(this.vbButton4);
            this.pnBET.Controls.Add(this.vbButton1);
            this.pnBET.Controls.Add(this.vbButton2);
            this.pnBET.Controls.Add(this.vbButton3);
            this.pnBET.Controls.Add(this.textBox1);
            this.pnBET.Controls.Add(this.label1);
            this.pnBET.Controls.Add(this.cbbMNCC);
            this.pnBET.Controls.Add(this.lbMNCC);
            this.pnBET.Controls.Add(this.cbbMLH);
            this.pnBET.Controls.Add(this.lbMLH);
            this.pnBET.Controls.Add(this.dtpNN);
            this.pnBET.Controls.Add(this.cbbMSP);
            this.pnBET.Controls.Add(this.tbDVT);
            this.pnBET.Controls.Add(this.tbSL);
            this.pnBET.Controls.Add(this.tbMNH);
            this.pnBET.Controls.Add(this.lbNN);
            this.pnBET.Controls.Add(this.lbDVT);
            this.pnBET.Controls.Add(this.lbSL);
            this.pnBET.Controls.Add(this.lbMSP);
            this.pnBET.Controls.Add(this.lbMNH);
            this.pnBET.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBET.Location = new System.Drawing.Point(0, 379);
            this.pnBET.Margin = new System.Windows.Forms.Padding(4);
            this.pnBET.Name = "pnBET";
            this.pnBET.Size = new System.Drawing.Size(1156, 292);
            this.pnBET.TabIndex = 9;
            // 
            // vbButton4
            // 
            this.vbButton4.BackColor = System.Drawing.Color.Firebrick;
            this.vbButton4.BackgroundColor = System.Drawing.Color.Firebrick;
            this.vbButton4.BorderColor = System.Drawing.Color.LavenderBlush;
            this.vbButton4.BorderRadius = 10;
            this.vbButton4.BorderSize = 0;
            this.vbButton4.FlatAppearance.BorderSize = 0;
            this.vbButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton4.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton4.ForeColor = System.Drawing.Color.White;
            this.vbButton4.Location = new System.Drawing.Point(991, 166);
            this.vbButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbButton4.Name = "vbButton4";
            this.vbButton4.Size = new System.Drawing.Size(151, 44);
            this.vbButton4.TabIndex = 29;
            this.vbButton4.Text = "Tìm kiếm";
            this.vbButton4.TextColor = System.Drawing.Color.White;
            this.vbButton4.UseVisualStyleBackColor = false;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.Firebrick;
            this.vbButton1.BackgroundColor = System.Drawing.Color.Firebrick;
            this.vbButton1.BorderColor = System.Drawing.Color.Crimson;
            this.vbButton1.BorderRadius = 10;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(991, 22);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(151, 44);
            this.vbButton1.TabIndex = 28;
            this.vbButton1.Text = "Thêm";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.Firebrick;
            this.vbButton2.BackgroundColor = System.Drawing.Color.Firebrick;
            this.vbButton2.BorderColor = System.Drawing.Color.Crimson;
            this.vbButton2.BorderRadius = 10;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(991, 70);
            this.vbButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(151, 44);
            this.vbButton2.TabIndex = 27;
            this.vbButton2.Text = "Cập nhật";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // vbButton3
            // 
            this.vbButton3.BackColor = System.Drawing.Color.Firebrick;
            this.vbButton3.BackgroundColor = System.Drawing.Color.Firebrick;
            this.vbButton3.BorderColor = System.Drawing.Color.LavenderBlush;
            this.vbButton3.BorderRadius = 10;
            this.vbButton3.BorderSize = 0;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton3.ForeColor = System.Drawing.Color.White;
            this.vbButton3.Location = new System.Drawing.Point(991, 118);
            this.vbButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(151, 44);
            this.vbButton3.TabIndex = 26;
            this.vbButton3.Text = "Xóa";
            this.vbButton3.TextColor = System.Drawing.Color.White;
            this.vbButton3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 163);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 22);
            this.textBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên sản phẩm : ";
            // 
            // cbbMLH
            // 
            this.cbbMLH.FormattingEnabled = true;
            this.cbbMLH.Location = new System.Drawing.Point(709, 166);
            this.cbbMLH.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMLH.Name = "cbbMLH";
            this.cbbMLH.Size = new System.Drawing.Size(259, 24);
            this.cbbMLH.TabIndex = 21;
            this.cbbMLH.SelectedIndexChanged += new System.EventHandler(this.cbbMLH_SelectedIndexChanged);
            // 
            // dtpNN
            // 
            this.dtpNN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNN.Location = new System.Drawing.Point(703, 95);
            this.dtpNN.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNN.Name = "dtpNN";
            this.dtpNN.Size = new System.Drawing.Size(265, 22);
            this.dtpNN.TabIndex = 19;
            // 
            // cbbMSP
            // 
            this.cbbMSP.FormattingEnabled = true;
            this.cbbMSP.Location = new System.Drawing.Point(215, 97);
            this.cbbMSP.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMSP.Name = "cbbMSP";
            this.cbbMSP.Size = new System.Drawing.Size(259, 24);
            this.cbbMSP.TabIndex = 18;
            // 
            // tbDVT
            // 
            this.tbDVT.Location = new System.Drawing.Point(709, 26);
            this.tbDVT.Margin = new System.Windows.Forms.Padding(4);
            this.tbDVT.Name = "tbDVT";
            this.tbDVT.Size = new System.Drawing.Size(259, 22);
            this.tbDVT.TabIndex = 10;
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(215, 225);
            this.tbSL.Margin = new System.Windows.Forms.Padding(4);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(259, 22);
            this.tbSL.TabIndex = 9;
            // 
            // tbMNH
            // 
            this.tbMNH.Location = new System.Drawing.Point(215, 26);
            this.tbMNH.Margin = new System.Windows.Forms.Padding(4);
            this.tbMNH.Name = "tbMNH";
            this.tbMNH.Size = new System.Drawing.Size(259, 22);
            this.tbMNH.TabIndex = 7;
            // 
            // lbNN
            // 
            this.lbNN.AutoSize = true;
            this.lbNN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNN.Location = new System.Drawing.Point(549, 90);
            this.lbNN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNN.Name = "lbNN";
            this.lbNN.Size = new System.Drawing.Size(131, 27);
            this.lbNN.TabIndex = 4;
            this.lbNN.Text = "Ngày nhập :";
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVT.Location = new System.Drawing.Point(549, 26);
            this.lbDVT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(136, 27);
            this.lbDVT.TabIndex = 3;
            this.lbDVT.Text = "Đơn vị tính :";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.Location = new System.Drawing.Point(68, 218);
            this.lbSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(113, 27);
            this.lbSL.TabIndex = 2;
            this.lbSL.Text = "Số lượng :\r\n";
            // 
            // lbMSP
            // 
            this.lbMSP.AutoSize = true;
            this.lbMSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSP.Location = new System.Drawing.Point(25, 97);
            this.lbMSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMSP.Name = "lbMSP";
            this.lbMSP.Size = new System.Drawing.Size(156, 27);
            this.lbMSP.TabIndex = 1;
            this.lbMSP.Text = "Mã sản phẩm :";
            // 
            // lbMNH
            // 
            this.lbMNH.AutoSize = true;
            this.lbMNH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMNH.Location = new System.Drawing.Point(15, 26);
            this.lbMNH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMNH.Name = "lbMNH";
            this.lbMNH.Size = new System.Drawing.Size(166, 27);
            this.lbMNH.TabIndex = 0;
            this.lbMNH.Text = "Mã nhập hàng :";
            // 
            // lblNH
            // 
            this.lblNH.AutoSize = true;
            this.lblNH.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNH.Location = new System.Drawing.Point(468, 23);
            this.lblNH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNH.Name = "lblNH";
            this.lblNH.Size = new System.Drawing.Size(214, 45);
            this.lblNH.TabIndex = 1;
            this.lblNH.Text = "Nhập Hàng";
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lblNH);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1156, 91);
            this.pnTop.TabIndex = 8;
            // 
            // dtGVNH
            // 
            this.dtGVNH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGVNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVNH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGVNH.Location = new System.Drawing.Point(0, 0);
            this.dtGVNH.Margin = new System.Windows.Forms.Padding(4);
            this.dtGVNH.Name = "dtGVNH";
            this.dtGVNH.RowHeadersWidth = 51;
            this.dtGVNH.Size = new System.Drawing.Size(1156, 671);
            this.dtGVNH.TabIndex = 7;
            // 
            // vbButton5
            // 
            this.vbButton5.BackColor = System.Drawing.Color.Firebrick;
            this.vbButton5.BackgroundColor = System.Drawing.Color.Firebrick;
            this.vbButton5.BorderColor = System.Drawing.Color.Crimson;
            this.vbButton5.BorderRadius = 10;
            this.vbButton5.BorderSize = 0;
            this.vbButton5.FlatAppearance.BorderSize = 0;
            this.vbButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton5.ForeColor = System.Drawing.Color.White;
            this.vbButton5.Location = new System.Drawing.Point(991, 214);
            this.vbButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbButton5.Name = "vbButton5";
            this.vbButton5.Size = new System.Drawing.Size(151, 44);
            this.vbButton5.TabIndex = 30;
            this.vbButton5.Text = "Xuất";
            this.vbButton5.TextColor = System.Drawing.Color.White;
            this.vbButton5.UseVisualStyleBackColor = false;
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 671);
            this.Controls.Add(this.pnBET);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.dtGVNH);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.pnBET.ResumeLayout(false);
            this.pnBET.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMNCC;
        private System.Windows.Forms.Label lbMNCC;
        private System.Windows.Forms.Label lbMLH;
        private System.Windows.Forms.Panel pnBET;
        private System.Windows.Forms.ComboBox cbbMLH;
        private System.Windows.Forms.DateTimePicker dtpNN;
        private System.Windows.Forms.ComboBox cbbMSP;
        private System.Windows.Forms.TextBox tbDVT;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.TextBox tbMNH;
        private System.Windows.Forms.Label lbNN;
        private System.Windows.Forms.Label lbDVT;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbMSP;
        private System.Windows.Forms.Label lbMNH;
        private System.Windows.Forms.Label lblNH;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.DataGridView dtGVNH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private CustomButton.VBButton vbButton4;
        private CustomButton.VBButton vbButton1;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton vbButton3;
        private CustomButton.VBButton vbButton5;
    }
}
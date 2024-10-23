namespace KFC
{
    partial class LoaiHangControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaLoaiHang = new System.Windows.Forms.Label();
            this.lblTenLoaiHang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaLoaiHang
            // 
            this.lblMaLoaiHang.AutoSize = true;
            this.lblMaLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoaiHang.Location = new System.Drawing.Point(39, 40);
            this.lblMaLoaiHang.Name = "lblMaLoaiHang";
            this.lblMaLoaiHang.Size = new System.Drawing.Size(114, 20);
            this.lblMaLoaiHang.TabIndex = 3;
            this.lblMaLoaiHang.Text = "Mã Loại Hàng";
            // 
            // lblTenLoaiHang
            // 
            this.lblTenLoaiHang.AutoSize = true;
            this.lblTenLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoaiHang.Location = new System.Drawing.Point(37, 80);
            this.lblTenLoaiHang.Name = "lblTenLoaiHang";
            this.lblTenLoaiHang.Size = new System.Drawing.Size(204, 31);
            this.lblTenLoaiHang.TabIndex = 2;
            this.lblTenLoaiHang.Text = "Tên Loại Hàng";
            // 
            // LoaiHangControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMaLoaiHang);
            this.Controls.Add(this.lblTenLoaiHang);
            this.Name = "LoaiHangControl";
            this.Size = new System.Drawing.Size(359, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaLoaiHang;
        private System.Windows.Forms.Label lblTenLoaiHang;
    }
}

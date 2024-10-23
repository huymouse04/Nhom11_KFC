using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.IO;

namespace KFC
{
    public partial class CapNhatNhanVien : Form
    {
        private NhanVien_DTO nhanVien; // Biến lưu trữ thông tin nhân viên
        private bool isUpdateMode; // Đánh dấu xem là chế độ cập nhật hay thêm mới

        public CapNhatNhanVien()
        {
            InitializeComponent();
            isUpdateMode = false; // Đánh dấu đây là chế độ thêm mới
            txtMaNV.Enabled = true;
        }

        public CapNhatNhanVien(NhanVien_DTO nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
            isUpdateMode = true; // Đánh dấu đây là chế độ cập nhật
            txtMaNV.Enabled = false; // Khóa trường mã nhân viên để không thể thay đổi

            if (nhanVien != null)
            {
                // Kiểm tra giá trị nhân viên
                Console.WriteLine("Thông tin lương nhận được: " + nhanVien.TenNhanVien);

                SetNhanVienData(nhanVien);
            }
            else
            {
                MessageBox.Show("Thông tin lương không hợp lệ.");
            }
        }

        private NhanVien_BUS bus = new NhanVien_BUS();

        // Hàm này để nhận dữ liệu nhân viên từ NhanVienControl  
        private void SetNhanVienData(NhanVien_DTO nhanVien)
        {
            if (nhanVien != null)
            {
                txtTenNV.Text = nhanVien.TenNhanVien;
                cbChucVu.Text = nhanVien.ChucVu;
                txtMaNV.Text = nhanVien.MaNhanVien;
                mtbSDT.Text = nhanVien.SoDienThoai;
                txtEmail.Text = nhanVien.Email;
                txtDiaChi.Text = nhanVien.DiaChi;
                txtSoGioLam.Text = nhanVien.SoGioLam.ToString();
                dtpNgaySinh.Value = nhanVien.NgaySinh ?? DateTime.Now; // Nếu ngày sinh chưa được xác định

                // Kiểm tra và hiển thị ảnh nhân viên nếu có
                if (nhanVien.AnhNhanVien != null && nhanVien.AnhNhanVien.Length > 0)
                {
                    try
                    {
                        // Chuyển đổi byte[] thành Image
                        using (MemoryStream ms = new MemoryStream(nhanVien.AnhNhanVien))
                        {
                            pbAnhNV.Image = Image.FromStream(ms);
                            pbAnhNV.SizeMode = PictureBoxSizeMode.Zoom; // Thay đổi chế độ hiển thị hình ảnh
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể hiển thị ảnh: " + ex.Message);
                        pbAnhNV.Image = Properties.Resources.logo; // Ảnh mặc định khi không thể load ảnh
                        pbAnhNV.SizeMode = PictureBoxSizeMode.Zoom; // Thay đổi chế độ hiển thị hình ảnh
                    }
                }
                else
                {
                    pbAnhNV.Image = Properties.Resources.logo; // Ảnh mặc định khi không có ảnh
                    pbAnhNV.SizeMode = PictureBoxSizeMode.Zoom; // Thay đổi chế độ hiển thị hình ảnh
                }

                // Kiểm tra giới tính
                rdbNam.Checked = nhanVien.GioiTinh == "Nam";
                rdbNu.Checked = nhanVien.GioiTinh == "Nữ";
            }
            else
            {
                MessageBox.Show("Thông tin nhân viên không có sẵn.");
            }
        }



        public byte[] ConvertImageToByteArray(string imagePath)
        {
            using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (var ms = new MemoryStream())
                {
                    fs.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\"; // Thư mục khởi đầu
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp"; // Bộ lọc tệp hình ảnh
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị đường dẫn tệp ảnh trong TextBox  
                    txtPath.Text = openFileDialog.FileName;

                    // Đọc tệp hình ảnh vào byte[]
                    try
                    {
                        byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                        // Lưu trữ ảnh byte[] vào đối tượng nhân viên
                        pbAnhNV.Image = Image.FromFile(openFileDialog.FileName); // Hiển thị ảnh trong PictureBox
                        pbAnhNV.SizeMode = PictureBoxSizeMode.Zoom; // Thay đổi chế độ hiển thị hình ảnh
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
         ClearInputFields();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateMode)
                {
                    // Chế độ cập nhật
                    nhanVien.TenNhanVien = txtTenNV.Text.Trim();
                    nhanVien.GioiTinh = GetSelectedGender(); // Lấy giá trị giới tính từ RadioButton
                    nhanVien.NgaySinh = dtpNgaySinh.Value;
                    nhanVien.SoDienThoai = mtbSDT.Text.Trim();
                    nhanVien.Email = txtEmail.Text.Trim();
                    nhanVien.DiaChi = txtDiaChi.Text.Trim();
                    nhanVien.ChucVu = cbChucVu.Text.Trim();
                    nhanVien.SoGioLam = int.Parse(txtSoGioLam.Text);

                    // Chỉ cập nhật ảnh nếu có ảnh mới được chọn
                    if (pbAnhNV.Image != null)
                    {
                        nhanVien.AnhNhanVien = ConvertImageToByteArray(pbAnhNV.Image);
                    }

                    // Cập nhật thông tin nhân viên
                    bus.UpdateNhanVien(nhanVien);
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                }
                else
                {
                    // Chế độ thêm mới
                    NhanVien_DTO newNhanVien = new NhanVien_DTO
                    {
                        MaNhanVien = txtMaNV.Text.Trim(),
                        TenNhanVien = txtTenNV.Text.Trim(),
                        GioiTinh = GetSelectedGender(),
                        NgaySinh = dtpNgaySinh.Value,
                        SoDienThoai = mtbSDT.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        ChucVu = cbChucVu.Text.Trim(),
                        SoGioLam = int.Parse( txtSoGioLam.Text),
                        AnhNhanVien = ConvertImageToByteArray(pbAnhNV.Image) // Lưu ảnh vào đối tượng nhân 

                    };

                    bus.AddNhanVien(newNhanVien);
                    MessageBox.Show("Thêm nhân viên thành công!");
                    ClearInputFields(); // Làm sạch các trường nhập liệu
                }

                this.Close(); // Đóng form sau khi lưu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Phương thức chuyển đổi hình ảnh sang mảng byte[]
        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Lưu hình ảnh vào MemoryStream
                return ms.ToArray(); // Chuyển đổi thành mảng byte
            }
        }

        // Phương thức làm sạch các trường nhập liệu
        private void ClearInputFields()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            dtpNgaySinh.Value = DateTime.Now; // Đặt lại ngày sinh về ngày hiện tại
            mtbSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            pbAnhNV.Image = null; // Đặt lại hình ảnh
        }

        private string GetSelectedGender()
        {
            if (rdbNam.Checked)
                return "Nam";
            else if (rdbNu.Checked)
                return "Nữ";

            return null; // Hoặc một giá trị mặc định nếu không chọn
        }

    }
}


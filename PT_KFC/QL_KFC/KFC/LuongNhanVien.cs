using BUS;
using DAO;
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

namespace KFC
{
    public partial class LuongNhanVien : Form
    {
        private string maNhanVien;
        private int thang;
        private LuongNhanVien_BUS bus = new LuongNhanVien_BUS();
        private NhanVien_BUS nvbus = new NhanVien_BUS();
        public LuongNhanVien()
        {
            InitializeComponent();
            LoadData(); // Tải dữ liệu khi mở form
        }

        // Hàm tải dữ liệu lương lên DataGridView
        private void LoadData()
        {
            List<LuongNhanVien_DTO> listLuong = bus.LayDanhSachLuong();
            dgvLuongNhanVien.DataSource = listLuong;

            //// Cập nhật định dạng cho các cột Lương  
            //UpdateColumnFormat("LuongCoBan");
            //UpdateColumnFormat("ThuongChuyenCan");
            //UpdateColumnFormat("ThuongHieuSuat");

            // Kiểm tra và thêm cột Tổng Lương nếu không tồn tại  
            if (!dgvLuongNhanVien.Columns.Contains("TongLuong"))
            {
                DataGridViewTextBoxColumn tongLuongColumn = new DataGridViewTextBoxColumn
                {
                    Name = "TongLuong",
                    HeaderText = "Tổng Lương",
                    DataPropertyName = "TongLuong"
                };
                dgvLuongNhanVien.Columns.Add(tongLuongColumn);
            }

            // Cập nhật định dạng cho cột Tổng Lương  
            //dgvLuongNhanVien.Columns["TongLuong"].DefaultCellStyle.Format = "#,0";

            // Refresh lại DataGridView  
            dgvLuongNhanVien.Refresh();
        }

        //// Phương thức tái sử dụng để cập nhật định dạng  
        //private void UpdateColumnFormat(string columnName)
        //{
        //    if (dgvLuongNhanVien.Columns.Contains(columnName))
        //    {
        //        dgvLuongNhanVien.Columns[columnName].DefaultCellStyle.Format = "#,0"; // Định dạng ngăn cách hàng ngàn, không có số thập phân  
        //    }
        //}

        private void LuongNhanVien_Load(object sender, EventArgs e)
        {

        }

        public void CapNhatDanhSachLuong()
        {
          LoadData();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            CapNhatLuong cnl = new CapNhatLuong();
            cnl.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvLuongNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvLuongNhanVien.Rows[e.RowIndex];

                try
                {
                    string maNhanVien = selectedRow.Cells["MaNhanVien"].Value?.ToString();
                    if (string.IsNullOrEmpty(maNhanVien))
                    {
                        MessageBox.Show("Mã nhân viên không hợp lệ.");
                        return;
                    }

                    LuongNhanVien_DTO luongDTO = new LuongNhanVien_DTO
                    {
                        MaNhanVien = maNhanVien,
                        LuongCoBan = int.Parse(selectedRow.Cells["LuongCoBan"].Value.ToString()),
                        Thang = int.Parse(selectedRow.Cells["Thang"].Value.ToString()), // Lấy tháng từ DataGridView
                        SoNgayLam = int.Parse(selectedRow.Cells["SoNgayLam"].Value.ToString()),
                        ThuongChuyenCan = int.Parse(selectedRow.Cells["ThuongChuyenCan"].Value.ToString()),
                        ThuongHieuSuat = int.Parse(selectedRow.Cells["ThuongHieuSuat"].Value.ToString())
                    };

                    // Lấy thông tin nhân viên từ BUS
                    var nhanVien = nvbus.GetNhanVienByMa(maNhanVien);
                    if (nhanVien != null)
                    {
                        luongDTO.TenNhanVien = nhanVien.TenNhanVien; // Thêm tên nhân viên
                        luongDTO.ChucVu = nhanVien.ChucVu; // Thêm chức vụ
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên.");
                        return;
                    }

                    // Mở Form Cập Nhật
                    var capNhatLuongForm = new CapNhatLuong(luongDTO, this);
                    capNhatLuongForm.SalaryUpdated += (s, ev) => this.CapNhatDanhSachLuong(); // Đăng ký sự kiện
                    capNhatLuongForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có một lỗi xảy ra: {ex.Message}\nStack Trace: {ex.StackTrace}");
                }
            }
        }
        private void dgvLuongNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Đọc giá trị từ các ô của hàng đã chọn  
                var maNhanVienValue = dgvLuongNhanVien.Rows[e.RowIndex].Cells["MaNhanVien"].Value;
                var thangValue = dgvLuongNhanVien.Rows[e.RowIndex].Cells["Thang"].Value;

                // Lưu giá trị vào biến  
                maNhanVien = maNhanVienValue != null ? maNhanVienValue.ToString() : string.Empty;
                thang = thangValue != null ? Convert.ToInt32(thangValue) : 0;
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text.Trim();
            if (cbThang.Checked)
            {
                if (int.TryParse(searchTerm, out int month) && month >= 1 && month <= 12)
                {
                    var results = bus.SearchLuongByMonth(month);
                    dgvLuongNhanVien.DataSource = results;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tháng hợp lệ (1-12).");
                }
            }
            else
            {
                List<LuongNhanVien_DTO> results = bus.SearchLuongNhanVien(searchTerm);
                dgvLuongNhanVien.DataSource = results;
            }
        }

        public DataTable ConvertListToDataTable(List<DTO.LuongNhanVien_DTO> list)
        {
            DataTable dataTable = new DataTable(typeof(DTO.LuongNhanVien_DTO).Name);

            // Lấy tất cả các thuộc tính của DTO.NhanVien_DTO
            var properties = typeof(DTO.LuongNhanVien_DTO).GetProperties();

            // Tạo các cột cho DataTable dựa trên các thuộc tính
            foreach (var prop in properties)
            {
                // Kiểm tra nếu thuộc tính là kiểu Nullable, lấy kiểu cơ bản nếu cần
                var propType = prop.PropertyType;
                if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    propType = Nullable.GetUnderlyingType(propType);
                }

                dataTable.Columns.Add(prop.Name, propType);
            }

            // Thêm dữ liệu từ List vào DataTable
            foreach (var item in list)
            {
                var values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    var propValue = properties[i].GetValue(item, null);
                    // Nếu giá trị null, gán DBNull.Value
                    values[i] = propValue ?? DBNull.Value;
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            List<DTO.LuongNhanVien_DTO> ketQuaList;

            // Nếu từ khóa rỗng, lấy tất cả nhân viên
            if (string.IsNullOrEmpty(tuKhoa))
            {
                ketQuaList = bus.LayDanhSachLuong(); // Thay đổi thành phương thức lấy tất cả
            }
            else
            {
                ketQuaList = bus.SearchLuongNhanVien(tuKhoa); // Tìm kiếm theo từ khóa
            }

            // Kiểm tra kết quả
            if (ketQuaList == null || ketQuaList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào với từ khóa đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Chuyển đổi List<DTO.LuongNhanVien_DTO> sang DataTable
            DataTable ketQua = ConvertListToDataTable(ketQuaList);

            // Hiển thị báo cáo
            FormReport formLuong = new FormReport(FormReport.LoaiBaoCao.LuongNhanVien, ketQua);
            formLuong.Show();
        }
    }
}

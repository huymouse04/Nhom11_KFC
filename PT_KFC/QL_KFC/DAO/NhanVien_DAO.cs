    using DTO;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Linq;
    using System.Data.Linq.SqlClient;
    using System.Data.Linq.Mapping;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.Remoting.Contexts;

    namespace DAO
    {
        public class NhanVien_DAO
        {
            private KFCDataContext DB = new KFCDataContext(Connection_DAO.ConnectionString);

            public NhanVien_DAO() { }


            // Phương thức tìm kiếm nhân viên dựa trên tham số nhập vào
            public List<NhanVien_DTO> SearchNhanVien(string searchTerm)
            {
                // Tìm kiếm trong cơ sở dữ liệu
                var query = DB.NhanViens.AsQueryable();

                // Tìm kiếm theo nhiều thuộc tính
                var results = query.Where(nv =>
                    nv.MaNhanVien.Contains(searchTerm) ||
                    nv.TenNhanVien.Contains(searchTerm) ||
                    nv.SoDienThoai.Contains(searchTerm) ||
                    nv.ChucVu.Contains(searchTerm)).ToList();

                // Chuyển đổi danh sách nhân viên từ DAO sang DTO
                List<NhanVien_DTO> nhanVienDtos = results.Select(nv => new NhanVien_DTO
                {
                    MaNhanVien = nv.MaNhanVien,
                    TenNhanVien = nv.TenNhanVien,
                    SoDienThoai = nv.SoDienThoai,
                    ChucVu = nv.ChucVu,
                    GioiTinh = nv.GioiTinh,
                    NgaySinh = nv.NgaySinh,
                    Email = nv.Email,
                    DiaChi = nv.DiaChi,
                    AnhNhanVien = nv.AnhNhanVien != null ? nv.AnhNhanVien.ToArray() : null, // Không sử dụng toán tử ?.
                     SoGioLam = (int)(nv.SoGioLam ?? 0)
                    // Thêm các thuộc tính khác nếu cần thiết
                }).ToList();

                return nhanVienDtos; // Trả về danh sách DTO
            }

            public NhanVien GetNhanVienByMa(string maNhanVien)
            {
                // Trả về nhân viên từ cơ sở dữ liệu theo mã nhân viên
                return DB.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
            }

            public bool IsMaNhanVienExists(string maNhanVien)
            {
                return DB.NhanViens.Any(nv => nv.MaNhanVien == maNhanVien);
            }

            public void AddNhanVien(NhanVien_DTO nhanVien)
            {
                if (IsMaNhanVienExists(nhanVien.MaNhanVien))
                {
                    throw new Exception("Mã nhân viên đã tồn tại!");
                }

                // Sử dụng trực tiếp byte[] từ DTO
                var newNhanVien = new NhanVien
                {
                    MaNhanVien = nhanVien.MaNhanVien,
                    AnhNhanVien = nhanVien.AnhNhanVien != null ? new Binary(nhanVien.AnhNhanVien) : null, // Gán giá trị cho thuộc tính Binary
                    TenNhanVien = nhanVien.TenNhanVien,
                    GioiTinh = nhanVien.GioiTinh,
                    NgaySinh = nhanVien.NgaySinh,
                    SoDienThoai = nhanVien.SoDienThoai,
                    Email = nhanVien.Email,
                    DiaChi = nhanVien.DiaChi,
                    ChucVu = nhanVien.ChucVu,
                    SoGioLam = nhanVien.SoGioLam
                };

                DB.NhanViens.InsertOnSubmit(newNhanVien);
                DB.SubmitChanges();
            }

            public List<NhanVien_DTO> GetAllNhanVien()
            {
                var nhanViens = from nv in DB.NhanViens
                                select new NhanVien_DTO
                                {
                                    MaNhanVien = nv.MaNhanVien,
                                    AnhNhanVien = nv.AnhNhanVien != null ? nv.AnhNhanVien.ToArray() : null, // Lưu trữ byte[] trực tiếp
                                    TenNhanVien = nv.TenNhanVien,
                                    GioiTinh = nv.GioiTinh,
                                    NgaySinh = nv.NgaySinh.HasValue && nv.NgaySinh.Value >= new DateTime(1753, 1, 1) ? nv.NgaySinh.Value : (DateTime?)null,
                                    SoDienThoai = nv.SoDienThoai,
                                    Email = nv.Email,
                                    DiaChi = nv.DiaChi,
                                    ChucVu = nv.ChucVu,
                                    SoGioLam = (int)(nv.SoGioLam ?? 0)
                                };

                return nhanViens.ToList();
            }

            public void UpdateNhanVien(NhanVien_DTO nhanVien)
            {
                if (nhanVien == null)
                {
                    throw new ArgumentNullException(nameof(nhanVien), "Nhân viên không được null");
                }

                var existingNhanVien = DB.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == nhanVien.MaNhanVien);
                if (existingNhanVien != null)
                {
                    // Sử dụng byte[] từ DTO
                    existingNhanVien.AnhNhanVien = nhanVien.AnhNhanVien != null ? new Binary(nhanVien.AnhNhanVien) : null; // Gán giá trị cho thuộc tính Binary

                    existingNhanVien.TenNhanVien = nhanVien.TenNhanVien;
                    existingNhanVien.GioiTinh = nhanVien.GioiTinh;
                    existingNhanVien.NgaySinh = nhanVien.NgaySinh;
                    existingNhanVien.SoDienThoai = nhanVien.SoDienThoai;
                    existingNhanVien.Email = nhanVien.Email;
                    existingNhanVien.DiaChi = nhanVien.DiaChi;
                    existingNhanVien.ChucVu = nhanVien.ChucVu;
                    existingNhanVien.SoGioLam = nhanVien.SoGioLam;

                    DB.SubmitChanges();
                }
            }

            public void DeleteNhanVien(string maNhanVien)
            {
                var existingNhanVien = DB.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
                if (existingNhanVien != null)
                {
                    DB.NhanViens.DeleteOnSubmit(existingNhanVien);
                    DB.SubmitChanges();
                }
            }

        }
    }


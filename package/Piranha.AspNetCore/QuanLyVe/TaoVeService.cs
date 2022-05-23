using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Piranha.QuanLyVeInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFCity.Data.EF;
using static Piranha.AspNetCore.WfcEntity.WfcEntity;
using Piranha.AspNetCore.SCHelpers;

namespace Piranha.AspNetCore.QuanLyVe
{
    public class TaoVeService : IQuanLyVeService
    {
        private readonly dbContext _context;

        private readonly ILogger<TaoVeService> _logger;
        public TaoVeService(dbContext context, ILogger<TaoVeService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool TaoVe(int? SoLuongVe, int? LoaiVe)
        {
            try
            {
                var listInsertVe = new List<InsertVe>();
                if (SoLuongVe >= 100 && SoLuongVe <= 10000 && LoaiVe != null)
                {
                    var veCuoiCung = _context.ThongTinVes.OrderByDescending(m => m.ThuTuVe).Select(m => m.ThuTuVe).FirstOrDefault();
                    if (veCuoiCung == null)
                    {
                        var veCuoi = 9998;
                        for (int i = 0; i < SoLuongVe; i++)
                        {
                            veCuoi++;
                            var data = new InsertVe();
                            data.MaVe = "WFC" + veCuoi;
                            data.ThuTuVe = veCuoi;
                            listInsertVe.Add(data);
                        }
                    }
                    else
                    {
                        int veCuoi = veCuoiCung ?? default(int);

                        for (int i = 0; i < SoLuongVe; i++)
                        {
                            veCuoi++;
                            var data = new InsertVe();
                            data.MaVe = "WFC" + veCuoi;
                            data.ThuTuVe = veCuoi;
                            listInsertVe.Add(data);
                        }
                    }
                }
                var rs = new DataTable();
                DataColumn col = null;
                col = new DataColumn("MaVe");//0
                rs.Columns.Add(col);
                col = new DataColumn("ThuTuVe");//1
                rs.Columns.Add(col);
                //rs.Columns.Add("Item", typeof(InsertVe));
                if (listInsertVe != null)
                {
                    foreach (var item in listInsertVe)
                    {
                        var newRow = rs.NewRow();
                        newRow[0] = item.MaVe;
                        newRow[1] = item.ThuTuVe;
                        rs.Rows.Add(newRow);
                    }
                }
                var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@ThemVe2",
                            SqlDbType = SqlDbType.Structured,
                            Value = rs
                        },
                        new SqlParameter() {
                            ParameterName = "@LoaiVe",
                            SqlDbType = SqlDbType.Int,
                            Value = LoaiVe
                        }};
                using (var cnn = _context.Database.GetDbConnection())
                {
                    var cmm = cnn.CreateCommand();
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.CommandText = "[dbo].[ThemVe]";
                    cmm.Parameters.AddRange(param);
                    cmm.Connection = cnn;
                    cnn.Open();
                    var reader = cmm.ExecuteReader();
                }

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }


        }

        public List<DanhSachVe> DanhSachVe(string MaVe, int? LoaiVeId, DateTime? NgayTaoVe, DateTime? NgayBanVe, int? TrangThai)
        {
            var list = new List<DanhSachVe>();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@MaVe",
                            SqlDbType = SqlDbType.NVarChar,
                            Value = MaVe ==null? "null" : MaVe
                        },
                        new SqlParameter() {
                            ParameterName = "@LoaiVeId",
                            SqlDbType = SqlDbType.Int,
                            Value = LoaiVeId == null? -1 : LoaiVeId
                        },
                        new SqlParameter() {
                            ParameterName = "@NgayTaoVe",
                            SqlDbType = SqlDbType.Date,
                            Value = NgayTaoVe == null? "1/1/1900 12:00:00 AM" : NgayTaoVe
                        },
                        new SqlParameter() {
                            ParameterName = "@NgayBanVe",
                            SqlDbType = SqlDbType.Date,
                            Value = NgayBanVe == null? "1/1/1900 12:00:00 AM" : NgayBanVe
                        },
                        new SqlParameter() {
                            ParameterName = "@TrangThai",
                            SqlDbType = SqlDbType.Int,
                            Value = TrangThai ==null ? -1 : TrangThai
                        }
            };
            using (var cnn = _context.Database.GetDbConnection())
            {
                var cmm = cnn.CreateCommand();
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.CommandText = "[dbo].[DanhSachVe]";
                cmm.Parameters.AddRange(param);
                cmm.Connection = cnn;
                cnn.Open();
                var reader = cmm.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(
                        new DanhSachVe
                        {
                            ThongTinVeId = Convert.ToInt32(reader["ThongTinVeId"] + ""),
                            MaVe = reader["MaVe"].ToString(),
                            TenVe = reader["TenVe"].ToString(),
                            NgayTaoVe = !String.IsNullOrEmpty(reader["NgayTaoVe"] + "") ? Convert.ToDateTime(reader["NgayTaoVe"]).ToString("dd/MM/yyyy") : null,
                            NgayBanVe = !String.IsNullOrEmpty(reader["NgayBanVe"] + "") ? Convert.ToDateTime(reader["NgayBanVe"]).ToString("dd/MM/yyyy") : null,
                            TrangThai = Convert.ToInt32(reader["TrangThai"].ToString()),
                            KhachHangId = !String.IsNullOrEmpty(reader["KhachHangId"] + "") ? Convert.ToInt32(reader["KhachHangId"].ToString()) : null,
                            TenKhachHang = reader["HoTen"] + ""
                        });
                }
                return list;
            }

        }

        public List<DanhSachKhachHang> DanhSachKhachHang(string SoDienThoai, string HoTen, string Email)
        {
            var list = new List<DanhSachKhachHang>();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@SoDienThoai",
                            SqlDbType = SqlDbType.NVarChar,
                            Value = SoDienThoai ==null? "null" : SoDienThoai
                        },
                        new SqlParameter() {
                            ParameterName = "@HoTen",
                            SqlDbType = SqlDbType.NVarChar,
                            Value = HoTen == null?  "null" : HoTen
                        },
                         new SqlParameter() {
                            ParameterName = "@Email",
                            SqlDbType = SqlDbType.NVarChar,
                            Value = Email == null?  "null" : Email
                        },
            };
            using (var cnn = _context.Database.GetDbConnection())
            {
                var cmm = cnn.CreateCommand();
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.CommandText = "[dbo].[sp_Customer]";
                cmm.Parameters.AddRange(param);
                cmm.Connection = cnn;
                cnn.Open();
                var reader = cmm.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(
                        new DanhSachKhachHang
                        {
                            KhachHangId = Convert.ToInt32(reader["KhachHangId"].ToString()),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            Email = reader["Email"].ToString(),
                            LanMuaCuoi = !String.IsNullOrEmpty(reader["LanMuaCuoi"] + "") ? Convert.ToDateTime(reader["LanMuaCuoi"]).ToString("dd/MM/yyyy") : null,
                        });
                }
                return list;
            }
        }

        public List<KhachHangDatHang> KhachHangDatHang(int? KhachHangId)
        {
            var list = new List<KhachHangDatHang>();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@KhachHangId",
                            SqlDbType = SqlDbType.Int,
                            Value = KhachHangId ==null?  -1 : KhachHangId
                        }
            };
            using (var cnn = _context.Database.GetDbConnection())
            {
                var cmm = cnn.CreateCommand();
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.CommandText = "[dbo].[sp_CustomerOrder]";
                cmm.Parameters.AddRange(param);
                cmm.Connection = cnn;
                cnn.Open();
                var reader = cmm.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(
                        new KhachHangDatHang
                        {
                            OrderId = Convert.ToInt32(reader["OrderId"].ToString()),
                            NgayDatVe = !String.IsNullOrEmpty(reader["NgayDatVe"] + "") ? Convert.ToDateTime(reader["NgayDatVe"]).ToString("dd/MM/yyyy") : null,
                            TongTien = reader["TongTien"].ToString(),
                            NguoiDiKem = reader["NguoiDiKem"].ToString(),
                            GhiChu = reader["GhiChu"].ToString(),
                            MaDonHang = reader["MaDonHang"].ToString(),
                            SoLuongVe = reader["SoLuongVe"].ToString(),
                            TenMaGiamGia = reader["TenMaGiamGia"].ToString(),
                        });
                }
                return list;
            }
        }

        public List<ChiTietDonHang> ChiTietDonHang(int? OrderId)
        {
            var list = new List<ChiTietDonHang>();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@OrderId",
                            SqlDbType = SqlDbType.Int,
                            Value = OrderId ==null? -1 : OrderId
                        }
            };
            using (var cnn = _context.Database.GetDbConnection())
            {
                var cmm = cnn.CreateCommand();
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.CommandText = "[dbo].[sp_OrderDetail]";
                cmm.Parameters.AddRange(param);
                cmm.Connection = cnn;
                cnn.Open();
                var reader = cmm.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(
                        new ChiTietDonHang
                        {
                            OrderId = Convert.ToInt32(reader["OrderId"].ToString()),
                            ThongTinVeId = Convert.ToInt32(reader["ThongTinVeId"].ToString()),
                            OrderItemId = Convert.ToInt32(reader["OrderItemId"].ToString()),
                            MaVe = reader["MaVe"].ToString(),
                            TenVe = reader["TenVe"].ToString(),
                            GiaVe = reader["GiaVe"].ToString(),
                        });
                }
                return list;
            }
        }

        public List<QuanLyDonHang> QuanLyDonHang(string MaDonHang, string SoDienThoai, string HoTen, string Email)
        {

            var list = new List<QuanLyDonHang>();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@MaDonHang",
                            SqlDbType = SqlDbType.NVarChar,
                            Value = MaDonHang ==null? "null" : MaDonHang
                        },
                         new SqlParameter() {
                            ParameterName = "@SoDienThoai",
                            SqlDbType = SqlDbType.NVarChar,
                            Value = SoDienThoai ==null? "null" : SoDienThoai
                        },
                         new SqlParameter() {
                            ParameterName = "@HoTen",
                            SqlDbType = SqlDbType.NVarChar,
                            Value = HoTen ==null? "null" : HoTen
                        },
                         new SqlParameter() {
                            ParameterName = "@Email",
                            SqlDbType = SqlDbType.NVarChar,
                            Value = Email ==null? "null" : Email
                        }
            };
            using (var cnn = _context.Database.GetDbConnection())
            {
                var cmm = cnn.CreateCommand();
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.CommandText = "[dbo].[sp_ManageOrder]";
                cmm.Parameters.AddRange(param);
                cmm.Connection = cnn;
                cnn.Open();
                var reader = cmm.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(
                        new QuanLyDonHang
                        {
                            OrderId = Convert.ToInt32(reader["OrderId"].ToString()),
                            NgayDatVe = !String.IsNullOrEmpty(reader["NgayDatVe"] + "") ? Convert.ToDateTime(reader["NgayDatVe"]).ToString("dd/MM/yyyy") : null,
                            TongTien = reader["TongTien"].ToString(),
                            NguoiDiKem = reader["NguoiDiKem"].ToString(),
                            GhiChu = reader["GhiChu"].ToString(),
                            MaDonHang = reader["MaDonHang"].ToString(),
                            SoLuongVe = reader["SoLuongVe"].ToString(),
                            TenMaGiamGia = reader["TenMaGiamGia"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            Email = reader["Email"].ToString(),
                        });
                }
                return list;
            }
        }

        public List<MaGiamGia> QuanLyMaGiamGia(string TenMaGiamGia, int? TrangThai)
        {
            var list = new List<MaGiamGia>();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@TenMaGiamGia",
                            SqlDbType = SqlDbType.NVarChar,
                            Value = TenMaGiamGia ==null? "null" : TenMaGiamGia
                        },
                         new SqlParameter() {
                            ParameterName = "@TrangThai",
                            SqlDbType = SqlDbType.NVarChar,
                            Value = TrangThai ==null? -1 : TrangThai
                        }
            };
            using (var cnn = _context.Database.GetDbConnection())
            {
                var cmm = cnn.CreateCommand();
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.CommandText = "[dbo].[sp_QuanLyMaGiamGia]";
                cmm.Parameters.AddRange(param);
                cmm.Connection = cnn;
                cnn.Open();
                var reader = cmm.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(
                        new MaGiamGia
                        {
                            MaGiamGiaId = Convert.ToInt32(reader["OrderId"].ToString()),
                            TenMaGiamGia = reader["TenMaGiamGia"].ToString(),
                            NgayBatDau = !String.IsNullOrEmpty(reader["NgayBatDau"] + "") ? Convert.ToDateTime(reader["NgayBatDau"]).ToString("dd/MM/yyyy") : null,
                            NgayKetThuc = !String.IsNullOrEmpty(reader["NgayKetThuc"] + "") ? Convert.ToDateTime(reader["NgayKetThuc"]).ToString("dd/MM/yyyy") : null,
                            TyLe = !String.IsNullOrEmpty(reader["TyLe"] + "") ? Convert.ToInt32(reader["TyLe"].ToString()) : null,                        
                            SoTien = reader["SoTien"].ToString(),
                            TrangThai = !String.IsNullOrEmpty(reader["TrangThai"] + "") ? Convert.ToInt32(reader["TrangThai"].ToString()) : null                                              
                        });
                }
                return list;
            }
        }

        public List<XuatEx> QuanLyMaGiamGia()
        {
            var list = new List<XuatEx>();
            using (var cnn = _context.Database.GetDbConnection())
            {
                var cmm = cnn.CreateCommand();
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.CommandText = "[dbo].[sp_XuatExcelVe]";
                cmm.Connection = cnn;
                cnn.Open();
                var reader = cmm.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(
                        new XuatEx
                        {
                            MaVe = reader["MaVe"].ToString()
                        });
                }
                return list;
            }
        }
    }
}

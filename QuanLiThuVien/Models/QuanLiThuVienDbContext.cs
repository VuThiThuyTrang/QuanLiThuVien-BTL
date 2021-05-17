using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLiThuVien.Models
{
    public partial class QuanLiThuVienDbContext : DbContext
    {
        public QuanLiThuVienDbContext()
            : base("name=QuanLiThuVienDbContext")
        {
        }
        public virtual DbSet<BangThuThu> BangThuThus { get; set; }
        public virtual DbSet<DangKyCaBiet> DangKyCaBiets { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<KhoSach> KhoSachs { get; set; }
        public virtual DbSet<MuonTra> MuonTras { get; set; }
        public virtual DbSet<NhaXB> NhaXBs { get; set; }
        public virtual DbSet<Sach> Sachs { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

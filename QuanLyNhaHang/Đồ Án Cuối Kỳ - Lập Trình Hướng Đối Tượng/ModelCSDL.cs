using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng
{
    public partial class ModelCSDL : DbContext
    {
        public ModelCSDL()
            : base("name=ModelCSDL")
        {
        }

        public virtual DbSet<BanAn> BanAn { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual DbSet<DanhSachMonAn> DanhSachMonAn { get; set; }
        public virtual DbSet<MonAn> MonAn { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhieuTamTinhHoaDon> PhieuTamTinhHoaDon { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BanAn>()
                .HasMany(e => e.PhieuTamTinhHoaDon)
                .WithRequired(e => e.BanAn)
                .HasForeignKey(e => e.idBanAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanhSachMonAn>()
                .HasMany(e => e.MonAn)
                .WithRequired(e => e.DanhSachMonAn)
                .HasForeignKey(e => e.idDSMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.ChiTietHoaDon)
                .WithRequired(e => e.MonAn)
                .HasForeignKey(e => e.idMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.tennhanvien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.TaiKhoan)
                .WithRequired(e => e.NhanVien)
                .HasForeignKey(e => e.UserName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuTamTinhHoaDon>()
                .HasMany(e => e.ChiTietHoaDon)
                .WithRequired(e => e.PhieuTamTinhHoaDon)
                .HasForeignKey(e => e.idBill)
                .WillCascadeOnDelete(false);
        }
    }
}

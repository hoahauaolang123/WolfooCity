using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFCity.Data.Configuration;
using WFCity.Data.Entities;

namespace WFCity.Data.EF
{
    public class dbContext : DbContext  
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options) { 
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ThongTiVeConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiVeConfiguration());
            modelBuilder.ApplyConfiguration(new MaGiamGiaConfiguration());

            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());


            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<ThongTinVe> ThongTinVes { get; set; }
        public DbSet<LoaiVe> LoaiVes { get; set; }
        public DbSet<MaGiamGia> MaGiamGias { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}

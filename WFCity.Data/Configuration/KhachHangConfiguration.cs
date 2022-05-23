using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFCity.Data.Entities;

namespace WFCity.Data.Configuration
{
    public class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHangs");
            builder.HasKey(x => x.KhachHangId);
            builder.Property(x => x.HoTen).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(150);
            builder.Property(x => x.SoDienThoai).HasMaxLength(50);

        }
    }
}

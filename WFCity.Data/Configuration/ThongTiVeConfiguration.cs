
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFCity.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WFCity.Data
{
    public class ThongTiVeConfiguration : IEntityTypeConfiguration<ThongTinVe>
    {
        public void Configure(EntityTypeBuilder<ThongTinVe> builder)
        {
            builder.ToTable("ThongTinVes"); 
            builder.HasKey(x => x.ThongTinVeId);
            builder.Property(x => x.MaVe).IsUnicode(false).HasMaxLength(50);


            //builder.Property(x => x.Email).IsUnicode(false).HasMaxLength(50);
            //builder.Property(x => x.HoTen).IsUnicode(true).HasMaxLength(150);
            //builder.HasOne(x => x.LoaiVe).WithMany(x => x.ThongTinVes).HasForeignKey(x => x.LoaiVeId);
            //builder.HasOne(x => x.MaGiamGia).WithMany(x => x.ThongTinVes).HasForeignKey(x => x.MaGiamGiaId);
        }
    }
}

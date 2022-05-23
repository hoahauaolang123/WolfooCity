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
    public class MaGiamGiaConfiguration : IEntityTypeConfiguration<MaGiamGia>
    {
        public void Configure(EntityTypeBuilder<MaGiamGia> builder)
        {
            builder.ToTable("MaGiamGias"); 
            builder.HasKey(x => x.MaGiamGiaId); 
            builder.Property(x => x.TenMaGiamGia).IsRequired().HasMaxLength(50);
            builder.Property(x => x.SoLuongSuDung).IsRequired().HasDefaultValue(0);
        }
    }
}



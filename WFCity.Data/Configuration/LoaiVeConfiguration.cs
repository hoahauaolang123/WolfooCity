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
    public class LoaiVeConfiguration : IEntityTypeConfiguration<LoaiVe>
    {
        public void Configure(EntityTypeBuilder<LoaiVe> builder)
        {
            builder.ToTable("LoaiVes"); // tên bảng trong sql
            builder.HasKey(x => x.LoaiVeId); // khóa chính
            builder.Property(x=> x.GiaVe).IsRequired();            
            builder.Property(x=> x.TenVe).HasMaxLength(50).IsUnicode(true);            

        }
    }
}


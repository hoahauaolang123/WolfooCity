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
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs"); // tên bảng trong sql
            builder.HasKey(x => x.Key); // khóa chính
            builder.Property(x => x.Value).IsRequired(true); // bắt buộc nhập
        }
    }
}

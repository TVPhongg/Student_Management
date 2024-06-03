using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Student_Management.Data.Entities;

namespace Student_Management.Data.Configuration
{
    /// <summary>
    /// cấu hình bảng Class
    /// </summary>
    public class ClassConfig : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Class");
            builder.HasKey(x => x.ClassId);
            builder.Property(x => x.ClassName).HasMaxLength(50).IsRequired();
        }
    }
}

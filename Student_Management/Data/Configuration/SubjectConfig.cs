using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Student_Management.Data.Entities;

namespace Student_Management.Data.Configuration
{
    /// <summary>
    /// cấu hình bảng Subject
    /// </summary>
    public class SubjectConfig : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subject");
            builder.HasKey(x => x.SubjectId);
            builder.Property(x => x.SubjectName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Hour).IsRequired();
        }
    }
}

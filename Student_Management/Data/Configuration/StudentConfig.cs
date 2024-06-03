using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Student_Management.Data.Entities;

namespace Student_Management.Data.Configuration
{
    /// <summary>
    /// cấu hình bảng Student
    /// </summary>
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(std => std.StudentId);
            builder.Property(std => std.StudentName).HasMaxLength(50).IsRequired();
            builder.Property(std => std.Sex).HasMaxLength(10);
            builder.Property(std => std.DoB).HasMaxLength(50);

            builder.HasOne<Class>(x => x.Class).WithMany(x => x.Students).HasForeignKey(x => x.ClassId)
                .IsRequired(true).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

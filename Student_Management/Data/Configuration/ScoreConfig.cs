using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Student_Management.Data.Entities;

namespace Student_Management.Data.Configuration
{
    /// <summary>
    /// cấu hình bảng Score
    /// </summary>
    public class ScoreConfig : IEntityTypeConfiguration<Score>
    {
        public void Configure(EntityTypeBuilder<Score> builder)
        {
            builder.ToTable("Ccore");
            builder.HasKey(x => new { x.StudentId, x.SubjectId });
            builder.Property(x => x.ExamTimes).IsRequired();
            builder.Property(x => x.TestScore).IsRequired();

            builder.HasOne<Subject>(x => x.Subject).WithMany(x => x.Scores).HasForeignKey(x => x.SubjectId)
                .IsRequired(true).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Student>(x => x.Student).WithMany(x => x.Scores).HasForeignKey(x => x.StudentId)
                .IsRequired(true).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

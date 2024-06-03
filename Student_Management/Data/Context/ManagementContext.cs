using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Student_Management.Data.Configuration;
using Student_Management.Data.Entities;

namespace Student_Management.Data.Context
{
    /// <summary>
    /// IdentityDBContext: trung gian giữa CSDL và Code -> query, add, insert,.. 
    /// làm việc với user và xác thực 
    /// </summary>
    public class ManagementContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public ManagementContext(DbContextOptions<ManagementContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClassConfig());
            modelBuilder.ApplyConfiguration(new ScoreConfig());
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new SubjectConfig());   
            modelBuilder.ApplyConfiguration(new AppUserConfig());
            modelBuilder.ApplyConfiguration(new AppRoleConfig());

            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogin");
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

        }


        /// <summary>
        /// DbSet: thể hiện của các bảng trong CSDL -> giúp truy xuất dữ liệu từ CSDL
        /// </summary>
        public DbSet<Class> Classes { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}

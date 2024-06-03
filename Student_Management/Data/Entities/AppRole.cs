using Microsoft.AspNetCore.Identity;

namespace Student_Management.Data.Entities
{
    /// <summary>
    /// Thông tin cơ bản quyền của người dùng
    /// </summary>
    public class AppRole : IdentityRole<Guid>
    {
        /// <summary>
        /// Mô tả
        /// </summary>
        public string Descrip { get; set; }
    }
}

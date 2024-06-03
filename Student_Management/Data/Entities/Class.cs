namespace Student_Management.Data.Entities
{
    /// <summary>
    /// bảng lớp
    /// </summary>
    public class Class
    {
        /// <summary>
        /// Id lớp
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// tên lớp
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// mã khoa
        /// </summary>


        /// <summary>
        /// điều hướng tập hợp đến bảng sinh viên
        /// </summary>
        public virtual ICollection<Student> Students { get; set; }
    }
}

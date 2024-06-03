namespace Student_Management.DTOs.StudentDTOs
{
    /// <summary>
    /// bảng student dto
    /// </summary>
    public class StudentDTO
    {
        /// <summary>
        /// id sinh viên
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// tên sinh viên
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// giới tính
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// ngày sinh
        /// </summary>
        public DateTime DoB { get; set; }

        /// <summary>
        /// mã lớp
        /// </summary>
        public int ClassId { get; set; }
    }
}

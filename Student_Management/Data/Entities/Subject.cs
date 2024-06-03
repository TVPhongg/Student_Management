namespace Student_Management.Data.Entities
{
    /// <summary>
    /// bảng môn học
    /// </summary>
    public class Subject
    {

        /// <summary>
        /// mã môn học
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// tên môn học
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// số giờ/ số tiết
        /// </summary>
        public int Hour { get; set; }


        /// <summary>
        /// điều hướng tập hợp đến bảng điểm
        /// </summary>
        public virtual ICollection<Score> Scores { get; set; }

    }
}

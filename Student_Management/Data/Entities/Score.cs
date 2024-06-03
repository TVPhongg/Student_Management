namespace Student_Management.Data.Entities
{
    /// <summary>
    /// bảng điểm
    /// </summary>
    public class Score
    {
        /// <summary>
        /// id sinh viên
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// id môn học
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// số lần thi
        /// </summary>
        public int ExamTimes { get; set; }

        /// <summary>
        /// điểm thi
        /// </summary>
        public double TestScore { get; set; }

        /// <summary>
        /// điều hướng tham chiếu đến bảng môn học 
        /// </summary>
        public virtual Subject Subject { get; set; }

        /// <summary>
        /// điều hướng tham chiếu đến bảng sinh viên
        /// </summary>
        public virtual Student Student { get; set; }


    }
}

using System.Security.Claims;

namespace Student_Management.Data.Entities
{
    /// <summary>
    /// bảng sinh viên
    /// </summary>
    public class Student
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

        /// <summary>
        /// điều hướng tập hợp đến bảng điểm
        /// </summary>
        public virtual ICollection<Score> Scores { get; set; }

        /// <summary>
        /// điều hướng tập hợp đến bảng lớp học
        /// </summary>
        public virtual Class Class { get; set; }

        /*
          ICollection(thao tác crud)
          IEnumerable(chỉ duyệt ptu) 
          IList(truy cập theo chỉ số) 
          IDictionary(cặp khóa-giá trị)
          ISet, List, Dictionary, Stack. 
        */
    }
}

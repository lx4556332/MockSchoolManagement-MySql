namespace MockSchoolManagement.ViewModels.Teachers
{
    public class AssignedCourseViewModel
    {
        /// <summary>
        /// 课程ID
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 是否被选择
        /// </summary>
        public bool IsSelected { get; set; }
    }

    /// <summary>
    /// 班级信息
    /// </summary>
    public class AssignedDepartmentViewModel
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 是否被选择
        /// </summary>
        public bool IsSelected { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MockSchoolManagement.Models
{
    /// <summary>
    /// 教师信息
    /// </summary>
    public class Teacher : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "聘用时间")]
        public DateTime HireDate { get; set; }


        /// <summary>
        /// 教师编号
        /// </summary>
        public string TeacherCode { get; set; }

        /// <summary>
        /// 教师姓名
        /// </summary>
        public string TeacherName { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 教师联系方式
        /// </summary>
        public string TeacherPhone { get; set; }

        /// <summary>
        /// 办公室地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 教授课程名称
        /// </summary>
        public string TeachCourseName { get; set; }

        /// <summary>
        /// 教授班级
        /// </summary>
        public string TeachClass { get; set; }



        public virtual ICollection<CourseAssignment> CourseAssignments { get; set; }

        public virtual OfficeLocation OfficeLocation { get; set; }
    }
}
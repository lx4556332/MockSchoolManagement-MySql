using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MockSchoolManagement.Models
{
    /// <summary>
    /// 系部
    /// </summary>
    public class Department
    {
        public int DepartmentID { get; set; }
        [Display(Name = "院系名称")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        /// <summary>
        /// 班级编号
        /// </summary>
        public string ClassCode { get; set; }


        /// <summary>
        /// 预算
        /// </summary>
        [DataType(DataType.Currency)]
        [Display(Name = "预算")]

        public decimal Budget { get; set; }

        /// <summary>
        /// 成立时间
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "成立时间")]
        public DateTime StartDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        [Display(Name = "负责人")]

        public int? TeacherID { get; set; }
        /// <summary>
        /// 系部主任
        /// </summary
        public virtual Teacher Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }


        /// <summary>
        /// 班主任名称
        /// </summary>
        public string HeadTeacherName { get; set; }


        /// <summary>
        /// 班主任联系方式
        /// </summary>
        public string HeadTeacherPhone { get; set; }


        /// <summary>
        /// 班级日常评分
        /// </summary>
        public float ClassScore { get; set; }
    }
}
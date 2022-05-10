using Microsoft.AspNetCore.Mvc.Rendering;
using MockSchoolManagement.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MockSchoolManagement.ViewModels.Departments
{
    public class DepartmentCreateViewModel
    {
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "班级名称")]
        public string Name { get; set; }

        /// <summary>
        /// 班级编号
        /// </summary>
        [DataType(DataType.Currency)]
        [Display(Name = "班级编号")]
        public string ClassCode { get; set; }


        [Timestamp]
        public byte[] RowVersion { get; set; }

        [Display(Name = "班主任")]
        public SelectList TeacherList { get; set; }


        public int? TeacherID { get; set; }

        /// <summary>
        /// 班主任
        /// </summary>
        public Teacher Administrator { get; set; }


        /// <summary>
        /// 日常评分
        /// </summary>
        [Display(Name = "日常评分")]
        public float? ClassScore { get; set; }
    }
}
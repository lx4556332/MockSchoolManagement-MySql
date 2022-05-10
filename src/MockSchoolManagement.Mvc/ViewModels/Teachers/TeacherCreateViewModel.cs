using MockSchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MockSchoolManagement.ViewModels.Teachers
{
    public class TeacherCreateViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "姓名")]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 教师编号
        /// </summary>
        [Required]
        [Display(Name = "教师编号")]
        public string UserCode { get; set; }


        [Display(Name = "性别")]
        [Required(ErrorMessage = "请输入性别,它不能为空")]
        public string UserSex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [Display(Name = "年龄")]
        [Required(ErrorMessage = "请输入年龄,它不能为空")]
        public int Age { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        [Display(Name = "职称")]
        [Required(ErrorMessage = "请输入职称,它不能为空")]
        public string Title { get; set; }

        /// <summary>
        /// 教师联系方式
        /// </summary>
        [Display(Name = "教师联系方式")]
        public string TeacherPhone { get; set; }

        /// <summary>
        /// 办公室地址
        /// </summary>
        [Display(Name = "办公室地址")]
        public string Address { get; set; }


        /// <summary>
        /// 教授课程名称
        /// </summary>
        
        [Display(Name = "教授课程名称")]
        public string TeachCourseName { get; set; }

        /// <summary>
        /// 教授班级
        /// </summary>
        [Display(Name = "教授班级名称")]
        public string TeachClass { get; set; }



        [Display(Name = "聘用时间")]
        public DateTime? HireDate { get; set; }
    }
}
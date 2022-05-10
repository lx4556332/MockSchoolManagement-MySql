using Microsoft.AspNetCore.Http;
using MockSchoolManagement.Models.EnumTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.ViewModels
{
    public class StudentCreateViewModel
    {
        [Display(Name = "学生编号")]
        [Required(ErrorMessage = "请输入学生编号,它不能为空")]
        public string UserCode { get; set; }


        [Display(Name = "姓名")]
        [Required(ErrorMessage = "请输入姓名,它不能为空")]
        public string Name { get; set; }

        [Display(Name = "性别")]
        [Required(ErrorMessage = "请输入性别,它不能为空")]
        public string UserSex { get; set; }


        [Display(Name = "所属班级")]
        [Required(ErrorMessage = "请所属班级,它不能为空")]
        public string DepartmentName{ get; set; }
        
        /// <summary>
        /// 年龄
        /// </summary>
        [Display(Name = "年龄")]
        [Required(ErrorMessage = "请输入年龄,它不能为空")]
        public int Age { get; set; }

        /// <summary>
        /// 家长姓名
        /// </summary>
        [Display(Name = "家长姓名")]
        public string ParentName { get; set; }

        /// <summary>
        /// 家长联系方式
        /// </summary>
        [Display(Name = "家长联系方式")]
        [RegularExpression(@"^[1]+[3,4,5,8]+\d{9}",ErrorMessage ="手机号码号码格式不正确")]
        public string ParentPhoneNo { get; set; }

        /// <summary>
        /// 语文成绩
        /// </summary>
        [Display(Name = "语文成绩")]
        public float ChineseScore { get; set; }

        /// <summary>
        /// 数学成绩
        /// </summary>
        [Display(Name = "数学成绩")]
        public float MathScore { get; set; }

        /// <summary>
        /// 英语成绩
        /// </summary>
        [Display(Name = "英语成绩")]
        public float EnglishScore { get; set; }
        /// <summary>
        /// 主修科目
        /// </summary>
        [Display(Name = "主修科目")]
        public MajorEnum? Major { get; set; }

        [Display(Name = "电子邮件")]
        public string Email { get; set; }

        [Display(Name = "头像")]     
        public List<IFormFile> Photos { get; set; }

        /// <summary>
        /// 入学时间
        /// </summary>
        [Display(Name = "入学时间")]
        public DateTime? EnrollmentDate { get; set; }

    }
}

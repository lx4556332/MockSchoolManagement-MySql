using MockSchoolManagement.Models.EnumTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MockSchoolManagement.Models
{
    public class Student : Person
    {
        /// <summary>
        /// 主修科目
        /// </summary>
        public MajorEnum? Major { get; set; }

        public string PhotoPath { get; set; }

        [NotMapped]
        public string EncryptedId { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        public string UserCode { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string UserSex { get; set; }

        /// <summary>
        /// 年纪
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 家长姓名
        /// </summary>
        public string ParentName { get; set; }

        /// <summary>
        /// 家长联系方式
        /// </summary>
        public string ParentPhoneNo { get; set; }

        /// <summary>
        /// 语文成绩
        /// </summary>
        public float ChineseScore { get; set; }


        /// <summary>
        /// 数学成绩
        /// </summary>
        public float MathScore { get; set; }

        /// <summary>
        /// 英语成绩
        /// </summary>
        public float EnglishScore { get; set; }


        /// <summary>
        /// 入学时间
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }






        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
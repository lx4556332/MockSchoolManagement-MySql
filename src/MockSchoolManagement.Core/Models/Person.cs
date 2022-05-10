using System.ComponentModel.DataAnnotations;

namespace MockSchoolManagement.Models
{
    public abstract class Person
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "姓名")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "电子邮箱")]
        public string Email { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string UserSex { get; set; }


        /// <summary>
        /// 编号或者学号
        /// </summary>
        public string UserCode { get; set; }

        /// <summary>
        /// 所属班级
        /// </summary>
        public string DepartmentName { get; set; }

    }
}
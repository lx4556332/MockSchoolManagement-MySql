using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockSchoolManagement.Application.Students.Dtos
{

    /// <summary>
    /// 入学时间分组
    /// </summary>
    public class EnrollmentDateGroupDto
    {

        /// <summary>
        /// 班级时间
        /// </summary>
        public string DepartmentName { get; set; }

        public int StudentCount { get; set; }
    }
}

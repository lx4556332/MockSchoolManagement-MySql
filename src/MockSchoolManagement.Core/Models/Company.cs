using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MockSchoolManagement.Core.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Display(Name = "公司名称")]
        public string CompanyName { get; set; }

    }
}

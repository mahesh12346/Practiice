using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class CompanyModel
    {
        [Key]
        public int comapny_id { get; set; }
        public string comapny_name { get; set; }
        public DateTime company_founded_on { get; set; }
    }
}

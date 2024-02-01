using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Entrities
{
    class Department
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Code is required")]
        public int Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfCreation { get; set; }
        public List<Employee> employees { get; set; }
    
    }
}

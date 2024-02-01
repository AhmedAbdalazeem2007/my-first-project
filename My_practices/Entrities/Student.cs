using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Entrities
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        public decimal Gpa { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [NotMapped]
        public decimal Age { get; set; }

        public DateTime Birthdate { get; set; }


    }
}

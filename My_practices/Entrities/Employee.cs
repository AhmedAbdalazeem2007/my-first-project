using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Entrities
{
    internal class Employee : IComparable<Employee>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 9)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public decimal Sal { get; set; }
        [Range(20, 50)]
        public int? Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime HireDate { get; set; }
        public string ImgUrl {  get; set; }
        public int DepartmentId { get; set; }

        public Department department { get; set; }
        public int CompareTo(Employee? other)
        {
            return this.Id.CompareTo(other.Id);
        }
        public override string ToString()
        {
            return "jhj";
        }
    }
}

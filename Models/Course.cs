using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moncc.Models
{
    public class Course: UserActivity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string? Description { get; set; }
         [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        //làm phần điều hướng
        public virtual Department? department { get; set; }






    }
}

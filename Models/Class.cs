using System.ComponentModel.DataAnnotations.Schema;

namespace Moncc.Models
{
    public class Class:UserActivity
    {
        public int Id { get; set; } 
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int StudentNumber { get; set; }
        public int UserId { get; set; }
        [ForeignKey("Department")]
        public virtual Department? department { get; set; }
        [ForeignKey("User")]
        public virtual User? user { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Moncc.Models
{
    public class Department:UserActivity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Leader { get; set; }
        public DateTime BeginningDate { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}

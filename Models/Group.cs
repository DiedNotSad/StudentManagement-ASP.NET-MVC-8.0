using System.ComponentModel.DataAnnotations.Schema;

namespace Moncc.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentNumber { get; set; }
        public int DepartmnetId { get; set; }
        [ForeignKey("Department")]
        public virtual Department department { get; set; }

        public int UserId { get; set; }
        [ForeignKey("User")]
        public virtual User user { get; set; }
        

    }
}

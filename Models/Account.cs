using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Moncc.Models
{
    public class Account:UserActivity
    {
        [Key]
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        [Required, MaxLength(60)]
        public string Username { get; set; }
        [Required, MaxLength(60)]
        public string Password { get; set; }
        [MaxLength(100)]
        public string IpClient { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? LastLogout { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }
    }
}

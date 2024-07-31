namespace Moncc.Models
{
    public class Role:UserActivity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}

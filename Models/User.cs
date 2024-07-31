namespace Moncc.Models
{
    public class User: UserActivity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }

    }
}

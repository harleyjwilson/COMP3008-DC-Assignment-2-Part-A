namespace LocalDBWebApiUsingEF.Models
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }
        // Foreign Key to User
        public int UserId { get; set; }

        // Navigation Property to User (optional but recommended for EF operations)
        public User User { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LocalDBWebApiUsingEF.Models
{
    public class BankAccount
    {

        public int AccountNumber { get; set; }
        public string? AccountHolderName { get; set; }
        public double Balance { get; set; }
        // Foreign Key to User

        public int UserId { get; set; }

        // Navigation Property to User (optional but recommended for EF operations)
        [JsonIgnore]
        public virtual User? User { get; set; }
    }
}

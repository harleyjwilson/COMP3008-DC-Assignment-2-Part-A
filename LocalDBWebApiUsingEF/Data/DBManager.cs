using LocalDBWebApiUsingEF.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LocalDBWebApiUsingEF.Data
{
    public class DBManager : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Users.db;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User Seed Data
            List<User> users = new List<User>
            {
                new User("sajib")
                {
                    // Username = "sajib",
                    Name = "Sajib",
                    Email = "email1@gmail.com",
                    Address = "Bently",
                    Phone = "111-111-1111",
                    Password = "mypassword1",
                    Picture = "/images/man1.jpeg"
                },
                new User("mistry")
                {
                    // Username = "mistry",
                    Name = "Mistry",
                    Email = "email2@gmail.com",
                    Address = "Victoria Park",
                    Phone = "222-222-2222",
                    Password = "mypassword",
                    Picture = "/images/man2.jpeg"
                },
                new User("mike")
                {
                    // Username = "mike",
                    Name = "Mike",
                    Email = "email3@gmail.com",
                    Address = "Northbridge",
                    Phone = "333-333-3333",
                    Password = "mypassword3",
                    Picture = "/images/women1.jpeg"
                }
            };
            modelBuilder.Entity<User>().HasData(users);

            // BankAccount Seed Data
            List<BankAccount> bankAccounts = new List<BankAccount>
            {
                new BankAccount(10001, "sajib")
                {
                    // AccountNumber = 10001,
                    AccountHolderName = "Sajib's Account",
                    Balance = 5000.50
                    // UserUsername = "sajib"  // Reference to Sajib's User Id
                },
                new BankAccount(10002, "mistry")
                {
                    // AccountNumber = 10002,
                    AccountHolderName = "Mistry's Account",
                    Balance = 2500.75
                    // UserUsername = "mistry"   // Reference to Mistry's User Id
                },
                new BankAccount(10003, "mike")
                {
                    // AccountNumber = 10003,
                    AccountHolderName = "Mike's Account",
                    Balance = 12000.00
                    // UserUsername = "mike"   // Reference to Mike's User Id
                }
            };
            // Set AccountNumber as the primary key for User
            modelBuilder.Entity<User>()
                .HasKey(b => b.Username);

            // Set AccountNumber as the primary key for BankAccount
            modelBuilder.Entity<BankAccount>()
                .HasKey(b => b.AccountNumber);

            // Configure the relationship
            modelBuilder.Entity<BankAccount>()
                .HasOne(b => b.User)
                .WithMany(u => u.BankAccounts)  // Indicates that a user can have multiple bank accounts
                .HasForeignKey(b => b.UserUsername)
                .OnDelete(DeleteBehavior.Cascade)  // If a user is deleted, their bank accounts are deleted as well
                .IsRequired(true);  // UserId is required, but User navigation property is not
            modelBuilder.Entity<BankAccount>().HasData(bankAccounts);

        }
    }
}

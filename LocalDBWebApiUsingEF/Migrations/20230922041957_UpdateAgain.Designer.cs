﻿// <auto-generated />
using LocalDBWebApiUsingEF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocalDBWebApiUsingEF.Migrations
{
    [DbContext(typeof(DBManager))]
    [Migration("20230922041957_UpdateAgain")]
    partial class UpdateAgain
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.BankAccount", b =>
                {
                    b.Property<int>("AccountNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountHolderName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AccountNumber");

                    b.HasIndex("UserId");

                    b.ToTable("BankAccounts");

                    b.HasData(
                        new
                        {
                            AccountNumber = 10001,
                            AccountHolderName = "Sajib's Account",
                            Balance = 5000.5,
                            UserId = 1
                        },
                        new
                        {
                            AccountNumber = 10002,
                            AccountHolderName = "Mistry's Account",
                            Balance = 2500.75,
                            UserId = 2
                        },
                        new
                        {
                            AccountNumber = 10003,
                            AccountHolderName = "Mike's Account",
                            Balance = 12000.0,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Bently",
                            Age = 20,
                            Email = "email1@gmail.com",
                            Name = "Sajib",
                            Password = "mypassword1",
                            Phone = "111-111-1111"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Victoria Park",
                            Age = 30,
                            Email = "email2@gmail.com",
                            Name = "Mistry",
                            Password = "mypassword2",
                            Phone = "222-222-2222"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Northbridge",
                            Age = 40,
                            Email = "email3@gmail.com",
                            Name = "Mike",
                            Password = "mypassword3",
                            Phone = "333-333-3333"
                        });
                });

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.BankAccount", b =>
                {
                    b.HasOne("LocalDBWebApiUsingEF.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}

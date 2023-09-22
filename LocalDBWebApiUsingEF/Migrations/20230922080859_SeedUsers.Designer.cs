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
    [Migration("20230922080859_SeedUsers")]
    partial class SeedUsers
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
                        .HasColumnType("TEXT");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AccountNumber");

                    b.HasIndex("UserId");

                    b.ToTable("BankAccounts");
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

                    b.Property<string>("Picture")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Address 1",
                            Age = 39,
                            Email = "user1@mail.com",
                            Name = "User1",
                            Password = "password1",
                            Phone = "123-456-1",
                            Picture = "/images/man1.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Address 2",
                            Age = 43,
                            Email = "user2@mail.com",
                            Name = "User2",
                            Password = "password2",
                            Phone = "123-456-2",
                            Picture = "/images/women2.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Address 3",
                            Age = 47,
                            Email = "user3@mail.com",
                            Name = "User3",
                            Password = "password3",
                            Phone = "123-456-3",
                            Picture = "/images/man2.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Address 4",
                            Age = 51,
                            Email = "user4@mail.com",
                            Name = "User4",
                            Password = "password4",
                            Phone = "123-456-4",
                            Picture = "/images/women2.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Address 5",
                            Age = 33,
                            Email = "user5@mail.com",
                            Name = "User5",
                            Password = "password5",
                            Phone = "123-456-5",
                            Picture = "/images/women2.jpeg"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Address 6",
                            Age = 33,
                            Email = "user6@mail.com",
                            Name = "User6",
                            Password = "password6",
                            Phone = "123-456-6",
                            Picture = "/images/man2.jpeg"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Address 7",
                            Age = 55,
                            Email = "user7@mail.com",
                            Name = "User7",
                            Password = "password7",
                            Phone = "123-456-7",
                            Picture = "/images/women1.jpeg"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Address 8",
                            Age = 20,
                            Email = "user8@mail.com",
                            Name = "User8",
                            Password = "password8",
                            Phone = "123-456-8",
                            Picture = "/images/women2.jpeg"
                        },
                        new
                        {
                            Id = 9,
                            Address = "Address 9",
                            Age = 47,
                            Email = "user9@mail.com",
                            Name = "User9",
                            Password = "password9",
                            Phone = "123-456-9",
                            Picture = "/images/women1.jpeg"
                        },
                        new
                        {
                            Id = 10,
                            Address = "Address 10",
                            Age = 22,
                            Email = "user10@mail.com",
                            Name = "User10",
                            Password = "password10",
                            Phone = "123-456-10",
                            Picture = "/images/women2.jpeg"
                        });
                });

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.BankAccount", b =>
                {
                    b.HasOne("LocalDBWebApiUsingEF.Models.User", "User")
                        .WithMany("BankAccounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.User", b =>
                {
                    b.Navigation("BankAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using BIT.NET.BankApp.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BIT.NET.BankApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210118122526_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BIT.NET.BankApp.Domain.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Balance")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BIT.NET.BankApp.Domain.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("TypeId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("BIT.NET.BankApp.Domain.Entities.CardType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CardType");
                });

            modelBuilder.Entity("BIT.NET.BankApp.Domain.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("TypeId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("BIT.NET.BankApp.Domain.Entities.TransactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TransactionType");
                });

            modelBuilder.Entity("BIT.NET.BankApp.Domain.Entities.Card", b =>
                {
                    b.HasOne("BIT.NET.BankApp.Domain.Entities.Account", "Account")
                        .WithMany("Cards")
                        .HasForeignKey("AccountId");

                    b.HasOne("BIT.NET.BankApp.Domain.Entities.CardType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Account");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("BIT.NET.BankApp.Domain.Entities.Transaction", b =>
                {
                    b.HasOne("BIT.NET.BankApp.Domain.Entities.Account", null)
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId");

                    b.HasOne("BIT.NET.BankApp.Domain.Entities.TransactionType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("BIT.NET.BankApp.Domain.Entities.Account", b =>
                {
                    b.Navigation("Cards");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}

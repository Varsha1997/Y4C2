﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Y4C2.Models;

namespace Y4C2.Migrations
{
    [DbContext(typeof(AddContentDBContext))]
    partial class AddContentDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Y4C2.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArchiveStatus");

                    b.Property<string>("Dob");

                    b.Property<string>("Email");

                    b.Property<string>("FName");

                    b.Property<string>("LName");

                    b.Property<string>("Password");

                    b.Property<string>("TakenYogaClass");

                    b.Property<string>("Username");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Y4C2.Models.AddContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Audio");

                    b.Property<string>("BlogAuthor");

                    b.Property<string>("BlogContent");

                    b.Property<string>("BlogTitle");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Property<string>("Video");

                    b.HasKey("Id");

                    b.ToTable("AC");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using BPT.Test.JASM.BackEnd.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BPT.Test.JASM.BackEnd.DataAccess.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20210308235834_AddModelStudentAssigment")]
    partial class AddModelStudentAssigment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BPT.Test.JASM.BackEnd.DataAccess.Assignments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("BPT.Test.JASM.BackEnd.DataAccess.StudenAssigments", b =>
                {
                    b.Property<Guid>("IdAssignments")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdStudent")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdAssignments", "IdStudent");

                    b.HasIndex("IdStudent");

                    b.ToTable("StudenAssigments");
                });

            modelBuilder.Entity("BPT.Test.JASM.BackEnd.DataAccess.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("BPT.Test.JASM.BackEnd.DataAccess.StudenAssigments", b =>
                {
                    b.HasOne("BPT.Test.JASM.BackEnd.DataAccess.Assignments", "Assignments")
                        .WithMany("StudenAssigments")
                        .HasForeignKey("IdAssignments")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BPT.Test.JASM.BackEnd.DataAccess.Student", "Student")
                        .WithMany("StudenAssigments")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignments");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("BPT.Test.JASM.BackEnd.DataAccess.Assignments", b =>
                {
                    b.Navigation("StudenAssigments");
                });

            modelBuilder.Entity("BPT.Test.JASM.BackEnd.DataAccess.Student", b =>
                {
                    b.Navigation("StudenAssigments");
                });
#pragma warning restore 612, 618
        }
    }
}

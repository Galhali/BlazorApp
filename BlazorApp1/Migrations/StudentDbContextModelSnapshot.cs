﻿// <auto-generated />
using System;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp1.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("BlazorApp1.Data.Ocena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("OcenaCwiczenia")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("OcenaKoncowa")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("OcenaWyklady")
                        .HasColumnType("TEXT");

                    b.Property<int>("ZapisanieId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ZapisanieId");

                    b.ToTable("Oceny");
                });

            modelBuilder.Entity("BlazorApp1.Data.Przedmiot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NazwaPrzedmiotu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OpisPrzedmiotu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Przedmioty");
                });

            modelBuilder.Entity("BlazorApp1.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Avatar")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Semestr")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Wiek")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Studenci");
                });

            modelBuilder.Entity("BlazorApp1.Data.Zapisanie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataZapisania")
                        .HasColumnType("TEXT");

                    b.Property<int>("PrzedmiotId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PrzedmiotId");

                    b.HasIndex("StudentId");

                    b.ToTable("Zapisania");
                });

            modelBuilder.Entity("BlazorApp1.Data.Ocena", b =>
                {
                    b.HasOne("BlazorApp1.Data.Zapisanie", "Zapisanie")
                        .WithMany()
                        .HasForeignKey("ZapisanieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zapisanie");
                });

            modelBuilder.Entity("BlazorApp1.Data.Zapisanie", b =>
                {
                    b.HasOne("BlazorApp1.Data.Przedmiot", "Przedmiot")
                        .WithMany()
                        .HasForeignKey("PrzedmiotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorApp1.Data.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Przedmiot");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}

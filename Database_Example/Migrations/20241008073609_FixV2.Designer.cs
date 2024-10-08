﻿// <auto-generated />
using Database_Example.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database_Example.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20241008073609_FixV2")]
    partial class FixV2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Database_Example.Model.FavouriteWords", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.Property<int>("WordsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.HasIndex("WordsId");

                    b.ToTable("FavouriteUsersWord");
                });

            modelBuilder.Entity("Database_Example.Model.FlashCards", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("FlashCards");
                });

            modelBuilder.Entity("Database_Example.Model.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Database_Example.Model.Words", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FlashCardId")
                        .HasColumnType("int");

                    b.Property<string>("Translate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FlashCardId");

                    b.ToTable("Word");
                });

            modelBuilder.Entity("Database_Example.Model.FavouriteWords", b =>
                {
                    b.HasOne("Database_Example.Model.Users", "Users")
                        .WithMany("FavouriteWords")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database_Example.Model.Words", "Words")
                        .WithMany()
                        .HasForeignKey("WordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");

                    b.Navigation("Words");
                });

            modelBuilder.Entity("Database_Example.Model.FlashCards", b =>
                {
                    b.HasOne("Database_Example.Model.Users", "Users")
                        .WithMany("FlashCards")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Database_Example.Model.Words", b =>
                {
                    b.HasOne("Database_Example.Model.FlashCards", "FlashCards")
                        .WithMany("Words")
                        .HasForeignKey("FlashCardId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FlashCards");
                });

            modelBuilder.Entity("Database_Example.Model.FlashCards", b =>
                {
                    b.Navigation("Words");
                });

            modelBuilder.Entity("Database_Example.Model.Users", b =>
                {
                    b.Navigation("FavouriteWords");

                    b.Navigation("FlashCards");
                });
#pragma warning restore 612, 618
        }
    }
}

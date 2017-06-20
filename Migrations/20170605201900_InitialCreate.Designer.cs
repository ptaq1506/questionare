using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using aspnetcoreapp;

namespace aspnetcoreapp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20170605201900_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entites.AnswerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<int>("OptionId");

                    b.Property<int>("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("AnswerSet");
                });

            modelBuilder.Entity("DAL.Entites.QuestionareEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("RespondendsNumber");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("QuestionareSet");
                });

            modelBuilder.Entity("DAL.Entites.QuestionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Question");

                    b.Property<int>("QuestionareId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("QuestionareId");

                    b.ToTable("QuestionSet");
                });

            modelBuilder.Entity("DAL.Entites.QuestionOptionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OptionText");

                    b.Property<int>("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionOptionSet");
                });

            modelBuilder.Entity("DAL.Entites.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MembershipId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UsersSet");
                });

            modelBuilder.Entity("DAL.Entites.AnswerEntity", b =>
                {
                    b.HasOne("DAL.Entites.QuestionEntity", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entites.QuestionareEntity", b =>
                {
                    b.HasOne("DAL.Entites.UserEntity", "User")
                        .WithMany("Questionares")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entites.QuestionEntity", b =>
                {
                    b.HasOne("DAL.Entites.QuestionareEntity", "Questionare")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionareId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entites.QuestionOptionEntity", b =>
                {
                    b.HasOne("DAL.Entites.QuestionEntity", "Question")
                        .WithMany("QuestionOptions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

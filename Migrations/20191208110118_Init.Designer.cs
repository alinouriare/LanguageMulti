﻿// <auto-generated />
using System;
using LangMulti.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LangMulti.Migrations
{
    [DbContext(typeof(MyCMSContext))]
    [Migration("20191208110118_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LangMulti.Models.Language", b =>
                {
                    b.Property<int>("Lang_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageTitle")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Lang_Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("LangMulti.Models.News", b =>
                {
                    b.Property<int>("News_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("ImageName")
                        .HasMaxLength(50);

                    b.Property<int>("Lang_Id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("News_Id");

                    b.HasIndex("Lang_Id");

                    b.ToTable("Newses");
                });

            modelBuilder.Entity("LangMulti.Models.News", b =>
                {
                    b.HasOne("LangMulti.Models.Language", "Language")
                        .WithMany("News")
                        .HasForeignKey("Lang_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

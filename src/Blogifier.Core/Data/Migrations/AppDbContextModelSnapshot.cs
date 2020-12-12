﻿// <auto-generated />
using System;
using Blogifier.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blogifier.Core.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Blogifier.Shared.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Avatar")
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.Property<string>("Bio")
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<int?>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATE('now')");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Blogifier.Shared.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cover")
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATE('now')");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("TEXT");

                    b.Property<string>("FooterScript")
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("HeaderScript")
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IncludeFeatured")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemsPerPage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Logo")
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.Property<string>("Theme")
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Blogifier.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATE('now')");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Blogifier.Shared.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cover")
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATE('now')");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostViews")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Published")
                        .HasColumnType("TEXT");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<bool>("Selected")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Blogifier.Shared.Subscriber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATE('now')");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("TEXT");

                    b.Property<string>("Ip")
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("CategoryPost", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriesId", "PostsId");

                    b.HasIndex("PostsId");

                    b.ToTable("CategoryPost");
                });

            modelBuilder.Entity("Blogifier.Shared.Author", b =>
                {
                    b.HasOne("Blogifier.Shared.Blog", null)
                        .WithMany("Authors")
                        .HasForeignKey("BlogId");
                });

            modelBuilder.Entity("Blogifier.Shared.Post", b =>
                {
                    b.HasOne("Blogifier.Shared.Author", null)
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blogifier.Shared.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId");

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("Blogifier.Shared.Subscriber", b =>
                {
                    b.HasOne("Blogifier.Shared.Blog", "Blog")
                        .WithMany()
                        .HasForeignKey("BlogId");

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("CategoryPost", b =>
                {
                    b.HasOne("Blogifier.Shared.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blogifier.Shared.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blogifier.Shared.Author", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Blogifier.Shared.Blog", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}

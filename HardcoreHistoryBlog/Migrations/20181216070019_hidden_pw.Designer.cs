﻿// <auto-generated />
using System;
using HardcoreHistoryBlog.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HardcoreHistoryBlog.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181216070019_hidden_pw")]
    partial class hidden_pw
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HardcoreHistoryBlog.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Role");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("Role")
                        .IsUnique()
                        .HasFilter("[Role] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloggerId");

                    b.HasKey("Id");

                    b.HasIndex("BloggerId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Url");

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("PostId");

                    b.HasKey("CategoryId");

                    b.HasIndex("PostId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Contributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloggerId");

                    b.HasKey("Id");

                    b.HasIndex("BloggerId");

                    b.ToTable("Contributor");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Like", b =>
                {
                    b.Property<int>("LikeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentForeignKey");

                    b.Property<bool>("Liked");

                    b.Property<int>("PostForeignKey");

                    b.HasKey("LikeId");

                    b.HasIndex("CommentForeignKey");

                    b.HasIndex("PostForeignKey");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<int?>("BlogForeignKey");

                    b.Property<int?>("BlogViewModelId");

                    b.Property<string>("BloggerId");

                    b.Property<string>("BloggerId1");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<int?>("ContributorForeignKey");

                    b.Property<int>("GetPost");

                    b.Property<string>("MemberId");

                    b.Property<DateTime?>("Modified");

                    b.Property<DateTime>("PostedOn");

                    b.Property<bool>("Published");

                    b.Property<string>("Short_Description")
                        .IsRequired();

                    b.Property<string>("Title");

                    b.HasKey("PostId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BlogForeignKey");

                    b.HasIndex("BlogViewModelId");

                    b.HasIndex("BloggerId");

                    b.HasIndex("BloggerId1");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ContributorForeignKey");

                    b.HasIndex("MemberId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.PostCategory", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int?>("PostId1");

                    b.HasKey("PostId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PostId1");

                    b.ToTable("PostCategory");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.PostTag", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("PostId1");

                    b.Property<int>("TagId");

                    b.HasKey("PostId");

                    b.HasIndex("PostId1");

                    b.HasIndex("TagId");

                    b.ToTable("postTags");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorDetailsId");

                    b.Property<int>("Categories");

                    b.Property<int?>("ContributorDetailsId");

                    b.Property<string>("HomeImage")
                        .IsRequired();

                    b.Property<string>("HomeImageText")
                        .IsRequired();

                    b.Property<string>("MemberDetailsId");

                    b.Property<int>("NumberOfLastPost");

                    b.Property<int>("NumberOfTopPost");

                    b.Property<int>("PostNumberInPage");

                    b.Property<DateTime>("Update_Time");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorDetailsId");

                    b.HasIndex("ContributorDetailsId");

                    b.HasIndex("MemberDetailsId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Widget", b =>
                {
                    b.Property<int>("WidgetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<int?>("ContributorDetailsId");

                    b.Property<DateTime>("Updated_On");

                    b.Property<string>("WidgetContent")
                        .IsRequired();

                    b.Property<string>("WidgetName")
                        .IsRequired();

                    b.HasKey("WidgetId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ContributorDetailsId");

                    b.ToTable("Widgets");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.BlogViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("BlogViewModel");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CommentedOn")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<int>("FK_Comments_Posts_PostId");

                    b.Property<string>("MemberDetailsId");

                    b.Property<int>("MemberId");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("DateTime2");

                    b.Property<int>("PostId");

                    b.Property<bool>("Publish");

                    b.Property<DateTime?>("Update_time");

                    b.HasKey("CommentId");

                    b.HasIndex("FK_Comments_Posts_PostId");

                    b.HasIndex("MemberDetailsId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blogger", b =>
                {
                    b.HasBaseType("HardcoreHistoryBlog.Data.ApplicationUser");

                    b.Property<string>("UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Blogger");

                    b.HasDiscriminator().HasValue("Blogger");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Member", b =>
                {
                    b.HasBaseType("HardcoreHistoryBlog.Data.ApplicationUser");

                    b.Property<string>("UserId")
                        .HasColumnName("Member_UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Member");

                    b.HasDiscriminator().HasValue("Member");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Data.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("Description");

                    b.Property<string>("ParentRoleId");

                    b.HasIndex("ParentRoleId");

                    b.ToTable("ApplicationRole");

                    b.HasDiscriminator().HasValue("ApplicationRole");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Data.ApplicationUser", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Data.ApplicationRole", "ApplicationRole")
                        .WithOne("ApplicationUser")
                        .HasForeignKey("HardcoreHistoryBlog.Data.ApplicationUser", "Role");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Author", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Models.Blogger", "Blogger")
                        .WithMany()
                        .HasForeignKey("BloggerId");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Category", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Post")
                        .WithMany("GetCategories")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Contributor", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Models.Blogger", "Blogger")
                        .WithMany()
                        .HasForeignKey("BloggerId");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Like", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Models.Comment", "Comment")
                        .WithMany("Likes")
                        .HasForeignKey("CommentForeignKey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Post", "Post")
                        .WithMany("Likes")
                        .HasForeignKey("PostForeignKey")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Post", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogForeignKey");

                    b.HasOne("HardcoreHistoryBlog.Models.BlogViewModel")
                        .WithMany("Posts")
                        .HasForeignKey("BlogViewModelId");

                    b.HasOne("HardcoreHistoryBlog.Models.Blogger")
                        .WithMany("AuthoredPosts")
                        .HasForeignKey("BloggerId");

                    b.HasOne("HardcoreHistoryBlog.Models.Blogger")
                        .WithMany("ContributedToPosts")
                        .HasForeignKey("BloggerId1");

                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Contributor", "Contributor")
                        .WithMany()
                        .HasForeignKey("ContributorForeignKey");

                    b.HasOne("HardcoreHistoryBlog.Models.Member")
                        .WithMany("CommentedOnPosts")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.PostCategory", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Category", "Category")
                        .WithMany("PostCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId1");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.PostTag", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Post", "Post")
                        .WithMany("postTags")
                        .HasForeignKey("PostId1");

                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Settings", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Author", "AuthorDetails")
                        .WithMany()
                        .HasForeignKey("AuthorDetailsId");

                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Contributor", "ContributorDetails")
                        .WithMany()
                        .HasForeignKey("ContributorDetailsId");

                    b.HasOne("HardcoreHistoryBlog.Models.Member", "MemberDetails")
                        .WithMany()
                        .HasForeignKey("MemberDetailsId");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blog_Models.Widget", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Author", "AuthorDetails")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Contributor", "ContributorDetails")
                        .WithMany()
                        .HasForeignKey("ContributorDetailsId");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.BlogViewModel", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Comment", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Models.Blog_Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("FK_Comments_Posts_PostId");

                    b.HasOne("HardcoreHistoryBlog.Models.Member", "MemberDetails")
                        .WithMany()
                        .HasForeignKey("MemberDetailsId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HardcoreHistoryBlog.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Blogger", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Data.ApplicationUser", "User")
                        .WithMany("Bloggers")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Models.Member", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Data.ApplicationUser", "User")
                        .WithMany("Members")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("HardcoreHistoryBlog.Data.ApplicationRole", b =>
                {
                    b.HasOne("HardcoreHistoryBlog.Data.ApplicationRole", "ParentRole")
                        .WithMany()
                        .HasForeignKey("ParentRoleId");
                });
#pragma warning restore 612, 618
        }
    }
}

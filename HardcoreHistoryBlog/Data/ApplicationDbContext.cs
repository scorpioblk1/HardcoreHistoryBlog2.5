﻿using System;
using System.Collections.Generic;
using System.Text;
using HardcoreHistoryBlog.Models;
using HardcoreHistoryBlog.Models.Blog_Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HardcoreHistoryBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext<
        ApplicationUser>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<Tag> Tags { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Comment> Comments { get; set; }
            public DbSet<Like> Likes { get; set; }
            public DbSet<Blogger> Bloggers { get; set; }
            public DbSet<Client> Clients { get; set; }
            public DbSet<Member> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PostTag>()
                .HasKey(t => new { t.PostId, t.TagId });

            builder.Entity<PostTag>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId);

            builder.Entity<PostTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagId);

            //builder.Entity<ApplicationUser>()
            //    .HasMany(e => e.Claims)
            //    .WithOne()
            //    .HasForeignKey(e => e.UserId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<ApplicationUser>()
            //    .HasMany(e => e.Logins)
            //    .WithOne()
            //    .HasForeignKey(e => e.UserId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<ApplicationUser>()
            //    .HasMany(e => e.Roles)
            //    .WithOne()
            //    .HasForeignKey(e => e.UserId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

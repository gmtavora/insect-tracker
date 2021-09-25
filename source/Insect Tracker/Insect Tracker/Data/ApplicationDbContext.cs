using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Insect_Tracker.Models;

namespace Insect_Tracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("User");
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable("Role");
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });

            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Insect_Tracker.Models.Message> Message { get; set; }

        public DbSet<Insect_Tracker.Models.Project> Project { get; set; }

        public DbSet<Insect_Tracker.Models.Ticket> Ticket { get; set; }
        public DbSet<Insect_Tracker.Models.Comment> Comment { get; set; }
        public DbSet<Insect_Tracker.Models.Attachment> Attachment { get; set; }
        public DbSet<Insect_Tracker.Models.UserMessage> UserMessage { get; set; }
        public DbSet<Insect_Tracker.Models.UserProject> UserProject { get; set; }
    }
}

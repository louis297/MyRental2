using System;
using System.Reflection;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyRental2.Models.UserModel;

namespace MyRental2.Models
{
    /// <summary>
    /// DB context for the whole MyRental2 project
    /// </summary>
    public class MyRentalDbContext: ApiAuthorizationDbContext<MyRentalUser>
    {

        public MyRentalDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationStoreOptions): base(options, operationStoreOptions)
        {
        }

        // configure the tables, add FK, relation or seeding data
        /// <summary>
        /// configure the tables, add FK, relation or seeding data
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Automatically get model builder from all the files
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            // seeding user and roles
            #region seed custom admin role
            string ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_ID = ADMIN_ID;
            //seed custom admin role
            modelBuilder.Entity<MyRentalRole>().HasData(new MyRentalRole
            {
                Id = ROLE_ID,
                Name = "root",
                NormalizedName = "ROOT"
            });
            modelBuilder.Entity<MyRentalRole>().HasData(new MyRentalRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<MyRentalRole>().HasData(new MyRentalRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "VIP",
                NormalizedName = "VIP"
            });
            modelBuilder.Entity<MyRentalRole>().HasData(new MyRentalRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "user",
                NormalizedName = "USER"
            });
            //seed admins
            var hasher = new PasswordHasher<MyRentalUser>();
            modelBuilder.Entity<MyRentalUser>().HasData(new MyRentalUser
            {
                Id = ADMIN_ID,
                FirstName = "Admin",
                LastName = "Admin",
                NickName = "louis",
                UserName = "admin@test.com",
                NormalizedUserName = "admin@test.com".ToUpper(),
                Email = "admin@x.com",
                NormalizedEmail = "admin@x.com".ToUpper(),
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "admin"),
                SecurityStamp = string.Empty
            });
            //seed admin into role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
            #endregion
        }
    }
}

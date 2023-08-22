using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ST10084788_PROG7311_POE.Data;
using static ST10084788_PROG7311_POE.Data.ApplicationDbContext;
using System.IO;
using ST10084788_PROG7311_POE.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ST10084788_PROG7311_POE.Data.Migrations;

namespace ST10084788_PROG7311_POE.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasKey(products => new { products.ProductID});
           
            // Products for farmer 1
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 1, ProductName = "Spring Onions", ProductDesc = "Freshly Harvested Spring Onions", ProductCategory = "Vegetable", Quantity = 15, Price = 30, DateAdded = new DateTime(2023, 05, 20), FarmerID = "3" , ProductImage = "https://www.foodandwine.com/thmb/mlUUeD3gpRZQq2qUs8nead6QAYY=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/The-Difference-Between-Green-Onions-FT-3-BLOG0622-3e3086b7871d44309f4d64dfe8536e00.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 2, ProductName = "Strawberries", ProductDesc = "Freshly Harvested Strawberries", ProductCategory = "Fruit", Quantity = 30, Price = 20, DateAdded = new DateTime(2023, 05, 26), FarmerID = "3", ProductImage = "https://www.dispatch.com/gcdn/presto/2022/05/10/NCOD/0a1efdfc-bc59-40bb-9007-f6a875ae1b0a-strawberries_in_rows.JPG" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 3, ProductName = "Pineapples", ProductDesc = "Freshly Harvested Pineapples", ProductCategory = "Fruit", Quantity = 20, Price = 25, DateAdded = new DateTime(2023, 05, 24), FarmerID = "3", ProductImage = "https://media6.ppl-media.com/mediafiles/blogs/pineapple_6439817058.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 4, ProductName = "Peaches", ProductDesc = "Freshly Harvested Peaches", ProductCategory = "Fruit", Quantity = 20, Price = 10, DateAdded = new DateTime(2023, 05, 21), FarmerID = "3", ProductImage = "https://extension.usu.edu/nutrition/images/peaches.png" });

            // Products for farmer 2
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 5, ProductName = "Carrots", ProductDesc = "Freshly Harvested Carrots", ProductCategory = "Vegetable", Quantity = 50, Price = 15, DateAdded = new DateTime(2023, 04, 29), FarmerID = "4", ProductImage = "https://www.almanac.com/sites/default/files/styles/or/public/image_nodes/carrots-table_popidar-ss.jpg?itok=-6KDefXK" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 6, ProductName = "Sunflowers", ProductDesc = "Fresh Sunflowers", ProductCategory = "Flowers and Plants", Quantity = 35, Price = 25, DateAdded = new DateTime(2023, 05, 27), FarmerID = "4", ProductImage = "https://cdn.wikifarmer.com/wp-content/uploads/2022/06/Sunflower-History-Uses-and-Plant-information.jpg" });
            

            //Seeding roles to AspNetRoles table
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "Admin".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2", Name = "Employee", NormalizedName = "Employee".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "3", Name = "Farmer", NormalizedName = "Farmer".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "4", Name = "Customer", NormalizedName = "Customer".ToUpper() });


            // hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<IdentityUser>();


            //Seed the Admin account
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "1",
                    UserName = "Admin1",
                    NormalizedUserName = "ADMIN1",
                    Email = "admin1@gmail.com",
                    NormalizedEmail = "ADMIN1@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Admin23_")

                }
            );


            //Seeding the relation between user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                }
            );

            //Seed the employee account
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "2", 
                    UserName = "Employee1",
                    NormalizedUserName = "EMPLOYEE1",
                    Email = "employee1@gmail.com",
                    NormalizedEmail = "EMPLOYEE1@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Employee23_")
                    
                }
            );


            //Seeding the relation between user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "2"
                }
            );


            //Seed the first  farmer account
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "3", 
                    UserName = "Farmer1",
                    NormalizedUserName = "FARMER1",
                    Email= "farmer1@gmail.com",
                    NormalizedEmail= "FARMER1@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Farmer23_")
                }
            );


            //Seeding the relation between user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "3",
                    UserId = "3"
                }
            );


            //Seed the second farmer account
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "4",
                    UserName = "Farmer2",
                    NormalizedUserName = "FARMER2",
                    Email = "farmer2@gmail.com",
                    NormalizedEmail = "FARMER2@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Farmer23_")
                }
            );


            //Seeding the relation between user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "3",
                    UserId = "4"
                }
            );

        }


    }
}

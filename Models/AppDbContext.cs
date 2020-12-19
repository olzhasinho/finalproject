using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ArtShop3.Models
{
    
    public class AppDbContext : IdentityDbContext<User>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Art> Arts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Programming" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Disign" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "3D modeling" });
            

            //seed art

            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 1,
                Name = "c++",
                Description = "Deep inside Photo",
                Price = 2000,
                CategoryId = 1,
                ImageUrl = "/images/1.jpg",
                InStock = true,
                IsArtOfTheWeek = true,
                ImageThumbnailUrl = "/images/22.jpg",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 2,
                Name = "c#",
                Description = "Deep inside Photo2",
                Price = 2000,
                CategoryId = 1,
                ImageUrl = "/images/3.jpg",
                InStock = true,
                IsArtOfTheWeek = false,
                ImageThumbnailUrl = "/images/44.jpeg",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 3,
                Name = "java",
                Description = "Deep inside Photo3",
                Price = 2000,
                CategoryId = 1,
                ImageUrl = "/images/5.jpg",
                InStock = false,
                IsArtOfTheWeek = true,
                ImageThumbnailUrl = "/images/66.jpg",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 4,
                Name = "asp.net",
                Description = "Deep inside Photo",
                Price = 2000,
                CategoryId = 1,
                ImageUrl = "/images/7.jpg",
                InStock = false,
                IsArtOfTheWeek = false,
                ImageThumbnailUrl = "/images/88.jpg",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 5,
                Name = "videosmile",
                Description = "Deep inside Photo",
                Price = 2000,
                CategoryId = 2,
                ImageUrl = "/images/naruto1.jpg",
                InStock = false,
                IsArtOfTheWeek = true,
                ImageThumbnailUrl = "/images/des1.jpg",
                ArtLike = 0,
                IsFavorite = true
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 6,
                Name = "Super Photoshop",
                Description = "Deep inside Photo",
                Price = 2000,
                CategoryId = 2,
                ImageUrl = "/images/naruto3.jpg",
                InStock = true,
                IsArtOfTheWeek = false,
                ImageThumbnailUrl = "/images/des2.png",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 7,
                Name = "Plane modeling form 0",
                Description = "Deep inside Photo",
                Price = 2000,
                CategoryId = 3,
                ImageUrl = "/images/kill1.png",
                InStock = true,
                IsArtOfTheWeek = true,
                ImageThumbnailUrl = "/images/3d1.jpg",
                ArtLike = 0,
                IsFavorite = false
            });
            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 8,
                Name = "Merz",
                Description = "Deep inside Photo4",
                Price = 2000,
                CategoryId = 3,
                ImageUrl = "/images/kill3.jpg",
                InStock = false,
                IsArtOfTheWeek = false,
                ImageThumbnailUrl = "/images/3d2.jpg",
                ArtLike = 0,
                IsFavorite = false
            });

        }
    }
}

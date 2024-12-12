//using InhumanShopApp.Infrastructure.Data.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InhumanShopApp.Infrastructure.Data.Configuration
//{
//    public class ProductConfiguration : IEntityTypeConfiguration<Product>
//    {

//        private Product[] initialProducts = new Product[]
        
//        {
//            // Toys
//            new Product() { Id = 1, Name = "Chew Toy", Count = 5, Price = 23.43M, Category ="Toys",Description  =      "Durable chew toy for dogs.", ImageUrl = "/images/chew_toy.jpg" },
//            new Product() { Id = 2, Name = "Cat Ball", Count = 5, Price = 15.99M, Category ="Toys",Description  =      "Colorful ball with bell for cats.", ImageUrl = "/imagescat_ball.jpg" },
//            new Product() { Id = 3, Name = "Bird Swing", Count = 5, Price = 12.49M, Category ="Toys",Description =       "Swing toy for small birds.", ImageUrl = "/images/bird_swing.jpg" },
//            new Product() { Id = 4, Name = "Hamster Tunnel", Count = 5, Price = 18.75M, Category = "Toys",  Description =    "Plastic tunnel for hamsters.", ImageUrl = "/images/hamster_tunnel.jpg" },
//            new Product() { Id = 5, Name = "Interactive Feeder", Count = 5, Price = 29.99M, Category ="Toys",      Description = "Puzzle feeder to engage pets.", ImageUrl = "imagesinteractive_feeder.jpg" },
        
//            //// Clothes
//            //new Product() { Id = 6, Name = "Dog Sweater", Count = 5, Price = 27.99M, CategoryId = 1,  Description =    "Warm sweater for small dogs.", ImageUrl = "/images/dog_sweater.jpg" },
//            //new Product() { Id = 7, Name = "Raincoat for Dogs", Count = 5, Price = 34.50M, CategoryId = 1,         Description = "Waterproof raincoat for pets.", ImageUrl = "imagesdog_raincoat.jpg" },
//            //new Product() { Id = 8, Name = "Cat Costume", Count = 5, Price = 22.99M, CategoryId = 1,  Description =    "Adorable costume for cats.", ImageUrl = "/images/cat_costume.jpg" },
//            //new Product() { Id = 9, Name = "Boots for Dogs", Count = 5, Price = 19.49M, CategoryId = 1,    Description    = "Protective boots for dogs.", ImageUrl = "/images/dog_boots.jpg" },
//            //new Product() { Id = 10, Name = "Pet Scarf", Count = 5, Price = 12.99M, CategoryId = 1,Description    =     "Stylish scarf for pets.", ImageUrl = "/images/pet_scarf.jpg" },
        
//            // Medicines
//            new Product() { Id = 11, Name = "Flea Treatment", Count = 5, Price = 45.99M, Category="Medicines",         Description = "Effective flea treatment for pets.", ImageUrl = "/images flea_treatment.jpg" },
//            new Product() { Id = 12, Name = "Deworming Tablets", Count = 5, Price = 28.75M,Category="Medicines",        Description = "Tablets for deworming cats and dogs.", ImageUrl = "images/deworming_tablets.jpg" },
//            new Product() { Id = 13, Name = "Vitamin Supplement", Count = 5, Price = 22.00M, Category = "Medicines",       Description = "Multivitamin for pets' health.", ImageUrl ="imagesvitamin_supplement.jpg" },
//            new Product() { Id = 14, Name = "Ear Drops", Count = 5, Price = 18.50M, Category = "Medicines",     Description =    "Ear infection treatment drops.", ImageUrl = "/images/ear_drops.jpg" },
//            new Product() { Id = 15, Name = "Joint Health Supplement", Count = 5, Price = 32.99M, Category =    "Medicines",    Description = "Supplement for joint health.", ImageUrl = "imagesjoint_supplement.jpg" }
//        };

//        public void Configure(EntityTypeBuilder<Product> builder)
//        {
//            builder.HasData(initialProducts);
//        }

//    }
//}

﻿using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Data.SeedData
{
    public class SizeSeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Size>().HasData(
                new Size { Id = 1, Name = "XS" },
                new Size { Id = 2, Name = "S" },
                new Size { Id = 3, Name = "M" },
                new Size { Id = 4, Name = "L" },
                new Size { Id = 5, Name = "XL" }
            );
        }
    }
}

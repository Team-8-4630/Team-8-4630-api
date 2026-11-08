using Microsoft.EntityFrameworkCore;
using Team_8_4630.Domain.Catalog;

namespace Team_8_4630.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ModelBuilder builder)
        {
            builder.Entity<Item>().HasData(
                new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m)
                {
                    Id = 1
                },
                new Item("Shorts", "Ohio State shorts.", "Nike", 44.99m)
                {
                    Id = 2
                }
            );
        }
    }
}
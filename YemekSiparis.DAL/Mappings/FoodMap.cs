using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparis.Core.Entities;
using YemekSiparis.Core.Enums;

namespace YemekSiparis.DAL.Mappings
{
    public class FoodMap : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            
			builder.HasData(new Food
			{
				Id = 1,
				Name = "SteakHouse",
				Stock = 20,
				Price = 120m,
				CategoryID = 1,
				Description = "110 gr. Helal Dana Eti, Cheader Peyniri, Karamelize Soğan",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 20,
			});
			builder.HasData(new Food
			{
				Id = 2,
				Name = "Margarita Bol Malzemos",
				Stock = 30,
				Price = 110m,
				CategoryID = 2,
				Description = "Mozeralla,Domates",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 24,
			});
			builder.HasData(new Food
			{
				Id = 3,
				Name = "Penne Soslu Makarna",
				Stock = 45,
				Price = 125m,
				CategoryID = 3,
				Description = "Penne Sosu, Krema",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 30,
			});

			// Additional entries for hamburgers
			builder.HasData(new Food
			{
				Id = 4,
				Name = "Classic Burger",
				Stock = 25,
				Price = 90m,
				CategoryID = 1,
				Description = "180 gr. Dana köfte, cheddar peyniri, marul, domates, turşu",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 15,
			});
			// Add more burger entries (5 in total)

			// Additional entries for pizzas
			builder.HasData(new Food
			{
				Id = 7,
				Name = "Pepperoni Pizza",
				Stock = 40,
				Price = 100m,
				CategoryID = 2,
				Description = "Mozeralla, pepperoni sosis, pizza sosu",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 22,
			});
			// Add more pizza entries (5 in total)

			// Additional entries for pastas
			builder.HasData(new Food
			{
				Id = 12,
				Name = "Spaghetti Carbonara",
				Stock = 35,
				Price = 130m,
				CategoryID = 3,
				Description = "Spagetti makarna, jambon, yumurta sarısı, parmesan peyniri, krema",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 25,
			});
			// Add more pasta entries (5 in total)

			// Additional entries for kebabs
			builder.HasData(new Food
			{
				Id = 17,
				Name = "Adana Kebab",
				Stock = 50,
				Price = 150m,
				CategoryID = 4,
				Description = "Adana usulü dana kıyma, baharatlar, lavaş",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 35,
			});

			builder.HasData(new Food
			{
				Id = 5,
				Name = "Cheese Lover's Burger",
				Stock = 15,
				Price = 95m,
				CategoryID = 1,
				Description = "200 gr. Dana köfte, cheddar, mozeralla, peynir sosu, marul, domates",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 18,
			});

			builder.HasData(new Food
			{
				Id = 6,
				Name = "BBQ Bacon Burger",
				Stock = 18,
				Price = 110m,
				CategoryID = 1,
				Description = "180 gr. Dana köfte, bacon, barbekü sos, cheddar, marul, turşu",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 20,
			});

			// Additional entries for pizzas
			builder.HasData(new Food
			{
				Id = 8,
				Name = "Vegetarian Delight Pizza",
				Stock = 28,
				Price = 95m,
				CategoryID = 2,
				Description = "Mozeralla, biber, mantar, siyah zeytin, mısır, domates",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 25,
			});

			builder.HasData(new Food
			{
				Id = 9,
				Name = "Seafood Supreme Pizza",
				Stock = 32,
				Price = 120m,
				CategoryID = 2,
				Description = "Mozeralla, karides, kalamar, midye, sarımsak, roka",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 28,
			});

			// Additional entries for pastas
			builder.HasData(new Food
			{
				Id = 13,
				Name = "Ravioli with Sage Butter",
				Stock = 40,
				Price = 135m,
				CategoryID = 3,
				Description = "Ravioli, tereyağlı adaçayı sosu, parmesan peyniri",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 22,
			});

			builder.HasData(new Food
			{
				Id = 14,
				Name = "Lemon Garlic Shrimp Pasta",
				Stock = 38,
				Price = 140m,
				CategoryID = 3,
				Description = "Karides, sarımsak, limon sos, fettuccine makarna",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 30,
			});

			// Additional entries for kebabs
			builder.HasData(new Food
			{
				Id = 18,
				Name = "Iskender Kebab",
				Stock = 22,
				Price = 160m,
				CategoryID = 4,
				Description = "Döner et, yoğurt, domates sosu, tereyağlı ekmek",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 40,
			});

			builder.HasData(new Food
			{
				Id = 19,
				Name = "Chicken Shish Kebab",
				Stock = 25,
				Price = 145m,
				CategoryID = 4,
				Description = "Tavuk şiş, baharatlar, pilav, acılı sos",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 35,
			});

			// Additional entries for hamburgers
			builder.HasData(new Food
			{
				Id = 21,
				Name = "Spicy Jalapeño Burger",
				Stock = 20,
				Price = 100m,
				CategoryID = 1,
				Description = "180 gr. Acılı dana köfte, jalapeño biber, pepper jack peyniri, marul, domates",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 18,
			});

			builder.HasData(new Food
			{
				Id = 22,
				Name = "Mushroom Swiss Burger",
				Stock = 18,
				Price = 110m,
				CategoryID = 1,
				Description = "200 gr. Dana köfte, mantar, swiss peyniri, hardal, turşu",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 20,
			});

			// Additional entries for pizzas
			builder.HasData(new Food
			{
				Id = 23,
				Name = "Margherita with Truffle Oil",
				Stock = 25,
				Price = 120m,
				CategoryID = 2,
				Description = "Mozeralla, domates, taze fesleğen, trüf yağı",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 22,
			});

			builder.HasData(new Food
			{
				Id = 24,
				Name = "BBQ Chicken Ranch Pizza",
				Stock = 30,
				Price = 130m,
				CategoryID = 2,
				Description = "Tavuk, barbekü sos, ranch sos, mozeralla, soğan",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 25,
			});

			// Additional entries for pastas
			builder.HasData(new Food
			{
				Id = 25,
				Name = "Linguine with Pesto Genovese",
				Stock = 35,
				Price = 125m,
				CategoryID = 3,
				Description = "Linguine makarna, pesto sos, taze parmesan peyniri",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 20,
			});

			builder.HasData(new Food
			{
				Id = 26,
				Name = "Creamy Garlic Mushroom Fettuccine",
				Stock = 32,
				Price = 135m,
				CategoryID = 3,
				Description = "Fettuccine makarna, kremsi sarımsaklı mantar sos, parmesan peyniri",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 28,
			});

			// Additional entries for kebabs
			builder.HasData(new Food
			{
				Id = 27,
				Name = "Mixed Grill Kebab",
				Stock = 28,
				Price = 155m,
				CategoryID = 4,
				Description = "Tavuk, dana, kuzu şiş, baharatlar, közlenmiş sebzeler, pilav",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 40,
			});

			builder.HasData(new Food
			{
				Id = 28,
				Name = "Vegetarian Falafel Wrap",
				Stock = 22,
				Price = 140m,
				CategoryID = 4,
				Description = "Falafel, humus, taze sebzeler, lavaş",
				CreatedDate = DateTime.Now,
				Status = Status.Active,
				PrepTime = 35,
			});

		}
	}
    
}

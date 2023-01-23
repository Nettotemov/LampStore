using LampStore.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LampStore.Services;
using Microsoft.EntityFrameworkCore;

namespace LampStore.Pages
{
	public class CardProduct : PageModel
	{
		private ICatalogRepository repository;
		public CardProduct(ICatalogRepository repo)
		{
			repository = repo;
		}

		public Product? productCard; //вывод карточки товара
		public List<Category> DisplayedCategories { get; private set; } = new();
		public long ProductID { get; private set; }

		public List<string> DisplayedPhotos { get; private set; } = new();

		public List<Product> DisplayedProducts { get; private set; } = new();

		public async Task<IActionResult> OnGetAsync(long productId) //инициализация карточки товара
		{
			DisplayedCategories = await repository.Categorys.Select(c => c).Distinct().ToListAsync();
			DisplayedProducts = await repository.Products.Select(p => p).ToListAsync();

			foreach (var product in DisplayedProducts)
			{
				if (product.ProductID == productId)
				{
					DisplayedPhotos = product.Photos.Split(',').ToList();

					productCard = new Product()
					{
						Artikul = product.Artikul,
						MainPhoto = product!.MainPhoto,
						Photos = product.Photos,
						Name = product.Name,
						MinDescription = product.MinDescription,
						Description = product.Description,
						Price = product.Price,
						Discount = product.Discount,
						OldPrice = product.OldPrice,
						ProductID = product.ProductID,
						Tags = product.Tags,
						Color = product.Color,
						Kelvins = product.Kelvins,
						Type = product.Type,
						Material = product.Material,
						Availability = product.Availability,
						Size = product.Size,
						BaseSize = product.BaseSize,
						CordLength = product.CordLength,
						LightSource = product.LightSource,
						PowerW = product.PowerW,
						Category = product.Category,
					};
					return Page();
				}
			}

			return StatusCode(404);
		}

	}
}

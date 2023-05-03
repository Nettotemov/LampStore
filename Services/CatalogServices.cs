using LampStore.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LampStore.Services
{
	public class CatalogServices
	{
		public List<Product> ProductsByName(List<Product> products, string name) //проверка по названию
		{
			return products.Where(p => p.Name.ToUpper().StartsWith(name.ToUpper()) || p.Artikul.ToUpper().StartsWith(name.ToUpper())).ToList();
		}
		public List<Product> ProductsByTags(List<Product> products, string[] tags) //проверка тегов
		{
			// return products.Where(prod => prod.ProductTags
			// 							   .Select(p => p.ID)
			// 							   .Intersect(tags)
			// 							   .Any()).ToList();

			return products.Where(p => tags.All(t => p.ProductTags.Select(s => s.Value).Any(tag => tag.Contains(t)))).ToList();
		}

		public List<Product> ProductsByColors(List<Product> products, string[] colors) //проверка цвета
		{
			return products.Where(p => colors.Any(color => p.Color.Contains(color))).ToList();
		}

		public List<Product> ProductsByTypes(List<Product> products, string[] types) //проверка типа
		{
			return products.Where(p => types.Any(type => p.ProductType!.Name.Contains(type))).ToList();
		}
		public List<Product> ProductsByMaterials(List<Product> products, string[] materials) //проверка типа
		{
			return products.Where(p => materials.All(material => p.Material.Contains(material))).ToList();
		}

		public List<Product> ProductsByCategory(List<Product> products, string category) //проверка по категории
		{
			return products.Where(p => p.Category!.CategoryName == category).ToList();
		}

		public List<Product> ProductsUpMaxPrice(List<Product> products, string maxPrice) //проверка по максимальной цене
		{
			return products.Where(p => p.Price <= Convert.ToInt64(maxPrice)).ToList();
		}

		public List<Product> ProductsUpMinPrice(List<Product> products, string minPrice) //проверка по минимальной цене
		{
			return products.Where(p => p.Price >= Convert.ToInt64(minPrice)).ToList();
		}

		public List<Product> ProductsFromMinToMaxPrice(List<Product> products, string minPrice, string maxPrice) //проверка по минимальной и максимальной цене
		{
			return products.Where(p => p.Price >= Convert.ToInt64(minPrice)).Where(p => p.Price <= Convert.ToInt64(maxPrice)).ToList();
		}


		public List<Product> FilterForLightSource(string lightSource, List<Product> products)
		{
			return products.Where(p => p.LightSource == lightSource).ToList();
		}

		public List<Product> FilterForColor(string color, List<Product> products)
		{
			return products.Where(p => p.Color == color).ToList();
		}

		public List<Product> FilterForSize(string size, List<Product> products)
		{
			return products.Where(p => p.Size == size).ToList();
		}
		public List<Product> FilterForModel(string model, List<Product> products)
		{
			return products.Where(p => p.ModelLight?.Name == model).ToList();
		}

		public List<Product> FilterForPower(string powerW, List<Product> products)
		{
			return products.Where(p => p.PowerW == powerW).ToList();
		}

		public List<Product> FilterForAddController(string dim, List<Product> products)
		{
			return products.Where(p => p.AddControl == dim).ToList();
		}
	}
}
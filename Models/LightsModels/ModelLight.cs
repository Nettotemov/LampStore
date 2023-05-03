using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json.Serialization;

namespace LampStore.Models
{
	public class ModelLight
	{
		[Key]
		public int ID { get; set; }

		[Required(ErrorMessage = "Пожалуйста, укажите значение")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите описание")]
		public string Description { get; set; }

		public string? Img { get; set; } = string.Empty;
		public bool IsAvailable { get; set; }
		public bool IsHomePage { get; set; }

		[BindNever]
		public ICollection<AdditionalBlocksForModelLight> AdditionalBlocks { get; set; } = new List<AdditionalBlocksForModelLight>();
		
		[BindNever]
		public ICollection<Product> Products { get; set; } = new List<Product>();

		[Required(ErrorMessage = "Пожалуйста, укажите коллекцию")]
		public int? CollectionLightID { get; set; }
		public CollectionLight CollectionModel { get; set; }

	}
}
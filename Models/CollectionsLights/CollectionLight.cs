using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LampStore.Models
{
	public class CollectionLight
	{
		[Key]
		public int ID { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите название")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите описание")]
		public string Description { get; set; }

		public string? Img { get; set; } = string.Empty;

		public bool IsAvailable { get; set; }
		public bool IsHomePage { get; set; }

		[BindNever]
		public ICollection<AdditionalBlocksForCollection> AdditionalBlocks { get; set; } = new List<AdditionalBlocksForCollection>();

		[BindNever]
		public ICollection<Product> Products { get; set; } = new List<Product>();
		
		[BindNever]
		public ICollection<ModelLight> ModelLights { get; set; } = new List<ModelLight>();


	}
}
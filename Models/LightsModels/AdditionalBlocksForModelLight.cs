using System.ComponentModel.DataAnnotations;
using LampStore.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LampStore.Models
{
	public class AdditionalBlocksForModelLight
	{
		[Key]
		public int ID { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите название")]
		public string Caption { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите описание")]
		public string Description { get; set; }
		public bool IsAvailable { get; set; }
		public string? Url { get; set; } = string.Empty;

		public AdditionalBlockType AdditionalBlockType { get; set; }

		public int ModelLightID { get; set; }
		public ModelLight ModelLight { get; set; }

	}
}
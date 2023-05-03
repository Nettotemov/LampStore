using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LampStore.Models
{
	public class EFModelLight : IModelLight
	{
		private StoreDbContext context;

		public EFModelLight(StoreDbContext ctx)
		{
			this.context = ctx;
		}

		public IQueryable<Product> Products => context.Products;
		public IQueryable<CollectionLight> CollectionLight => context.CollectionLights;
		public IQueryable<ModelLight> LightsModels => context.LightsModels;

		public IQueryable<AdditionalBlocksForModelLight> AdditionalBlocksInModelLight => context.AdditionalBlocksForModelLight;

		public void SaveModelLight(ModelLight model)
		{
			context.SaveChanges();
		}

		public void CreateModelLight(ModelLight model)
		{
			context.Add(model);
			context.SaveChanges();
		}

		public void DeleteModelLight(ModelLight model)
		{
			context.Remove(model);
			context.SaveChanges();
		}

		public void SaveAdditionalBlocksForModelLight(AdditionalBlocksForModelLight a)
		{
			context.SaveChanges();
		}

		public void CreateAdditionalBlocksForModelLight(AdditionalBlocksForModelLight a)
		{
			context.Add(a);
			context.SaveChanges();
		}

		public void DeleteAdditionalBlocksForModelLight(AdditionalBlocksForModelLight a)
		{
			context.Remove(a);
			context.SaveChanges();
		}
	}
}
using Microsoft.EntityFrameworkCore;

namespace LampStore.Models
{
	public class EFCollectionLight : ICollectionLight
	{
		private StoreDbContext context;

		public EFCollectionLight(StoreDbContext ctx)
		{
			this.context = ctx;
		}

		public IQueryable<CollectionLight> CollectionLight => context.CollectionLights;
		public IQueryable<Product> Products => context.Products.Include(p => p.ModelLight);

		public IQueryable<ModelLight> LightsModels => context.LightsModels;

		public IQueryable<AdditionalBlocksForCollection> AdditionalBlocksInCollection => context.AdditionalBlocksForCollection;

		public void CreateAdditionalBlocksForCollection(AdditionalBlocksForCollection a)
		{
			context.Add(a);
			context.SaveChanges();
		}

		public void CreateCollection(CollectionLight c)
		{
			context.Add(c);
			context.SaveChanges();
		}

		public void DeleteAdditionalBlocksForCollection(AdditionalBlocksForCollection a)
		{
			context.Remove(a);
			context.SaveChanges();
		}

		public void DeleteCollection(CollectionLight c)
		{
			context.Remove(c);
			context.SaveChanges();
		}

		public void SaveAdditionalBlocksForCollection(AdditionalBlocksForCollection a)
		{
			context.SaveChanges();
		}

		public void SaveCollection(CollectionLight c)
		{
			context.SaveChanges();
		}
	}
}
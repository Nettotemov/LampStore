namespace LampStore.Models
{
	public interface ICollectionLight
	{
		IQueryable<CollectionLight> CollectionLight { get; }
		IQueryable<Product> Products { get; }
		IQueryable<ModelLight> LightsModels { get; }
		IQueryable<AdditionalBlocksForCollection> AdditionalBlocksInCollection { get; }
		
		void SaveCollection(CollectionLight c);
		void CreateCollection(CollectionLight c);
		void DeleteCollection(CollectionLight c);


		void SaveAdditionalBlocksForCollection(AdditionalBlocksForCollection a);
		void CreateAdditionalBlocksForCollection(AdditionalBlocksForCollection a);
		void DeleteAdditionalBlocksForCollection(AdditionalBlocksForCollection a);

	}
}
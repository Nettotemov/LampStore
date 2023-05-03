namespace LampStore.Models
{
	public interface IModelLight
	{
		IQueryable<CollectionLight> CollectionLight { get; }
		IQueryable<Product> Products { get; }
		IQueryable<ModelLight> LightsModels { get; }
		IQueryable<AdditionalBlocksForModelLight> AdditionalBlocksInModelLight { get; }

		void SaveModelLight(ModelLight model);
		void CreateModelLight(ModelLight model);
		void DeleteModelLight(ModelLight model);


		void SaveAdditionalBlocksForModelLight(AdditionalBlocksForModelLight a);
		void CreateAdditionalBlocksForModelLight(AdditionalBlocksForModelLight a);
		void DeleteAdditionalBlocksForModelLight(AdditionalBlocksForModelLight a);

	}
}
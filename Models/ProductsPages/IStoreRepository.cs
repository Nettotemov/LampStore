namespace LampStore.Models
{
	public interface IStoreRepository
	{
		IQueryable<Product> Products { get; }
		IQueryable<Category> Category { get; }
		IQueryable<Tag> Tags { get; }
		IQueryable<ProductType> Types { get; }
		IQueryable<CollectionLight> CollectionsModels { get; }
		IQueryable<ModelLight> LightsModels { get; }

		void SaveProduct(Product p);
		void CreateProduct(Product p);
		void DeleteProduct(Product p);

		void SaveTag(Tag t);
		void CreateTag(Tag t);
		void DeleteTag(Tag t);

		void SaveType(ProductType type);
		void CreateType(ProductType type);
		void DeleteType(ProductType type);
	}
}
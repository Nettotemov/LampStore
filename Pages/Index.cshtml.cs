﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using LampStore.Models;
using Microsoft.EntityFrameworkCore;

namespace LampStore.Pages;

public class IndexModel : PageModel
{
	private IAboutPageRepository aboutRepository;
	private ICategoryRepository categoryRepository;
	private ICollectionLight collectionsRepository;
	private IModelLight lightsModelsRepository;

	public IndexModel(IAboutPageRepository aboutRepo, ICategoryRepository categoryRepo, ICollectionLight collectionsRepo, IModelLight lightsModelsRepo)
	{
		aboutRepository = aboutRepo;
		categoryRepository = categoryRepo;
		collectionsRepository = collectionsRepo;
		lightsModelsRepository = lightsModelsRepo;
	}
	public List<AboutPage> DisplayAboutPages { get; private set; } = new();
	public List<Category> DisplayCategory { get; private set; } = new();
	public List<CollectionLight> DisplayCollectionsPages { get; private set; } = new();
	public List<ModelLight> DisplayLightsModelsPages { get; private set; } = new();

	public int countNode = 0;

	public async Task OnGetAsync()
	{
		DisplayAboutPages = await aboutRepository.AboutPages.Where(p => p.DisplayHomePage == true).ToListAsync();
		DisplayCategory = await categoryRepository.Categorys.Where(c => c.DisplayHomePage == true).ToListAsync();
		DisplayCollectionsPages = await collectionsRepository.CollectionLight.Where(c => c.IsAvailable == true && c.IsHomePage == true).ToListAsync();
		DisplayLightsModelsPages = await lightsModelsRepository.LightsModels.Where(c => c.IsAvailable == true && c.IsHomePage == true).ToListAsync();
	}
}

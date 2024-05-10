using BethanyPieShop.Models;
using BethanyPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Controllers
{
	public class PieController : Controller
	{
		private readonly IPieRepository _pieRepository;
		private readonly ICategoryRepository _categoryRepository;

		public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
			_pieRepository = pieRepository;
		}

		public IActionResult List()
		{
			//ViewBag.CurrentCategory = "Cheese Cakes";
			//return View(_pieRepository.AllPies);
			PieListViewModel pieListViewModel = new PieListViewModel(_pieRepository.AllPies, "Cheese Cakes");
			return View(pieListViewModel);
		}
	}
}

using Microsoft.AspNetCore.Mvc;
using ProPublicAPI.Interfaces;
using ProPublicAPI.Models;
using ProPublicAPI.Services;

namespace ProPublicAPI.Controllers
{
    [Route("organization")]
    public class OrganizationController : Controller
    {
        private readonly INonprofitService _nonprofitService;

        public OrganizationController(INonprofitService nonprofitService)
        {
            _nonprofitService = nonprofitService;
        }

        public IActionResult Index()
        {
            return View(new NonProfitOrganizations());
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search(string query, int page = 0, int perPage = 100)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                ViewBag.Error = "Please enter a search term.";
                return View("Index", new NonProfitOrganizations());
            }

            var results = await _nonprofitService.SearchNonProfitsAsync(query, page, perPage);
            ViewData["Query"] = query;
            if (results==null)
            {
                return View("Index", new NonProfitOrganizations());
            }
            return View("Index", results);
        }

        [HttpGet("{ein}")]
        public async Task<IActionResult> GetOrganization(string ein)
        {
            var data = await _nonprofitService.GetOrganizationDetailAsync(ein);
            if (data == null)
            {
                ViewBag.Error = "Organization not found.";
            }

            return View("OrganizationDetail", data);
        }
    }
}

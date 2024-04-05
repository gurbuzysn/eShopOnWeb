using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopWeb.Infrastructure.Identity;

namespace Microsoft.eShopWeb.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize]
[Route("[controller]/[action]")]
public class AdminController : Controller
{
    public IActionResult Dashboard()
    {
        return View();
    }

    public async Task<IActionResult> OrderList()
    {


        return View();
    }
}

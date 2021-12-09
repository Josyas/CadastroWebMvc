using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroWebMvc.Services;

namespace CadastroWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellersService;

        public SellersController(SellerService sellerService)
        {
            _sellersService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellersService.FindAll(); // Retornar uma lista Seller
            return View(list);
        }
    }
}

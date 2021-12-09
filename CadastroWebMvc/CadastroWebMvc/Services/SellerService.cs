using CadastroWebMvc.Data;
using CadastroWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroWebMvc.Services
{
    public class SellerService
    {
        private readonly CadastroWebMvcContext _context;

        public SellerService(CadastroWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}

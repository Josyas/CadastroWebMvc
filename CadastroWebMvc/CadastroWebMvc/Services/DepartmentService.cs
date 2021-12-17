using CadastroWebMvc.Data;
using CadastroWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CadastroWebMvc.Services
{
    public class DepartmentService
    {
        private readonly CadastroWebMvcContext _context;

        public DepartmentService(CadastroWebMvcContext context)
        {
            _context = context;
        }

        //Retornar todos departamentos
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(X => X.Name).ToListAsync();
        }

    }
}


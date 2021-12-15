using CadastroWebMvc.Data;
using CadastroWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;


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
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

        internal object FindById(int value)
        {
            throw new NotImplementedException();
        }
    }
}

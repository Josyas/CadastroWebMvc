using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroWebMvc.Models;

namespace CadastroWebMvc.Data
{
    public class CadastroWebMvcContext : DbContext
    {
        public CadastroWebMvcContext (DbContextOptions<CadastroWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroWebMvc.Models.Department> Department { get; set; }
    }
}

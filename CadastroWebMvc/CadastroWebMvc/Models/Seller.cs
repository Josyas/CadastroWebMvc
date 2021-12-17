using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace CadastroWebMvc.Models
{
    public class Seller
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }

        
        [Required(ErrorMessage = "{0} required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double BaseSalary { get; set; } 

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>(); //Lista de vendas associada com o vendedroe

        public Seller()
        {
        }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        } 
        
        //Adicionar uma venda na lista de venda
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        //Remover uma venda na lista de venda
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        //Retornar o total de vendas nos periodo inicial e final
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}

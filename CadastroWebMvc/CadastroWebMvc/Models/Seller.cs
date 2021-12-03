using System;
using System.Collections.Generic;
using System.Linq;
namespace CadastroWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>(); //Lista de vendas associada com o vendedroe

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthdate, double basesalary, Department department)
        {
            Id = id;
            Name = name;
            BirthDate = birthdate;
            BaseSalary = basesalary;
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

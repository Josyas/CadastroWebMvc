using System;
using System.Collections.Generic;
using System.Linq;
namespace CadastroWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(string name)
        {
            
            Name = name;
            
        }


        /// Adicionar o vendedor na lista seller
        public void AddSeler(Seller seller)
        {
            Sellers.Add(seller);
        }

        //Calcular o total de vendas do departamento no perido inicial e final
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(Seller => Seller.TotalSales(initial, final));
        }
    }
}

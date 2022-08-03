using System;
using System.Linq;
using System.Collections.Generic;

namespace VendasMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double SalarioBase { get; set; }
        public DateTime DataNascimento { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, double salarioBase, DateTime dataNascimento, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            SalarioBase = salarioBase;
            DataNascimento = dataNascimento;
            Departamento = departamento;
        }

        public void AddVenda(Vendas venda)
        {
            Vendas.Add(venda);
        }

        public void ExcluirVenda(Vendas venda)
        {
            Vendas.Remove(venda);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendas.Where(venda => venda.Data >= inicial && venda.Data <= final).Sum(venda => venda.Valor);
        }
    }
}

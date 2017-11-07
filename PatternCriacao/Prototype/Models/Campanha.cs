using Prototype.Models.Interfaces;
using System;
using System.Text;

namespace Prototype.Models
{
    public class Campanha : IPrototype<Campanha>
    {
        public Guid     IdCampanha { get; private set; }
        public DateTime Vencimento { get; private set; }
        public String   Nome       { get; private set; }
        
        public Campanha(String nome, DateTime vencimento)
        {
            this.Nome = nome;
            this.Vencimento = vencimento;
            this.IdCampanha = Guid.NewGuid();
        }
        public Campanha Clone()
        {
            var nome = "Cópia da campanha " + this.Nome;
            var vencimento = this.Vencimento.AddDays(10); 
            return new Campanha(nome, vencimento);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("-------------");
            builder.Append("\n");
            builder.Append("Id:");
            builder.Append(this.IdCampanha);
            builder.Append("\n");

            builder.Append("-------------");
            builder.Append("\n");
            builder.Append("Nome da Campanha: ");
            builder.Append(this.Nome);
            builder.Append("\n");
            
            builder.Append("------------------");
            builder.Append("\n");
            builder.Append("Data de Vencimento: ");
            builder.Append(this.Vencimento.ToString("dd/MM/yyyy hh:mm:ss"));

            return builder.ToString();
        }
    }
}

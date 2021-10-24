using Gerenciador.Entregas.Core.Models;
using System.Collections.Generic;

namespace Entregas.Dominio.Models
{
    public class Estabelecimento : Entity
    {
        public string RazaoSocial { get; set; }
        public virtual List<Produto> Produtos { get; set; }
        public virtual List<Entrega> Entregas { get; set; }
        public string Cnpj { get; set; }
    }
}
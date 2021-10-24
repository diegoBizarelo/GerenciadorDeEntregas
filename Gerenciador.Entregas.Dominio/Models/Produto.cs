using Gerenciador.Entregas.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entregas.Dominio.Models
{
    public class Produto : Entity
    {
        public Guid EstabelecimentoId { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ProdutosEntrega> Entregas { get; } = new List<ProdutosEntrega>();
    }
}

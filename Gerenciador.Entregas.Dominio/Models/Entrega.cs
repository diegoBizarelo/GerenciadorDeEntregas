using Gerenciador.Entregas.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entregas.Dominio.Models
{
    public class Entrega :  Entity
    {
        public Entregador Entregador { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
        public Endereco Endereco { get; set; }
        public Guid EnderecoId { get; set; }
        public Guid EntregadorId { get; set; }
        public Guid EstabelecimentoId { get; set; }
        public virtual ICollection<ProdutosEntrega> Produtos { get; } = new List<ProdutosEntrega>();
    }
}

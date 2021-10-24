using Gerenciador.Entregas.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entregas.Dominio.Models
{
    public class ProdutosEntrega : Entity
    {
        public Guid ProdutoId { get; set; }
        public Guid EntregaId { get; set; }
        public Entrega Entrega { get; set; }
        public Produto Produto { get; set; }
    }
}

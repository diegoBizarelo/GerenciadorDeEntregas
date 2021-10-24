using Gerenciador.Entregas.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entregas.Dominio.Models
{
    public class Entregador : Entity
    {
        public string Nome { get; set; }
        public string Transporte { get; set; }
        public bool Disponivel { get; set; }
        public virtual List<Entrega> Entregas { get; set; }
    }
}

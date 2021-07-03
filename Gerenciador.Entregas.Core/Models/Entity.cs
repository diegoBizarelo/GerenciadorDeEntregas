using System;

namespace Gerenciador.Entregas.Core.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}

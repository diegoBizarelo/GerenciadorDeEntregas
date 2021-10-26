using Entregas.Data.Context;
using Entregas.Dominio.Models;
using Entregas.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entregas.Data.Repository
{
    public class EntregadorRepository : BaseRepository<Entregador>, IEntregadorRepository
    {
        public EntregadorRepository(EntregasContext context) : base(context)
        {

        }
    }
}

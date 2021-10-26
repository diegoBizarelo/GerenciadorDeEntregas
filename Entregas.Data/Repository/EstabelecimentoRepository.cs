using Entregas.Data.Context;
using Entregas.Dominio.Models;
using Entregas.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entregas.Data.Repository
{
    public class EstabelecimentoRepository : BaseRepository<Estabelecimento>, IEstabelecimentoRepository
    {
        public EstabelecimentoRepository(EntregasContext context) : base(context)
        {

        }
    }
}

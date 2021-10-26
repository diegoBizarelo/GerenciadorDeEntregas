﻿using Entregas.Data.Context;
using Entregas.Dominio.Models;
using Entregas.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entregas.Data.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(EntregasContext context) : base(context)
        {

        }
    }
}

using Entregas.Data.Context;
using Entregas.Data.Repository;
using Entregas.Dominio.Models;
using Entregas.Dominio.Repository;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entregas.ServiceTests
{
    public class TesteEntregadorRepository
    {
        private List<Entregador> _entregadores { get; } = new List<Entregador>();
        public TesteEntregadorRepository()
        {
            _entregadores.AddRange(
                new List<Entregador>() {
                    new Entregador
                    {
                        Id = Guid.NewGuid(),
                        Disponivel = false,
                        Entregas = new List<Entrega>(),
                        Nome = "Pedro",
                        Transporte = "Moto",
                        DataCriacao = DateTime.Now
                    },
                    new Entregador
                    {
                        Id = Guid.NewGuid(),
                        Disponivel = false,
                        Entregas = new List<Entrega>(),
                        Nome = "Pedro",
                        Transporte = "Moto",
                        DataCriacao = DateTime.Now
                    },
                    new Entregador
                    {
                        Id = Guid.NewGuid(),
                        Disponivel = false,
                        Entregas = new List<Entrega>(),
                        Nome = "InuYasha",
                        Transporte = "Moto",
                        DataCriacao = DateTime.Now
                    }
                    ,
                    new Entregador
                    {
                        Id = Guid.NewGuid(),
                        Disponivel = false,
                        Entregas = new List<Entrega>(),
                        Nome = "Paulo",
                        Transporte = "Moto",
                        DataCriacao = DateTime.Now
                    },
                    new Entregador
                    {
                        Id = Guid.NewGuid(),
                        Disponivel = false,
                        Entregas = new List<Entrega>(),
                        Nome = "Augusto",
                        Transporte = "Moto",
                        DataCriacao = DateTime.Now
                    } 
                });
        }
        [Fact]
        public async Task CadastraEntregadorHandleExcute()
        {
            var options = new DbContextOptionsBuilder<EntregasContext>()
                .UseInMemoryDatabase("MeuContexto").Options;

            var contexto = new EntregasContext(options);
            var repo = new EntregadorRepository(contexto);

            foreach (var e in _entregadores) {
                await repo.Adicionar(e);
            }
            Assert.Equal(5, repo.ObterTodos().Result.Count);
        }

        [Fact]
        public async Task QuandoExceptionForLancadaResultadoDeveSerFalso()
        {
            var mock = new Mock<IEntregadorRepository>();
            mock.Setup(r => r.Adicionar(It.IsAny<Entregador>()))
                .Throws(new Exception("Houve um erro na inclusão de entregador"));

            var repo = mock.Object;

            Assert.Throws<Exception>(() => repo.Adicionar(new Entregador()).RunSynchronously());
        }
    }
}

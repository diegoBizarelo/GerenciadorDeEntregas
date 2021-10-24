using Gerenciador.Entregas.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entregas.Dominio.Models
{
    public class User : Entity
    {
        public String Email { get; set; }
        public String Password { get; set; }
    }
}

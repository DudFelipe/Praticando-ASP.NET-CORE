using GestaoClientes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoClientes.Domain.Models
{
    public class TiposDeClientes : EntityBase
    {
        public TiposDeClientes()
        {

        }

        public string Descricao { get; set; }
    }
}

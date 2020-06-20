using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoClientes.Domain.Entities
{
    public class EntityBase
    {

        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}

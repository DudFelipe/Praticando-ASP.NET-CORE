using GestaoClientes.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoClientes.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<TiposDeClientes> TiposDeClientes { get; set; }
    }
}

using GestaoClientes.Domain.Entities;
using GestaoClientes.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoClientes.Domain.Models
{
    public class Cliente : EntityBase
    {
        public Cliente()
        {
            DataCadastro = DateTime.Now;
        }

        [ForeignKey("TiposDeCliente")]
        [Display(Name = "Tipo de Cliente")]
        public Guid TiposDeClientesId { get; set; }
        public virtual TiposDeClientes TipoDeCliente { get; set; }

        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; } = true;
    }
}

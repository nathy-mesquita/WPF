using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ControleClientes.Core.Entities;

namespace ControleClientes.Models.InputModels
{
    public class UpdatePessoaInputModel
    {
        [Required(ErrorMessage = "Cpf Obrigatório!")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Endereço Obrigatório!")]
        public IList<Endereco> Enderecos { get; set; }
    }
}

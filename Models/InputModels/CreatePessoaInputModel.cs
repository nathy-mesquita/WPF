using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ControleClientes.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ControleClientes.Models.InputModels
{
    public class CreatePessoaInputModel
    {
        [Required(ErrorMessage = "Nome Obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sobrenome Obrigatório!")]
        public string Sobrenome { get; set; }

        [StringLength(11, ErrorMessage = "Cpf inválido!")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Data de nascimento Obrigatório!")]
        public DateTime DataNascimento { get; set; }

        public char Genero { get; set; }

        [Required(ErrorMessage = "Endereço Obrigatório!")]
        public IList<Endereco> Enderecos { get; set; }
    }
}

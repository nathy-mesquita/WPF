using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ControleClientes.Core.Entities
{
    public class Pessoa : BaseEntity
    {
        public Pessoa(string nome, string sobrenome, string cpf, DateTime dataNascimento, char genero, IEnumerable<Endereco> endereco) : base()
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Genero = genero;

            this.Enderecos = new List<Endereco>();
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public char Genero { get; private set; }
        public IEnumerable<Endereco> Enderecos { get; set; }

        public int CalculaIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }
    }
}

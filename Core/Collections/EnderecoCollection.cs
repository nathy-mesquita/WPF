using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using ControleClientes.Core.Entities;

namespace ControleClientes.Core.Collections
{
    public class EnderecoCollection : CollectionBase
    {
        public List<Endereco> LoadEndereco()
        {
            List<Endereco> enderecos = new List<Endereco>();
            enderecos.Add(new Endereco()
            {
               Tipo = TipoEndereco.Cobranca,
               Logradouro = "Rua itapiru",
               Numero = 33,
               Complemento = "casa",
               Bairro = "Catumbi",
               Cidade = "Rio de janeiro",
               Estado= "RJ",
               Cep = "20211290",
               IdPessoa =1
                
            });
            enderecos.Add(new Endereco()
            {
                Tipo = TipoEndereco.Comercial,
                Logradouro = "Av das Americas",
                Numero = 33,
                Complemento = "trabalho",
                Bairro = "Barra",
                Cidade = "Rio de janeiro",
                Estado = "RJ",
                Cep = "20211290",
                IdPessoa = 1
            });
            enderecos.Add(new Endereco()
            {
                Tipo = TipoEndereco.Residencial,
                Logradouro = "Rua itapiru",
                Numero = 77,
                Complemento = "casa",
                Bairro = "Catumbi",
                Cidade = "Rio de janeiro",
                Estado = "RJ",
                Cep = "20251030",
                IdPessoa = 1
            });
            return enderecos;
        }
    }
}

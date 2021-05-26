using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_WF_Telefone
{
    class Cliente
    {
        private string _nome;
        private string _cpf;
        private string _telefone;
        private string _cep;
        private string _estado;
        private string _cidade;
        private string _rua;
        private string _numero;
        private string _complemento;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Cep { get => _cep; set => _cep = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Rua { get => _rua; set => _rua = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Complemento { get => _complemento; set => _complemento = value; }

        public Cliente(string nome, string cpf, string telefone, string cep, string estado,
            string cidade, string rua, string numero, string complemento)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Cep = cep;
            Estado = estado;
            Cidade = cidade;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
        }
    }
}

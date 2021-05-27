using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_WF_Telefone
{
    class Linha
    {
        private string _numeroLinha;
        private string _dataContratacao;
        private bool _isAtivo;
        private int _idCliente;
        private int _idPlano;

        public string NumeroLinha { get => _numeroLinha; set => _numeroLinha = value; }
        public string DataContratacao { get => _dataContratacao; set => _dataContratacao = value; }
        public bool IsAtivo { get => _isAtivo; set => _isAtivo = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdPlano { get => _idPlano; set => _idPlano = value; }

        public Linha(int idcliente, int idplano, string numeroLinha, string dataContratacao)
        {
            IdCliente = idcliente;
            IdPlano = idplano;
            NumeroLinha = numeroLinha;
            DataContratacao = dataContratacao;
            IsAtivo = true;
        }
    }
}

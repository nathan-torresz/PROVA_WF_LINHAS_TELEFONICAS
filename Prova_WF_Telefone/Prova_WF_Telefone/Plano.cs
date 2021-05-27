using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Prova_WF_Telefone
{
    class Plano
    {
        private string _nome;
        private string _franquia;
        private string _conteudo;
        private string _caracteristica;
        private string mensalidade;
        

        public string Nome { get => _nome; set => _nome = value; }
        public string Franquia { get => _franquia; set => _franquia = value; }
        public string Conteudo { get => _conteudo; set => _conteudo = value; }
        public string Caracteristica { get => _caracteristica; set => _caracteristica = value; }
        public string Mensalidade { get => mensalidade; set => mensalidade = value; }

        public Plano(string nome, string franquia, string conteudo, string caracteristica, string mensalidade)
        {
            Nome = nome;
            Franquia = franquia;
            Conteudo = conteudo;
            Caracteristica = caracteristica;
            Mensalidade = mensalidade;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Prova_WF_Telefone
{
    class BD
    {
        private static SqlConnection conexao = new SqlConnection();
        private static SqlCommand sql = new SqlCommand();

        public const int EXECUTE_NON_QUERY = 0;
        public const int EXECUTE_SCALAR = 1;

        private static SqlDataAdapter Inicializar()
        {
            conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Pacotes;Integrated Security=True";
            sql.Connection = conexao;
            SqlDataAdapter adapt = new SqlDataAdapter(sql.CommandText, conexao);
            return adapt;
        }

        public static int Executar(out SqlDataAdapter adapt, int metodo = EXECUTE_NON_QUERY)
        {
            adapt = Inicializar();
            int i = 0;
            conexao.Open();
            if(metodo == EXECUTE_NON_QUERY)
            {
                i = sql.ExecuteNonQuery();
            }
            else if (metodo == EXECUTE_SCALAR)
            {
                i = Convert.ToInt32(sql.ExecuteScalar() ?? -1);
            }
            conexao.Close();
            return i;
        }

        public static int Executar(int metodo = EXECUTE_NON_QUERY)
        {
            return Executar(out SqlDataAdapter adapt, metodo);
        }
        public static int CadastrarCliente(Cliente c)
        {
            sql = new SqlCommand();
            sql.CommandText = $"INSERT INTO Clientes (Nome, Cpf, Telefone, Cep, Estado, Cidade, Rua, Numero, Complemento) " +
                $"output INSERTED.Id " +
                $"VALUES (@nome, @cpf, @telefone, @cep, @estado, @cidade, @rua, @numero, @complemento)";
            sql.Parameters.AddWithValue("@nome", c.Nome);
            sql.Parameters.AddWithValue("@cpf", c.Cpf);
            sql.Parameters.AddWithValue("@telefone", c.Telefone);
            sql.Parameters.AddWithValue("@cep", c.Cep);
            sql.Parameters.AddWithValue("@estado", c.Estado);
            sql.Parameters.AddWithValue("@cidade", c.Cidade);
            sql.Parameters.AddWithValue("@rua", c.Rua);
            sql.Parameters.AddWithValue("@numero", c.Numero);
            sql.Parameters.AddWithValue("@complemento", c.Complemento);
            int linhasAfetadas = Executar();
            return linhasAfetadas;
        }
        public static SqlDataAdapter SelectClientes()
        {
            sql = new SqlCommand();
            sql.CommandText = "SELECT * FROM Clientes";
            int linhasAfetadas = Executar(out SqlDataAdapter adapt);
            return adapt;
        }
        public static SqlDataAdapter BuscarClientePorTelefone(string telefone)
        {
            sql = new SqlCommand();
            sql.CommandText = $"SELECT * FROM Clientes " +
                $"WHERE Telefone LIKE '%{telefone}%'";
            int linhasAfetadas = Executar(out SqlDataAdapter adapt);
            return adapt;
        }
        public static SqlDataAdapter BuscarClientePorNome(string nome)
        {
            sql = new SqlCommand();
            sql.CommandText = $"SELECT * FROM Clientes " +
                $"WHERE Nome LIKE '%{nome}%'";
            int linhasAfetadas = Executar(out SqlDataAdapter adapt);
            return adapt;
        }
        public static SqlDataAdapter BuscarClientePorCPF(string cpf)
        {
            sql = new SqlCommand();
            sql.CommandText = $"SELECT * FROM Clientes " +
                $"WHERE Cpf LIKE '%{cpf}%'";
            int linhasAfetadas = Executar(out SqlDataAdapter adapt);
            return adapt;
        }
        public static int EditarCliente(int id, Cliente c)
        {
            sql = new SqlCommand();
            sql.CommandText = $"UPDATE Clientes SET Nome = @nome, Telefone = @telefone, Estado = @estado, Cidade = @cidade, Cep = @cep, Rua = @rua, Numero = @numero, Complemento = @complemento " +
                $"WHERE Id = @id";
            sql.Parameters.AddWithValue("@nome", c.Nome);
            sql.Parameters.AddWithValue("@telefone", c.Telefone);
            sql.Parameters.AddWithValue("@estado", c.Estado);
            sql.Parameters.AddWithValue("@cidade", c.Cidade);
            sql.Parameters.AddWithValue("@cep", c.Cep);
            sql.Parameters.AddWithValue("@rua", c.Rua);
            sql.Parameters.AddWithValue("@numero", c.Numero);
            sql.Parameters.AddWithValue("@complemento", c.Complemento);
            sql.Parameters.AddWithValue("@id", id);
            int linhasAfetadas = Executar();
            return linhasAfetadas;
        }

        public static SqlDataAdapter SelectPlanos()
        {
            sql = new SqlCommand();
            sql.CommandText = "SELECT * FROM Planos";
            int linhasAfetadas = Executar(out SqlDataAdapter adapt);
            return adapt;
        }
        public static SqlDataAdapter SelectTelefone()
        {
            sql = new SqlCommand();
            sql.CommandText = "SELECT (Telefone) FROM Clientes";
            int linhasAfetadas = Executar(out SqlDataAdapter adapt);
            return adapt;
        }
        public static SqlDataAdapter RetornarLinhasCliente(int idCliente)
        {
            sql = new SqlCommand();
            sql.CommandText = $"SELECT ID id_Cliente, id_Plano, Numero, Data_de_contratacao, Ativo FROM Linhas WHERE id_Cliente = '{idCliente}'";
            Executar(out SqlDataAdapter adapt);
            return adapt;
        }
        public static void InserirLinha(Linha l)
        {
            sql = new SqlCommand();
            sql.CommandText = $"INSERT INTO Linhas (id_Cliente, id_Plano, Numero, Data_de_contratacao, Ativo) VALUES ('{l.IdCliente}', '{l.IdPlano}', '{l.NumeroLinha}', '{l.DataContratacao}', 1)";
            Executar(out SqlDataAdapter adaptador);
        }

    }
}

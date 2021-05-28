using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prova_WF_Telefone
{
    public partial class Form1 : Form
    {
        private FormAddCliente formaddcliente;
        private FormBuscaCliente formbuscarcliente;
        private FormIncluirLinhaTelefonica formincluir;
        private FormAterarPlano formalterarplano;
        public Form1()
        {
            InitializeComponent();
            formaddcliente = new FormAddCliente(this);
            formbuscarcliente = new FormBuscaCliente(this);
            formincluir = new FormIncluirLinhaTelefonica(this);
            formalterarplano = new FormAterarPlano(this);
        }

        private void incluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaddcliente.Show();
            this.Hide();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formbuscarcliente.Show();
            this.Hide();
        }

        public void Atualizar()
        {
            SqlDataAdapter adapt = null;
            try
            {
                adapt = BD.SelectClientes();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao buscar!");
            }
            finally
            {
                if (adapt != null)
                {
                    DataTable tabela = new DataTable();
                    adapt.Fill(tabela);
                    dgvClientes.DataSource = tabela;
                    dgvClientes.ClearSelection();
                }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int linhaSelecionada = dgvClientes.SelectedCells[0].RowIndex;
                int idcliente = (int)dgvClientes.Rows[linhaSelecionada].Cells[0].Value;

                Listar(idcliente);           
        }
        private void Listar(int idCliente)
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = BD.RetornarLinhasCliente(idCliente);
            }
            catch
            {
                MessageBox.Show("Erro ao buscar!");
            }
            finally
            {
                if (adaptador != null)
                {
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dgvLinhas.DataSource = tabela;
                }
                else MessageBox.Show("Erro ao buscar!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void incluirLinhaTelefônicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formincluir.Show();
            this.Hide();
        }

        private void btAtivar_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = dgvLinhas.SelectedCells[0].RowIndex;
            int idLinha = (int)dgvLinhas.Rows[LinhaSelecionada].Cells[0].Value;

            BD.AtivarLinha(idLinha);

            int linhaSelecionada1 = dgvClientes.SelectedCells[0].RowIndex;
            int idcliente = (int)dgvClientes.Rows[linhaSelecionada1].Cells[0].Value;

            Listar(idcliente);
        }

        private void btDesativar_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = dgvLinhas.SelectedCells[0].RowIndex;
            int idLinha = (int)dgvLinhas.Rows[LinhaSelecionada].Cells[0].Value;

            BD.DesativarLinha(idLinha);
            int linhaSelecionada1 = dgvClientes.SelectedCells[0].RowIndex;
            int idcliente = (int)dgvClientes.Rows[linhaSelecionada1].Cells[0].Value;

            Listar(idcliente);
        }

        private void modificarPlanoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formalterarplano.Show();
            this.Hide();
        }
    }
}

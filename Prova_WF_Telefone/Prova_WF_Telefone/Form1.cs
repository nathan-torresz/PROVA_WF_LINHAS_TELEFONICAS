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
        public Form1()
        {
            InitializeComponent();
        }

        private void incluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddCliente().Show();
            this.Hide();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormBuscaCliente().Show();
            this.Hide();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void Atualizar()
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
            if(dgvClientes.SelectedCells.Count > 0)
            {
                int linhaSelecionada = dgvClientes.SelectedCells[0].RowIndex;

            }
        }
    }
}

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
    public partial class FormIncluirLinhaTelefonica : Form
    {
        private Form1 form1;
        public FormIncluirLinhaTelefonica(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btInserirLinha_Click(object sender, EventArgs e)
        {
            
        }

        private void FormIncluirLinhaTelefonica_Load(object sender, EventArgs e)
        {
            Atualizar();
            AtualizarPlanos();
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

        private void AtualizarPlanos()
        {
            SqlDataAdapter adapt = null;
            try
            {
                adapt = BD.SelectPlanos();
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
                    dgvPlanos.DataSource = tabela;
                    dgvPlanos.ClearSelection();
                }
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btContratarLinha_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = dgvPlanos.SelectedCells[0].RowIndex;
            int idPlano = (int)dgvPlanos.Rows[LinhaSelecionada].Cells[0].Value;

            int LinhaSelecionada1 = dgvClientes.SelectedCells[0].RowIndex;
            int idCliente = (int)dgvClientes.Rows[LinhaSelecionada1].Cells[0].Value;

            string numero = (string)dgvClientes.Rows[LinhaSelecionada1].Cells[3].Value;

            DateTime hoje = DateTime.Now;

            BD.InserirLinha(new Linha(idCliente, idPlano, numero, $"{hoje.Day}/{hoje.Month}/{hoje.Year}"));
        }
    }
}

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
    public partial class FormAterarPlano : Form
    {
        private Form1 form1;
        public FormAterarPlano(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAterarPlano_Load(object sender, EventArgs e)
        {
            AtualizarPlanos();
            AtualizarLinhas();
        }
        private void AtualizarLinhas()
        {
            SqlDataAdapter adapt = null;
            try
            {
                adapt = BD.SelectLinhas();
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
                    dgvLinhas.DataSource = tabela;
                    dgvLinhas.ClearSelection();
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

        private void btAlteraPLano_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = dgvPlanos.SelectedCells[0].RowIndex;
            int idPlano = (int)dgvPlanos.Rows[LinhaSelecionada].Cells[0].Value;
           
            int LinhaSelecionada1 = dgvLinhas.SelectedCells[0].RowIndex;
            int idLinha = (int)dgvLinhas.Rows[LinhaSelecionada1].Cells[0].Value;

            BD.AlterarPlano(idLinha, idPlano);

            AtualizarLinhas();
            AtualizarPlanos();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
}

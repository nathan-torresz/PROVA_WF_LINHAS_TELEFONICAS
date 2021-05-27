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
    public partial class FormAlterarPlano : Form
    {
        private Form1 form1;
        public FormAlterarPlano(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        public void btAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        public void Atualizar()
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
                    dgvPlanosDisponiveis.DataSource = tabela;
                    dgvPlanosDisponiveis.ClearSelection();
                }
            }
        }

        private void dgvTelefone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(mbTelefone.Text.Length >= 11)
            {

            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (mbTelefone.Text.Length == 11)
            {
                SqlDataAdapter adapt = null;
                try
                {
                    adapt = BD.SelectTelefone();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro!");
                }
                finally
                {
                    if (adapt != null)
                    {
                        DataTable tabela = new DataTable();
                        adapt.Fill(tabela);
                        dgvTelefone.DataSource = tabela;
                        dgvTelefone.ClearSelection();
                    }
                }
            }
        }
        public void MostrarTelefone()
        {
            SqlDataAdapter adapt = null;
            try
            {
                adapt = BD.SelectTelefone();
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
                    dgvTelefone.DataSource = tabela;
                    dgvTelefone.ClearSelection();
                }
            }
        }
    }
}

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
    public partial class FormBuscaCliente : Form
    {
        private Form1 form1;
        public FormBuscaCliente(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void rbBuscarNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuscarNome.Checked)
            {
                lbBusca.Text = "Insira o Nome que procura!";
            }
        }

        private void rbBuscarCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuscarCPF.Checked)
            {
                lbBusca.Text = "Insira o CPF que procura!";
            }
        }

        private void rbBuscarTelefone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuscarTelefone.Checked)
            {
                lbBusca.Text = "Insira o Telefone que procura!";
            }
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            lbTabela.Text = "Lista de Clientes";
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            lbTabela.Text = "Tabela";
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes1.SelectedCells.Count > 0)
            {
                int linhaSelecionada = dgvClientes1.SelectedCells[0].RowIndex;

                gbIniciarBusca.Enabled = false;
                gbOpcoesBusca.Enabled = false;
                gbEditar.Enabled = true;

                tbNomeEditar.Text = dgvClientes1.Rows[linhaSelecionada].Cells[1].Value.ToString();
                mbTelefoneEditar.Text = dgvClientes1.Rows[linhaSelecionada].Cells[3].Value.ToString();
                mbCepEditar.Text = dgvClientes1.Rows[linhaSelecionada].Cells[4].Value.ToString();
                tbEstadoEditar.Text = dgvClientes1.Rows[linhaSelecionada].Cells[5].Value.ToString();
                tbCidadeEditar.Text = dgvClientes1.Rows[linhaSelecionada].Cells[6].Value.ToString();
                tbRuaEditar.Text = dgvClientes1.Rows[linhaSelecionada].Cells[7].Value.ToString();
                tbNumeroEditar.Text = dgvClientes1.Rows[linhaSelecionada].Cells[8].Value.ToString();
                cbComplementoEditar.Text = dgvClientes1.Rows[linhaSelecionada].Cells[9].Value.ToString();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (rbBuscarTelefone.Checked)
            {
                SqlDataAdapter adapt = null;
                try
                {
                    adapt = BD.BuscarClientePorTelefone(tbBusca.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro!");
                }
                finally
                {
                    if (adapt != null)
                    {
                        DataTable tabela = new DataTable();
                        adapt.Fill(tabela);
                        dgvClientes1.DataSource = tabela;
                        dgvClientes1.ClearSelection();
                    }
                }
            }
            if (rbBuscarNome.Checked)
            {
                SqlDataAdapter adapt = null;
                try
                {
                    adapt = BD.BuscarClientePorNome(tbBusca.Text);
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
                        dgvClientes1.DataSource = tabela;
                        dgvClientes1.ClearSelection();
                    }
                }
            }
            if (rbBuscarCPF.Checked)
            {
                SqlDataAdapter adapt = null;
                try
                {
                    adapt = BD.BuscarClientePorCPF(tbBusca.Text);
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
                        dgvClientes1.DataSource = tabela;
                        dgvClientes1.ClearSelection();
                    }
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                int linhaSelecionada = dgvClientes1.SelectedCells[0].RowIndex;
                int idCliente = (int)dgvClientes1.Rows[linhaSelecionada].Cells[0].Value;

                string cpf = null;
                i = BD.EditarCliente(idCliente, new Cliente(tbNomeEditar.Text, cpf, mbTelefoneEditar.Text,mbCepEditar.Text,
                    tbEstadoEditar.Text, tbCidadeEditar.Text, tbRuaEditar.Text, tbNumeroEditar.Text, cbComplementoEditar.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar!");
            }
            finally
            {
                if (i > 0)
                {
                    MessageBox.Show("Alteração concluída com êxito!");
                    tbNomeEditar.Clear();
                    tbNumeroEditar.Clear();
                    tbRuaEditar.Clear();
                    tbEstadoEditar.Clear();
                    mbCepEditar.Clear();
                    mbTelefoneEditar.Clear();

                    gbIniciarBusca.Enabled = true;
                    gbEditar.Enabled = false;

                    dgvClientes1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Erro ao editar!");
                }
            }
            Atualizar();
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
                    dgvClientes1.DataSource = tabela;
                    dgvClientes1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Erro ao buscar!");
                }
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
            gbEditar.Enabled = false;
            gbIniciarBusca.Enabled = true;
            gbOpcoesBusca.Enabled = true;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
}

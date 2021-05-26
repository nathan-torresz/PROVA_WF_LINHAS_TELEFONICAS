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
    public partial class FormAddCliente : Form
    {
        public FormAddCliente()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                i = BD.CadastrarCliente(new Cliente(mtNome.Text, mtCpf.Text, mtTelefone.Text, mtCEP.Text,
                    tbEstado.Text, tbCidade.Text, tbRua.Text,
                    tbNumero.Text, cbComplemento.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar cliente!");
            }
            finally
            {
                if (i > 0)
                {
                    MessageBox.Show($"Cadastro de {mtNome.Text} realizado com sucesso!");
                    mtNome.Clear();
                    mtTelefone.Clear();
                    mtCpf.Clear();
                    mtCEP.Clear();
                    tbCidade.Clear();
                    tbEstado.Clear();
                    tbNumero.Clear();
                    tbRua.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar cliente!");
                }
            }
        }
    }
}

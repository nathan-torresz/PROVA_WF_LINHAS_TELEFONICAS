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
                    dataGridView1.DataSource = tabela;
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
}

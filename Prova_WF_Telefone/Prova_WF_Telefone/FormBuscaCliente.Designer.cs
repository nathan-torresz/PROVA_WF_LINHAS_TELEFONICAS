namespace Prova_WF_Telefone
{
    partial class FormBuscaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClientes1 = new System.Windows.Forms.DataGridView();
            this.gbOpcoesBusca = new System.Windows.Forms.GroupBox();
            this.rbBuscarTelefone = new System.Windows.Forms.RadioButton();
            this.rbBuscarCPF = new System.Windows.Forms.RadioButton();
            this.rbBuscarNome = new System.Windows.Forms.RadioButton();
            this.gbIniciarBusca = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.lbBusca = new System.Windows.Forms.Label();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.lbTabela = new System.Windows.Forms.Label();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.mbCepEditar = new System.Windows.Forms.MaskedTextBox();
            this.mbTelefoneEditar = new System.Windows.Forms.MaskedTextBox();
            this.cbComplementoEditar = new System.Windows.Forms.ComboBox();
            this.tbNumeroEditar = new System.Windows.Forms.TextBox();
            this.tbRuaEditar = new System.Windows.Forms.TextBox();
            this.tbCidadeEditar = new System.Windows.Forms.TextBox();
            this.tbEstadoEditar = new System.Windows.Forms.TextBox();
            this.tbNomeEditar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes1)).BeginInit();
            this.gbOpcoesBusca.SuspendLayout();
            this.gbIniciarBusca.SuspendLayout();
            this.gbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes1
            // 
            this.dgvClientes1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes1.Location = new System.Drawing.Point(378, 39);
            this.dgvClientes1.Name = "dgvClientes1";
            this.dgvClientes1.RowHeadersWidth = 51;
            this.dgvClientes1.RowTemplate.Height = 24;
            this.dgvClientes1.Size = new System.Drawing.Size(519, 301);
            this.dgvClientes1.TabIndex = 0;
            this.dgvClientes1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            this.dgvClientes1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            this.dgvClientes1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            // 
            // gbOpcoesBusca
            // 
            this.gbOpcoesBusca.Controls.Add(this.rbBuscarTelefone);
            this.gbOpcoesBusca.Controls.Add(this.rbBuscarCPF);
            this.gbOpcoesBusca.Controls.Add(this.rbBuscarNome);
            this.gbOpcoesBusca.Location = new System.Drawing.Point(12, 208);
            this.gbOpcoesBusca.Name = "gbOpcoesBusca";
            this.gbOpcoesBusca.Size = new System.Drawing.Size(360, 153);
            this.gbOpcoesBusca.TabIndex = 1;
            this.gbOpcoesBusca.TabStop = false;
            this.gbOpcoesBusca.Text = "Opções de Busca";
            // 
            // rbBuscarTelefone
            // 
            this.rbBuscarTelefone.AutoSize = true;
            this.rbBuscarTelefone.Location = new System.Drawing.Point(6, 111);
            this.rbBuscarTelefone.Name = "rbBuscarTelefone";
            this.rbBuscarTelefone.Size = new System.Drawing.Size(85, 21);
            this.rbBuscarTelefone.TabIndex = 2;
            this.rbBuscarTelefone.TabStop = true;
            this.rbBuscarTelefone.Text = "Telefone";
            this.rbBuscarTelefone.UseVisualStyleBackColor = true;
            this.rbBuscarTelefone.CheckedChanged += new System.EventHandler(this.rbBuscarTelefone_CheckedChanged);
            // 
            // rbBuscarCPF
            // 
            this.rbBuscarCPF.AutoSize = true;
            this.rbBuscarCPF.Location = new System.Drawing.Point(6, 70);
            this.rbBuscarCPF.Name = "rbBuscarCPF";
            this.rbBuscarCPF.Size = new System.Drawing.Size(55, 21);
            this.rbBuscarCPF.TabIndex = 1;
            this.rbBuscarCPF.TabStop = true;
            this.rbBuscarCPF.Text = "CPF";
            this.rbBuscarCPF.UseVisualStyleBackColor = true;
            this.rbBuscarCPF.CheckedChanged += new System.EventHandler(this.rbBuscarCPF_CheckedChanged);
            // 
            // rbBuscarNome
            // 
            this.rbBuscarNome.AutoSize = true;
            this.rbBuscarNome.Checked = true;
            this.rbBuscarNome.Location = new System.Drawing.Point(6, 32);
            this.rbBuscarNome.Name = "rbBuscarNome";
            this.rbBuscarNome.Size = new System.Drawing.Size(66, 21);
            this.rbBuscarNome.TabIndex = 0;
            this.rbBuscarNome.TabStop = true;
            this.rbBuscarNome.Text = "Nome";
            this.rbBuscarNome.UseVisualStyleBackColor = true;
            this.rbBuscarNome.CheckedChanged += new System.EventHandler(this.rbBuscarNome_CheckedChanged);
            // 
            // gbIniciarBusca
            // 
            this.gbIniciarBusca.Controls.Add(this.btBuscar);
            this.gbIniciarBusca.Controls.Add(this.lbBusca);
            this.gbIniciarBusca.Controls.Add(this.tbBusca);
            this.gbIniciarBusca.Location = new System.Drawing.Point(12, 14);
            this.gbIniciarBusca.Name = "gbIniciarBusca";
            this.gbIniciarBusca.Size = new System.Drawing.Size(360, 188);
            this.gbIniciarBusca.TabIndex = 2;
            this.gbIniciarBusca.TabStop = false;
            this.gbIniciarBusca.Text = "iniciarBusca";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(138, 126);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // lbBusca
            // 
            this.lbBusca.AutoSize = true;
            this.lbBusca.Location = new System.Drawing.Point(88, 60);
            this.lbBusca.Name = "lbBusca";
            this.lbBusca.Size = new System.Drawing.Size(179, 17);
            this.lbBusca.TabIndex = 1;
            this.lbBusca.Text = "Insira o Nome que procura!";
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(55, 98);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(241, 22);
            this.tbBusca.TabIndex = 0;
            // 
            // lbTabela
            // 
            this.lbTabela.AutoSize = true;
            this.lbTabela.Location = new System.Drawing.Point(379, 13);
            this.lbTabela.Name = "lbTabela";
            this.lbTabela.Size = new System.Drawing.Size(52, 17);
            this.lbTabela.TabIndex = 3;
            this.lbTabela.Text = "Tabela";
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.mbCepEditar);
            this.gbEditar.Controls.Add(this.mbTelefoneEditar);
            this.gbEditar.Controls.Add(this.cbComplementoEditar);
            this.gbEditar.Controls.Add(this.tbNumeroEditar);
            this.gbEditar.Controls.Add(this.tbRuaEditar);
            this.gbEditar.Controls.Add(this.tbCidadeEditar);
            this.gbEditar.Controls.Add(this.tbEstadoEditar);
            this.gbEditar.Controls.Add(this.tbNomeEditar);
            this.gbEditar.Controls.Add(this.label9);
            this.gbEditar.Controls.Add(this.label8);
            this.gbEditar.Controls.Add(this.btEditar);
            this.gbEditar.Controls.Add(this.label6);
            this.gbEditar.Controls.Add(this.label5);
            this.gbEditar.Controls.Add(this.label4);
            this.gbEditar.Controls.Add(this.label3);
            this.gbEditar.Controls.Add(this.label2);
            this.gbEditar.Controls.Add(this.label1);
            this.gbEditar.Location = new System.Drawing.Point(12, 367);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(885, 292);
            this.gbEditar.TabIndex = 6;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar Nome e Endereço";
            // 
            // mbCepEditar
            // 
            this.mbCepEditar.Location = new System.Drawing.Point(79, 171);
            this.mbCepEditar.Mask = "00000-000";
            this.mbCepEditar.Name = "mbCepEditar";
            this.mbCepEditar.Size = new System.Drawing.Size(188, 22);
            this.mbCepEditar.TabIndex = 2;
            // 
            // mbTelefoneEditar
            // 
            this.mbTelefoneEditar.Location = new System.Drawing.Point(79, 124);
            this.mbTelefoneEditar.Mask = "(00)00000-0000";
            this.mbTelefoneEditar.Name = "mbTelefoneEditar";
            this.mbTelefoneEditar.Size = new System.Drawing.Size(188, 22);
            this.mbTelefoneEditar.TabIndex = 1;
            // 
            // cbComplementoEditar
            // 
            this.cbComplementoEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComplementoEditar.FormattingEnabled = true;
            this.cbComplementoEditar.Items.AddRange(new object[] {
            "Casa",
            "Apartamento"});
            this.cbComplementoEditar.Location = new System.Drawing.Point(675, 122);
            this.cbComplementoEditar.Name = "cbComplementoEditar";
            this.cbComplementoEditar.Size = new System.Drawing.Size(188, 24);
            this.cbComplementoEditar.TabIndex = 7;
            // 
            // tbNumeroEditar
            // 
            this.tbNumeroEditar.Location = new System.Drawing.Point(675, 75);
            this.tbNumeroEditar.Name = "tbNumeroEditar";
            this.tbNumeroEditar.Size = new System.Drawing.Size(188, 22);
            this.tbNumeroEditar.TabIndex = 6;
            // 
            // tbRuaEditar
            // 
            this.tbRuaEditar.Location = new System.Drawing.Point(356, 174);
            this.tbRuaEditar.Name = "tbRuaEditar";
            this.tbRuaEditar.Size = new System.Drawing.Size(188, 22);
            this.tbRuaEditar.TabIndex = 5;
            // 
            // tbCidadeEditar
            // 
            this.tbCidadeEditar.Location = new System.Drawing.Point(356, 124);
            this.tbCidadeEditar.Name = "tbCidadeEditar";
            this.tbCidadeEditar.Size = new System.Drawing.Size(188, 22);
            this.tbCidadeEditar.TabIndex = 4;
            // 
            // tbEstadoEditar
            // 
            this.tbEstadoEditar.Location = new System.Drawing.Point(356, 73);
            this.tbEstadoEditar.Name = "tbEstadoEditar";
            this.tbEstadoEditar.Size = new System.Drawing.Size(188, 22);
            this.tbEstadoEditar.TabIndex = 3;
            // 
            // tbNomeEditar
            // 
            this.tbNomeEditar.Location = new System.Drawing.Point(79, 72);
            this.tbNomeEditar.Name = "tbNomeEditar";
            this.tbNomeEditar.Size = new System.Drawing.Size(188, 22);
            this.tbNomeEditar.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(607, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Número:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Complemento:";
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(387, 245);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(81, 32);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rua:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(12, 670);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 3;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(604, 346);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 0;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // FormBuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 705);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.gbEditar);
            this.Controls.Add(this.lbTabela);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.gbIniciarBusca);
            this.Controls.Add(this.gbOpcoesBusca);
            this.Controls.Add(this.dgvClientes1);
            this.Name = "FormBuscaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes1)).EndInit();
            this.gbOpcoesBusca.ResumeLayout(false);
            this.gbOpcoesBusca.PerformLayout();
            this.gbIniciarBusca.ResumeLayout(false);
            this.gbIniciarBusca.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes1;
        private System.Windows.Forms.GroupBox gbOpcoesBusca;
        private System.Windows.Forms.RadioButton rbBuscarTelefone;
        private System.Windows.Forms.RadioButton rbBuscarCPF;
        private System.Windows.Forms.RadioButton rbBuscarNome;
        private System.Windows.Forms.GroupBox gbIniciarBusca;
        private System.Windows.Forms.Label lbBusca;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label lbTabela;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbComplementoEditar;
        private System.Windows.Forms.TextBox tbNumeroEditar;
        private System.Windows.Forms.TextBox tbRuaEditar;
        private System.Windows.Forms.TextBox tbCidadeEditar;
        private System.Windows.Forms.TextBox tbEstadoEditar;
        private System.Windows.Forms.TextBox tbNomeEditar;
        private System.Windows.Forms.MaskedTextBox mbCepEditar;
        private System.Windows.Forms.MaskedTextBox mbTelefoneEditar;
        private System.Windows.Forms.Button btAtualizar;
    }
}
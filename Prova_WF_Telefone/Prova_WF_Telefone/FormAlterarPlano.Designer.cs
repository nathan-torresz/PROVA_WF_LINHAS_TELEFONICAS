namespace Prova_WF_Telefone
{
    partial class FormAlterarPlano
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
            this.label1 = new System.Windows.Forms.Label();
            this.mbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dgvPlanosAtivos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPlanosDisponiveis = new System.Windows.Forms.DataGridView();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanosAtivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanosDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite uma linha cadastrada";
            // 
            // mbTelefone
            // 
            this.mbTelefone.Location = new System.Drawing.Point(41, 66);
            this.mbTelefone.Mask = "(00)00000-0000";
            this.mbTelefone.Name = "mbTelefone";
            this.mbTelefone.Size = new System.Drawing.Size(260, 22);
            this.mbTelefone.TabIndex = 1;
            // 
            // dgvPlanosAtivos
            // 
            this.dgvPlanosAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanosAtivos.Location = new System.Drawing.Point(37, 232);
            this.dgvPlanosAtivos.Name = "dgvPlanosAtivos";
            this.dgvPlanosAtivos.RowHeadersWidth = 51;
            this.dgvPlanosAtivos.RowTemplate.Height = 24;
            this.dgvPlanosAtivos.Size = new System.Drawing.Size(845, 150);
            this.dgvPlanosAtivos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Planos Ativos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Planos Disponíveis";
            // 
            // dgvPlanosDisponiveis
            // 
            this.dgvPlanosDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanosDisponiveis.Location = new System.Drawing.Point(37, 421);
            this.dgvPlanosDisponiveis.Name = "dgvPlanosDisponiveis";
            this.dgvPlanosDisponiveis.RowHeadersWidth = 51;
            this.dgvPlanosDisponiveis.RowTemplate.Height = 24;
            this.dgvPlanosDisponiveis.Size = new System.Drawing.Size(845, 150);
            this.dgvPlanosDisponiveis.TabIndex = 4;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(37, 586);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(90, 28);
            this.btVoltar.TabIndex = 6;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(397, 577);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(90, 28);
            this.btAdicionar.TabIndex = 7;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(397, 387);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(90, 28);
            this.btAtualizar.TabIndex = 8;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Location = new System.Drawing.Point(654, 32);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.RowHeadersWidth = 51;
            this.dgvTelefone.RowTemplate.Height = 24;
            this.dgvTelefone.Size = new System.Drawing.Size(228, 150);
            this.dgvTelefone.TabIndex = 9;
            this.dgvTelefone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefone_CellClick);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(135, 94);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 10;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // FormAlterarPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 640);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dgvTelefone);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPlanosDisponiveis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPlanosAtivos);
            this.Controls.Add(this.mbTelefone);
            this.Controls.Add(this.label1);
            this.Name = "FormAlterarPlano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlterarPlano";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanosAtivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanosDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mbTelefone;
        private System.Windows.Forms.DataGridView dgvPlanosAtivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPlanosDisponiveis;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.Button btBuscar;
    }
}
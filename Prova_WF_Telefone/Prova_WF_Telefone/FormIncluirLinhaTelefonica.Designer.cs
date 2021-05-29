namespace Prova_WF_Telefone
{
    partial class FormIncluirLinhaTelefonica
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
            this.btVoltar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvPlanos = new System.Windows.Forms.DataGridView();
            this.btContratarLinha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVoltar.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(12, 489);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(91, 32);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 280);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(920, 180);
            this.dgvClientes.TabIndex = 4;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // dgvPlanos
            // 
            this.dgvPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanos.Location = new System.Drawing.Point(12, 47);
            this.dgvPlanos.Name = "dgvPlanos";
            this.dgvPlanos.RowHeadersWidth = 51;
            this.dgvPlanos.RowTemplate.Height = 24;
            this.dgvPlanos.Size = new System.Drawing.Size(920, 180);
            this.dgvPlanos.TabIndex = 5;
            // 
            // btContratarLinha
            // 
            this.btContratarLinha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btContratarLinha.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContratarLinha.Location = new System.Drawing.Point(416, 466);
            this.btContratarLinha.Name = "btContratarLinha";
            this.btContratarLinha.Size = new System.Drawing.Size(113, 47);
            this.btContratarLinha.TabIndex = 6;
            this.btContratarLinha.Text = "Contratar";
            this.btContratarLinha.UseVisualStyleBackColor = true;
            this.btContratarLinha.Click += new System.EventHandler(this.btContratarLinha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Planos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Clientes";
            // 
            // FormIncluirLinhaTelefonica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btContratarLinha);
            this.Controls.Add(this.dgvPlanos);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btVoltar);
            this.Name = "FormIncluirLinhaTelefonica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIncluirLinhaTelefonica";
            this.Load += new System.EventHandler(this.FormIncluirLinhaTelefonica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvPlanos;
        private System.Windows.Forms.Button btContratarLinha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
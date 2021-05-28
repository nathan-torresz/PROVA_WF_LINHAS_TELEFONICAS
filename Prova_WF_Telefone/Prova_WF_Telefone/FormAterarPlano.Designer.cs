namespace Prova_WF_Telefone
{
    partial class FormAterarPlano
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
            this.dgvPlanos = new System.Windows.Forms.DataGridView();
            this.dgvLinhas = new System.Windows.Forms.DataGridView();
            this.btAlteraPLano = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanos
            // 
            this.dgvPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanos.Location = new System.Drawing.Point(12, 308);
            this.dgvPlanos.Name = "dgvPlanos";
            this.dgvPlanos.RowHeadersWidth = 51;
            this.dgvPlanos.RowTemplate.Height = 24;
            this.dgvPlanos.Size = new System.Drawing.Size(776, 150);
            this.dgvPlanos.TabIndex = 0;
            // 
            // dgvLinhas
            // 
            this.dgvLinhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinhas.Location = new System.Drawing.Point(12, 130);
            this.dgvLinhas.Name = "dgvLinhas";
            this.dgvLinhas.RowHeadersWidth = 51;
            this.dgvLinhas.RowTemplate.Height = 24;
            this.dgvLinhas.Size = new System.Drawing.Size(776, 150);
            this.dgvLinhas.TabIndex = 1;
            // 
            // btAlteraPLano
            // 
            this.btAlteraPLano.Location = new System.Drawing.Point(345, 464);
            this.btAlteraPLano.Name = "btAlteraPLano";
            this.btAlteraPLano.Size = new System.Drawing.Size(75, 23);
            this.btAlteraPLano.TabIndex = 2;
            this.btAlteraPLano.Text = "Alterar Plano";
            this.btAlteraPLano.UseVisualStyleBackColor = true;
            this.btAlteraPLano.Click += new System.EventHandler(this.btAlteraPLano_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(12, 510);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 3;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // FormAterarPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btAlteraPLano);
            this.Controls.Add(this.dgvLinhas);
            this.Controls.Add(this.dgvPlanos);
            this.Name = "FormAterarPlano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAterarPlano";
            this.Load += new System.EventHandler(this.FormAterarPlano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanos;
        private System.Windows.Forms.DataGridView dgvLinhas;
        private System.Windows.Forms.Button btAlteraPLano;
        private System.Windows.Forms.Button btVoltar;
    }
}
namespace Prova_WF_Telefone
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lINHATELEFÔNICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirLinhaTelefônicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLANOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPlanoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvLinhas = new System.Windows.Forms.DataGridView();
            this.btAtivar = new System.Windows.Forms.Button();
            this.btDesativar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.lINHATELEFÔNICAToolStripMenuItem,
            this.pLANOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem});
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            // 
            // incluirClienteToolStripMenuItem
            // 
            this.incluirClienteToolStripMenuItem.Name = "incluirClienteToolStripMenuItem";
            this.incluirClienteToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.incluirClienteToolStripMenuItem.Text = "Incluir Cliente";
            this.incluirClienteToolStripMenuItem.Click += new System.EventHandler(this.incluirClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // lINHATELEFÔNICAToolStripMenuItem
            // 
            this.lINHATELEFÔNICAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirLinhaTelefônicaToolStripMenuItem});
            this.lINHATELEFÔNICAToolStripMenuItem.Name = "lINHATELEFÔNICAToolStripMenuItem";
            this.lINHATELEFÔNICAToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.lINHATELEFÔNICAToolStripMenuItem.Text = "LINHA TELEFÔNICA";
            // 
            // incluirLinhaTelefônicaToolStripMenuItem
            // 
            this.incluirLinhaTelefônicaToolStripMenuItem.Name = "incluirLinhaTelefônicaToolStripMenuItem";
            this.incluirLinhaTelefônicaToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.incluirLinhaTelefônicaToolStripMenuItem.Text = "Incluir Linha Telefônica";
            this.incluirLinhaTelefônicaToolStripMenuItem.Click += new System.EventHandler(this.incluirLinhaTelefônicaToolStripMenuItem_Click);
            // 
            // pLANOSToolStripMenuItem
            // 
            this.pLANOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarPlanoClienteToolStripMenuItem});
            this.pLANOSToolStripMenuItem.Name = "pLANOSToolStripMenuItem";
            this.pLANOSToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.pLANOSToolStripMenuItem.Text = "PLANOS";
            // 
            // modificarPlanoClienteToolStripMenuItem
            // 
            this.modificarPlanoClienteToolStripMenuItem.Name = "modificarPlanoClienteToolStripMenuItem";
            this.modificarPlanoClienteToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.modificarPlanoClienteToolStripMenuItem.Text = "Modificar Plano - Cliente";
            this.modificarPlanoClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarPlanoClienteToolStripMenuItem_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(29, 65);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(733, 159);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // dgvLinhas
            // 
            this.dgvLinhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinhas.Location = new System.Drawing.Point(29, 250);
            this.dgvLinhas.Name = "dgvLinhas";
            this.dgvLinhas.RowHeadersWidth = 51;
            this.dgvLinhas.RowTemplate.Height = 24;
            this.dgvLinhas.Size = new System.Drawing.Size(733, 158);
            this.dgvLinhas.TabIndex = 2;
            // 
            // btAtivar
            // 
            this.btAtivar.Location = new System.Drawing.Point(578, 414);
            this.btAtivar.Name = "btAtivar";
            this.btAtivar.Size = new System.Drawing.Size(89, 44);
            this.btAtivar.TabIndex = 3;
            this.btAtivar.Text = "Ativar";
            this.btAtivar.UseVisualStyleBackColor = true;
            this.btAtivar.Click += new System.EventHandler(this.btAtivar_Click);
            // 
            // btDesativar
            // 
            this.btDesativar.Location = new System.Drawing.Point(670, 414);
            this.btDesativar.Name = "btDesativar";
            this.btDesativar.Size = new System.Drawing.Size(92, 44);
            this.btDesativar.TabIndex = 4;
            this.btDesativar.Text = "Desativar";
            this.btDesativar.UseVisualStyleBackColor = true;
            this.btDesativar.Click += new System.EventHandler(this.btDesativar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btDesativar);
            this.Controls.Add(this.btAtivar);
            this.Controls.Add(this.dgvLinhas);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirClienteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvLinhas;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lINHATELEFÔNICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirLinhaTelefônicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLANOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPlanoClienteToolStripMenuItem;
        private System.Windows.Forms.Button btAtivar;
        private System.Windows.Forms.Button btDesativar;
    }
}


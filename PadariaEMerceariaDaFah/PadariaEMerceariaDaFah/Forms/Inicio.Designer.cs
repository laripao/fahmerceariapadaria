namespace PadariaEMerceariaDaFah
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.list_vencimento = new System.Windows.Forms.ListBox();
            this.tabEstoque = new System.Windows.Forms.TabPage();
            this.panel_produto = new System.Windows.Forms.Panel();
            this.tabVendas = new System.Windows.Forms.TabPage();
            this.panel_vendas = new System.Windows.Forms.Panel();
            this.tabGerencia = new System.Windows.Forms.TabPage();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.print_button = new System.Windows.Forms.Button();
            this.groupResultados = new System.Windows.Forms.GroupBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabela = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TabGoCliente = new System.Windows.Forms.Button();
            this.TabGo_Fornecedor = new System.Windows.Forms.Button();
            this.TabGoFuncionario = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabLogo.SuspendLayout();
            this.tabEstoque.SuspendLayout();
            this.tabVendas.SuspendLayout();
            this.tabGerencia.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabLogo);
            this.tabControl1.Controls.Add(this.tabEstoque);
            this.tabControl1.Controls.Add(this.tabVendas);
            this.tabControl1.Controls.Add(this.tabGerencia);
            this.tabControl1.Controls.Add(this.tabPesquisa);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1260, 779);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabLogo
            // 
            this.tabLogo.BackColor = System.Drawing.Color.Transparent;
            this.tabLogo.Controls.Add(this.label1);
            this.tabLogo.Controls.Add(this.list_vencimento);
            this.tabLogo.Location = new System.Drawing.Point(4, 30);
            this.tabLogo.Name = "tabLogo";
            this.tabLogo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogo.Size = new System.Drawing.Size(1252, 749);
            this.tabLogo.TabIndex = 0;
            this.tabLogo.Text = "Importante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produtos que vencerão em 5 dias";
            // 
            // list_vencimento
            // 
            this.list_vencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_vencimento.FormattingEnabled = true;
            this.list_vencimento.ItemHeight = 21;
            this.list_vencimento.Location = new System.Drawing.Point(6, 31);
            this.list_vencimento.Name = "list_vencimento";
            this.list_vencimento.Size = new System.Drawing.Size(1240, 684);
            this.list_vencimento.TabIndex = 0;
            // 
            // tabEstoque
            // 
            this.tabEstoque.BackColor = System.Drawing.Color.SkyBlue;
            this.tabEstoque.Controls.Add(this.panel_produto);
            this.tabEstoque.Location = new System.Drawing.Point(4, 30);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstoque.Size = new System.Drawing.Size(1252, 749);
            this.tabEstoque.TabIndex = 1;
            this.tabEstoque.Text = "Estoque";
            // 
            // panel_produto
            // 
            this.panel_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_produto.Location = new System.Drawing.Point(0, 0);
            this.panel_produto.Name = "panel_produto";
            this.panel_produto.Size = new System.Drawing.Size(1249, 875);
            this.panel_produto.TabIndex = 0;
            // 
            // tabVendas
            // 
            this.tabVendas.BackColor = System.Drawing.Color.SkyBlue;
            this.tabVendas.Controls.Add(this.panel_vendas);
            this.tabVendas.Location = new System.Drawing.Point(4, 30);
            this.tabVendas.Name = "tabVendas";
            this.tabVendas.Size = new System.Drawing.Size(1252, 749);
            this.tabVendas.TabIndex = 4;
            this.tabVendas.Text = "Vendas";
            // 
            // panel_vendas
            // 
            this.panel_vendas.Location = new System.Drawing.Point(4, 4);
            this.panel_vendas.Name = "panel_vendas";
            this.panel_vendas.Size = new System.Drawing.Size(1290, 738);
            this.panel_vendas.TabIndex = 0;
            // 
            // tabGerencia
            // 
            this.tabGerencia.Controls.Add(this.TabGoCliente);
            this.tabGerencia.Controls.Add(this.TabGo_Fornecedor);
            this.tabGerencia.Controls.Add(this.TabGoFuncionario);
            this.tabGerencia.Location = new System.Drawing.Point(4, 30);
            this.tabGerencia.Name = "tabGerencia";
            this.tabGerencia.Size = new System.Drawing.Size(1252, 749);
            this.tabGerencia.TabIndex = 2;
            this.tabGerencia.Text = "Gerência";
            this.tabGerencia.UseVisualStyleBackColor = true;
            // 
            
            // 
            // TabGoCliente
            // 
            this.TabGoCliente.Location = new System.Drawing.Point(3, 0);
            this.TabGoCliente.Name = "TabGoCliente";
            this.TabGoCliente.Size = new System.Drawing.Size(419, 142);
            this.TabGoCliente.TabIndex = 0;
            this.TabGoCliente.Text = "Cliente";
            this.TabGoCliente.UseVisualStyleBackColor = true;
            this.TabGoCliente.Click += new System.EventHandler(this.TabGoCliente_Click);
            // 
            // TabGo_Fornecedor
            // 
            this.TabGo_Fornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TabGo_Fornecedor.Location = new System.Drawing.Point(797, 1);
            this.TabGo_Fornecedor.Name = "TabGo_Fornecedor";
            this.TabGo_Fornecedor.Size = new System.Drawing.Size(452, 141);
            this.TabGo_Fornecedor.TabIndex = 2;
            this.TabGo_Fornecedor.Text = "Fornecedor";
            this.TabGo_Fornecedor.UseVisualStyleBackColor = true;
            this.TabGo_Fornecedor.Click += new System.EventHandler(this.TabGo_Fornecedor_Click);
            // 
            // TabGoFuncionario
            // 
            this.TabGoFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabGoFuncionario.Location = new System.Drawing.Point(406, 0);
            this.TabGoFuncionario.Name = "TabGoFuncionario";
            this.TabGoFuncionario.Size = new System.Drawing.Size(408, 142);
            this.TabGoFuncionario.TabIndex = 1;
            this.TabGoFuncionario.Text = "Funcionário";
            this.TabGoFuncionario.UseVisualStyleBackColor = true;
            this.TabGoFuncionario.Click += new System.EventHandler(this.TabGoFuncionario_Click);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.AutoScroll = true;
            this.tabPesquisa.Controls.Add(this.print_button);
            this.tabPesquisa.Controls.Add(this.groupResultados);
            this.tabPesquisa.Controls.Add(this.btn_pesquisar);
            this.tabPesquisa.Controls.Add(this.groupBox1);
            this.tabPesquisa.Controls.Add(this.label2);
            this.tabPesquisa.Controls.Add(this.tabela);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 30);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Size = new System.Drawing.Size(1252, 749);
            this.tabPesquisa.TabIndex = 3;
            this.tabPesquisa.Text = "Pesquisa";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            this.tabPesquisa.Click += new System.EventHandler(this.tabPesquisa_Click);
            // 
            // print_button
            // 
            this.print_button.Location = new System.Drawing.Point(330, 14);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(176, 29);
            this.print_button.TabIndex = 7;
            this.print_button.Text = "Imprimir Resultados";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // groupResultados
            // 
            this.groupResultados.Location = new System.Drawing.Point(16, 189);
            this.groupResultados.Name = "groupResultados";
            this.groupResultados.Size = new System.Drawing.Size(829, 100);
            this.groupResultados.TabIndex = 6;
            this.groupResultados.TabStop = false;
            this.groupResultados.Text = "Resultados";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(570, 14);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(205, 29);
            this.btn_pesquisar.TabIndex = 6;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar:";
            // 
            // tabela
            // 
            this.tabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabela.FormattingEnabled = true;
            this.tabela.Items.AddRange(new object[] {
            "Produto",
            "Fornecedor",
            "Funcionario",
            "Cliente",
            "Venda",
            "Ingrediente"});
            this.tabela.Location = new System.Drawing.Point(92, 14);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(161, 29);
            this.tabela.TabIndex = 3;
            this.tabela.SelectedIndexChanged += new System.EventHandler(this.tabela_SelectedIndexChanged);
            // 
            // TabGoCliente
            // 
            this.TabGoCliente.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Clients_icon4;
            this.TabGoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TabGoCliente.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGoCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TabGoCliente.Location = new System.Drawing.Point(3, 281);
            this.TabGoCliente.Name = "TabGoCliente";
            this.TabGoCliente.Size = new System.Drawing.Size(397, 258);
            this.TabGoCliente.TabIndex = 0;
            this.TabGoCliente.Text = "Cliente";
            this.TabGoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TabGoCliente.UseVisualStyleBackColor = true;
            this.TabGoCliente.Click += new System.EventHandler(this.TabGoCliente_Click);
            // 
            // TabGo_Fornecedor
            // 
            this.TabGo_Fornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TabGo_Fornecedor.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Preppy_icon;
            this.TabGo_Fornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TabGo_Fornecedor.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGo_Fornecedor.Location = new System.Drawing.Point(820, 281);
            this.TabGo_Fornecedor.Name = "TabGo_Fornecedor";
            this.TabGo_Fornecedor.Size = new System.Drawing.Size(429, 257);
            this.TabGo_Fornecedor.TabIndex = 2;
            this.TabGo_Fornecedor.Text = "Fornecedor";
            this.TabGo_Fornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TabGo_Fornecedor.UseVisualStyleBackColor = true;
            this.TabGo_Fornecedor.Click += new System.EventHandler(this.TabGo_Fornecedor_Click);
            // 
            // TabGoFuncionario
            // 
            this.TabGoFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabGoFuncionario.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Administrator_icon;
            this.TabGoFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TabGoFuncionario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGoFuncionario.Location = new System.Drawing.Point(406, 281);
            this.TabGoFuncionario.Name = "TabGoFuncionario";
            this.TabGoFuncionario.Size = new System.Drawing.Size(408, 258);
            this.TabGoFuncionario.TabIndex = 1;
            this.TabGoFuncionario.Text = "Funcionário";
            this.TabGoFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TabGoFuncionario.UseVisualStyleBackColor = true;
            this.TabGoFuncionario.Click += new System.EventHandler(this.TabGoFuncionario_Click);
            // 
            // Inicio
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1284, 793);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Início";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLogo.ResumeLayout(false);
            this.tabLogo.PerformLayout();
            this.tabEstoque.ResumeLayout(false);
            this.tabVendas.ResumeLayout(false);
            this.tabGerencia.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go_gerencia;
        private System.Windows.Forms.Button go_estoque;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogo;
        private System.Windows.Forms.TabPage tabEstoque;
        private System.Windows.Forms.TabPage tabGerencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_vencimento;
        private System.Windows.Forms.Button TabGo_Fornecedor;
        private System.Windows.Forms.Button TabGoFuncionario;
        private System.Windows.Forms.Panel panel_produto;
        private System.Windows.Forms.Button TabGoCliente;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tabela;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.GroupBox groupResultados;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabVendas;
        private System.Windows.Forms.Panel panel_vendas;
    }
}


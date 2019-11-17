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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabEstoque = new System.Windows.Forms.TabPage();
            this.TabShowProducts = new System.Windows.Forms.Button();
            this.tabGerencia = new System.Windows.Forms.TabPage();
            this.TabGoCliente = new System.Windows.Forms.Button();
            this.TabGo_Fornecedor = new System.Windows.Forms.Button();
            this.TabGoFuncionario = new System.Windows.Forms.Button();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabela = new System.Windows.Forms.ComboBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.groupResultados = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabLogo.SuspendLayout();
            this.tabEstoque.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabGerencia);
            this.tabControl1.Controls.Add(this.tabPesquisa);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 637);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogo
            // 
            this.tabLogo.BackColor = System.Drawing.Color.Transparent;
            this.tabLogo.Controls.Add(this.label1);
            this.tabLogo.Controls.Add(this.listBox1);
            this.tabLogo.Location = new System.Drawing.Point(4, 30);
            this.tabLogo.Name = "tabLogo";
            this.tabLogo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogo.Size = new System.Drawing.Size(848, 603);
            this.tabLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produtos que vencerão \r\nem 5 dias";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(6, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 319);
            this.listBox1.TabIndex = 0;
            // 
            // tabEstoque
            // 
            this.tabEstoque.Controls.Add(this.TabShowProducts);
            this.tabEstoque.Location = new System.Drawing.Point(4, 30);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstoque.Size = new System.Drawing.Size(848, 603);
            this.tabEstoque.TabIndex = 1;
            this.tabEstoque.Text = "Estoque";
            this.tabEstoque.UseVisualStyleBackColor = true;
            // 
            // TabShowProducts
            // 
            this.TabShowProducts.Location = new System.Drawing.Point(58, 167);
            this.TabShowProducts.Name = "TabShowProducts";
            this.TabShowProducts.Size = new System.Drawing.Size(145, 61);
            this.TabShowProducts.TabIndex = 1;
            this.TabShowProducts.Text = "Visualizar produtos";
            this.TabShowProducts.UseVisualStyleBackColor = true;
            this.TabShowProducts.Click += new System.EventHandler(this.TabShowProducts_Click);
            // 
            // tabGerencia
            // 
            this.tabGerencia.Controls.Add(this.TabGoCliente);
            this.tabGerencia.Controls.Add(this.TabGo_Fornecedor);
            this.tabGerencia.Controls.Add(this.TabGoFuncionario);
            this.tabGerencia.Location = new System.Drawing.Point(4, 30);
            this.tabGerencia.Name = "tabGerencia";
            this.tabGerencia.Size = new System.Drawing.Size(848, 603);
            this.tabGerencia.TabIndex = 2;
            this.tabGerencia.Text = "Gerência";
            this.tabGerencia.UseVisualStyleBackColor = true;
            // 
            // TabGoCliente
            // 
            this.TabGoCliente.Location = new System.Drawing.Point(23, 138);
            this.TabGoCliente.Name = "TabGoCliente";
            this.TabGoCliente.Size = new System.Drawing.Size(116, 66);
            this.TabGoCliente.TabIndex = 2;
            this.TabGoCliente.Text = "Cliente";
            this.TabGoCliente.UseVisualStyleBackColor = true;
            this.TabGoCliente.Click += new System.EventHandler(this.TabGoCliente_Click);
            // 
            // TabGo_Fornecedor
            // 
            this.TabGo_Fornecedor.Location = new System.Drawing.Point(352, 138);
            this.TabGo_Fornecedor.Name = "TabGo_Fornecedor";
            this.TabGo_Fornecedor.Size = new System.Drawing.Size(116, 66);
            this.TabGo_Fornecedor.TabIndex = 1;
            this.TabGo_Fornecedor.Text = "Fornecedor";
            this.TabGo_Fornecedor.UseVisualStyleBackColor = true;
            this.TabGo_Fornecedor.Click += new System.EventHandler(this.TabGo_Fornecedor_Click);
            // 
            // TabGoFuncionario
            // 
            this.TabGoFuncionario.Location = new System.Drawing.Point(194, 138);
            this.TabGoFuncionario.Name = "TabGoFuncionario";
            this.TabGoFuncionario.Size = new System.Drawing.Size(116, 66);
            this.TabGoFuncionario.TabIndex = 0;
            this.TabGoFuncionario.Text = "Funcionário";
            this.TabGoFuncionario.UseVisualStyleBackColor = true;
            this.TabGoFuncionario.Click += new System.EventHandler(this.TabGoFuncionario_Click);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.AutoScroll = true;
            this.tabPesquisa.Controls.Add(this.groupResultados);
            this.tabPesquisa.Controls.Add(this.btn_pesquisar);
            this.tabPesquisa.Controls.Add(this.groupBox1);
            this.tabPesquisa.Controls.Add(this.label2);
            this.tabPesquisa.Controls.Add(this.tabela);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 30);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Size = new System.Drawing.Size(848, 603);
            this.tabPesquisa.TabIndex = 3;
            this.tabPesquisa.Text = "Pesquisa";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            this.tabPesquisa.Click += new System.EventHandler(this.tabPesquisa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 100);
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
            "Cliente"});
            this.tabela.Location = new System.Drawing.Point(92, 14);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(161, 29);
            this.tabela.TabIndex = 3;
            this.tabela.SelectedIndexChanged += new System.EventHandler(this.tabela_SelectedIndexChanged);
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
            // groupResultados
            // 
            this.groupResultados.Location = new System.Drawing.Point(16, 159);
            this.groupResultados.Name = "groupResultados";
            this.groupResultados.Size = new System.Drawing.Size(829, 100);
            this.groupResultados.TabIndex = 6;
            this.groupResultados.TabStop = false;
            this.groupResultados.Text = "Resultados";
            // 
            // Inicio
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(880, 661);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.Text = "Início";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLogo.ResumeLayout(false);
            this.tabLogo.PerformLayout();
            this.tabEstoque.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button TabShowProducts;
        private System.Windows.Forms.Button TabGo_Fornecedor;
        private System.Windows.Forms.Button TabGoFuncionario;
        private System.Windows.Forms.Button TabGoCliente;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tabela;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.GroupBox groupResultados;
    }
}


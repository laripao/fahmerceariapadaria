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
            this.panel_produto = new System.Windows.Forms.Panel();
            this.tabGerencia = new System.Windows.Forms.TabPage();
            this.TabGo_Fornecedor = new System.Windows.Forms.Button();
            this.TabGoFuncionario = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabLogo.SuspendLayout();
            this.tabEstoque.SuspendLayout();
            this.tabGerencia.SuspendLayout();
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
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 750);
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
            this.tabLogo.Size = new System.Drawing.Size(846, 598);
            this.tabLogo.TabIndex = 0;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(6, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(834, 319);
            this.listBox1.TabIndex = 0;
            // 
            // tabEstoque
            // 
            this.tabEstoque.Controls.Add(this.panel_produto);
            this.tabEstoque.Location = new System.Drawing.Point(4, 30);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstoque.Size = new System.Drawing.Size(962, 716);
            this.tabEstoque.TabIndex = 1;
            this.tabEstoque.Text = "Estoque";
            this.tabEstoque.UseVisualStyleBackColor = true;
            // 
            // panel_produto
            // 
            this.panel_produto.Location = new System.Drawing.Point(6, 6);
            this.panel_produto.Name = "panel_produto";
            this.panel_produto.Size = new System.Drawing.Size(947, 704);
            this.panel_produto.TabIndex = 2;
            // 
            // tabGerencia
            // 
            this.tabGerencia.Controls.Add(this.TabGo_Fornecedor);
            this.tabGerencia.Controls.Add(this.TabGoFuncionario);
            this.tabGerencia.Location = new System.Drawing.Point(4, 30);
            this.tabGerencia.Name = "tabGerencia";
            this.tabGerencia.Size = new System.Drawing.Size(846, 598);
            this.tabGerencia.TabIndex = 2;
            this.tabGerencia.Text = "Gerência";
            this.tabGerencia.UseVisualStyleBackColor = true;
            // 
            // TabGo_Fornecedor
            // 
            this.TabGo_Fornecedor.Location = new System.Drawing.Point(266, 138);
            this.TabGo_Fornecedor.Name = "TabGo_Fornecedor";
            this.TabGo_Fornecedor.Size = new System.Drawing.Size(116, 66);
            this.TabGo_Fornecedor.TabIndex = 1;
            this.TabGo_Fornecedor.Text = "Fornecedor";
            this.TabGo_Fornecedor.UseVisualStyleBackColor = true;
            this.TabGo_Fornecedor.Click += new System.EventHandler(this.TabGo_Fornecedor_Click);
            // 
            // TabGoFuncionario
            // 
            this.TabGoFuncionario.Location = new System.Drawing.Point(97, 138);
            this.TabGoFuncionario.Name = "TabGoFuncionario";
            this.TabGoFuncionario.Size = new System.Drawing.Size(116, 66);
            this.TabGoFuncionario.TabIndex = 0;
            this.TabGoFuncionario.Text = "Funcionário";
            this.TabGoFuncionario.UseVisualStyleBackColor = true;
            this.TabGoFuncionario.Click += new System.EventHandler(this.TabGoFuncionario_Click);
            // 
            // Inicio
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(994, 774);
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
        private System.Windows.Forms.Button TabGo_Fornecedor;
        private System.Windows.Forms.Button TabGoFuncionario;
        private System.Windows.Forms.Panel panel_produto;
    }
}


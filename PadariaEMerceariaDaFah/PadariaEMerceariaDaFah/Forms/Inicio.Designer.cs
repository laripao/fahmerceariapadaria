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
            this.tabInicial = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabEstoque = new System.Windows.Forms.TabPage();
            this.TabShowProducts = new System.Windows.Forms.Button();
            this.tabGerencia = new System.Windows.Forms.TabPage();
            this.TabGo_Fornecedor = new System.Windows.Forms.Button();
            this.TabGoFuncionario = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabInicial.SuspendLayout();
            this.tabEstoque.SuspendLayout();
            this.tabGerencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabInicial);
            this.tabControl1.Controls.Add(this.tabEstoque);
            this.tabControl1.Controls.Add(this.tabGerencia);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 403);
            this.tabControl1.TabIndex = 2;
            // 
            // tabInicial
            // 
            this.tabInicial.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabInicial.Controls.Add(this.label1);
            this.tabInicial.Controls.Add(this.listBox1);
            this.tabInicial.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabInicial.Location = new System.Drawing.Point(4, 30);
            this.tabInicial.Name = "tabInicial";
            this.tabInicial.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicial.Size = new System.Drawing.Size(593, 369);
            this.tabInicial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produtos que vencerão em 5 dias";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(6, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 214);
            this.listBox1.TabIndex = 0;
            // 
            // tabEstoque
            // 
            this.tabEstoque.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabEstoque.Controls.Add(this.TabShowProducts);
            this.tabEstoque.Location = new System.Drawing.Point(4, 30);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstoque.Size = new System.Drawing.Size(593, 369);
            this.tabEstoque.TabIndex = 1;
            this.tabEstoque.Text = "Estoque";
            // 
            // TabShowProducts
            // 
            this.TabShowProducts.AutoSize = true;
            this.TabShowProducts.Location = new System.Drawing.Point(217, 152);
            this.TabShowProducts.Margin = new System.Windows.Forms.Padding(2);
            this.TabShowProducts.Name = "TabShowProducts";
            this.TabShowProducts.Size = new System.Drawing.Size(179, 70);
            this.TabShowProducts.TabIndex = 1;
            this.TabShowProducts.Text = "Visualizar produtos";
            this.TabShowProducts.UseVisualStyleBackColor = true;
            this.TabShowProducts.Click += new System.EventHandler(this.TabShowProducts_Click);
            // 
            // tabGerencia
            // 
            this.tabGerencia.AutoScroll = true;
            this.tabGerencia.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabGerencia.Controls.Add(this.TabGo_Fornecedor);
            this.tabGerencia.Controls.Add(this.TabGoFuncionario);
            this.tabGerencia.Location = new System.Drawing.Point(4, 30);
            this.tabGerencia.Name = "tabGerencia";
            this.tabGerencia.Size = new System.Drawing.Size(593, 369);
            this.tabGerencia.TabIndex = 2;
            this.tabGerencia.Text = "Gerência";
            // 
            // TabGo_Fornecedor
            // 
            this.TabGo_Fornecedor.Location = new System.Drawing.Point(319, 133);
            this.TabGo_Fornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.TabGo_Fornecedor.Name = "TabGo_Fornecedor";
            this.TabGo_Fornecedor.Size = new System.Drawing.Size(163, 75);
            this.TabGo_Fornecedor.TabIndex = 2;
            this.TabGo_Fornecedor.Text = "Fornecedor";
            this.TabGo_Fornecedor.UseVisualStyleBackColor = true;
            this.TabGo_Fornecedor.Click += new System.EventHandler(this.TabGo_Fornecedor_Click);
            // 
            // TabGoFuncionario
            // 
            this.TabGoFuncionario.AutoSize = true;
            this.TabGoFuncionario.Location = new System.Drawing.Point(78, 133);
            this.TabGoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.TabGoFuncionario.Name = "TabGoFuncionario";
            this.TabGoFuncionario.Size = new System.Drawing.Size(163, 75);
            this.TabGoFuncionario.TabIndex = 1;
            this.TabGoFuncionario.Text = "Funcionario";
            this.TabGoFuncionario.UseVisualStyleBackColor = true;
            this.TabGoFuncionario.Click += new System.EventHandler(this.TabGoFuncionario_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(624, 427);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInicial.ResumeLayout(false);
            this.tabInicial.PerformLayout();
            this.tabEstoque.ResumeLayout(false);
            this.tabEstoque.PerformLayout();
            this.tabGerencia.ResumeLayout(false);
            this.tabGerencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInicial;
        private System.Windows.Forms.TabPage tabEstoque;
        private System.Windows.Forms.TabPage tabGerencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button TabShowProducts;
        private System.Windows.Forms.Button TabGoFuncionario;
        private System.Windows.Forms.Button TabGo_Fornecedor;
    }
}


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
            this.go_gerencia.Location = new System.Drawing.Point(38, 339);
            this.go_gerencia.Name = "go_gerencia";
            this.go_gerencia.Size = new System.Drawing.Size(118, 48);
            this.go_gerencia.TabIndex = 0;
            this.go_gerencia.Text = "Gerência";
            this.go_gerencia.UseVisualStyleBackColor = true;
            this.go_gerencia.Click += new System.EventHandler(this.go_gerencia_Click);
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
            this.go_estoque.Location = new System.Drawing.Point(38, 12);
            this.go_estoque.Name = "go_estoque";
            this.go_estoque.Size = new System.Drawing.Size(118, 48);
            this.go_estoque.TabIndex = 1;
            this.go_estoque.Text = "Estoque";
            this.go_estoque.UseVisualStyleBackColor = true;
            this.go_estoque.Click += new System.EventHandler(this.go_estoque_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 82);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 465);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage1.Size = new System.Drawing.Size(962, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage2.Size = new System.Drawing.Size(962, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gerência";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(962, 432);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Estoque";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.go_estoque);
            this.Controls.Add(this.go_gerencia);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go_gerencia;
        private System.Windows.Forms.Button go_estoque;
    }
}


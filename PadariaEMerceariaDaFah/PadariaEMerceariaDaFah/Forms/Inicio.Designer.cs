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
            this.go_gerencia = new System.Windows.Forms.Button();
            this.go_estoque = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInicial = new System.Windows.Forms.TabPage();
            this.tabEstoque = new System.Windows.Forms.TabPage();
            this.tabGerencia = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ashow = new System.Windows.Forms.Button();
            this.Bemployee = new System.Windows.Forms.Button();
            this.Bprovider = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabInicial.SuspendLayout();
            this.tabEstoque.SuspendLayout();
            this.tabGerencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // go_gerencia
            // 
            this.go_gerencia.Location = new System.Drawing.Point(107, 448);
            this.go_gerencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.go_gerencia.Name = "go_gerencia";
            this.go_gerencia.Size = new System.Drawing.Size(88, 39);
            this.go_gerencia.TabIndex = 0;
            this.go_gerencia.Text = "Gerência";
            this.go_gerencia.UseVisualStyleBackColor = true;
            this.go_gerencia.Click += new System.EventHandler(this.go_gerencia_Click);
            // 
            // go_estoque
            // 
            this.go_estoque.Location = new System.Drawing.Point(15, 448);
            this.go_estoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.go_estoque.Name = "go_estoque";
            this.go_estoque.Size = new System.Drawing.Size(88, 39);
            this.go_estoque.TabIndex = 1;
            this.go_estoque.Text = "Estoque";
            this.go_estoque.UseVisualStyleBackColor = true;
            this.go_estoque.Click += new System.EventHandler(this.go_estoque_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabInicial);
            this.tabControl1.Controls.Add(this.tabEstoque);
            this.tabControl1.Controls.Add(this.tabGerencia);
            this.tabControl1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 430);
            this.tabControl1.TabIndex = 2;
            // 
            // tabInicial
            // 
            this.tabInicial.Controls.Add(this.label1);
            this.tabInicial.Controls.Add(this.listBox1);
            this.tabInicial.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabInicial.Location = new System.Drawing.Point(4, 29);
            this.tabInicial.Name = "tabInicial";
            this.tabInicial.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicial.Size = new System.Drawing.Size(593, 397);
            this.tabInicial.TabIndex = 0;
            this.tabInicial.UseVisualStyleBackColor = true;
            // 
            // tabEstoque
            // 
            this.tabEstoque.Controls.Add(this.Ashow);
            this.tabEstoque.Location = new System.Drawing.Point(4, 29);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstoque.Size = new System.Drawing.Size(593, 397);
            this.tabEstoque.TabIndex = 1;
            this.tabEstoque.Text = "Estoque";
            this.tabEstoque.UseVisualStyleBackColor = true;
            // 
            // tabGerencia
            // 
            this.tabGerencia.AutoScroll = true;
            this.tabGerencia.Controls.Add(this.Bprovider);
            this.tabGerencia.Controls.Add(this.Bemployee);
            this.tabGerencia.Location = new System.Drawing.Point(4, 29);
            this.tabGerencia.Name = "tabGerencia";
            this.tabGerencia.Size = new System.Drawing.Size(593, 397);
            this.tabGerencia.TabIndex = 2;
            this.tabGerencia.Text = "Gerência";
            this.tabGerencia.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 224);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produtos que vencerão em 5 dias";
            // 
            // Ashow
            // 
            this.Ashow.AutoSize = true;
            this.Ashow.Location = new System.Drawing.Point(25, 20);
            this.Ashow.Margin = new System.Windows.Forms.Padding(2);
            this.Ashow.Name = "Ashow";
            this.Ashow.Size = new System.Drawing.Size(164, 70);
            this.Ashow.TabIndex = 1;
            this.Ashow.Text = "Visualizar produtos";
            this.Ashow.UseVisualStyleBackColor = true;
            // 
            // Bemployee
            // 
            this.Bemployee.AutoSize = true;
            this.Bemployee.Location = new System.Drawing.Point(78, 133);
            this.Bemployee.Margin = new System.Windows.Forms.Padding(2);
            this.Bemployee.Name = "Bemployee";
            this.Bemployee.Size = new System.Drawing.Size(163, 75);
            this.Bemployee.TabIndex = 1;
            this.Bemployee.Text = "Funcionario";
            this.Bemployee.UseVisualStyleBackColor = true;
            // 
            // Bprovider
            // 
            this.Bprovider.Location = new System.Drawing.Point(319, 133);
            this.Bprovider.Margin = new System.Windows.Forms.Padding(2);
            this.Bprovider.Name = "Bprovider";
            this.Bprovider.Size = new System.Drawing.Size(163, 75);
            this.Bprovider.TabIndex = 2;
            this.Bprovider.Text = "Fornecedor";
            this.Bprovider.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 491);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.go_estoque);
            this.Controls.Add(this.go_gerencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

        private System.Windows.Forms.Button go_gerencia;
        private System.Windows.Forms.Button go_estoque;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInicial;
        private System.Windows.Forms.TabPage tabEstoque;
        private System.Windows.Forms.TabPage tabGerencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Ashow;
        private System.Windows.Forms.Button Bemployee;
        private System.Windows.Forms.Button Bprovider;
    }
}


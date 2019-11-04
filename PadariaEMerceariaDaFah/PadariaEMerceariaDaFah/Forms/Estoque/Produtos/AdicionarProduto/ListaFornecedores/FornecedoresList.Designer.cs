namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFornecedores
{
    partial class FornecedoresList
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
            this.list_fornecedor = new System.Windows.Forms.ListBox();
            this.go_fornecedor_Click = new System.Windows.Forms.Button();
            this.go_addFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_fornecedor
            // 
            this.list_fornecedor.FormattingEnabled = true;
            this.list_fornecedor.ItemHeight = 16;
            this.list_fornecedor.Location = new System.Drawing.Point(13, 13);
            this.list_fornecedor.Name = "list_fornecedor";
            this.list_fornecedor.Size = new System.Drawing.Size(673, 292);
            this.list_fornecedor.TabIndex = 0;
            this.list_fornecedor.DoubleClick += new System.EventHandler(this.list_fornecedor_DoubleClick);
            // 
            // go_fornecedor_Click
            // 
            this.go_fornecedor_Click.Location = new System.Drawing.Point(13, 312);
            this.go_fornecedor_Click.Name = "go_fornecedor_Click";
            this.go_fornecedor_Click.Size = new System.Drawing.Size(329, 40);
            this.go_fornecedor_Click.TabIndex = 1;
            this.go_fornecedor_Click.Text = "Editar um fornecedor";
            this.go_fornecedor_Click.UseVisualStyleBackColor = true;
            this.go_fornecedor_Click.Click += new System.EventHandler(this.go_fornecedor_Click_Click);
            // 
            // go_addFornecedor
            // 
            this.go_addFornecedor.Location = new System.Drawing.Point(357, 311);
            this.go_addFornecedor.Name = "go_addFornecedor";
            this.go_addFornecedor.Size = new System.Drawing.Size(329, 40);
            this.go_addFornecedor.TabIndex = 2;
            this.go_addFornecedor.Text = "Adicionar um novo fornecedor";
            this.go_addFornecedor.UseVisualStyleBackColor = true;
            this.go_addFornecedor.Click += new System.EventHandler(this.go_addFornecedor_Click);
            // 
            // FornecedoresList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 365);
            this.Controls.Add(this.go_addFornecedor);
            this.Controls.Add(this.go_fornecedor_Click);
            this.Controls.Add(this.list_fornecedor);
            this.Name = "FornecedoresList";
            this.Text = "FornecedoresList";
            this.Load += new System.EventHandler(this.FornecedoresList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_fornecedor;
        private System.Windows.Forms.Button go_fornecedor_Click;
        private System.Windows.Forms.Button go_addFornecedor;
    }
}
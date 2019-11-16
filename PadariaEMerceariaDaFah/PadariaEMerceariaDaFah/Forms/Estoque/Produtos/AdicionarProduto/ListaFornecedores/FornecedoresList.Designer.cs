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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FornecedoresList));
            this.list_fornecedor = new System.Windows.Forms.ListBox();
            this.go_addFornecedor = new System.Windows.Forms.Button();
            this.go_fornecedor_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_fornecedor
            // 
            this.list_fornecedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_fornecedor.FormattingEnabled = true;
            this.list_fornecedor.ItemHeight = 17;
            this.list_fornecedor.Location = new System.Drawing.Point(10, 11);
            this.list_fornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_fornecedor.Name = "list_fornecedor";
            this.list_fornecedor.Size = new System.Drawing.Size(506, 225);
            this.list_fornecedor.TabIndex = 0;
            this.list_fornecedor.DoubleClick += new System.EventHandler(this.list_fornecedor_DoubleClick);
            // 
            // go_addFornecedor
            // 
            this.go_addFornecedor.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.func_Add;
            this.go_addFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_addFornecedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_addFornecedor.Location = new System.Drawing.Point(269, 241);
            this.go_addFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.go_addFornecedor.Name = "go_addFornecedor";
            this.go_addFornecedor.Size = new System.Drawing.Size(247, 45);
            this.go_addFornecedor.TabIndex = 2;
            this.go_addFornecedor.Text = "Adicionar um novo fornecedor";
            this.go_addFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_addFornecedor.UseVisualStyleBackColor = true;
            this.go_addFornecedor.Click += new System.EventHandler(this.go_addFornecedor_Click);
            // 
            // go_fornecedor_Click
            // 
            this.go_fornecedor_Click.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Editfunc;
            this.go_fornecedor_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_fornecedor_Click.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_fornecedor_Click.Location = new System.Drawing.Point(10, 241);
            this.go_fornecedor_Click.Margin = new System.Windows.Forms.Padding(2);
            this.go_fornecedor_Click.Name = "go_fornecedor_Click";
            this.go_fornecedor_Click.Size = new System.Drawing.Size(245, 45);
            this.go_fornecedor_Click.TabIndex = 1;
            this.go_fornecedor_Click.Text = "Editar um fornecedor";
            this.go_fornecedor_Click.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_fornecedor_Click.UseVisualStyleBackColor = true;
            this.go_fornecedor_Click.Click += new System.EventHandler(this.go_fornecedor_Click_Click);
            // 
            // FornecedoresList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(524, 297);
            this.Controls.Add(this.go_addFornecedor);
            this.Controls.Add(this.go_fornecedor_Click);
            this.Controls.Add(this.list_fornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FornecedoresList";
            this.Text = "Lista de Fornecedores";
            this.Load += new System.EventHandler(this.FornecedoresList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_fornecedor;
        private System.Windows.Forms.Button go_fornecedor_Click;
        private System.Windows.Forms.Button go_addFornecedor;
    }
}
namespace PadariaEMerceariaDaFah.Forms.Estoque.Itens.AdicionarItem.ListaProdutos
{
    partial class ProdutosList
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
            this.list_produtos = new System.Windows.Forms.ListBox();
            this.add_produto_cancel = new System.Windows.Forms.Button();
            this.go_addProduto = new System.Windows.Forms.Button();
            this.go_produto_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_produtos
            // 
            this.list_produtos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_produtos.FormattingEnabled = true;
            this.list_produtos.ItemHeight = 21;
            this.list_produtos.Location = new System.Drawing.Point(12, 11);
            this.list_produtos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_produtos.Name = "list_produtos";
            this.list_produtos.Size = new System.Drawing.Size(689, 256);
            this.list_produtos.TabIndex = 14;
            this.list_produtos.DoubleClick += new System.EventHandler(this.list_produtos_DoubleClick);
            // 
            // add_produto_cancel
            // 
            this.add_produto_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_produto_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_produto_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_produto_cancel.Location = new System.Drawing.Point(562, 294);
            this.add_produto_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_produto_cancel.Name = "add_produto_cancel";
            this.add_produto_cancel.Size = new System.Drawing.Size(139, 55);
            this.add_produto_cancel.TabIndex = 17;
            this.add_produto_cancel.Text = "Cancelar";
            this.add_produto_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_produto_cancel.UseVisualStyleBackColor = true;
            this.add_produto_cancel.Click += new System.EventHandler(this.add_produto_cancel_Click);
            // 
            // go_addProduto
            // 
            this.go_addProduto.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.buy2;
            this.go_addProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_addProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_addProduto.Location = new System.Drawing.Point(252, 294);
            this.go_addProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_addProduto.Name = "go_addProduto";
            this.go_addProduto.Size = new System.Drawing.Size(304, 55);
            this.go_addProduto.TabIndex = 16;
            this.go_addProduto.Text = "Adicionar um novo produto";
            this.go_addProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_addProduto.UseVisualStyleBackColor = true;
            this.go_addProduto.Click += new System.EventHandler(this.go_addProduto_Click);
            // 
            // go_produto_Click
            // 
            this.go_produto_Click.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.edit_validated_icon;
            this.go_produto_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_produto_Click.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_produto_Click.Location = new System.Drawing.Point(12, 294);
            this.go_produto_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_produto_Click.Name = "go_produto_Click";
            this.go_produto_Click.Size = new System.Drawing.Size(234, 55);
            this.go_produto_Click.TabIndex = 15;
            this.go_produto_Click.Text = "Editar um produto";
            this.go_produto_Click.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_produto_Click.UseVisualStyleBackColor = true;
            this.go_produto_Click.Click += new System.EventHandler(this.go_produto_Click_Click);
            // 
            // ProdutosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(716, 359);
            this.Controls.Add(this.add_produto_cancel);
            this.Controls.Add(this.go_addProduto);
            this.Controls.Add(this.go_produto_Click);
            this.Controls.Add(this.list_produtos);
            this.Name = "ProdutosList";
            this.Text = "ProdutosList";
            this.Load += new System.EventHandler(this.ProdutosList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_produto_cancel;
        private System.Windows.Forms.Button go_addProduto;
        private System.Windows.Forms.Button go_produto_Click;
        private System.Windows.Forms.ListBox list_produtos;
    }
}
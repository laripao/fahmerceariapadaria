﻿namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFornecedores
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
            this.add_produto_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_fornecedor
            // 
            this.list_fornecedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_fornecedor.FormattingEnabled = true;
            this.list_fornecedor.ItemHeight = 21;
            this.list_fornecedor.Location = new System.Drawing.Point(13, 14);
            this.list_fornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_fornecedor.Name = "list_fornecedor";
            this.list_fornecedor.Size = new System.Drawing.Size(689, 256);
            this.list_fornecedor.TabIndex = 0;
            this.list_fornecedor.DoubleClick += new System.EventHandler(this.list_fornecedor_DoubleClick);
            // 
            // go_addFornecedor
            // 
            this.go_addFornecedor.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.func_Add;
            this.go_addFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_addFornecedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_addFornecedor.Location = new System.Drawing.Point(253, 297);
            this.go_addFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_addFornecedor.Name = "go_addFornecedor";
            this.go_addFornecedor.Size = new System.Drawing.Size(304, 55);
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
            this.go_fornecedor_Click.Location = new System.Drawing.Point(13, 297);
            this.go_fornecedor_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_fornecedor_Click.Name = "go_fornecedor_Click";
            this.go_fornecedor_Click.Size = new System.Drawing.Size(234, 55);
            this.go_fornecedor_Click.TabIndex = 1;
            this.go_fornecedor_Click.Text = "Editar um fornecedor";
            this.go_fornecedor_Click.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_fornecedor_Click.UseVisualStyleBackColor = true;
            this.go_fornecedor_Click.Click += new System.EventHandler(this.go_fornecedor_Click_Click);
            // 
            // add_produto_cancel
            // 
            this.add_produto_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_produto_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_produto_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_produto_cancel.Location = new System.Drawing.Point(563, 297);
            this.add_produto_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_produto_cancel.Name = "add_produto_cancel";
            this.add_produto_cancel.Size = new System.Drawing.Size(139, 55);
            this.add_produto_cancel.TabIndex = 13;
            this.add_produto_cancel.Text = "Cancelar";
            this.add_produto_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_produto_cancel.UseVisualStyleBackColor = true;
            this.add_produto_cancel.Click += new System.EventHandler(this.add_produto_cancel_Click);
            // 
            // FornecedoresList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(717, 366);
            this.Controls.Add(this.add_produto_cancel);
            this.Controls.Add(this.go_addFornecedor);
            this.Controls.Add(this.go_fornecedor_Click);
            this.Controls.Add(this.list_fornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button add_produto_cancel;
    }
}
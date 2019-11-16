namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos.RemoverProduto
{
    partial class RemoverProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoverProduto));
            this.label6 = new System.Windows.Forms.Label();
            this.group_edit_produto = new System.Windows.Forms.GroupBox();
            this.group_ingredientes = new System.Windows.Forms.GroupBox();
            this.lista_ingredientes = new System.Windows.Forms.ListBox();
            this.valor_text = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.des_text = new System.Windows.Forms.TextBox();
            this.nome_produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fabricado = new System.Windows.Forms.RadioButton();
            this.fornecedores = new System.Windows.Forms.Label();
            this.Fornecedor = new System.Windows.Forms.TextBox();
            this.revendido = new System.Windows.Forms.RadioButton();
            this.acc_remove = new System.Windows.Forms.Button();
            this.cancel_remove = new System.Windows.Forms.Button();
            this.group_edit_produto.SuspendLayout();
            this.group_ingredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tem certeza que deseja remover este produto?";
            // 
            // group_edit_produto
            // 
            this.group_edit_produto.BackColor = System.Drawing.Color.White;
            this.group_edit_produto.Controls.Add(this.group_ingredientes);
            this.group_edit_produto.Controls.Add(this.valor_text);
            this.group_edit_produto.Controls.Add(this.label3);
            this.group_edit_produto.Controls.Add(this.des_text);
            this.group_edit_produto.Controls.Add(this.nome_produto);
            this.group_edit_produto.Controls.Add(this.label2);
            this.group_edit_produto.Controls.Add(this.label1);
            this.group_edit_produto.Controls.Add(this.fabricado);
            this.group_edit_produto.Controls.Add(this.fornecedores);
            this.group_edit_produto.Controls.Add(this.Fornecedor);
            this.group_edit_produto.Controls.Add(this.revendido);
            this.group_edit_produto.Enabled = false;
            this.group_edit_produto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_edit_produto.Location = new System.Drawing.Point(9, 28);
            this.group_edit_produto.Margin = new System.Windows.Forms.Padding(2);
            this.group_edit_produto.Name = "group_edit_produto";
            this.group_edit_produto.Padding = new System.Windows.Forms.Padding(2);
            this.group_edit_produto.Size = new System.Drawing.Size(525, 356);
            this.group_edit_produto.TabIndex = 21;
            this.group_edit_produto.TabStop = false;
            this.group_edit_produto.Text = "Produto";
            // 
            // group_ingredientes
            // 
            this.group_ingredientes.Controls.Add(this.lista_ingredientes);
            this.group_ingredientes.Location = new System.Drawing.Point(49, 211);
            this.group_ingredientes.Margin = new System.Windows.Forms.Padding(2);
            this.group_ingredientes.Name = "group_ingredientes";
            this.group_ingredientes.Padding = new System.Windows.Forms.Padding(2);
            this.group_ingredientes.Size = new System.Drawing.Size(460, 131);
            this.group_ingredientes.TabIndex = 20;
            this.group_ingredientes.TabStop = false;
            this.group_ingredientes.Text = "Ingredientes";
            // 
            // lista_ingredientes
            // 
            this.lista_ingredientes.FormattingEnabled = true;
            this.lista_ingredientes.ItemHeight = 17;
            this.lista_ingredientes.Location = new System.Drawing.Point(20, 20);
            this.lista_ingredientes.Margin = new System.Windows.Forms.Padding(2);
            this.lista_ingredientes.Name = "lista_ingredientes";
            this.lista_ingredientes.Size = new System.Drawing.Size(420, 89);
            this.lista_ingredientes.TabIndex = 0;
            // 
            // valor_text
            // 
            this.valor_text.Location = new System.Drawing.Point(69, 106);
            this.valor_text.Margin = new System.Windows.Forms.Padding(2);
            this.valor_text.Mask = "99,99";
            this.valor_text.Name = "valor_text";
            this.valor_text.Size = new System.Drawing.Size(32, 23);
            this.valor_text.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor:";
            // 
            // des_text
            // 
            this.des_text.Location = new System.Drawing.Point(84, 141);
            this.des_text.Margin = new System.Windows.Forms.Padding(2);
            this.des_text.Multiline = true;
            this.des_text.Name = "des_text";
            this.des_text.Size = new System.Drawing.Size(420, 55);
            this.des_text.TabIndex = 17;
            // 
            // nome_produto
            // 
            this.nome_produto.Location = new System.Drawing.Point(69, 77);
            this.nome_produto.Margin = new System.Windows.Forms.Padding(2);
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.Size = new System.Drawing.Size(440, 23);
            this.nome_produto.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            // 
            // fabricado
            // 
            this.fabricado.AutoSize = true;
            this.fabricado.Location = new System.Drawing.Point(111, 26);
            this.fabricado.Margin = new System.Windows.Forms.Padding(2);
            this.fabricado.Name = "fabricado";
            this.fabricado.Size = new System.Drawing.Size(92, 21);
            this.fabricado.TabIndex = 13;
            this.fabricado.TabStop = true;
            this.fabricado.Text = "Fabricado";
            this.fabricado.UseVisualStyleBackColor = true;
            // 
            // fornecedores
            // 
            this.fornecedores.AutoSize = true;
            this.fornecedores.Location = new System.Drawing.Point(234, 27);
            this.fornecedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fornecedores.Name = "fornecedores";
            this.fornecedores.Size = new System.Drawing.Size(85, 17);
            this.fornecedores.TabIndex = 11;
            this.fornecedores.Text = "Fornecedor:";
            // 
            // Fornecedor
            // 
            this.Fornecedor.Enabled = false;
            this.Fornecedor.Location = new System.Drawing.Point(323, 24);
            this.Fornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(198, 23);
            this.Fornecedor.TabIndex = 10;
            // 
            // revendido
            // 
            this.revendido.AutoSize = true;
            this.revendido.Location = new System.Drawing.Point(11, 26);
            this.revendido.Margin = new System.Windows.Forms.Padding(2);
            this.revendido.Name = "revendido";
            this.revendido.Size = new System.Drawing.Size(96, 21);
            this.revendido.TabIndex = 9;
            this.revendido.TabStop = true;
            this.revendido.Text = "Revendido";
            this.revendido.UseVisualStyleBackColor = true;
            // 
            // acc_remove
            // 
            this.acc_remove.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.remove_func_icon;
            this.acc_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acc_remove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_remove.Location = new System.Drawing.Point(142, 388);
            this.acc_remove.Margin = new System.Windows.Forms.Padding(2);
            this.acc_remove.Name = "acc_remove";
            this.acc_remove.Size = new System.Drawing.Size(118, 44);
            this.acc_remove.TabIndex = 20;
            this.acc_remove.Text = "Remover";
            this.acc_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.acc_remove.UseVisualStyleBackColor = true;
            this.acc_remove.Click += new System.EventHandler(this.acc_remove_Click);
            // 
            // cancel_remove
            // 
            this.cancel_remove.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.cancel_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancel_remove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_remove.Location = new System.Drawing.Point(299, 388);
            this.cancel_remove.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_remove.Name = "cancel_remove";
            this.cancel_remove.Size = new System.Drawing.Size(118, 44);
            this.cancel_remove.TabIndex = 19;
            this.cancel_remove.Text = "Cancelar";
            this.cancel_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel_remove.UseVisualStyleBackColor = true;
            this.cancel_remove.Click += new System.EventHandler(this.cancel_remove_Click);
            // 
            // RemoverProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(545, 443);
            this.Controls.Add(this.group_edit_produto);
            this.Controls.Add(this.acc_remove);
            this.Controls.Add(this.cancel_remove);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RemoverProduto";
            this.Text = "Remover Produto";
            this.Load += new System.EventHandler(this.RemoverProduto_Load);
            this.group_edit_produto.ResumeLayout(false);
            this.group_edit_produto.PerformLayout();
            this.group_ingredientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button acc_remove;
        private System.Windows.Forms.Button cancel_remove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox group_edit_produto;
        private System.Windows.Forms.GroupBox group_ingredientes;
        private System.Windows.Forms.ListBox lista_ingredientes;
        private System.Windows.Forms.MaskedTextBox valor_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox des_text;
        private System.Windows.Forms.TextBox nome_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton fabricado;
        private System.Windows.Forms.Label fornecedores;
        private System.Windows.Forms.TextBox Fornecedor;
        private System.Windows.Forms.RadioButton revendido;
    }
}
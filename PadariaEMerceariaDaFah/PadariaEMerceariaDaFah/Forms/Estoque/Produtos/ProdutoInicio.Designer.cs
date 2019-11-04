namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos
{
    partial class ProdutoInicio
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.habilitar_edicao = new System.Windows.Forms.CheckBox();
            this.group_edit_produto = new System.Windows.Forms.GroupBox();
            this.group_ingredientes = new System.Windows.Forms.GroupBox();
            this.add_ingredientes = new System.Windows.Forms.Button();
            this.text_ingredientes = new System.Windows.Forms.TextBox();
            this.lista_ingredientes = new System.Windows.Forms.ListBox();
            this.valor_text = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.des_text = new System.Windows.Forms.TextBox();
            this.nome_produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fabricado = new System.Windows.Forms.RadioButton();
            this.linkFornecedores = new System.Windows.Forms.LinkLabel();
            this.fornecedores = new System.Windows.Forms.Label();
            this.Fornecedor = new System.Windows.Forms.TextBox();
            this.revendido = new System.Windows.Forms.RadioButton();
            this.list_produto = new System.Windows.Forms.ListBox();
            this.remove_produto = new System.Windows.Forms.Button();
            this.save_edit_produto = new System.Windows.Forms.Button();
            this.add_produto = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.group_edit_produto.SuspendLayout();
            this.group_ingredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.add_produto);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(925, 605);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.habilitar_edicao);
            this.groupBox1.Controls.Add(this.group_edit_produto);
            this.groupBox1.Controls.Add(this.list_produto);
            this.groupBox1.Location = new System.Drawing.Point(6, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 526);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos Existentes";
            // 
            // habilitar_edicao
            // 
            this.habilitar_edicao.AutoSize = true;
            this.habilitar_edicao.Location = new System.Drawing.Point(245, 32);
            this.habilitar_edicao.Name = "habilitar_edicao";
            this.habilitar_edicao.Size = new System.Drawing.Size(129, 21);
            this.habilitar_edicao.TabIndex = 10;
            this.habilitar_edicao.Text = "Habilitar Edição";
            this.habilitar_edicao.UseVisualStyleBackColor = true;
            this.habilitar_edicao.CheckedChanged += new System.EventHandler(this.habilitar_edicao_CheckedChanged);
            // 
            // group_edit_produto
            // 
            this.group_edit_produto.Controls.Add(this.group_ingredientes);
            this.group_edit_produto.Controls.Add(this.valor_text);
            this.group_edit_produto.Controls.Add(this.label3);
            this.group_edit_produto.Controls.Add(this.des_text);
            this.group_edit_produto.Controls.Add(this.nome_produto);
            this.group_edit_produto.Controls.Add(this.label2);
            this.group_edit_produto.Controls.Add(this.label1);
            this.group_edit_produto.Controls.Add(this.fabricado);
            this.group_edit_produto.Controls.Add(this.linkFornecedores);
            this.group_edit_produto.Controls.Add(this.fornecedores);
            this.group_edit_produto.Controls.Add(this.Fornecedor);
            this.group_edit_produto.Controls.Add(this.revendido);
            this.group_edit_produto.Controls.Add(this.remove_produto);
            this.group_edit_produto.Controls.Add(this.save_edit_produto);
            this.group_edit_produto.Location = new System.Drawing.Point(245, 59);
            this.group_edit_produto.Name = "group_edit_produto";
            this.group_edit_produto.Size = new System.Drawing.Size(662, 461);
            this.group_edit_produto.TabIndex = 8;
            this.group_edit_produto.TabStop = false;
            this.group_edit_produto.Text = "Produto";
            // 
            // group_ingredientes
            // 
            this.group_ingredientes.Controls.Add(this.add_ingredientes);
            this.group_ingredientes.Controls.Add(this.text_ingredientes);
            this.group_ingredientes.Controls.Add(this.lista_ingredientes);
            this.group_ingredientes.Location = new System.Drawing.Point(65, 260);
            this.group_ingredientes.Name = "group_ingredientes";
            this.group_ingredientes.Size = new System.Drawing.Size(591, 139);
            this.group_ingredientes.TabIndex = 20;
            this.group_ingredientes.TabStop = false;
            this.group_ingredientes.Text = "Ingredientes";
            // 
            // add_ingredientes
            // 
            this.add_ingredientes.Location = new System.Drawing.Point(469, 22);
            this.add_ingredientes.Name = "add_ingredientes";
            this.add_ingredientes.Size = new System.Drawing.Size(116, 22);
            this.add_ingredientes.TabIndex = 2;
            this.add_ingredientes.Text = "Adicionar";
            this.add_ingredientes.UseVisualStyleBackColor = true;
            this.add_ingredientes.Click += new System.EventHandler(this.add_ingredientes_Click);
            // 
            // text_ingredientes
            // 
            this.text_ingredientes.Location = new System.Drawing.Point(26, 22);
            this.text_ingredientes.Name = "text_ingredientes";
            this.text_ingredientes.Size = new System.Drawing.Size(437, 22);
            this.text_ingredientes.TabIndex = 1;
            // 
            // lista_ingredientes
            // 
            this.lista_ingredientes.FormattingEnabled = true;
            this.lista_ingredientes.ItemHeight = 16;
            this.lista_ingredientes.Location = new System.Drawing.Point(26, 51);
            this.lista_ingredientes.Name = "lista_ingredientes";
            this.lista_ingredientes.Size = new System.Drawing.Size(559, 84);
            this.lista_ingredientes.TabIndex = 0;
            // 
            // valor_text
            // 
            this.valor_text.Location = new System.Drawing.Point(65, 131);
            this.valor_text.Mask = "99,99";
            this.valor_text.Name = "valor_text";
            this.valor_text.Size = new System.Drawing.Size(42, 22);
            this.valor_text.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor:";
            // 
            // des_text
            // 
            this.des_text.Location = new System.Drawing.Point(91, 174);
            this.des_text.Multiline = true;
            this.des_text.Name = "des_text";
            this.des_text.Size = new System.Drawing.Size(565, 67);
            this.des_text.TabIndex = 17;
            // 
            // nome_produto
            // 
            this.nome_produto.Location = new System.Drawing.Point(65, 92);
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.Size = new System.Drawing.Size(591, 22);
            this.nome_produto.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            // 
            // fabricado
            // 
            this.fabricado.AutoSize = true;
            this.fabricado.Location = new System.Drawing.Point(111, 32);
            this.fabricado.Name = "fabricado";
            this.fabricado.Size = new System.Drawing.Size(92, 21);
            this.fabricado.TabIndex = 13;
            this.fabricado.TabStop = true;
            this.fabricado.Text = "Fabricado";
            this.fabricado.UseVisualStyleBackColor = true;
            this.fabricado.CheckedChanged += new System.EventHandler(this.fabricado_CheckedChanged);
            // 
            // linkFornecedores
            // 
            this.linkFornecedores.AutoSize = true;
            this.linkFornecedores.Location = new System.Drawing.Point(438, 56);
            this.linkFornecedores.Name = "linkFornecedores";
            this.linkFornecedores.Size = new System.Drawing.Size(166, 17);
            this.linkFornecedores.TabIndex = 12;
            this.linkFornecedores.TabStop = true;
            this.linkFornecedores.Text = "Selecione um fornecedor";
            this.linkFornecedores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFornecedores_LinkClicked);
            // 
            // fornecedores
            // 
            this.fornecedores.AutoSize = true;
            this.fornecedores.Location = new System.Drawing.Point(303, 33);
            this.fornecedores.Name = "fornecedores";
            this.fornecedores.Size = new System.Drawing.Size(85, 17);
            this.fornecedores.TabIndex = 11;
            this.fornecedores.Text = "Fornecedor:";
            // 
            // Fornecedor
            // 
            this.Fornecedor.Enabled = false;
            this.Fornecedor.Location = new System.Drawing.Point(394, 31);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(262, 22);
            this.Fornecedor.TabIndex = 10;
            // 
            // revendido
            // 
            this.revendido.AutoSize = true;
            this.revendido.Location = new System.Drawing.Point(8, 31);
            this.revendido.Name = "revendido";
            this.revendido.Size = new System.Drawing.Size(97, 21);
            this.revendido.TabIndex = 9;
            this.revendido.TabStop = true;
            this.revendido.Text = "Revendido";
            this.revendido.UseVisualStyleBackColor = true;
            this.revendido.CheckedChanged += new System.EventHandler(this.revendido_CheckedChanged);
            // 
            // list_produto
            // 
            this.list_produto.FormattingEnabled = true;
            this.list_produto.ItemHeight = 16;
            this.list_produto.Location = new System.Drawing.Point(12, 21);
            this.list_produto.Name = "list_produto";
            this.list_produto.Size = new System.Drawing.Size(214, 500);
            this.list_produto.TabIndex = 1;
            this.list_produto.SelectedValueChanged += new System.EventHandler(this.list_produto_SelectedValueChanged);
            // 
            // remove_produto
            // 
            this.remove_produto.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.shopping_basket_remove_icon;
            this.remove_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remove_produto.Location = new System.Drawing.Point(409, 405);
            this.remove_produto.Name = "remove_produto";
            this.remove_produto.Size = new System.Drawing.Size(196, 50);
            this.remove_produto.TabIndex = 8;
            this.remove_produto.Text = "Remover Produto";
            this.remove_produto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_produto.UseVisualStyleBackColor = true;
            this.remove_produto.Click += new System.EventHandler(this.remove_produto_Click);
            // 
            // save_edit_produto
            // 
            this.save_edit_produto.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.edit_validated_icon;
            this.save_edit_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_edit_produto.Location = new System.Drawing.Point(26, 405);
            this.save_edit_produto.Name = "save_edit_produto";
            this.save_edit_produto.Size = new System.Drawing.Size(143, 50);
            this.save_edit_produto.TabIndex = 7;
            this.save_edit_produto.Text = "Salvar Edição";
            this.save_edit_produto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_edit_produto.UseVisualStyleBackColor = true;
            this.save_edit_produto.Click += new System.EventHandler(this.save_edit_produto_Click);
            // 
            // add_produto
            // 
            this.add_produto.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.buy2;
            this.add_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_produto.Location = new System.Drawing.Point(550, 21);
            this.add_produto.Name = "add_produto";
            this.add_produto.Size = new System.Drawing.Size(294, 46);
            this.add_produto.TabIndex = 0;
            this.add_produto.Text = "Cadastrar Novo Produto";
            this.add_produto.UseVisualStyleBackColor = true;
            this.add_produto.Click += new System.EventHandler(this.add_produto_Click);
            // 
            // ProdutoInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 625);
            this.Controls.Add(this.groupBox2);
            this.Name = "ProdutoInicio";
            this.Text = "ProdutoInicio";
            this.Load += new System.EventHandler(this.ProdutoInicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_edit_produto.ResumeLayout(false);
            this.group_edit_produto.PerformLayout();
            this.group_ingredientes.ResumeLayout(false);
            this.group_ingredientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox habilitar_edicao;
        private System.Windows.Forms.GroupBox group_edit_produto;
        private System.Windows.Forms.Button remove_produto;
        private System.Windows.Forms.Button save_edit_produto;
        private System.Windows.Forms.ListBox list_produto;
        private System.Windows.Forms.Button add_produto;
        private System.Windows.Forms.RadioButton fabricado;
        private System.Windows.Forms.LinkLabel linkFornecedores;
        private System.Windows.Forms.Label fornecedores;
        private System.Windows.Forms.TextBox Fornecedor;
        private System.Windows.Forms.RadioButton revendido;
        private System.Windows.Forms.MaskedTextBox valor_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox des_text;
        private System.Windows.Forms.TextBox nome_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group_ingredientes;
        private System.Windows.Forms.Button add_ingredientes;
        private System.Windows.Forms.TextBox text_ingredientes;
        private System.Windows.Forms.ListBox lista_ingredientes;
    }
}
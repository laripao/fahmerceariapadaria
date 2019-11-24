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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoInicio));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.habilitar_edicao = new System.Windows.Forms.CheckBox();
            this.group_edit_produto = new System.Windows.Forms.GroupBox();
            this.group_ingredientes = new System.Windows.Forms.GroupBox();
            this.remove_ingredientes = new System.Windows.Forms.Button();
            this.add_ingredientes = new System.Windows.Forms.Button();
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
            this.linkFuncionario = new System.Windows.Forms.LinkLabel();
            this.QuemFabricou = new System.Windows.Forms.TextBox();
            this.fabricado_funcionario = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.group_edit_produto.SuspendLayout();
            this.group_ingredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.add_produto);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(935, 701);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.remove_produto);
            this.groupBox1.Controls.Add(this.save_edit_produto);
            this.groupBox1.Controls.Add(this.habilitar_edicao);
            this.groupBox1.Controls.Add(this.group_edit_produto);
            this.groupBox1.Controls.Add(this.list_produto);
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(935, 628);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos Existentes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // habilitar_edicao
            // 
            this.habilitar_edicao.AutoSize = true;
            this.habilitar_edicao.Location = new System.Drawing.Point(245, 25);
            this.habilitar_edicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.habilitar_edicao.Name = "habilitar_edicao";
            this.habilitar_edicao.Size = new System.Drawing.Size(164, 25);
            this.habilitar_edicao.TabIndex = 10;
            this.habilitar_edicao.Text = "Habilitar Edição";
            this.habilitar_edicao.UseVisualStyleBackColor = true;
            this.habilitar_edicao.CheckedChanged += new System.EventHandler(this.habilitar_edicao_CheckedChanged);
            // 
            // group_edit_produto
            // 
            this.group_edit_produto.BackColor = System.Drawing.Color.White;
            this.group_edit_produto.Controls.Add(this.linkFuncionario);
            this.group_edit_produto.Controls.Add(this.QuemFabricou);
            this.group_edit_produto.Controls.Add(this.fabricado_funcionario);
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
            this.group_edit_produto.Location = new System.Drawing.Point(245, 59);
            this.group_edit_produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_edit_produto.Name = "group_edit_produto";
            this.group_edit_produto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_edit_produto.Size = new System.Drawing.Size(673, 511);
            this.group_edit_produto.TabIndex = 8;
            this.group_edit_produto.TabStop = false;
            this.group_edit_produto.Text = "Produto";
            // 
            // group_ingredientes
            // 
            this.group_ingredientes.Controls.Add(this.remove_ingredientes);
            this.group_ingredientes.Controls.Add(this.add_ingredientes);
            this.group_ingredientes.Controls.Add(this.lista_ingredientes);
            this.group_ingredientes.Location = new System.Drawing.Point(65, 260);
            this.group_ingredientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_ingredientes.Name = "group_ingredientes";
            this.group_ingredientes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_ingredientes.Size = new System.Drawing.Size(597, 159);
            this.group_ingredientes.TabIndex = 20;
            this.group_ingredientes.TabStop = false;
            this.group_ingredientes.Text = "Ingredientes";
            // 
            // remove_ingredientes
            // 
            this.remove_ingredientes.Location = new System.Drawing.Point(393, 120);
            this.remove_ingredientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_ingredientes.Name = "remove_ingredientes";
            this.remove_ingredientes.Size = new System.Drawing.Size(139, 31);
            this.remove_ingredientes.TabIndex = 5;
            this.remove_ingredientes.Text = "Retirar";
            this.remove_ingredientes.UseVisualStyleBackColor = true;
            this.remove_ingredientes.Click += new System.EventHandler(this.remove_ingredientes_Click);
            // 
            // add_ingredientes
            // 
            this.add_ingredientes.Location = new System.Drawing.Point(64, 120);
            this.add_ingredientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_ingredientes.Name = "add_ingredientes";
            this.add_ingredientes.Size = new System.Drawing.Size(113, 31);
            this.add_ingredientes.TabIndex = 4;
            this.add_ingredientes.Text = "Adicionar";
            this.add_ingredientes.UseVisualStyleBackColor = true;
            this.add_ingredientes.Click += new System.EventHandler(this.add_ingredientes_Click_1);
            // 
            // lista_ingredientes
            // 
            this.lista_ingredientes.FormattingEnabled = true;
            this.lista_ingredientes.ItemHeight = 21;
            this.lista_ingredientes.Location = new System.Drawing.Point(25, 24);
            this.lista_ingredientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lista_ingredientes.Name = "lista_ingredientes";
            this.lista_ingredientes.Size = new System.Drawing.Size(559, 88);
            this.lista_ingredientes.TabIndex = 0;
            // 
            // valor_text
            // 
            this.valor_text.Location = new System.Drawing.Point(71, 134);
            this.valor_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valor_text.Name = "valor_text";
            this.valor_text.Size = new System.Drawing.Size(66, 27);
            this.valor_text.TabIndex = 19;
            this.valor_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_text_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor:";
            // 
            // des_text
            // 
            this.des_text.Location = new System.Drawing.Point(101, 174);
            this.des_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.des_text.Multiline = true;
            this.des_text.Name = "des_text";
            this.des_text.Size = new System.Drawing.Size(560, 67);
            this.des_text.TabIndex = 17;
            // 
            // nome_produto
            // 
            this.nome_produto.Location = new System.Drawing.Point(71, 97);
            this.nome_produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.Size = new System.Drawing.Size(591, 27);
            this.nome_produto.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            // 
            // fabricado
            // 
            this.fabricado.AutoSize = true;
            this.fabricado.Location = new System.Drawing.Point(148, 28);
            this.fabricado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fabricado.Name = "fabricado";
            this.fabricado.Size = new System.Drawing.Size(117, 25);
            this.fabricado.TabIndex = 13;
            this.fabricado.TabStop = true;
            this.fabricado.Text = "Fabricado";
            this.fabricado.UseVisualStyleBackColor = true;
            this.fabricado.CheckedChanged += new System.EventHandler(this.fabricado_CheckedChanged);
            // 
            // linkFornecedores
            // 
            this.linkFornecedores.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkFornecedores.AutoSize = true;
            this.linkFornecedores.BackColor = System.Drawing.Color.White;
            this.linkFornecedores.LinkColor = System.Drawing.Color.Blue;
            this.linkFornecedores.Location = new System.Drawing.Point(427, 60);
            this.linkFornecedores.Name = "linkFornecedores";
            this.linkFornecedores.Size = new System.Drawing.Size(216, 21);
            this.linkFornecedores.TabIndex = 12;
            this.linkFornecedores.TabStop = true;
            this.linkFornecedores.Text = "Selecione um fornecedor";
            this.linkFornecedores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFornecedores_LinkClicked);
            // 
            // fornecedores
            // 
            this.fornecedores.AutoSize = true;
            this.fornecedores.Location = new System.Drawing.Point(280, 33);
            this.fornecedores.Name = "fornecedores";
            this.fornecedores.Size = new System.Drawing.Size(110, 21);
            this.fornecedores.TabIndex = 11;
            this.fornecedores.Text = "Fornecedor:";
            // 
            // Fornecedor
            // 
            this.Fornecedor.Enabled = false;
            this.Fornecedor.Location = new System.Drawing.Point(399, 30);
            this.Fornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(263, 27);
            this.Fornecedor.TabIndex = 10;
            // 
            // revendido
            // 
            this.revendido.AutoSize = true;
            this.revendido.Location = new System.Drawing.Point(15, 28);
            this.revendido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revendido.Name = "revendido";
            this.revendido.Size = new System.Drawing.Size(122, 25);
            this.revendido.TabIndex = 9;
            this.revendido.TabStop = true;
            this.revendido.Text = "Revendido";
            this.revendido.UseVisualStyleBackColor = true;
            this.revendido.CheckedChanged += new System.EventHandler(this.revendido_CheckedChanged);
            // 
            // list_produto
            // 
            this.list_produto.FormattingEnabled = true;
            this.list_produto.ItemHeight = 21;
            this.list_produto.Location = new System.Drawing.Point(12, 21);
            this.list_produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_produto.Name = "list_produto";
            this.list_produto.Size = new System.Drawing.Size(215, 487);
            this.list_produto.TabIndex = 1;
            this.list_produto.SelectedValueChanged += new System.EventHandler(this.list_produto_SelectedValueChanged);
            // 
            // remove_produto
            // 
            this.remove_produto.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.shopping_basket_remove_icon;
            this.remove_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remove_produto.Location = new System.Drawing.Point(579, 574);
            this.remove_produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_produto.Name = "remove_produto";
            this.remove_produto.Size = new System.Drawing.Size(215, 50);
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
            this.save_edit_produto.Location = new System.Drawing.Point(260, 574);
            this.save_edit_produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_edit_produto.Name = "save_edit_produto";
            this.save_edit_produto.Size = new System.Drawing.Size(183, 50);
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
            this.add_produto.Location = new System.Drawing.Point(584, 22);
            this.add_produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_produto.Name = "add_produto";
            this.add_produto.Size = new System.Drawing.Size(293, 46);
            this.add_produto.TabIndex = 0;
            this.add_produto.Text = "Cadastrar Novo Produto";
            this.add_produto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_produto.UseVisualStyleBackColor = true;
            this.add_produto.Click += new System.EventHandler(this.add_produto_Click);
            // 
            // linkFuncionario
            // 
            this.linkFuncionario.AutoSize = true;
            this.linkFuncionario.Location = new System.Drawing.Point(263, 468);
            this.linkFuncionario.Name = "linkFuncionario";
            this.linkFuncionario.Size = new System.Drawing.Size(215, 21);
            this.linkFuncionario.TabIndex = 23;
            this.linkFuncionario.TabStop = true;
            this.linkFuncionario.Text = "Selecione um funcionário";
            this.linkFuncionario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFuncionario_LinkClicked);
            // 
            // QuemFabricou
            // 
            this.QuemFabricou.Enabled = false;
            this.QuemFabricou.Location = new System.Drawing.Point(148, 439);
            this.QuemFabricou.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuemFabricou.Name = "QuemFabricou";
            this.QuemFabricou.Size = new System.Drawing.Size(501, 27);
            this.QuemFabricou.TabIndex = 22;
            // 
            // fabricado_funcionario
            // 
            this.fabricado_funcionario.AutoSize = true;
            this.fabricado_funcionario.Location = new System.Drawing.Point(4, 442);
            this.fabricado_funcionario.Name = "fabricado_funcionario";
            this.fabricado_funcionario.Size = new System.Drawing.Size(134, 21);
            this.fabricado_funcionario.TabIndex = 21;
            this.fabricado_funcionario.Text = "Fabricado por:";
            // 
            // ProdutoInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(957, 719);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ProdutoInicio";
            this.Text = "Produto Início";
            this.Load += new System.EventHandler(this.ProdutoInicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_edit_produto.ResumeLayout(false);
            this.group_edit_produto.PerformLayout();
            this.group_ingredientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox habilitar_edicao;
        private System.Windows.Forms.Button remove_produto;
        private System.Windows.Forms.Button save_edit_produto;
        private System.Windows.Forms.ListBox list_produto;
        private System.Windows.Forms.Button add_produto;
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
        private System.Windows.Forms.LinkLabel linkFornecedores;
        private System.Windows.Forms.Label fornecedores;
        private System.Windows.Forms.TextBox Fornecedor;
        private System.Windows.Forms.RadioButton revendido;
        private System.Windows.Forms.Button remove_ingredientes;
        private System.Windows.Forms.Button add_ingredientes;
        private System.Windows.Forms.LinkLabel linkFuncionario;
        private System.Windows.Forms.TextBox QuemFabricou;
        private System.Windows.Forms.Label fabricado_funcionario;
    }
}
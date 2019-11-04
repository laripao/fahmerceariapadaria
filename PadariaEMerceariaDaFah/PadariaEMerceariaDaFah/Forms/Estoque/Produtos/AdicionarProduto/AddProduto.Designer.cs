namespace PadariaEMerceariaDaFah.Forms.Estoque.AddProduto
{
    partial class AddProduto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.group_ingredientes = new System.Windows.Forms.GroupBox();
            this.add_ingredientes = new System.Windows.Forms.Button();
            this.text_ingredientes = new System.Windows.Forms.TextBox();
            this.lista_ingredientes = new System.Windows.Forms.ListBox();
            this.add_produto_salvar = new System.Windows.Forms.Button();
            this.add_produto_cancel = new System.Windows.Forms.Button();
            this.valor_text = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fabricado = new System.Windows.Forms.RadioButton();
            this.des_text = new System.Windows.Forms.TextBox();
            this.nome_produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkFornecedores = new System.Windows.Forms.LinkLabel();
            this.fornecedores = new System.Windows.Forms.Label();
            this.Fornecedor = new System.Windows.Forms.TextBox();
            this.revendido = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.group_ingredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.group_ingredientes);
            this.groupBox1.Controls.Add(this.add_produto_salvar);
            this.groupBox1.Controls.Add(this.add_produto_cancel);
            this.groupBox1.Controls.Add(this.valor_text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fabricado);
            this.groupBox1.Controls.Add(this.des_text);
            this.groupBox1.Controls.Add(this.nome_produto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkFornecedores);
            this.groupBox1.Controls.Add(this.fornecedores);
            this.groupBox1.Controls.Add(this.Fornecedor);
            this.groupBox1.Controls.Add(this.revendido);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // group_ingredientes
            // 
            this.group_ingredientes.Controls.Add(this.add_ingredientes);
            this.group_ingredientes.Controls.Add(this.text_ingredientes);
            this.group_ingredientes.Controls.Add(this.lista_ingredientes);
            this.group_ingredientes.Location = new System.Drawing.Point(62, 254);
            this.group_ingredientes.Name = "group_ingredientes";
            this.group_ingredientes.Size = new System.Drawing.Size(700, 188);
            this.group_ingredientes.TabIndex = 14;
            this.group_ingredientes.TabStop = false;
            this.group_ingredientes.Text = "Ingredientes";
            // 
            // add_ingredientes
            // 
            this.add_ingredientes.Location = new System.Drawing.Point(520, 18);
            this.add_ingredientes.Name = "add_ingredientes";
            this.add_ingredientes.Size = new System.Drawing.Size(174, 30);
            this.add_ingredientes.TabIndex = 2;
            this.add_ingredientes.Text = "Adicionar";
            this.add_ingredientes.UseVisualStyleBackColor = true;
            this.add_ingredientes.Click += new System.EventHandler(this.add_ingredientes_Click);
            // 
            // text_ingredientes
            // 
            this.text_ingredientes.Location = new System.Drawing.Point(26, 18);
            this.text_ingredientes.Multiline = true;
            this.text_ingredientes.Name = "text_ingredientes";
            this.text_ingredientes.Size = new System.Drawing.Size(476, 30);
            this.text_ingredientes.TabIndex = 1;
            // 
            // lista_ingredientes
            // 
            this.lista_ingredientes.FormattingEnabled = true;
            this.lista_ingredientes.ItemHeight = 16;
            this.lista_ingredientes.Location = new System.Drawing.Point(26, 58);
            this.lista_ingredientes.Name = "lista_ingredientes";
            this.lista_ingredientes.Size = new System.Drawing.Size(668, 116);
            this.lista_ingredientes.TabIndex = 0;
            // 
            // add_produto_salvar
            // 
            this.add_produto_salvar.Location = new System.Drawing.Point(177, 448);
            this.add_produto_salvar.Name = "add_produto_salvar";
            this.add_produto_salvar.Size = new System.Drawing.Size(163, 49);
            this.add_produto_salvar.TabIndex = 13;
            this.add_produto_salvar.Text = "Salvar";
            this.add_produto_salvar.UseVisualStyleBackColor = true;
            this.add_produto_salvar.Click += new System.EventHandler(this.add_produto_salvar_Click);
            // 
            // add_produto_cancel
            // 
            this.add_produto_cancel.Location = new System.Drawing.Point(429, 448);
            this.add_produto_cancel.Name = "add_produto_cancel";
            this.add_produto_cancel.Size = new System.Drawing.Size(163, 49);
            this.add_produto_cancel.TabIndex = 12;
            this.add_produto_cancel.Text = "Cancelar";
            this.add_produto_cancel.UseVisualStyleBackColor = true;
            this.add_produto_cancel.Click += new System.EventHandler(this.add_produto_cancel_Click);
            // 
            // valor_text
            // 
            this.valor_text.Location = new System.Drawing.Point(62, 123);
            this.valor_text.Mask = "99,99";
            this.valor_text.Name = "valor_text";
            this.valor_text.Size = new System.Drawing.Size(42, 22);
            this.valor_text.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor:";
            // 
            // fabricado
            // 
            this.fabricado.AutoSize = true;
            this.fabricado.Location = new System.Drawing.Point(110, 23);
            this.fabricado.Name = "fabricado";
            this.fabricado.Size = new System.Drawing.Size(92, 21);
            this.fabricado.TabIndex = 8;
            this.fabricado.TabStop = true;
            this.fabricado.Text = "Fabricado";
            this.fabricado.UseVisualStyleBackColor = true;
            this.fabricado.CheckedChanged += new System.EventHandler(this.fabricado_CheckedChanged);
            // 
            // des_text
            // 
            this.des_text.Location = new System.Drawing.Point(88, 166);
            this.des_text.Multiline = true;
            this.des_text.Name = "des_text";
            this.des_text.Size = new System.Drawing.Size(674, 67);
            this.des_text.TabIndex = 7;
            // 
            // nome_produto
            // 
            this.nome_produto.Location = new System.Drawing.Point(62, 84);
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.Size = new System.Drawing.Size(700, 22);
            this.nome_produto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // linkFornecedores
            // 
            this.linkFornecedores.AutoSize = true;
            this.linkFornecedores.Location = new System.Drawing.Point(544, 47);
            this.linkFornecedores.Name = "linkFornecedores";
            this.linkFornecedores.Size = new System.Drawing.Size(166, 17);
            this.linkFornecedores.TabIndex = 3;
            this.linkFornecedores.TabStop = true;
            this.linkFornecedores.Text = "Selecione um fornecedor";
            this.linkFornecedores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFornecedores_LinkClicked);
            // 
            // fornecedores
            // 
            this.fornecedores.AutoSize = true;
            this.fornecedores.Location = new System.Drawing.Point(409, 24);
            this.fornecedores.Name = "fornecedores";
            this.fornecedores.Size = new System.Drawing.Size(85, 17);
            this.fornecedores.TabIndex = 2;
            this.fornecedores.Text = "Fornecedor:";
            // 
            // Fornecedor
            // 
            this.Fornecedor.Location = new System.Drawing.Point(500, 22);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(262, 22);
            this.Fornecedor.TabIndex = 1;
            this.Fornecedor.TextChanged += new System.EventHandler(this.Fornecedor_TextChanged);
            // 
            // revendido
            // 
            this.revendido.AutoSize = true;
            this.revendido.Location = new System.Drawing.Point(7, 22);
            this.revendido.Name = "revendido";
            this.revendido.Size = new System.Drawing.Size(97, 21);
            this.revendido.TabIndex = 0;
            this.revendido.TabStop = true;
            this.revendido.Text = "Revendido";
            this.revendido.UseVisualStyleBackColor = true;
            this.revendido.CheckedChanged += new System.EventHandler(this.revendido_CheckedChanged);
            // 
            // AddProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 528);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddProduto";
            this.Text = "AddProduto";
            this.Load += new System.EventHandler(this.AddProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_ingredientes.ResumeLayout(false);
            this.group_ingredientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fornecedores;
        private System.Windows.Forms.TextBox Fornecedor;
        private System.Windows.Forms.RadioButton revendido;
        private System.Windows.Forms.LinkLabel linkFornecedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome_produto;
        private System.Windows.Forms.TextBox des_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton fabricado;
        private System.Windows.Forms.MaskedTextBox valor_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_produto_salvar;
        private System.Windows.Forms.Button add_produto_cancel;
        private System.Windows.Forms.GroupBox group_ingredientes;
        private System.Windows.Forms.Button add_ingredientes;
        private System.Windows.Forms.TextBox text_ingredientes;
        private System.Windows.Forms.ListBox lista_ingredientes;
    }
}
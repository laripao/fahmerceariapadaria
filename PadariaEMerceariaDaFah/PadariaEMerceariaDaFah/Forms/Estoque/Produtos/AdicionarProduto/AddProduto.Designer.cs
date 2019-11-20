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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuemFabricou = new System.Windows.Forms.TextBox();
            this.fabricado_funcionario = new System.Windows.Forms.Label();
            this.group_ingredientes = new System.Windows.Forms.GroupBox();
            this.remove_ingredientes = new System.Windows.Forms.Button();
            this.add_ingredientes = new System.Windows.Forms.Button();
            this.lista_ingredientes = new System.Windows.Forms.ListBox();
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
            this.add_produto_salvar = new System.Windows.Forms.Button();
            this.add_produto_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.group_ingredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.QuemFabricou);
            this.groupBox1.Controls.Add(this.fabricado_funcionario);
            this.groupBox1.Controls.Add(this.group_ingredientes);
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
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(827, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // QuemFabricou
            // 
            this.QuemFabricou.Location = new System.Drawing.Point(156, 476);
            this.QuemFabricou.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuemFabricou.Name = "QuemFabricou";
            this.QuemFabricou.Size = new System.Drawing.Size(628, 27);
            this.QuemFabricou.TabIndex = 16;
            // 
            // fabricado_funcionario
            // 
            this.fabricado_funcionario.AutoSize = true;
            this.fabricado_funcionario.Location = new System.Drawing.Point(7, 479);
            this.fabricado_funcionario.Name = "fabricado_funcionario";
            this.fabricado_funcionario.Size = new System.Drawing.Size(134, 21);
            this.fabricado_funcionario.TabIndex = 15;
            this.fabricado_funcionario.Text = "Fabricado por:";
            // 
            // group_ingredientes
            // 
            this.group_ingredientes.Controls.Add(this.remove_ingredientes);
            this.group_ingredientes.Controls.Add(this.add_ingredientes);
            this.group_ingredientes.Controls.Add(this.lista_ingredientes);
            this.group_ingredientes.Location = new System.Drawing.Point(84, 258);
            this.group_ingredientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_ingredientes.Name = "group_ingredientes";
            this.group_ingredientes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_ingredientes.Size = new System.Drawing.Size(700, 214);
            this.group_ingredientes.TabIndex = 14;
            this.group_ingredientes.TabStop = false;
            this.group_ingredientes.Text = "Ingredientes";
            // 
            // remove_ingredientes
            // 
            this.remove_ingredientes.Location = new System.Drawing.Point(444, 179);
            this.remove_ingredientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_ingredientes.Name = "remove_ingredientes";
            this.remove_ingredientes.Size = new System.Drawing.Size(139, 31);
            this.remove_ingredientes.TabIndex = 3;
            this.remove_ingredientes.Text = "Retirar";
            this.remove_ingredientes.UseVisualStyleBackColor = true;
            this.remove_ingredientes.Click += new System.EventHandler(this.remove_ingredientes_Click);
            // 
            // add_ingredientes
            // 
            this.add_ingredientes.Location = new System.Drawing.Point(115, 179);
            this.add_ingredientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_ingredientes.Name = "add_ingredientes";
            this.add_ingredientes.Size = new System.Drawing.Size(113, 31);
            this.add_ingredientes.TabIndex = 2;
            this.add_ingredientes.Text = "Adicionar";
            this.add_ingredientes.UseVisualStyleBackColor = true;
            this.add_ingredientes.Click += new System.EventHandler(this.add_ingredientes_Click);
            // 
            // lista_ingredientes
            // 
            this.lista_ingredientes.FormattingEnabled = true;
            this.lista_ingredientes.ItemHeight = 21;
            this.lista_ingredientes.Location = new System.Drawing.Point(27, 24);
            this.lista_ingredientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lista_ingredientes.Name = "lista_ingredientes";
            this.lista_ingredientes.Size = new System.Drawing.Size(668, 151);
            this.lista_ingredientes.TabIndex = 0;
            // 
            // valor_text
            // 
            this.valor_text.Location = new System.Drawing.Point(111, 126);
            this.valor_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valor_text.Name = "valor_text";
            this.valor_text.Size = new System.Drawing.Size(70, 27);
            this.valor_text.TabIndex = 10;
            this.valor_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_text_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor:";
            // 
            // fabricado
            // 
            this.fabricado.AutoSize = true;
            this.fabricado.Location = new System.Drawing.Point(139, 25);
            this.fabricado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fabricado.Name = "fabricado";
            this.fabricado.Size = new System.Drawing.Size(117, 25);
            this.fabricado.TabIndex = 8;
            this.fabricado.TabStop = true;
            this.fabricado.Text = "Fabricado";
            this.fabricado.UseVisualStyleBackColor = true;
            this.fabricado.CheckedChanged += new System.EventHandler(this.fabricado_CheckedChanged);
            // 
            // des_text
            // 
            this.des_text.Location = new System.Drawing.Point(109, 169);
            this.des_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.des_text.Multiline = true;
            this.des_text.Name = "des_text";
            this.des_text.Size = new System.Drawing.Size(673, 67);
            this.des_text.TabIndex = 7;
            // 
            // nome_produto
            // 
            this.nome_produto.Location = new System.Drawing.Point(111, 87);
            this.nome_produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.Size = new System.Drawing.Size(700, 27);
            this.nome_produto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // linkFornecedores
            // 
            this.linkFornecedores.AutoSize = true;
            this.linkFornecedores.Location = new System.Drawing.Point(559, 53);
            this.linkFornecedores.Name = "linkFornecedores";
            this.linkFornecedores.Size = new System.Drawing.Size(216, 21);
            this.linkFornecedores.TabIndex = 3;
            this.linkFornecedores.TabStop = true;
            this.linkFornecedores.Text = "Selecione um fornecedor";
            this.linkFornecedores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFornecedores_LinkClicked);
            // 
            // fornecedores
            // 
            this.fornecedores.AutoSize = true;
            this.fornecedores.Location = new System.Drawing.Point(409, 25);
            this.fornecedores.Name = "fornecedores";
            this.fornecedores.Size = new System.Drawing.Size(110, 21);
            this.fornecedores.TabIndex = 2;
            this.fornecedores.Text = "Fornecedor:";
            // 
            // Fornecedor
            // 
            this.Fornecedor.Location = new System.Drawing.Point(528, 22);
            this.Fornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(263, 27);
            this.Fornecedor.TabIndex = 1;
            this.Fornecedor.TextChanged += new System.EventHandler(this.Fornecedor_TextChanged);
            // 
            // revendido
            // 
            this.revendido.AutoSize = true;
            this.revendido.Location = new System.Drawing.Point(11, 25);
            this.revendido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revendido.Name = "revendido";
            this.revendido.Size = new System.Drawing.Size(122, 25);
            this.revendido.TabIndex = 0;
            this.revendido.TabStop = true;
            this.revendido.Text = "Revendido";
            this.revendido.UseVisualStyleBackColor = true;
            this.revendido.CheckedChanged += new System.EventHandler(this.revendido_CheckedChanged);
            // 
            // add_produto_salvar
            // 
            this.add_produto_salvar.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.add_produto_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_produto_salvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_produto_salvar.Location = new System.Drawing.Point(212, 526);
            this.add_produto_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_produto_salvar.Name = "add_produto_salvar";
            this.add_produto_salvar.Size = new System.Drawing.Size(113, 49);
            this.add_produto_salvar.TabIndex = 13;
            this.add_produto_salvar.Text = "Salvar";
            this.add_produto_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_produto_salvar.UseVisualStyleBackColor = true;
            this.add_produto_salvar.Click += new System.EventHandler(this.add_produto_salvar_Click);
            // 
            // add_produto_cancel
            // 
            this.add_produto_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_produto_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_produto_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_produto_cancel.Location = new System.Drawing.Point(445, 526);
            this.add_produto_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_produto_cancel.Name = "add_produto_cancel";
            this.add_produto_cancel.Size = new System.Drawing.Size(139, 49);
            this.add_produto_cancel.TabIndex = 12;
            this.add_produto_cancel.Text = "Cancelar";
            this.add_produto_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_produto_cancel.UseVisualStyleBackColor = true;
            this.add_produto_cancel.Click += new System.EventHandler(this.add_produto_cancel_Click);
            // 
            // AddProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(852, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.add_produto_salvar);
            this.Controls.Add(this.add_produto_cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddProduto";
            this.Text = "Adicionar Produto";
            this.Load += new System.EventHandler(this.AddProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_ingredientes.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lista_ingredientes;
        private System.Windows.Forms.TextBox QuemFabricou;
        private System.Windows.Forms.Label fabricado_funcionario;
        private System.Windows.Forms.Button remove_ingredientes;
    }
}
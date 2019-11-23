namespace PadariaEMerceariaDaFah.Forms.Estoque.Ingredientes
{
    partial class IngredientesInicio
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
            this.edit_ingrediente = new System.Windows.Forms.GroupBox();
            this.remove_ingrediente = new System.Windows.Forms.Button();
            this.save_edit_ingrediente = new System.Windows.Forms.Button();
            this.quantidade_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.data_validade = new System.Windows.Forms.DateTimePicker();
            this.valor_text = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nome_ingrediente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkFornecedores = new System.Windows.Forms.LinkLabel();
            this.fornecedores = new System.Windows.Forms.Label();
            this.Fornecedor = new System.Windows.Forms.TextBox();
            this.habilitar_edicao = new System.Windows.Forms.CheckBox();
            this.list_Ingrediente = new System.Windows.Forms.ListBox();
            this.add_ingrediente = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.edit_ingrediente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.add_ingrediente);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(935, 409);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredientes";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.edit_ingrediente);
            this.groupBox1.Controls.Add(this.habilitar_edicao);
            this.groupBox1.Controls.Add(this.list_Ingrediente);
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(935, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredientes Existentes";
            // 
            // edit_ingrediente
            // 
            this.edit_ingrediente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_ingrediente.BackColor = System.Drawing.Color.White;
            this.edit_ingrediente.Controls.Add(this.remove_ingrediente);
            this.edit_ingrediente.Controls.Add(this.save_edit_ingrediente);
            this.edit_ingrediente.Controls.Add(this.quantidade_text);
            this.edit_ingrediente.Controls.Add(this.label5);
            this.edit_ingrediente.Controls.Add(this.data_validade);
            this.edit_ingrediente.Controls.Add(this.valor_text);
            this.edit_ingrediente.Controls.Add(this.label3);
            this.edit_ingrediente.Controls.Add(this.nome_ingrediente);
            this.edit_ingrediente.Controls.Add(this.label2);
            this.edit_ingrediente.Controls.Add(this.label1);
            this.edit_ingrediente.Controls.Add(this.linkFornecedores);
            this.edit_ingrediente.Controls.Add(this.fornecedores);
            this.edit_ingrediente.Controls.Add(this.Fornecedor);
            this.edit_ingrediente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_ingrediente.Location = new System.Drawing.Point(245, 54);
            this.edit_ingrediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_ingrediente.Name = "edit_ingrediente";
            this.edit_ingrediente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_ingrediente.Size = new System.Drawing.Size(684, 265);
            this.edit_ingrediente.TabIndex = 15;
            this.edit_ingrediente.TabStop = false;
            this.edit_ingrediente.Text = "Ingrediente";
            // 
            // remove_ingrediente
            // 
            this.remove_ingrediente.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.shopping_basket_remove_icon;
            this.remove_ingrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remove_ingrediente.Location = new System.Drawing.Point(388, 208);
            this.remove_ingrediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_ingrediente.Name = "remove_ingrediente";
            this.remove_ingrediente.Size = new System.Drawing.Size(227, 50);
            this.remove_ingrediente.TabIndex = 21;
            this.remove_ingrediente.Text = "Remover Ingrediente";
            this.remove_ingrediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_ingrediente.UseVisualStyleBackColor = true;
            this.remove_ingrediente.Click += new System.EventHandler(this.remove_ingrediente_Click);
            // 
            // save_edit_ingrediente
            // 
            this.save_edit_ingrediente.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.edit_validated_icon;
            this.save_edit_ingrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_edit_ingrediente.Location = new System.Drawing.Point(69, 208);
            this.save_edit_ingrediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_edit_ingrediente.Name = "save_edit_ingrediente";
            this.save_edit_ingrediente.Size = new System.Drawing.Size(183, 50);
            this.save_edit_ingrediente.TabIndex = 20;
            this.save_edit_ingrediente.Text = "Salvar Edição";
            this.save_edit_ingrediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_edit_ingrediente.UseVisualStyleBackColor = true;
            this.save_edit_ingrediente.Click += new System.EventHandler(this.save_edit_ingrediente_Click);
            // 
            // quantidade_text
            // 
            this.quantidade_text.Location = new System.Drawing.Point(629, 126);
            this.quantidade_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantidade_text.Name = "quantidade_text";
            this.quantidade_text.Size = new System.Drawing.Size(49, 27);
            this.quantidade_text.TabIndex = 19;
            this.quantidade_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidade_text_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantidade:";
            // 
            // data_validade
            // 
            this.data_validade.Location = new System.Drawing.Point(111, 164);
            this.data_validade.Name = "data_validade";
            this.data_validade.Size = new System.Drawing.Size(364, 27);
            this.data_validade.TabIndex = 17;
            this.data_validade.Value = new System.DateTime(2019, 11, 16, 20, 13, 20, 0);
            // 
            // valor_text
            // 
            this.valor_text.Location = new System.Drawing.Point(111, 126);
            this.valor_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valor_text.Name = "valor_text";
            this.valor_text.Size = new System.Drawing.Size(41, 27);
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
            // nome_ingrediente
            // 
            this.nome_ingrediente.Location = new System.Drawing.Point(111, 87);
            this.nome_ingrediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nome_ingrediente.Name = "nome_ingrediente";
            this.nome_ingrediente.Size = new System.Drawing.Size(567, 27);
            this.nome_ingrediente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Validade:";
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
            this.linkFornecedores.Location = new System.Drawing.Point(157, 53);
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
            this.fornecedores.Location = new System.Drawing.Point(7, 25);
            this.fornecedores.Name = "fornecedores";
            this.fornecedores.Size = new System.Drawing.Size(110, 21);
            this.fornecedores.TabIndex = 2;
            this.fornecedores.Text = "Fornecedor:";
            // 
            // Fornecedor
            // 
            this.Fornecedor.Enabled = false;
            this.Fornecedor.Location = new System.Drawing.Point(126, 22);
            this.Fornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(263, 27);
            this.Fornecedor.TabIndex = 1;
            this.Fornecedor.TextChanged += new System.EventHandler(this.Fornecedor_TextChanged);
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
            // list_Ingrediente
            // 
            this.list_Ingrediente.FormattingEnabled = true;
            this.list_Ingrediente.ItemHeight = 21;
            this.list_Ingrediente.Location = new System.Drawing.Point(12, 21);
            this.list_Ingrediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_Ingrediente.Name = "list_Ingrediente";
            this.list_Ingrediente.Size = new System.Drawing.Size(215, 298);
            this.list_Ingrediente.TabIndex = 1;
            this.list_Ingrediente.SelectedValueChanged += new System.EventHandler(this.list_Ingrediente_SelectedValueChanged);
            // 
            // add_ingrediente
            // 
            this.add_ingrediente.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.buy2;
            this.add_ingrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_ingrediente.Location = new System.Drawing.Point(584, 22);
            this.add_ingrediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_ingrediente.Name = "add_ingrediente";
            this.add_ingrediente.Size = new System.Drawing.Size(293, 46);
            this.add_ingrediente.TabIndex = 0;
            this.add_ingrediente.Text = "Cadastrar Novo Ingrediente";
            this.add_ingrediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_ingrediente.UseVisualStyleBackColor = true;
            this.add_ingrediente.Click += new System.EventHandler(this.add_produto_Click);
            // 
            // IngredientesInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 429);
            this.Controls.Add(this.groupBox2);
            this.Name = "IngredientesInicio";
            this.Text = "IngredientesInicio";
            this.Load += new System.EventHandler(this.IngredientesInicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.edit_ingrediente.ResumeLayout(false);
            this.edit_ingrediente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox habilitar_edicao;
        private System.Windows.Forms.ListBox list_Ingrediente;
        private System.Windows.Forms.Button add_ingrediente;
        private System.Windows.Forms.GroupBox edit_ingrediente;
        private System.Windows.Forms.Button remove_ingrediente;
        private System.Windows.Forms.Button save_edit_ingrediente;
        private System.Windows.Forms.TextBox quantidade_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker data_validade;
        private System.Windows.Forms.MaskedTextBox valor_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome_ingrediente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkFornecedores;
        private System.Windows.Forms.Label fornecedores;
        private System.Windows.Forms.TextBox Fornecedor;
    }
}
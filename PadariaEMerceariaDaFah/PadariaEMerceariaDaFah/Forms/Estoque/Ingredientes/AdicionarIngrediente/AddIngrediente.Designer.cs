namespace PadariaEMerceariaDaFah.Forms.Estoque.Ingredientes.AdicionarIngrediente
{
    partial class AddIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngrediente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.add_ingrediente_salvar = new System.Windows.Forms.Button();
            this.add_ingrediente_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.quantidade_text);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.data_validade);
            this.groupBox1.Controls.Add(this.valor_text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nome_ingrediente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkFornecedores);
            this.groupBox1.Controls.Add(this.fornecedores);
            this.groupBox1.Controls.Add(this.Fornecedor);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(367, 170);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrediente";
            // 
            // quantidade_text
            // 
            this.quantidade_text.Location = new System.Drawing.Point(322, 102);
            this.quantidade_text.Margin = new System.Windows.Forms.Padding(2);
            this.quantidade_text.Name = "quantidade_text";
            this.quantidade_text.Size = new System.Drawing.Size(38, 23);
            this.quantidade_text.TabIndex = 19;
            this.quantidade_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidade_text_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantidade:";
            // 
            // data_validade
            // 
            this.data_validade.Location = new System.Drawing.Point(83, 133);
            this.data_validade.Margin = new System.Windows.Forms.Padding(2);
            this.data_validade.Name = "data_validade";
            this.data_validade.Size = new System.Drawing.Size(277, 23);
            this.data_validade.TabIndex = 17;
            this.data_validade.Value = new System.DateTime(2019, 11, 16, 20, 13, 20, 0);
            // 
            // valor_text
            // 
            this.valor_text.Location = new System.Drawing.Point(83, 102);
            this.valor_text.Margin = new System.Windows.Forms.Padding(2);
            this.valor_text.Name = "valor_text";
            this.valor_text.Size = new System.Drawing.Size(32, 23);
            this.valor_text.TabIndex = 10;
            this.valor_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_text_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor:";
            // 
            // nome_ingrediente
            // 
            this.nome_ingrediente.Location = new System.Drawing.Point(83, 71);
            this.nome_ingrediente.Margin = new System.Windows.Forms.Padding(2);
            this.nome_ingrediente.Name = "nome_ingrediente";
            this.nome_ingrediente.Size = new System.Drawing.Size(277, 23);
            this.nome_ingrediente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Validade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // linkFornecedores
            // 
            this.linkFornecedores.AutoSize = true;
            this.linkFornecedores.Location = new System.Drawing.Point(118, 43);
            this.linkFornecedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkFornecedores.Name = "linkFornecedores";
            this.linkFornecedores.Size = new System.Drawing.Size(169, 17);
            this.linkFornecedores.TabIndex = 3;
            this.linkFornecedores.TabStop = true;
            this.linkFornecedores.Text = "Selecione um fornecedor";
            this.linkFornecedores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFornecedores_LinkClicked);
            // 
            // fornecedores
            // 
            this.fornecedores.AutoSize = true;
            this.fornecedores.Location = new System.Drawing.Point(5, 20);
            this.fornecedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fornecedores.Name = "fornecedores";
            this.fornecedores.Size = new System.Drawing.Size(85, 17);
            this.fornecedores.TabIndex = 2;
            this.fornecedores.Text = "Fornecedor:";
            // 
            // Fornecedor
            // 
            this.Fornecedor.Enabled = false;
            this.Fornecedor.Location = new System.Drawing.Point(94, 18);
            this.Fornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(198, 23);
            this.Fornecedor.TabIndex = 1;
            // 
            // add_ingrediente_salvar
            // 
            this.add_ingrediente_salvar.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.add_ingrediente_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_ingrediente_salvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_ingrediente_salvar.Location = new System.Drawing.Point(38, 182);
            this.add_ingrediente_salvar.Margin = new System.Windows.Forms.Padding(2);
            this.add_ingrediente_salvar.Name = "add_ingrediente_salvar";
            this.add_ingrediente_salvar.Size = new System.Drawing.Size(85, 40);
            this.add_ingrediente_salvar.TabIndex = 16;
            this.add_ingrediente_salvar.Text = "Salvar";
            this.add_ingrediente_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_ingrediente_salvar.UseVisualStyleBackColor = true;
            this.add_ingrediente_salvar.Click += new System.EventHandler(this.add_ingrediente_salvar_Click);
            // 
            // add_ingrediente_cancel
            // 
            this.add_ingrediente_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_ingrediente_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_ingrediente_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_ingrediente_cancel.Location = new System.Drawing.Point(213, 182);
            this.add_ingrediente_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.add_ingrediente_cancel.Name = "add_ingrediente_cancel";
            this.add_ingrediente_cancel.Size = new System.Drawing.Size(104, 40);
            this.add_ingrediente_cancel.TabIndex = 15;
            this.add_ingrediente_cancel.Text = "Cancelar";
            this.add_ingrediente_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_ingrediente_cancel.UseVisualStyleBackColor = true;
            this.add_ingrediente_cancel.Click += new System.EventHandler(this.add_ingrediente_cancel_Click);
            // 
            // AddIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(385, 232);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.add_ingrediente_salvar);
            this.Controls.Add(this.add_ingrediente_cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddIngrediente";
            this.Text = "Adicionar Ingrediente";
            this.Load += new System.EventHandler(this.AddIngrediente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome_ingrediente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkFornecedores;
        private System.Windows.Forms.Label fornecedores;
        private System.Windows.Forms.TextBox Fornecedor;
        private System.Windows.Forms.Button add_ingrediente_salvar;
        private System.Windows.Forms.Button add_ingrediente_cancel;
        private System.Windows.Forms.DateTimePicker data_validade;
        private System.Windows.Forms.TextBox quantidade_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox valor_text;
    }
}
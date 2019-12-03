namespace PadariaEMerceariaDaFah.Forms.Vendas.AddVenda
{
    partial class AddVenda
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkCliente = new System.Windows.Forms.LinkLabel();
            this.QuemComprou = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkFuncionario = new System.Windows.Forms.LinkLabel();
            this.QuemVendeu = new System.Windows.Forms.TextBox();
            this.vendido_funcionario = new System.Windows.Forms.Label();
            this.data_venda = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.group_produtos = new System.Windows.Forms.GroupBox();
            this.remove_produtos = new System.Windows.Forms.Button();
            this.add_produtos = new System.Windows.Forms.Button();
            this.lista_produtos = new System.Windows.Forms.ListBox();
            this.add_venda_cancel = new System.Windows.Forms.Button();
            this.add_venda_salvar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.group_produtos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.Valor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.linkCliente);
            this.groupBox3.Controls.Add(this.QuemComprou);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.linkFuncionario);
            this.groupBox3.Controls.Add(this.QuemVendeu);
            this.groupBox3.Controls.Add(this.vendido_funcionario);
            this.groupBox3.Controls.Add(this.data_venda);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.group_produtos);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(800, 465);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastro de Venda";
            // 
            // Valor
            // 
            this.Valor.Enabled = false;
            this.Valor.Location = new System.Drawing.Point(217, 414);
            this.Valor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(194, 27);
            this.Valor.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Valor total da compra:";
            // 
            // linkCliente
            // 
            this.linkCliente.AutoSize = true;
            this.linkCliente.Location = new System.Drawing.Point(403, 201);
            this.linkCliente.Name = "linkCliente";
            this.linkCliente.Size = new System.Drawing.Size(180, 21);
            this.linkCliente.TabIndex = 33;
            this.linkCliente.TabStop = true;
            this.linkCliente.Text = "Selecione um cliente";
            this.linkCliente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCliente_LinkClicked);
            // 
            // QuemComprou
            // 
            this.QuemComprou.Enabled = false;
            this.QuemComprou.Location = new System.Drawing.Point(206, 172);
            this.QuemComprou.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuemComprou.Name = "QuemComprou";
            this.QuemComprou.Size = new System.Drawing.Size(583, 27);
            this.QuemComprou.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Venda para o cliente:";
            // 
            // linkFuncionario
            // 
            this.linkFuncionario.AutoSize = true;
            this.linkFuncionario.Location = new System.Drawing.Point(392, 127);
            this.linkFuncionario.Name = "linkFuncionario";
            this.linkFuncionario.Size = new System.Drawing.Size(215, 21);
            this.linkFuncionario.TabIndex = 30;
            this.linkFuncionario.TabStop = true;
            this.linkFuncionario.Text = "Selecione um funcionário";
            this.linkFuncionario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFuncionario_LinkClicked);
            // 
            // QuemVendeu
            // 
            this.QuemVendeu.Enabled = false;
            this.QuemVendeu.Location = new System.Drawing.Point(206, 98);
            this.QuemVendeu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuemVendeu.Name = "QuemVendeu";
            this.QuemVendeu.Size = new System.Drawing.Size(583, 27);
            this.QuemVendeu.TabIndex = 29;
            // 
            // vendido_funcionario
            // 
            this.vendido_funcionario.AutoSize = true;
            this.vendido_funcionario.Location = new System.Drawing.Point(12, 101);
            this.vendido_funcionario.Name = "vendido_funcionario";
            this.vendido_funcionario.Size = new System.Drawing.Size(188, 21);
            this.vendido_funcionario.TabIndex = 28;
            this.vendido_funcionario.Text = "Venda realizada por:";
            // 
            // data_venda
            // 
            this.data_venda.Location = new System.Drawing.Point(166, 39);
            this.data_venda.Name = "data_venda";
            this.data_venda.Size = new System.Drawing.Size(364, 27);
            this.data_venda.TabIndex = 27;
            this.data_venda.Value = new System.DateTime(2019, 11, 30, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Data de Venda:";
            // 
            // group_produtos
            // 
            this.group_produtos.Controls.Add(this.remove_produtos);
            this.group_produtos.Controls.Add(this.add_produtos);
            this.group_produtos.Controls.Add(this.lista_produtos);
            this.group_produtos.Location = new System.Drawing.Point(6, 235);
            this.group_produtos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_produtos.Name = "group_produtos";
            this.group_produtos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_produtos.Size = new System.Drawing.Size(788, 159);
            this.group_produtos.TabIndex = 21;
            this.group_produtos.TabStop = false;
            this.group_produtos.Text = "Produtos Comprados";
            // 
            // remove_produtos
            // 
            this.remove_produtos.Location = new System.Drawing.Point(483, 120);
            this.remove_produtos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_produtos.Name = "remove_produtos";
            this.remove_produtos.Size = new System.Drawing.Size(139, 31);
            this.remove_produtos.TabIndex = 5;
            this.remove_produtos.Text = "Retirar";
            this.remove_produtos.UseVisualStyleBackColor = true;
            this.remove_produtos.Click += new System.EventHandler(this.remove_ingredientes_Click);
            // 
            // add_produtos
            // 
            this.add_produtos.Location = new System.Drawing.Point(154, 120);
            this.add_produtos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_produtos.Name = "add_produtos";
            this.add_produtos.Size = new System.Drawing.Size(113, 31);
            this.add_produtos.TabIndex = 4;
            this.add_produtos.Text = "Adicionar";
            this.add_produtos.UseVisualStyleBackColor = true;
            this.add_produtos.Click += new System.EventHandler(this.add_ingredientes_Click);
            // 
            // lista_produtos
            // 
            this.lista_produtos.FormattingEnabled = true;
            this.lista_produtos.ItemHeight = 21;
            this.lista_produtos.Location = new System.Drawing.Point(25, 24);
            this.lista_produtos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lista_produtos.Name = "lista_produtos";
            this.lista_produtos.Size = new System.Drawing.Size(757, 88);
            this.lista_produtos.TabIndex = 0;
            // 
            // add_venda_cancel
            // 
            this.add_venda_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_venda_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_venda_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_venda_cancel.Location = new System.Drawing.Point(501, 480);
            this.add_venda_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_venda_cancel.Name = "add_venda_cancel";
            this.add_venda_cancel.Size = new System.Drawing.Size(144, 49);
            this.add_venda_cancel.TabIndex = 16;
            this.add_venda_cancel.Text = "Cancelar";
            this.add_venda_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_venda_cancel.UseVisualStyleBackColor = true;
            this.add_venda_cancel.Click += new System.EventHandler(this.add_venda_cancel_Click);
            // 
            // add_venda_salvar
            // 
            this.add_venda_salvar.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.add_venda_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_venda_salvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_venda_salvar.Location = new System.Drawing.Point(177, 480);
            this.add_venda_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_venda_salvar.Name = "add_venda_salvar";
            this.add_venda_salvar.Size = new System.Drawing.Size(144, 49);
            this.add_venda_salvar.TabIndex = 17;
            this.add_venda_salvar.Text = "Salvar";
            this.add_venda_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_venda_salvar.UseVisualStyleBackColor = true;
            this.add_venda_salvar.Click += new System.EventHandler(this.add_venda_salvar_Click);
            // 
            // AddVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(820, 540);
            this.Controls.Add(this.add_venda_cancel);
            this.Controls.Add(this.add_venda_salvar);
            this.Controls.Add(this.groupBox3);
            this.Name = "AddVenda";
            this.Text = "AddVenda";
            this.Load += new System.EventHandler(this.AddVenda_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.group_produtos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_venda_cancel;
        private System.Windows.Forms.Button add_venda_salvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox group_produtos;
        private System.Windows.Forms.Button remove_produtos;
        private System.Windows.Forms.Button add_produtos;
        private System.Windows.Forms.ListBox lista_produtos;
        private System.Windows.Forms.DateTimePicker data_venda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkCliente;
        private System.Windows.Forms.TextBox QuemComprou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkFuncionario;
        private System.Windows.Forms.TextBox QuemVendeu;
        private System.Windows.Forms.Label vendido_funcionario;
        private System.Windows.Forms.TextBox Valor;
        private System.Windows.Forms.Label label3;
    }
}
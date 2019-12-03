namespace PadariaEMerceariaDaFah.Forms.Vendas
{
    partial class VendasInicio
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
            this.groupVendas = new System.Windows.Forms.GroupBox();
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
            this.remove_venda = new System.Windows.Forms.Button();
            this.habilitar_edicao = new System.Windows.Forms.CheckBox();
            this.save_edit_venda = new System.Windows.Forms.Button();
            this.list_vendas = new System.Windows.Forms.ListBox();
            this.add_venda = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupVendas.SuspendLayout();
            this.group_produtos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.add_venda);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1051, 683);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupVendas);
            this.groupBox1.Controls.Add(this.remove_venda);
            this.groupBox1.Controls.Add(this.habilitar_edicao);
            this.groupBox1.Controls.Add(this.save_edit_venda);
            this.groupBox1.Controls.Add(this.list_vendas);
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1047, 610);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas Realizadas";
            // 
            // groupVendas
            // 
            this.groupVendas.BackColor = System.Drawing.Color.White;
            this.groupVendas.Controls.Add(this.Valor);
            this.groupVendas.Controls.Add(this.label3);
            this.groupVendas.Controls.Add(this.linkCliente);
            this.groupVendas.Controls.Add(this.QuemComprou);
            this.groupVendas.Controls.Add(this.label1);
            this.groupVendas.Controls.Add(this.linkFuncionario);
            this.groupVendas.Controls.Add(this.QuemVendeu);
            this.groupVendas.Controls.Add(this.vendido_funcionario);
            this.groupVendas.Controls.Add(this.data_venda);
            this.groupVendas.Controls.Add(this.label2);
            this.groupVendas.Controls.Add(this.group_produtos);
            this.groupVendas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupVendas.Location = new System.Drawing.Point(241, 61);
            this.groupVendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupVendas.Name = "groupVendas";
            this.groupVendas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupVendas.Size = new System.Drawing.Size(800, 465);
            this.groupVendas.TabIndex = 16;
            this.groupVendas.TabStop = false;
            this.groupVendas.Text = "Cadastro de Venda";
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
            this.remove_produtos.Click += new System.EventHandler(this.remove_produtos_Click);
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
            this.add_produtos.Click += new System.EventHandler(this.add_produtos_Click);
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
            // remove_venda
            // 
            this.remove_venda.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.remove_func_icon;
            this.remove_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remove_venda.Location = new System.Drawing.Point(621, 542);
            this.remove_venda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_venda.Name = "remove_venda";
            this.remove_venda.Size = new System.Drawing.Size(248, 62);
            this.remove_venda.TabIndex = 8;
            this.remove_venda.Text = "Remover Venda";
            this.remove_venda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_venda.UseVisualStyleBackColor = true;
            this.remove_venda.Click += new System.EventHandler(this.remove_venda_Click);
            // 
            // habilitar_edicao
            // 
            this.habilitar_edicao.AutoSize = true;
            this.habilitar_edicao.Location = new System.Drawing.Point(245, 32);
            this.habilitar_edicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.habilitar_edicao.Name = "habilitar_edicao";
            this.habilitar_edicao.Size = new System.Drawing.Size(164, 25);
            this.habilitar_edicao.TabIndex = 10;
            this.habilitar_edicao.Text = "Habilitar Edição";
            this.habilitar_edicao.UseVisualStyleBackColor = true;
            this.habilitar_edicao.CheckedChanged += new System.EventHandler(this.habilitar_edicao_CheckedChanged);
            // 
            // save_edit_venda
            // 
            this.save_edit_venda.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.edit_validated_icon;
            this.save_edit_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_edit_venda.Location = new System.Drawing.Point(354, 542);
            this.save_edit_venda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_edit_venda.Name = "save_edit_venda";
            this.save_edit_venda.Size = new System.Drawing.Size(187, 64);
            this.save_edit_venda.TabIndex = 7;
            this.save_edit_venda.Text = "Salvar Edição";
            this.save_edit_venda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_edit_venda.UseVisualStyleBackColor = true;
            this.save_edit_venda.Click += new System.EventHandler(this.save_edit_venda_Click);
            // 
            // list_vendas
            // 
            this.list_vendas.FormattingEnabled = true;
            this.list_vendas.ItemHeight = 21;
            this.list_vendas.Location = new System.Drawing.Point(12, 21);
            this.list_vendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_vendas.Name = "list_vendas";
            this.list_vendas.Size = new System.Drawing.Size(223, 508);
            this.list_vendas.TabIndex = 1;
            // 
            // add_venda
            // 
            this.add_venda.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.func_Add;
            this.add_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_venda.Location = new System.Drawing.Point(731, 21);
            this.add_venda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_venda.Name = "add_venda";
            this.add_venda.Size = new System.Drawing.Size(299, 46);
            this.add_venda.TabIndex = 0;
            this.add_venda.Text = "Cadastrar Nova Venda";
            this.add_venda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_venda.UseVisualStyleBackColor = true;
            this.add_venda.Click += new System.EventHandler(this.add_venda_Click);
            // 
            // VendasInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1072, 710);
            this.Controls.Add(this.groupBox2);
            this.Name = "VendasInicio";
            this.Text = "VendasInicio";
            this.Load += new System.EventHandler(this.VendasInicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupVendas.ResumeLayout(false);
            this.groupVendas.PerformLayout();
            this.group_produtos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button remove_venda;
        private System.Windows.Forms.CheckBox habilitar_edicao;
        private System.Windows.Forms.Button save_edit_venda;
        private System.Windows.Forms.ListBox list_vendas;
        private System.Windows.Forms.Button add_venda;
        private System.Windows.Forms.GroupBox groupVendas;
        private System.Windows.Forms.TextBox Valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkCliente;
        private System.Windows.Forms.TextBox QuemComprou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkFuncionario;
        private System.Windows.Forms.TextBox QuemVendeu;
        private System.Windows.Forms.Label vendido_funcionario;
        private System.Windows.Forms.DateTimePicker data_venda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_produtos;
        private System.Windows.Forms.Button remove_produtos;
        private System.Windows.Forms.Button add_produtos;
        private System.Windows.Forms.ListBox lista_produtos;
    }
}
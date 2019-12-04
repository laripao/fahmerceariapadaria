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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendasInicio));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupVendas = new System.Windows.Forms.GroupBox();
            this.Valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuemComprou = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuemVendeu = new System.Windows.Forms.TextBox();
            this.vendido_funcionario = new System.Windows.Forms.Label();
            this.data_venda = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.group_produtos = new System.Windows.Forms.GroupBox();
            this.remove_produtos = new System.Windows.Forms.Button();
            this.add_produtos = new System.Windows.Forms.Button();
            this.lista_produtos = new System.Windows.Forms.ListBox();
            this.habilitar_edicao = new System.Windows.Forms.CheckBox();
            this.list_vendas = new System.Windows.Forms.ListBox();
            this.remove_venda = new System.Windows.Forms.Button();
            this.save_edit_venda = new System.Windows.Forms.Button();
            this.add_venda = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupVendas.SuspendLayout();
            this.group_produtos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.add_venda);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(788, 593);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupVendas);
            this.groupBox1.Controls.Add(this.remove_venda);
            this.groupBox1.Controls.Add(this.habilitar_edicao);
            this.groupBox1.Controls.Add(this.save_edit_venda);
            this.groupBox1.Controls.Add(this.list_vendas);
            this.groupBox1.Location = new System.Drawing.Point(0, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(785, 535);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas Realizadas";
            // 
            // groupVendas
            // 
            this.groupVendas.BackColor = System.Drawing.Color.White;
            this.groupVendas.Controls.Add(this.Valor);
            this.groupVendas.Controls.Add(this.label3);
            this.groupVendas.Controls.Add(this.QuemComprou);
            this.groupVendas.Controls.Add(this.label1);
            this.groupVendas.Controls.Add(this.QuemVendeu);
            this.groupVendas.Controls.Add(this.vendido_funcionario);
            this.groupVendas.Controls.Add(this.data_venda);
            this.groupVendas.Controls.Add(this.label2);
            this.groupVendas.Controls.Add(this.group_produtos);
            this.groupVendas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupVendas.Location = new System.Drawing.Point(181, 50);
            this.groupVendas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupVendas.Name = "groupVendas";
            this.groupVendas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupVendas.Size = new System.Drawing.Size(600, 378);
            this.groupVendas.TabIndex = 16;
            this.groupVendas.TabStop = false;
            this.groupVendas.Text = "Cadastro de Venda";
            // 
            // Valor
            // 
            this.Valor.Enabled = false;
            this.Valor.Location = new System.Drawing.Point(163, 336);
            this.Valor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(146, 23);
            this.Valor.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Valor total da compra:";
            // 
            // QuemComprou
            // 
            this.QuemComprou.Enabled = false;
            this.QuemComprou.Location = new System.Drawing.Point(154, 140);
            this.QuemComprou.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuemComprou.Name = "QuemComprou";
            this.QuemComprou.Size = new System.Drawing.Size(438, 23);
            this.QuemComprou.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Venda para o cliente:";
            // 
            // QuemVendeu
            // 
            this.QuemVendeu.Enabled = false;
            this.QuemVendeu.Location = new System.Drawing.Point(154, 80);
            this.QuemVendeu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuemVendeu.Name = "QuemVendeu";
            this.QuemVendeu.Size = new System.Drawing.Size(438, 23);
            this.QuemVendeu.TabIndex = 29;
            // 
            // vendido_funcionario
            // 
            this.vendido_funcionario.AutoSize = true;
            this.vendido_funcionario.Location = new System.Drawing.Point(9, 82);
            this.vendido_funcionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vendido_funcionario.Name = "vendido_funcionario";
            this.vendido_funcionario.Size = new System.Drawing.Size(145, 17);
            this.vendido_funcionario.TabIndex = 28;
            this.vendido_funcionario.Text = "Venda realizada por:";
            // 
            // data_venda
            // 
            this.data_venda.Location = new System.Drawing.Point(124, 32);
            this.data_venda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_venda.Name = "data_venda";
            this.data_venda.Size = new System.Drawing.Size(274, 23);
            this.data_venda.TabIndex = 27;
            this.data_venda.Value = new System.DateTime(2019, 11, 30, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Data de Venda:";
            // 
            // group_produtos
            // 
            this.group_produtos.Controls.Add(this.remove_produtos);
            this.group_produtos.Controls.Add(this.add_produtos);
            this.group_produtos.Controls.Add(this.lista_produtos);
            this.group_produtos.Location = new System.Drawing.Point(4, 191);
            this.group_produtos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.group_produtos.Name = "group_produtos";
            this.group_produtos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.group_produtos.Size = new System.Drawing.Size(591, 129);
            this.group_produtos.TabIndex = 21;
            this.group_produtos.TabStop = false;
            this.group_produtos.Text = "Produtos Comprados";
            // 
            // remove_produtos
            // 
            this.remove_produtos.Location = new System.Drawing.Point(362, 98);
            this.remove_produtos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remove_produtos.Name = "remove_produtos";
            this.remove_produtos.Size = new System.Drawing.Size(104, 25);
            this.remove_produtos.TabIndex = 5;
            this.remove_produtos.Text = "Retirar";
            this.remove_produtos.UseVisualStyleBackColor = true;
            this.remove_produtos.Click += new System.EventHandler(this.remove_produtos_Click);
            // 
            // add_produtos
            // 
            this.add_produtos.Location = new System.Drawing.Point(116, 98);
            this.add_produtos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_produtos.Name = "add_produtos";
            this.add_produtos.Size = new System.Drawing.Size(85, 25);
            this.add_produtos.TabIndex = 4;
            this.add_produtos.Text = "Adicionar";
            this.add_produtos.UseVisualStyleBackColor = true;
            this.add_produtos.Click += new System.EventHandler(this.add_produtos_Click);
            // 
            // lista_produtos
            // 
            this.lista_produtos.FormattingEnabled = true;
            this.lista_produtos.ItemHeight = 17;
            this.lista_produtos.Location = new System.Drawing.Point(19, 20);
            this.lista_produtos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lista_produtos.Name = "lista_produtos";
            this.lista_produtos.Size = new System.Drawing.Size(569, 72);
            this.lista_produtos.TabIndex = 0;
            // 
            // habilitar_edicao
            // 
            this.habilitar_edicao.AutoSize = true;
            this.habilitar_edicao.Location = new System.Drawing.Point(184, 26);
            this.habilitar_edicao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.habilitar_edicao.Name = "habilitar_edicao";
            this.habilitar_edicao.Size = new System.Drawing.Size(130, 21);
            this.habilitar_edicao.TabIndex = 10;
            this.habilitar_edicao.Text = "Habilitar Edição";
            this.habilitar_edicao.UseVisualStyleBackColor = true;
            this.habilitar_edicao.CheckedChanged += new System.EventHandler(this.habilitar_edicao_CheckedChanged);
            // 
            // list_vendas
            // 
            this.list_vendas.FormattingEnabled = true;
            this.list_vendas.ItemHeight = 17;
            this.list_vendas.Location = new System.Drawing.Point(9, 17);
            this.list_vendas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_vendas.Name = "list_vendas";
            this.list_vendas.Size = new System.Drawing.Size(168, 412);
            this.list_vendas.TabIndex = 1;
            this.list_vendas.SelectedIndexChanged += new System.EventHandler(this.list_vendas_SelectedIndexChanged);
            // 
            // remove_venda
            // 
            this.remove_venda.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.shopping_basket_remove_icon;
            this.remove_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remove_venda.Location = new System.Drawing.Point(466, 440);
            this.remove_venda.Margin = new System.Windows.Forms.Padding(2);
            this.remove_venda.Name = "remove_venda";
            this.remove_venda.Size = new System.Drawing.Size(151, 37);
            this.remove_venda.TabIndex = 8;
            this.remove_venda.Text = "Remover Venda";
            this.remove_venda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_venda.UseVisualStyleBackColor = true;
            this.remove_venda.Click += new System.EventHandler(this.remove_venda_Click);
            // 
            // save_edit_venda
            // 
            this.save_edit_venda.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.edit_validated_icon;
            this.save_edit_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_edit_venda.Location = new System.Drawing.Point(266, 440);
            this.save_edit_venda.Margin = new System.Windows.Forms.Padding(2);
            this.save_edit_venda.Name = "save_edit_venda";
            this.save_edit_venda.Size = new System.Drawing.Size(129, 37);
            this.save_edit_venda.TabIndex = 7;
            this.save_edit_venda.Text = "Salvar Edição";
            this.save_edit_venda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_edit_venda.UseVisualStyleBackColor = true;
            this.save_edit_venda.Click += new System.EventHandler(this.save_edit_venda_Click);
            // 
            // add_venda
            // 
            this.add_venda.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.shopping_basket_refresh_icon;
            this.add_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_venda.Location = new System.Drawing.Point(548, 17);
            this.add_venda.Margin = new System.Windows.Forms.Padding(2);
            this.add_venda.Name = "add_venda";
            this.add_venda.Size = new System.Drawing.Size(224, 37);
            this.add_venda.TabIndex = 0;
            this.add_venda.Text = "Cadastrar Nova Venda";
            this.add_venda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_venda.UseVisualStyleBackColor = true;
            this.add_venda.Click += new System.EventHandler(this.add_venda_Click);
            // 
            // VendasInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(804, 604);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox QuemComprou;
        private System.Windows.Forms.Label label1;
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
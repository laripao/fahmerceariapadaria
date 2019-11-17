namespace PadariaEMerceariaDaFah.Forms.Gerencia.Cliente
{
    partial class ClienteInicio
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
            this.list_cliente = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cliente_documento = new System.Windows.Forms.TextBox();
            this.cliente_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cliente_email = new System.Windows.Forms.TextBox();
            this.cliente_telefone = new System.Windows.Forms.TextBox();
            this.cliente_celular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.remove_cliente = new System.Windows.Forms.Button();
            this.save_edit_cliente = new System.Windows.Forms.Button();
            this.add_cliente = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.add_cliente);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(925, 521);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.remove_cliente);
            this.groupBox1.Controls.Add(this.habilitar_edicao);
            this.groupBox1.Controls.Add(this.save_edit_cliente);
            this.groupBox1.Controls.Add(this.list_cliente);
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(925, 448);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes Existentes";
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
            // list_cliente
            // 
            this.list_cliente.FormattingEnabled = true;
            this.list_cliente.ItemHeight = 21;
            this.list_cliente.Location = new System.Drawing.Point(12, 21);
            this.list_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_cliente.Name = "list_cliente";
            this.list_cliente.Size = new System.Drawing.Size(215, 382);
            this.list_cliente.TabIndex = 1;
            this.list_cliente.SelectedIndexChanged += new System.EventHandler(this.list_cliente_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cliente_documento);
            this.groupBox3.Controls.Add(this.cliente_nome);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(245, 61);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(674, 297);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // cliente_documento
            // 
            this.cliente_documento.Location = new System.Drawing.Point(130, 68);
            this.cliente_documento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cliente_documento.Name = "cliente_documento";
            this.cliente_documento.Size = new System.Drawing.Size(527, 27);
            this.cliente_documento.TabIndex = 5;
            // 
            // cliente_nome
            // 
            this.cliente_nome.Location = new System.Drawing.Point(113, 34);
            this.cliente_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cliente_nome.Name = "cliente_nome";
            this.cliente_nome.Size = new System.Drawing.Size(544, 27);
            this.cliente_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cliente_email);
            this.groupBox5.Controls.Add(this.cliente_telefone);
            this.groupBox5.Controls.Add(this.cliente_celular);
            this.groupBox5.Location = new System.Drawing.Point(35, 134);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(622, 140);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Celular:";
            // 
            // cliente_email
            // 
            this.cliente_email.Location = new System.Drawing.Point(108, 97);
            this.cliente_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cliente_email.Name = "cliente_email";
            this.cliente_email.Size = new System.Drawing.Size(293, 27);
            this.cliente_email.TabIndex = 2;
            // 
            // cliente_telefone
            // 
            this.cliente_telefone.Location = new System.Drawing.Point(108, 64);
            this.cliente_telefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cliente_telefone.Name = "cliente_telefone";
            this.cliente_telefone.Size = new System.Drawing.Size(293, 27);
            this.cliente_telefone.TabIndex = 1;
            // 
            // cliente_celular
            // 
            this.cliente_celular.Location = new System.Drawing.Point(108, 31);
            this.cliente_celular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cliente_celular.Name = "cliente_celular";
            this.cliente_celular.Size = new System.Drawing.Size(293, 27);
            this.cliente_celular.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Documento:";
            // 
            // remove_cliente
            // 
            this.remove_cliente.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.remove_func_icon;
            this.remove_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remove_cliente.Location = new System.Drawing.Point(559, 362);
            this.remove_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_cliente.Name = "remove_cliente";
            this.remove_cliente.Size = new System.Drawing.Size(248, 62);
            this.remove_cliente.TabIndex = 8;
            this.remove_cliente.Text = "Remover Cliente";
            this.remove_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_cliente.UseVisualStyleBackColor = true;
            this.remove_cliente.Click += new System.EventHandler(this.remove_cliente_Click);
            // 
            // save_edit_cliente
            // 
            this.save_edit_cliente.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.edit_validated_icon;
            this.save_edit_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_edit_cliente.Location = new System.Drawing.Point(292, 362);
            this.save_edit_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_edit_cliente.Name = "save_edit_cliente";
            this.save_edit_cliente.Size = new System.Drawing.Size(187, 64);
            this.save_edit_cliente.TabIndex = 7;
            this.save_edit_cliente.Text = "Salvar Edição";
            this.save_edit_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_edit_cliente.UseVisualStyleBackColor = true;
            this.save_edit_cliente.Click += new System.EventHandler(this.save_edit_cliente_Click);
            // 
            // add_cliente
            // 
            this.add_cliente.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.func_Add;
            this.add_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_cliente.Location = new System.Drawing.Point(549, 21);
            this.add_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_cliente.Name = "add_cliente";
            this.add_cliente.Size = new System.Drawing.Size(299, 46);
            this.add_cliente.TabIndex = 0;
            this.add_cliente.Text = "Cadastrar Novo Cliente";
            this.add_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_cliente.UseVisualStyleBackColor = true;
            this.add_cliente.Click += new System.EventHandler(this.add_cliente_Click);
            // 
            // ClienteInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(948, 545);
            this.Controls.Add(this.groupBox2);
            this.Name = "ClienteInicio";
            this.Text = "ClienteInicio";
            this.Load += new System.EventHandler(this.ClienteInicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button remove_cliente;
        private System.Windows.Forms.CheckBox habilitar_edicao;
        private System.Windows.Forms.Button save_edit_cliente;
        private System.Windows.Forms.ListBox list_cliente;
        private System.Windows.Forms.Button add_cliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox cliente_documento;
        private System.Windows.Forms.TextBox cliente_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cliente_email;
        private System.Windows.Forms.TextBox cliente_telefone;
        private System.Windows.Forms.TextBox cliente_celular;
        private System.Windows.Forms.Label label2;
    }
}
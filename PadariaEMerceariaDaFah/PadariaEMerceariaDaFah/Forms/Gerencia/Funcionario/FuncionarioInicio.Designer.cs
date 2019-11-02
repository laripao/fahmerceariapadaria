namespace PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario
{
    partial class FuncionarioInicio
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
            this.list_func = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.func_nome = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.func_estado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.func_numero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.func_cep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.func_pais = new System.Windows.Forms.TextBox();
            this.func_cidade = new System.Windows.Forms.TextBox();
            this.func_rua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.func_email = new System.Windows.Forms.TextBox();
            this.func_telefone = new System.Windows.Forms.TextBox();
            this.func_celular = new System.Windows.Forms.TextBox();
            this.func_funcao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.habilitar_edicao = new System.Windows.Forms.CheckBox();
            this.remove_func = new System.Windows.Forms.Button();
            this.save_edit_func = new System.Windows.Forms.Button();
            this.add_funcionario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_func
            // 
            this.list_func.FormattingEnabled = true;
            this.list_func.ItemHeight = 16;
            this.list_func.Location = new System.Drawing.Point(12, 21);
            this.list_func.Name = "list_func";
            this.list_func.Size = new System.Drawing.Size(214, 596);
            this.list_func.TabIndex = 1;
            this.list_func.SelectedValueChanged += new System.EventHandler(this.list_func_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.habilitar_edicao);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.list_func);
            this.groupBox1.Location = new System.Drawing.Point(6, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 626);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionários Existentes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.add_funcionario);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(925, 705);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionários";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.remove_func);
            this.groupBox3.Controls.Add(this.save_edit_func);
            this.groupBox3.Controls.Add(this.func_nome);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.func_funcao);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(245, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 547);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funcionario";
            // 
            // func_nome
            // 
            this.func_nome.Location = new System.Drawing.Point(94, 36);
            this.func_nome.Name = "func_nome";
            this.func_nome.Size = new System.Drawing.Size(511, 22);
            this.func_nome.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.func_estado);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.func_numero);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.func_cep);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.func_pais);
            this.groupBox4.Controls.Add(this.func_cidade);
            this.groupBox4.Controls.Add(this.func_rua);
            this.groupBox4.Location = new System.Drawing.Point(26, 222);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(579, 206);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Endereço:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Estado:";
            // 
            // func_estado
            // 
            this.func_estado.Location = new System.Drawing.Point(90, 59);
            this.func_estado.Name = "func_estado";
            this.func_estado.Size = new System.Drawing.Size(483, 22);
            this.func_estado.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Número:";
            // 
            // func_numero
            // 
            this.func_numero.Location = new System.Drawing.Point(90, 139);
            this.func_numero.Name = "func_numero";
            this.func_numero.Size = new System.Drawing.Size(483, 22);
            this.func_numero.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "CEP:";
            // 
            // func_cep
            // 
            this.func_cep.Location = new System.Drawing.Point(90, 172);
            this.func_cep.Name = "func_cep";
            this.func_cep.Size = new System.Drawing.Size(483, 22);
            this.func_cep.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "País:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rua:";
            // 
            // func_pais
            // 
            this.func_pais.Location = new System.Drawing.Point(90, 31);
            this.func_pais.Name = "func_pais";
            this.func_pais.Size = new System.Drawing.Size(483, 22);
            this.func_pais.TabIndex = 2;
            // 
            // func_cidade
            // 
            this.func_cidade.Location = new System.Drawing.Point(90, 83);
            this.func_cidade.Name = "func_cidade";
            this.func_cidade.Size = new System.Drawing.Size(483, 22);
            this.func_cidade.TabIndex = 1;
            // 
            // func_rua
            // 
            this.func_rua.Location = new System.Drawing.Point(90, 111);
            this.func_rua.Name = "func_rua";
            this.func_rua.Size = new System.Drawing.Size(483, 22);
            this.func_rua.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.func_email);
            this.groupBox5.Controls.Add(this.func_telefone);
            this.groupBox5.Controls.Add(this.func_celular);
            this.groupBox5.Location = new System.Drawing.Point(26, 90);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(579, 126);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Celular:";
            // 
            // func_email
            // 
            this.func_email.Location = new System.Drawing.Point(90, 87);
            this.func_email.Name = "func_email";
            this.func_email.Size = new System.Drawing.Size(293, 22);
            this.func_email.TabIndex = 2;
            // 
            // func_telefone
            // 
            this.func_telefone.Location = new System.Drawing.Point(90, 59);
            this.func_telefone.Name = "func_telefone";
            this.func_telefone.Size = new System.Drawing.Size(293, 22);
            this.func_telefone.TabIndex = 1;
            // 
            // func_celular
            // 
            this.func_celular.Location = new System.Drawing.Point(90, 31);
            this.func_celular.Name = "func_celular";
            this.func_celular.Size = new System.Drawing.Size(293, 22);
            this.func_celular.TabIndex = 0;
            // 
            // func_funcao
            // 
            this.func_funcao.Location = new System.Drawing.Point(94, 62);
            this.func_funcao.Name = "func_funcao";
            this.func_funcao.Size = new System.Drawing.Size(511, 22);
            this.func_funcao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Função:";
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
            this.habilitar_edicao.CheckedChanged += new System.EventHandler(this.habilitar_edicao_CheckedChanged_1);
            // 
            // remove_func
            // 
            this.remove_func.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.remove_func_icon;
            this.remove_func.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remove_func.Location = new System.Drawing.Point(392, 456);
            this.remove_func.Name = "remove_func";
            this.remove_func.Size = new System.Drawing.Size(196, 50);
            this.remove_func.TabIndex = 8;
            this.remove_func.Text = "Remover Funcionário";
            this.remove_func.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_func.UseVisualStyleBackColor = true;
            this.remove_func.Click += new System.EventHandler(this.remove_func_Click);
            // 
            // save_edit_func
            // 
            this.save_edit_func.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.edit_validated_icon;
            this.save_edit_func.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_edit_func.Location = new System.Drawing.Point(26, 456);
            this.save_edit_func.Name = "save_edit_func";
            this.save_edit_func.Size = new System.Drawing.Size(143, 50);
            this.save_edit_func.TabIndex = 7;
            this.save_edit_func.Text = "Salvar Edição";
            this.save_edit_func.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_edit_func.UseVisualStyleBackColor = true;
            this.save_edit_func.Click += new System.EventHandler(this.save_edit_func_Click);
            // 
            // add_funcionario
            // 
            this.add_funcionario.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.add_func_icon1;
            this.add_funcionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_funcionario.Location = new System.Drawing.Point(550, 21);
            this.add_funcionario.Name = "add_funcionario";
            this.add_funcionario.Size = new System.Drawing.Size(294, 46);
            this.add_funcionario.TabIndex = 0;
            this.add_funcionario.Text = "Cadastrar Novo Funcionário";
            this.add_funcionario.UseVisualStyleBackColor = true;
            this.add_funcionario.Click += new System.EventHandler(this.add_funcionario_Click);
            // 
            // FuncionarioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 729);
            this.Controls.Add(this.groupBox2);
            this.Name = "FuncionarioInicio";
            this.Text = "FuncionarioInicio";
            this.Load += new System.EventHandler(this.FuncionarioInicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_funcionario;
        private System.Windows.Forms.ListBox list_func;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button save_edit_func;
        private System.Windows.Forms.TextBox func_nome;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox func_estado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox func_numero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox func_cep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox func_pais;
        private System.Windows.Forms.TextBox func_cidade;
        private System.Windows.Forms.TextBox func_rua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox func_email;
        private System.Windows.Forms.TextBox func_telefone;
        private System.Windows.Forms.TextBox func_celular;
        private System.Windows.Forms.TextBox func_funcao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button remove_func;
        private System.Windows.Forms.CheckBox habilitar_edicao;
    }
}
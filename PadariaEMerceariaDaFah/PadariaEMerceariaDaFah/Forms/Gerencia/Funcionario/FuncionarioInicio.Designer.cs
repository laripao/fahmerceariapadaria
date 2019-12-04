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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioInicio));
            this.list_func = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.habilitar_edicao = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.func_nome = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.func_estado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.func_funcao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save_edit_func = new System.Windows.Forms.Button();
            this.remove_func = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.add_funcionario = new System.Windows.Forms.Button();
            this.func_cpf = new System.Windows.Forms.MaskedTextBox();
            this.func_celular = new System.Windows.Forms.MaskedTextBox();
            this.func_telefone = new System.Windows.Forms.MaskedTextBox();
            this.func_numero = new System.Windows.Forms.MaskedTextBox();
            this.func_cep = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_func
            // 
            this.list_func.FormattingEnabled = true;
            this.list_func.ItemHeight = 17;
            this.list_func.Location = new System.Drawing.Point(9, 17);
            this.list_func.Margin = new System.Windows.Forms.Padding(2);
            this.list_func.Name = "list_func";
            this.list_func.Size = new System.Drawing.Size(162, 480);
            this.list_func.TabIndex = 1;
            this.list_func.SelectedValueChanged += new System.EventHandler(this.list_func_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.habilitar_edicao);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.save_edit_func);
            this.groupBox1.Controls.Add(this.remove_func);
            this.groupBox1.Controls.Add(this.list_func);
            this.groupBox1.Location = new System.Drawing.Point(4, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(685, 509);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionários Existentes";
            // 
            // habilitar_edicao
            // 
            this.habilitar_edicao.AutoSize = true;
            this.habilitar_edicao.Location = new System.Drawing.Point(184, 20);
            this.habilitar_edicao.Margin = new System.Windows.Forms.Padding(2);
            this.habilitar_edicao.Name = "habilitar_edicao";
            this.habilitar_edicao.Size = new System.Drawing.Size(130, 21);
            this.habilitar_edicao.TabIndex = 15;
            this.habilitar_edicao.Text = "Habilitar Edição";
            this.habilitar_edicao.UseVisualStyleBackColor = true;
            this.habilitar_edicao.CheckedChanged += new System.EventHandler(this.habilitar_edicao_CheckedChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.func_cpf);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.func_nome);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.func_funcao);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(184, 45);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(496, 407);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funcionário";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "CPF:";
            // 
            // func_nome
            // 
            this.func_nome.Location = new System.Drawing.Point(92, 15);
            this.func_nome.Margin = new System.Windows.Forms.Padding(2);
            this.func_nome.Name = "func_nome";
            this.func_nome.Size = new System.Drawing.Size(384, 23);
            this.func_nome.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.func_cep);
            this.groupBox4.Controls.Add(this.func_numero);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.func_estado);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.func_pais);
            this.groupBox4.Controls.Add(this.func_cidade);
            this.groupBox4.Controls.Add(this.func_rua);
            this.groupBox4.Location = new System.Drawing.Point(20, 209);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(456, 184);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Endereço:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 45);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Estado:";
            // 
            // func_estado
            // 
            this.func_estado.Location = new System.Drawing.Point(77, 45);
            this.func_estado.Margin = new System.Windows.Forms.Padding(2);
            this.func_estado.Name = "func_estado";
            this.func_estado.Size = new System.Drawing.Size(363, 23);
            this.func_estado.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Número:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 153);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "País:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rua:";
            // 
            // func_pais
            // 
            this.func_pais.Location = new System.Drawing.Point(77, 18);
            this.func_pais.Margin = new System.Windows.Forms.Padding(2);
            this.func_pais.Name = "func_pais";
            this.func_pais.Size = new System.Drawing.Size(363, 23);
            this.func_pais.TabIndex = 7;
            // 
            // func_cidade
            // 
            this.func_cidade.Location = new System.Drawing.Point(77, 72);
            this.func_cidade.Margin = new System.Windows.Forms.Padding(2);
            this.func_cidade.Name = "func_cidade";
            this.func_cidade.Size = new System.Drawing.Size(363, 23);
            this.func_cidade.TabIndex = 9;
            // 
            // func_rua
            // 
            this.func_rua.Location = new System.Drawing.Point(77, 99);
            this.func_rua.Margin = new System.Windows.Forms.Padding(2);
            this.func_rua.Name = "func_rua";
            this.func_rua.Size = new System.Drawing.Size(363, 23);
            this.func_rua.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.func_telefone);
            this.groupBox5.Controls.Add(this.func_celular);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.func_email);
            this.groupBox5.Location = new System.Drawing.Point(20, 102);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(456, 102);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Celular:";
            // 
            // func_email
            // 
            this.func_email.Location = new System.Drawing.Point(76, 70);
            this.func_email.Margin = new System.Windows.Forms.Padding(2);
            this.func_email.Name = "func_email";
            this.func_email.Size = new System.Drawing.Size(221, 23);
            this.func_email.TabIndex = 6;
            // 
            // func_funcao
            // 
            this.func_funcao.Location = new System.Drawing.Point(92, 44);
            this.func_funcao.Margin = new System.Windows.Forms.Padding(2);
            this.func_funcao.Name = "func_funcao";
            this.func_funcao.Size = new System.Drawing.Size(384, 23);
            this.func_funcao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Função:";
            // 
            // save_edit_func
            // 
            this.save_edit_func.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.edit_validated_icon;
            this.save_edit_func.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_edit_func.Location = new System.Drawing.Point(204, 456);
            this.save_edit_func.Margin = new System.Windows.Forms.Padding(2);
            this.save_edit_func.Name = "save_edit_func";
            this.save_edit_func.Size = new System.Drawing.Size(133, 41);
            this.save_edit_func.TabIndex = 13;
            this.save_edit_func.Text = "Salvar Edição";
            this.save_edit_func.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_edit_func.UseVisualStyleBackColor = true;
            this.save_edit_func.Click += new System.EventHandler(this.save_edit_func_Click);
            // 
            // remove_func
            // 
            this.remove_func.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.remove_func_icon;
            this.remove_func.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remove_func.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove_func.Location = new System.Drawing.Point(474, 456);
            this.remove_func.Margin = new System.Windows.Forms.Padding(2);
            this.remove_func.Name = "remove_func";
            this.remove_func.Size = new System.Drawing.Size(186, 41);
            this.remove_func.TabIndex = 14;
            this.remove_func.Text = "Remover Funcionário";
            this.remove_func.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_func.UseVisualStyleBackColor = true;
            this.remove_func.Click += new System.EventHandler(this.remove_func_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.add_funcionario);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(694, 573);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionários";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // add_funcionario
            // 
            this.add_funcionario.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.func_Add;
            this.add_funcionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_funcionario.Location = new System.Drawing.Point(432, 17);
            this.add_funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.add_funcionario.Name = "add_funcionario";
            this.add_funcionario.Size = new System.Drawing.Size(232, 37);
            this.add_funcionario.TabIndex = 0;
            this.add_funcionario.Text = "Cadastrar Novo Funcionário";
            this.add_funcionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_funcionario.UseVisualStyleBackColor = true;
            this.add_funcionario.Click += new System.EventHandler(this.add_funcionario_Click);
            // 
            // func_cpf
            // 
            this.func_cpf.Location = new System.Drawing.Point(92, 73);
            this.func_cpf.Mask = "000.000.000-00";
            this.func_cpf.Name = "func_cpf";
            this.func_cpf.Size = new System.Drawing.Size(384, 23);
            this.func_cpf.TabIndex = 3;
            this.func_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.func_cpf_MaskInputRejected);
            // 
            // func_celular
            // 
            this.func_celular.Location = new System.Drawing.Point(76, 12);
            this.func_celular.Mask = "(00) 90000-0000";
            this.func_celular.Name = "func_celular";
            this.func_celular.Size = new System.Drawing.Size(221, 23);
            this.func_celular.TabIndex = 4;
            // 
            // func_telefone
            // 
            this.func_telefone.Location = new System.Drawing.Point(76, 41);
            this.func_telefone.Mask = "(00) 0000-0000";
            this.func_telefone.Name = "func_telefone";
            this.func_telefone.Size = new System.Drawing.Size(221, 23);
            this.func_telefone.TabIndex = 5;
            // 
            // func_numero
            // 
            this.func_numero.Location = new System.Drawing.Point(77, 123);
            this.func_numero.Mask = "000000000000";
            this.func_numero.Name = "func_numero";
            this.func_numero.Size = new System.Drawing.Size(363, 23);
            this.func_numero.TabIndex = 11;
            this.func_numero.ValidatingType = typeof(int);
            // 
            // func_cep
            // 
            this.func_cep.Location = new System.Drawing.Point(77, 150);
            this.func_cep.Mask = "00.000-000";
            this.func_cep.Name = "func_cep";
            this.func_cep.Size = new System.Drawing.Size(363, 23);
            this.func_cep.TabIndex = 12;
            // 
            // FuncionarioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(712, 592);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FuncionarioInicio";
            this.Text = "Funcionário Início";
            this.Load += new System.EventHandler(this.FuncionarioInicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox func_email;
        private System.Windows.Forms.TextBox func_funcao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button remove_func;
        private System.Windows.Forms.CheckBox habilitar_edicao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox func_estado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox func_pais;
        private System.Windows.Forms.TextBox func_cidade;
        private System.Windows.Forms.TextBox func_rua;
        private System.Windows.Forms.MaskedTextBox func_cpf;
        private System.Windows.Forms.MaskedTextBox func_celular;
        private System.Windows.Forms.MaskedTextBox func_cep;
        private System.Windows.Forms.MaskedTextBox func_numero;
        private System.Windows.Forms.MaskedTextBox func_telefone;
    }
}
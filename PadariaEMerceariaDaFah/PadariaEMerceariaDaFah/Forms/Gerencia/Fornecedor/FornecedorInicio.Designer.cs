﻿namespace PadariaEMerceariaDaFah.Forms.Gerencia.Fornecedor
{
    partial class FornecedorInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FornecedorInicio));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.remove_fornecedor = new System.Windows.Forms.Button();
            this.habilitar_edicao = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fornecedor_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fornecedor_email = new System.Windows.Forms.TextBox();
            this.fornecedor_telefone = new System.Windows.Forms.TextBox();
            this.fornecedor_celular = new System.Windows.Forms.TextBox();
            this.fornecedor_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save_edit_fornecedor = new System.Windows.Forms.Button();
            this.list_fornecedor = new System.Windows.Forms.ListBox();
            this.add_fornecedor = new System.Windows.Forms.Button();
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
            this.groupBox2.Controls.Add(this.add_fornecedor);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(925, 521);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fornecedores";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.remove_fornecedor);
            this.groupBox1.Controls.Add(this.habilitar_edicao);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.save_edit_fornecedor);
            this.groupBox1.Controls.Add(this.list_fornecedor);
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(925, 448);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornecedores Existentes";
            // 
            // remove_fornecedor
            // 
            this.remove_fornecedor.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.remove_func_icon;
            this.remove_fornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remove_fornecedor.Location = new System.Drawing.Point(559, 362);
            this.remove_fornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_fornecedor.Name = "remove_fornecedor";
            this.remove_fornecedor.Size = new System.Drawing.Size(248, 62);
            this.remove_fornecedor.TabIndex = 8;
            this.remove_fornecedor.Text = "Remover Fornecedor";
            this.remove_fornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_fornecedor.UseVisualStyleBackColor = true;
            this.remove_fornecedor.Click += new System.EventHandler(this.remove_fornecedor_Click);
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.fornecedor_nome);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.fornecedor_description);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(245, 73);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(661, 284);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fornecedor";
            // 
            // fornecedor_nome
            // 
            this.fornecedor_nome.Location = new System.Drawing.Point(117, 25);
            this.fornecedor_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fornecedor_nome.Name = "fornecedor_nome";
            this.fornecedor_nome.Size = new System.Drawing.Size(523, 27);
            this.fornecedor_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
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
            this.groupBox5.Controls.Add(this.fornecedor_email);
            this.groupBox5.Controls.Add(this.fornecedor_telefone);
            this.groupBox5.Controls.Add(this.fornecedor_celular);
            this.groupBox5.Location = new System.Drawing.Point(27, 132);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(615, 148);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Celular:";
            // 
            // fornecedor_email
            // 
            this.fornecedor_email.Location = new System.Drawing.Point(108, 92);
            this.fornecedor_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fornecedor_email.Name = "fornecedor_email";
            this.fornecedor_email.Size = new System.Drawing.Size(293, 27);
            this.fornecedor_email.TabIndex = 2;
            // 
            // fornecedor_telefone
            // 
            this.fornecedor_telefone.Location = new System.Drawing.Point(108, 59);
            this.fornecedor_telefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fornecedor_telefone.Name = "fornecedor_telefone";
            this.fornecedor_telefone.Size = new System.Drawing.Size(293, 27);
            this.fornecedor_telefone.TabIndex = 1;
            // 
            // fornecedor_celular
            // 
            this.fornecedor_celular.Location = new System.Drawing.Point(108, 26);
            this.fornecedor_celular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fornecedor_celular.Name = "fornecedor_celular";
            this.fornecedor_celular.Size = new System.Drawing.Size(293, 27);
            this.fornecedor_celular.TabIndex = 0;
            // 
            // fornecedor_description
            // 
            this.fornecedor_description.Location = new System.Drawing.Point(129, 65);
            this.fornecedor_description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fornecedor_description.MinimumSize = new System.Drawing.Size(4, 50);
            this.fornecedor_description.Name = "fornecedor_description";
            this.fornecedor_description.Size = new System.Drawing.Size(511, 27);
            this.fornecedor_description.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // save_edit_fornecedor
            // 
            this.save_edit_fornecedor.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.edit_validated_icon;
            this.save_edit_fornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_edit_fornecedor.Location = new System.Drawing.Point(292, 362);
            this.save_edit_fornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_edit_fornecedor.Name = "save_edit_fornecedor";
            this.save_edit_fornecedor.Size = new System.Drawing.Size(187, 64);
            this.save_edit_fornecedor.TabIndex = 7;
            this.save_edit_fornecedor.Text = "Salvar Edição";
            this.save_edit_fornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_edit_fornecedor.UseVisualStyleBackColor = true;
            this.save_edit_fornecedor.Click += new System.EventHandler(this.save_edit_fornecedor_Click);
            // 
            // list_fornecedor
            // 
            this.list_fornecedor.FormattingEnabled = true;
            this.list_fornecedor.ItemHeight = 21;
            this.list_fornecedor.Location = new System.Drawing.Point(12, 21);
            this.list_fornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_fornecedor.Name = "list_fornecedor";
            this.list_fornecedor.Size = new System.Drawing.Size(215, 382);
            this.list_fornecedor.TabIndex = 1;
            this.list_fornecedor.SelectedValueChanged += new System.EventHandler(this.list_fornecedor_SelectedValueChanged);
            // 
            // add_fornecedor
            // 
            this.add_fornecedor.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.func_Add;
            this.add_fornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_fornecedor.Location = new System.Drawing.Point(549, 21);
            this.add_fornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_fornecedor.Name = "add_fornecedor";
            this.add_fornecedor.Size = new System.Drawing.Size(299, 46);
            this.add_fornecedor.TabIndex = 0;
            this.add_fornecedor.Text = "Cadastrar Novo Fornecedor";
            this.add_fornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_fornecedor.UseVisualStyleBackColor = true;
            this.add_fornecedor.Click += new System.EventHandler(this.add_fornecedor_Click);
            // 
            // FornecedorInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(977, 546);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FornecedorInicio";
            this.Text = "Fornecedor Inicio";
            this.Load += new System.EventHandler(this.FornecedorInicio_Load);
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
        private System.Windows.Forms.CheckBox habilitar_edicao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button remove_fornecedor;
        private System.Windows.Forms.Button save_edit_fornecedor;
        private System.Windows.Forms.TextBox fornecedor_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fornecedor_email;
        private System.Windows.Forms.TextBox fornecedor_telefone;
        private System.Windows.Forms.TextBox fornecedor_celular;
        private System.Windows.Forms.TextBox fornecedor_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_fornecedor;
        private System.Windows.Forms.Button add_fornecedor;
    }
}
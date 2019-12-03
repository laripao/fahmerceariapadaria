namespace PadariaEMerceariaDaFah.Forms.Gerencia.Cliente.AddCliente
{
    partial class AddCliente
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
            this.add_cliente_cancel = new System.Windows.Forms.Button();
            this.add_cliente_salvar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox3.Location = new System.Drawing.Point(13, 38);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(800, 313);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // cliente_documento
            // 
            this.cliente_documento.Location = new System.Drawing.Point(130, 68);
            this.cliente_documento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cliente_documento.Name = "cliente_documento";
            this.cliente_documento.Size = new System.Drawing.Size(659, 27);
            this.cliente_documento.TabIndex = 5;
            // 
            // cliente_nome
            // 
            this.cliente_nome.Location = new System.Drawing.Point(113, 34);
            this.cliente_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cliente_nome.Name = "cliente_nome";
            this.cliente_nome.Size = new System.Drawing.Size(676, 27);
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
            this.groupBox5.Size = new System.Drawing.Size(744, 165);
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
            // add_cliente_cancel
            // 
            this.add_cliente_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_cliente_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_cliente_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cliente_cancel.Location = new System.Drawing.Point(432, 356);
            this.add_cliente_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_cliente_cancel.Name = "add_cliente_cancel";
            this.add_cliente_cancel.Size = new System.Drawing.Size(144, 49);
            this.add_cliente_cancel.TabIndex = 13;
            this.add_cliente_cancel.Text = "Cancelar";
            this.add_cliente_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_cliente_cancel.UseVisualStyleBackColor = true;
            this.add_cliente_cancel.Click += new System.EventHandler(this.add_cliente_cancel_Click);
            // 
            // add_cliente_salvar
            // 
            this.add_cliente_salvar.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.add_cliente_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_cliente_salvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cliente_salvar.Location = new System.Drawing.Point(156, 356);
            this.add_cliente_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_cliente_salvar.Name = "add_cliente_salvar";
            this.add_cliente_salvar.Size = new System.Drawing.Size(144, 49);
            this.add_cliente_salvar.TabIndex = 14;
            this.add_cliente_salvar.Text = "Salvar";
            this.add_cliente_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_cliente_salvar.UseVisualStyleBackColor = true;
            this.add_cliente_salvar.Click += new System.EventHandler(this.add_cliente_salvar_Click);
            // 
            // AddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(827, 415);
            this.Controls.Add(this.add_cliente_cancel);
            this.Controls.Add(this.add_cliente_salvar);
            this.Controls.Add(this.groupBox3);
            this.Name = "AddCliente";
            this.Text = "AddCliente";
            this.Load += new System.EventHandler(this.AddCliente_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_cliente_cancel;
        private System.Windows.Forms.Button add_cliente_salvar;
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
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCliente));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cliente_documento = new System.Windows.Forms.TextBox();
            this.cliente_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cliente_email = new System.Windows.Forms.MaskedTextBox();
            this.cliente_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cliente_celular = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.groupBox3.Location = new System.Drawing.Point(10, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(600, 254);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // cliente_documento
            // 
            this.cliente_documento.Location = new System.Drawing.Point(98, 55);
            this.cliente_documento.Margin = new System.Windows.Forms.Padding(2);
            this.cliente_documento.Name = "cliente_documento";
            this.cliente_documento.Size = new System.Drawing.Size(495, 23);
            this.cliente_documento.TabIndex = 1;
            // 
            // cliente_nome
            // 
            this.cliente_nome.Location = new System.Drawing.Point(85, 28);
            this.cliente_nome.Margin = new System.Windows.Forms.Padding(2);
            this.cliente_nome.Name = "cliente_nome";
            this.cliente_nome.Size = new System.Drawing.Size(508, 23);
            this.cliente_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cliente_email);
            this.groupBox5.Controls.Add(this.cliente_telefone);
            this.groupBox5.Controls.Add(this.cliente_celular);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(26, 109);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(558, 134);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contato";
            // 
            // cliente_email
            // 
            this.cliente_email.Location = new System.Drawing.Point(81, 82);
            this.cliente_email.Name = "cliente_email";
            this.cliente_email.Size = new System.Drawing.Size(221, 23);
            this.cliente_email.TabIndex = 4;
            // 
            // cliente_telefone
            // 
            this.cliente_telefone.Location = new System.Drawing.Point(81, 51);
            this.cliente_telefone.Mask = "(00) 0000-0000";
            this.cliente_telefone.Name = "cliente_telefone";
            this.cliente_telefone.Size = new System.Drawing.Size(221, 23);
            this.cliente_telefone.TabIndex = 3;
            // 
            // cliente_celular
            // 
            this.cliente_celular.Location = new System.Drawing.Point(81, 24);
            this.cliente_celular.Mask = "(00) 90000-0000";
            this.cliente_celular.Name = "cliente_celular";
            this.cliente_celular.Size = new System.Drawing.Size(221, 23);
            this.cliente_celular.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Documento:";
            // 
            // add_cliente_cancel
            // 
            this.add_cliente_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_cliente_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_cliente_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cliente_cancel.Location = new System.Drawing.Point(324, 289);
            this.add_cliente_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.add_cliente_cancel.Name = "add_cliente_cancel";
            this.add_cliente_cancel.Size = new System.Drawing.Size(108, 40);
            this.add_cliente_cancel.TabIndex = 6;
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
            this.add_cliente_salvar.Location = new System.Drawing.Point(117, 289);
            this.add_cliente_salvar.Margin = new System.Windows.Forms.Padding(2);
            this.add_cliente_salvar.Name = "add_cliente_salvar";
            this.add_cliente_salvar.Size = new System.Drawing.Size(108, 40);
            this.add_cliente_salvar.TabIndex = 5;
            this.add_cliente_salvar.Text = "Salvar";
            this.add_cliente_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_cliente_salvar.UseVisualStyleBackColor = true;
            this.add_cliente_salvar.Click += new System.EventHandler(this.add_cliente_salvar_Click);
            // 
            // AddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(620, 337);
            this.Controls.Add(this.add_cliente_cancel);
            this.Controls.Add(this.add_cliente_salvar);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddCliente";
            this.Text = "Adicionar Cliente";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cliente_email;
        private System.Windows.Forms.MaskedTextBox cliente_telefone;
        private System.Windows.Forms.MaskedTextBox cliente_celular;
    }
}
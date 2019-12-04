namespace PadariaEMerceariaDaFah.Forms.Gerencia.Cliente.RemoveCliente
{
    partial class RemoverCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoverCliente));
            this.acc_remove = new System.Windows.Forms.Button();
            this.cancel_remove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
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
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // acc_remove
            // 
            this.acc_remove.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.remove_func_icon;
            this.acc_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acc_remove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_remove.Location = new System.Drawing.Point(113, 302);
            this.acc_remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acc_remove.Name = "acc_remove";
            this.acc_remove.Size = new System.Drawing.Size(117, 44);
            this.acc_remove.TabIndex = 20;
            this.acc_remove.Text = "Remover";
            this.acc_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.acc_remove.UseVisualStyleBackColor = true;
            this.acc_remove.Click += new System.EventHandler(this.acc_remove_Click);
            // 
            // cancel_remove
            // 
            this.cancel_remove.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.cancel_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancel_remove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_remove.Location = new System.Drawing.Point(330, 302);
            this.cancel_remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel_remove.Name = "cancel_remove";
            this.cancel_remove.Size = new System.Drawing.Size(118, 44);
            this.cancel_remove.TabIndex = 19;
            this.cancel_remove.Text = "Cancelar";
            this.cancel_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel_remove.UseVisualStyleBackColor = true;
            this.cancel_remove.Click += new System.EventHandler(this.cancel_remove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(463, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tem certeza que deseja remover este cliente?";
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
            this.groupBox3.Location = new System.Drawing.Point(9, 45);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(530, 244);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // cliente_documento
            // 
            this.cliente_documento.Enabled = false;
            this.cliente_documento.Location = new System.Drawing.Point(98, 55);
            this.cliente_documento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cliente_documento.Name = "cliente_documento";
            this.cliente_documento.Size = new System.Drawing.Size(429, 23);
            this.cliente_documento.TabIndex = 5;
            // 
            // cliente_nome
            // 
            this.cliente_nome.Enabled = false;
            this.cliente_nome.Location = new System.Drawing.Point(85, 28);
            this.cliente_nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cliente_nome.Name = "cliente_nome";
            this.cliente_nome.Size = new System.Drawing.Size(442, 23);
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
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cliente_email);
            this.groupBox5.Controls.Add(this.cliente_telefone);
            this.groupBox5.Controls.Add(this.cliente_celular);
            this.groupBox5.Location = new System.Drawing.Point(26, 91);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(500, 134);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contato";
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
            // cliente_email
            // 
            this.cliente_email.Enabled = false;
            this.cliente_email.Location = new System.Drawing.Point(81, 79);
            this.cliente_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cliente_email.Name = "cliente_email";
            this.cliente_email.Size = new System.Drawing.Size(221, 23);
            this.cliente_email.TabIndex = 2;
            // 
            // cliente_telefone
            // 
            this.cliente_telefone.Enabled = false;
            this.cliente_telefone.Location = new System.Drawing.Point(81, 52);
            this.cliente_telefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cliente_telefone.Name = "cliente_telefone";
            this.cliente_telefone.Size = new System.Drawing.Size(221, 23);
            this.cliente_telefone.TabIndex = 1;
            // 
            // cliente_celular
            // 
            this.cliente_celular.Enabled = false;
            this.cliente_celular.Location = new System.Drawing.Point(81, 25);
            this.cliente_celular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cliente_celular.Name = "cliente_celular";
            this.cliente_celular.Size = new System.Drawing.Size(221, 23);
            this.cliente_celular.TabIndex = 0;
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
            // RemoverCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(548, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.acc_remove);
            this.Controls.Add(this.cancel_remove);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "RemoverCliente";
            this.Text = "Remover Cliente";
            this.Load += new System.EventHandler(this.RemoverCliente_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acc_remove;
        private System.Windows.Forms.Button cancel_remove;
        private System.Windows.Forms.Label label6;
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
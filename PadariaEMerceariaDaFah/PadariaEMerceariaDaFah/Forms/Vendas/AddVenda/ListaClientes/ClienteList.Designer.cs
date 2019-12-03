namespace PadariaEMerceariaDaFah.Forms.Vendas.AddVenda.ListaClientes
{
    partial class ClienteList
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
            this.list_cliente = new System.Windows.Forms.ListBox();
            this.add_cliente_cancel = new System.Windows.Forms.Button();
            this.go_addCliente = new System.Windows.Forms.Button();
            this.go_cliente_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_cliente
            // 
            this.list_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_cliente.FormattingEnabled = true;
            this.list_cliente.ItemHeight = 21;
            this.list_cliente.Location = new System.Drawing.Point(12, 34);
            this.list_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_cliente.Name = "list_cliente";
            this.list_cliente.Size = new System.Drawing.Size(689, 256);
            this.list_cliente.TabIndex = 18;
            this.list_cliente.DoubleClick += new System.EventHandler(this.list_cliente_DoubleClick);
            // 
            // add_cliente_cancel
            // 
            this.add_cliente_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_cliente_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_cliente_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cliente_cancel.Location = new System.Drawing.Point(562, 294);
            this.add_cliente_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_cliente_cancel.Name = "add_cliente_cancel";
            this.add_cliente_cancel.Size = new System.Drawing.Size(139, 55);
            this.add_cliente_cancel.TabIndex = 21;
            this.add_cliente_cancel.Text = "Cancelar";
            this.add_cliente_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_cliente_cancel.UseVisualStyleBackColor = true;
            this.add_cliente_cancel.Click += new System.EventHandler(this.add_cliente_cancel_Click);
            // 
            // go_addCliente
            // 
            this.go_addCliente.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.func_Add;
            this.go_addCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_addCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_addCliente.Location = new System.Drawing.Point(252, 294);
            this.go_addCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_addCliente.Name = "go_addCliente";
            this.go_addCliente.Size = new System.Drawing.Size(304, 55);
            this.go_addCliente.TabIndex = 20;
            this.go_addCliente.Text = "Adicionar um novo cliente";
            this.go_addCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_addCliente.UseVisualStyleBackColor = true;
            this.go_addCliente.Click += new System.EventHandler(this.go_addCliente_Click);
            // 
            // go_cliente_Click
            // 
            this.go_cliente_Click.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Editfunc;
            this.go_cliente_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_cliente_Click.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_cliente_Click.Location = new System.Drawing.Point(12, 294);
            this.go_cliente_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_cliente_Click.Name = "go_cliente_Click";
            this.go_cliente_Click.Size = new System.Drawing.Size(234, 55);
            this.go_cliente_Click.TabIndex = 19;
            this.go_cliente_Click.Text = "Editar um cliente";
            this.go_cliente_Click.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_cliente_Click.UseVisualStyleBackColor = true;
            this.go_cliente_Click.Click += new System.EventHandler(this.go_cliente_Click_Click);
            // 
            // ClienteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 361);
            this.Controls.Add(this.add_cliente_cancel);
            this.Controls.Add(this.go_addCliente);
            this.Controls.Add(this.go_cliente_Click);
            this.Controls.Add(this.list_cliente);
            this.Name = "ClienteList";
            this.Text = "ClienteList";
            this.Load += new System.EventHandler(this.ClienteList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_cliente_cancel;
        private System.Windows.Forms.Button go_addCliente;
        private System.Windows.Forms.Button go_cliente_Click;
        private System.Windows.Forms.ListBox list_cliente;
    }
}
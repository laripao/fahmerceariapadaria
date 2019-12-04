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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteList));
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
            this.list_cliente.ItemHeight = 17;
            this.list_cliente.Location = new System.Drawing.Point(9, 28);
            this.list_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_cliente.Name = "list_cliente";
            this.list_cliente.Size = new System.Drawing.Size(518, 208);
            this.list_cliente.TabIndex = 18;
            this.list_cliente.DoubleClick += new System.EventHandler(this.list_cliente_DoubleClick);
            // 
            // add_cliente_cancel
            // 
            this.add_cliente_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_cliente_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_cliente_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cliente_cancel.Location = new System.Drawing.Point(422, 239);
            this.add_cliente_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.add_cliente_cancel.Name = "add_cliente_cancel";
            this.add_cliente_cancel.Size = new System.Drawing.Size(104, 45);
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
            this.go_addCliente.Location = new System.Drawing.Point(189, 239);
            this.go_addCliente.Margin = new System.Windows.Forms.Padding(2);
            this.go_addCliente.Name = "go_addCliente";
            this.go_addCliente.Size = new System.Drawing.Size(228, 45);
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
            this.go_cliente_Click.Location = new System.Drawing.Point(9, 239);
            this.go_cliente_Click.Margin = new System.Windows.Forms.Padding(2);
            this.go_cliente_Click.Name = "go_cliente_Click";
            this.go_cliente_Click.Size = new System.Drawing.Size(176, 45);
            this.go_cliente_Click.TabIndex = 19;
            this.go_cliente_Click.Text = "Editar um cliente";
            this.go_cliente_Click.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_cliente_Click.UseVisualStyleBackColor = true;
            this.go_cliente_Click.Click += new System.EventHandler(this.go_cliente_Click_Click);
            // 
            // ClienteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(531, 293);
            this.Controls.Add(this.add_cliente_cancel);
            this.Controls.Add(this.go_addCliente);
            this.Controls.Add(this.go_cliente_Click);
            this.Controls.Add(this.list_cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ClienteList";
            this.Text = "Lista de Clientes";
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
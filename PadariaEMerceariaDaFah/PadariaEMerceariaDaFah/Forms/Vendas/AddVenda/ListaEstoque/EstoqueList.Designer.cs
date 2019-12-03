namespace PadariaEMerceariaDaFah.Forms.Vendas.AddVenda.ListaEstoque
{
    partial class EstoqueList
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
            this.list_estoque = new System.Windows.Forms.ListBox();
            this.ok_button_qtd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.quantidade_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add_estoque_cancel = new System.Windows.Forms.Button();
            this.go_addEstoque = new System.Windows.Forms.Button();
            this.go_estoque_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_estoque
            // 
            this.list_estoque.Enabled = false;
            this.list_estoque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_estoque.FormattingEnabled = true;
            this.list_estoque.ItemHeight = 21;
            this.list_estoque.Location = new System.Drawing.Point(12, 96);
            this.list_estoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_estoque.Name = "list_estoque";
            this.list_estoque.Size = new System.Drawing.Size(689, 256);
            this.list_estoque.TabIndex = 22;
            this.list_estoque.DoubleClick += new System.EventHandler(this.list_estoque_DoubleClick);
            // 
            // ok_button_qtd
            // 
            this.ok_button_qtd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ok_button_qtd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button_qtd.Location = new System.Drawing.Point(508, 11);
            this.ok_button_qtd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok_button_qtd.Name = "ok_button_qtd";
            this.ok_button_qtd.Size = new System.Drawing.Size(48, 32);
            this.ok_button_qtd.TabIndex = 30;
            this.ok_button_qtd.Text = "Ok!";
            this.ok_button_qtd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ok_button_qtd.UseVisualStyleBackColor = true;
            this.ok_button_qtd.Click += new System.EventHandler(this.ok_button_qtd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "unidades.";
            // 
            // quantidade_text
            // 
            this.quantidade_text.Location = new System.Drawing.Point(278, 11);
            this.quantidade_text.Multiline = true;
            this.quantidade_text.Name = "quantidade_text";
            this.quantidade_text.Size = new System.Drawing.Size(84, 32);
            this.quantidade_text.TabIndex = 28;
            this.quantidade_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidade_text_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Quantidade vendida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(615, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Clique duas vezes em um item para selecioná-lo.";
            // 
            // add_estoque_cancel
            // 
            this.add_estoque_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_estoque_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_estoque_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_estoque_cancel.Location = new System.Drawing.Point(562, 356);
            this.add_estoque_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_estoque_cancel.Name = "add_estoque_cancel";
            this.add_estoque_cancel.Size = new System.Drawing.Size(139, 55);
            this.add_estoque_cancel.TabIndex = 25;
            this.add_estoque_cancel.Text = "Cancelar";
            this.add_estoque_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_estoque_cancel.UseVisualStyleBackColor = true;
            this.add_estoque_cancel.Click += new System.EventHandler(this.add_estoque_cancel_Click);
            // 
            // go_addEstoque
            // 
            this.go_addEstoque.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.func_Add;
            this.go_addEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_addEstoque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_addEstoque.Location = new System.Drawing.Point(252, 356);
            this.go_addEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_addEstoque.Name = "go_addEstoque";
            this.go_addEstoque.Size = new System.Drawing.Size(304, 55);
            this.go_addEstoque.TabIndex = 24;
            this.go_addEstoque.Text = "Adicionar um novo item";
            this.go_addEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_addEstoque.UseVisualStyleBackColor = true;
            this.go_addEstoque.Click += new System.EventHandler(this.go_addEstoque_Click);
            // 
            // go_estoque_Click
            // 
            this.go_estoque_Click.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Editfunc;
            this.go_estoque_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_estoque_Click.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_estoque_Click.Location = new System.Drawing.Point(12, 356);
            this.go_estoque_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_estoque_Click.Name = "go_estoque_Click";
            this.go_estoque_Click.Size = new System.Drawing.Size(234, 55);
            this.go_estoque_Click.TabIndex = 23;
            this.go_estoque_Click.Text = "Editar um item";
            this.go_estoque_Click.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_estoque_Click.UseVisualStyleBackColor = true;
            this.go_estoque_Click.Click += new System.EventHandler(this.go_estoque_Click_Click);
            // 
            // EstoqueList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 425);
            this.Controls.Add(this.ok_button_qtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantidade_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add_estoque_cancel);
            this.Controls.Add(this.go_addEstoque);
            this.Controls.Add(this.go_estoque_Click);
            this.Controls.Add(this.list_estoque);
            this.Name = "EstoqueList";
            this.Text = "EstoqueList";
            this.Load += new System.EventHandler(this.EstoqueList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_estoque_cancel;
        private System.Windows.Forms.Button go_addEstoque;
        private System.Windows.Forms.Button go_estoque_Click;
        private System.Windows.Forms.ListBox list_estoque;
        private System.Windows.Forms.Button ok_button_qtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantidade_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}
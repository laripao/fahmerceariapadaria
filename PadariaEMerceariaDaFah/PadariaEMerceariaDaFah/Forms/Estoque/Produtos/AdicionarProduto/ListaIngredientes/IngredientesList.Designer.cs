namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaProdutos
{
    partial class IngredientesList
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
            this.add_produto_cancel = new System.Windows.Forms.Button();
            this.go_addIngrediente = new System.Windows.Forms.Button();
            this.go_ingrediente_Click = new System.Windows.Forms.Button();
            this.list_ingrediente = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantidade_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ok_button_qtd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_produto_cancel
            // 
            this.add_produto_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_produto_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_produto_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_produto_cancel.Location = new System.Drawing.Point(562, 444);
            this.add_produto_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_produto_cancel.Name = "add_produto_cancel";
            this.add_produto_cancel.Size = new System.Drawing.Size(125, 55);
            this.add_produto_cancel.TabIndex = 17;
            this.add_produto_cancel.Text = "Cancelar";
            this.add_produto_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_produto_cancel.UseVisualStyleBackColor = true;
            this.add_produto_cancel.Click += new System.EventHandler(this.add_produto_cancel_Click);
            // 
            // go_addIngrediente
            // 
            this.go_addIngrediente.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.buy;
            this.go_addIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_addIngrediente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_addIngrediente.Location = new System.Drawing.Point(252, 444);
            this.go_addIngrediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_addIngrediente.Name = "go_addIngrediente";
            this.go_addIngrediente.Size = new System.Drawing.Size(304, 55);
            this.go_addIngrediente.TabIndex = 16;
            this.go_addIngrediente.Text = "Adicionar um novo ingrediente";
            this.go_addIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_addIngrediente.UseVisualStyleBackColor = true;
            this.go_addIngrediente.Click += new System.EventHandler(this.go_addIngrediente_Click);
            // 
            // go_ingrediente_Click
            // 
            this.go_ingrediente_Click.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.edit_validated_icon;
            this.go_ingrediente_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_ingrediente_Click.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_ingrediente_Click.Location = new System.Drawing.Point(12, 444);
            this.go_ingrediente_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_ingrediente_Click.Name = "go_ingrediente_Click";
            this.go_ingrediente_Click.Size = new System.Drawing.Size(234, 55);
            this.go_ingrediente_Click.TabIndex = 15;
            this.go_ingrediente_Click.Text = "Editar um ingrediente";
            this.go_ingrediente_Click.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_ingrediente_Click.UseVisualStyleBackColor = true;
            this.go_ingrediente_Click.Click += new System.EventHandler(this.go_ingrediente_Click_Click);
            // 
            // list_ingrediente
            // 
            this.list_ingrediente.Enabled = false;
            this.list_ingrediente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_ingrediente.FormattingEnabled = true;
            this.list_ingrediente.ItemHeight = 21;
            this.list_ingrediente.Location = new System.Drawing.Point(12, 100);
            this.list_ingrediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_ingrediente.Name = "list_ingrediente";
            this.list_ingrediente.Size = new System.Drawing.Size(675, 340);
            this.list_ingrediente.TabIndex = 18;
            this.list_ingrediente.DoubleClick += new System.EventHandler(this.list_ingrediente_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(615, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Clique duas vezes em um item para selecioná-lo.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quantidade usada:";
            // 
            // quantidade_text
            // 
            this.quantidade_text.Location = new System.Drawing.Point(271, 21);
            this.quantidade_text.Name = "quantidade_text";
            this.quantidade_text.Size = new System.Drawing.Size(100, 22);
            this.quantidade_text.TabIndex = 21;
            this.quantidade_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidade_text_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "unidades.";
            // 
            // ok_button_qtd
            // 
            this.ok_button_qtd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ok_button_qtd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button_qtd.Location = new System.Drawing.Point(517, 15);
            this.ok_button_qtd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok_button_qtd.Name = "ok_button_qtd";
            this.ok_button_qtd.Size = new System.Drawing.Size(48, 32);
            this.ok_button_qtd.TabIndex = 23;
            this.ok_button_qtd.Text = "Ok!";
            this.ok_button_qtd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ok_button_qtd.UseVisualStyleBackColor = true;
            this.ok_button_qtd.Click += new System.EventHandler(this.ok_button_qtd_Click);
            // 
            // IngredientesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(693, 510);
            this.Controls.Add(this.ok_button_qtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantidade_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.list_ingrediente);
            this.Controls.Add(this.add_produto_cancel);
            this.Controls.Add(this.go_addIngrediente);
            this.Controls.Add(this.go_ingrediente_Click);
            this.Name = "IngredientesList";
            this.Text = "IngredientesList";
            this.Load += new System.EventHandler(this.IngredientesList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_produto_cancel;
        private System.Windows.Forms.Button go_addIngrediente;
        private System.Windows.Forms.Button go_ingrediente_Click;
        private System.Windows.Forms.ListBox list_ingrediente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantidade_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ok_button_qtd;
    }
}
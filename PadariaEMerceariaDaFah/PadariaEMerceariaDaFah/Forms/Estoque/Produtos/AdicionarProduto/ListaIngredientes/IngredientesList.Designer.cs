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
            this.SuspendLayout();
            // 
            // add_produto_cancel
            // 
            this.add_produto_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_produto_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_produto_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_produto_cancel.Location = new System.Drawing.Point(562, 259);
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
            this.go_addIngrediente.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.func_Add;
            this.go_addIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_addIngrediente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_addIngrediente.Location = new System.Drawing.Point(252, 259);
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
            this.go_ingrediente_Click.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Editfunc;
            this.go_ingrediente_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_ingrediente_Click.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_ingrediente_Click.Location = new System.Drawing.Point(12, 259);
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
            this.list_ingrediente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_ingrediente.FormattingEnabled = true;
            this.list_ingrediente.ItemHeight = 21;
            this.list_ingrediente.Location = new System.Drawing.Point(12, 1);
            this.list_ingrediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_ingrediente.Name = "list_ingrediente";
            this.list_ingrediente.Size = new System.Drawing.Size(675, 256);
            this.list_ingrediente.TabIndex = 18;
            this.list_ingrediente.DoubleClick += new System.EventHandler(this.list_ingrediente_DoubleClick);
            // 
            // IngredientesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 323);
            this.Controls.Add(this.list_ingrediente);
            this.Controls.Add(this.add_produto_cancel);
            this.Controls.Add(this.go_addIngrediente);
            this.Controls.Add(this.go_ingrediente_Click);
            this.Name = "IngredientesList";
            this.Text = "IngredientesList";
            this.Load += new System.EventHandler(this.IngredientesList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_produto_cancel;
        private System.Windows.Forms.Button go_addIngrediente;
        private System.Windows.Forms.Button go_ingrediente_Click;
        private System.Windows.Forms.ListBox list_ingrediente;
    }
}
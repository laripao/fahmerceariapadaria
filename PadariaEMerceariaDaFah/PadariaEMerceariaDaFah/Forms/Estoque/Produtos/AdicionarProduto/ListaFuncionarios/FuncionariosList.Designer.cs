namespace PadariaEMerceariaDaFah.Forms.Estoque.Produtos.AdicionarProduto.ListaFuncionarios
{
    partial class FuncionariosList
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
            this.list_funcionario = new System.Windows.Forms.ListBox();
            this.add_produto_cancel = new System.Windows.Forms.Button();
            this.go_addFuncionario = new System.Windows.Forms.Button();
            this.go_funcionario_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_funcionario
            // 
            this.list_funcionario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_funcionario.FormattingEnabled = true;
            this.list_funcionario.ItemHeight = 21;
            this.list_funcionario.Location = new System.Drawing.Point(12, 11);
            this.list_funcionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_funcionario.Name = "list_funcionario";
            this.list_funcionario.Size = new System.Drawing.Size(689, 256);
            this.list_funcionario.TabIndex = 14;
            this.list_funcionario.DoubleClick += new System.EventHandler(this.list_funcionario_DoubleClick);
            // 
            // add_produto_cancel
            // 
            this.add_produto_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_produto_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_produto_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_produto_cancel.Location = new System.Drawing.Point(562, 294);
            this.add_produto_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_produto_cancel.Name = "add_produto_cancel";
            this.add_produto_cancel.Size = new System.Drawing.Size(139, 55);
            this.add_produto_cancel.TabIndex = 17;
            this.add_produto_cancel.Text = "Cancelar";
            this.add_produto_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_produto_cancel.UseVisualStyleBackColor = true;
            this.add_produto_cancel.Click += new System.EventHandler(this.add_produto_cancel_Click);
            // 
            // go_addFuncionario
            // 
            this.go_addFuncionario.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.func_Add;
            this.go_addFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_addFuncionario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_addFuncionario.Location = new System.Drawing.Point(252, 294);
            this.go_addFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_addFuncionario.Name = "go_addFuncionario";
            this.go_addFuncionario.Size = new System.Drawing.Size(304, 55);
            this.go_addFuncionario.TabIndex = 16;
            this.go_addFuncionario.Text = "Adicionar um novo funcionário";
            this.go_addFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_addFuncionario.UseVisualStyleBackColor = true;
            this.go_addFuncionario.Click += new System.EventHandler(this.go_addFuncionario_Click);
            // 
            // go_funcionario_Click
            // 
            this.go_funcionario_Click.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Editfunc;
            this.go_funcionario_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_funcionario_Click.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_funcionario_Click.Location = new System.Drawing.Point(12, 294);
            this.go_funcionario_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_funcionario_Click.Name = "go_funcionario_Click";
            this.go_funcionario_Click.Size = new System.Drawing.Size(234, 55);
            this.go_funcionario_Click.TabIndex = 15;
            this.go_funcionario_Click.Text = "Editar um funcionario";
            this.go_funcionario_Click.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_funcionario_Click.UseVisualStyleBackColor = true;
            this.go_funcionario_Click.Click += new System.EventHandler(this.go_funcionario_Click_Click);
            // 
            // FuncionariosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 357);
            this.Controls.Add(this.add_produto_cancel);
            this.Controls.Add(this.go_addFuncionario);
            this.Controls.Add(this.go_funcionario_Click);
            this.Controls.Add(this.list_funcionario);
            this.Name = "FuncionariosList";
            this.Text = "FuncionariosList";
            this.Load += new System.EventHandler(this.FuncionariosList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_produto_cancel;
        private System.Windows.Forms.Button go_addFuncionario;
        private System.Windows.Forms.Button go_funcionario_Click;
        private System.Windows.Forms.ListBox list_funcionario;
    }
}
namespace PadariaEMerceariaDaFah.Forms
{
    partial class GerenciaInicio
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
            this.go_funcionario = new System.Windows.Forms.Button();
            this.go_fornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go_funcionario
            // 
            this.go_funcionario.Location = new System.Drawing.Point(12, 12);
            this.go_funcionario.Name = "go_funcionario";
            this.go_funcionario.Size = new System.Drawing.Size(355, 188);
            this.go_funcionario.TabIndex = 0;
            this.go_funcionario.Text = "Funcionario";
            this.go_funcionario.UseVisualStyleBackColor = true;
            this.go_funcionario.Click += new System.EventHandler(this.go_funcionario_Click);
            // 
            // go_fornecedor
            // 
            this.go_fornecedor.Location = new System.Drawing.Point(433, 12);
            this.go_fornecedor.Name = "go_fornecedor";
            this.go_fornecedor.Size = new System.Drawing.Size(355, 188);
            this.go_fornecedor.TabIndex = 1;
            this.go_fornecedor.Text = "Fornecedor";
            this.go_fornecedor.UseVisualStyleBackColor = true;
            this.go_fornecedor.Click += new System.EventHandler(this.go_fornecedor_Click);
            // 
            // GerenciaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 462);
            this.Controls.Add(this.go_fornecedor);
            this.Controls.Add(this.go_funcionario);
            this.Name = "GerenciaInicio";
            this.Text = "Gerencia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go_funcionario;
        private System.Windows.Forms.Button go_fornecedor;
    }
}
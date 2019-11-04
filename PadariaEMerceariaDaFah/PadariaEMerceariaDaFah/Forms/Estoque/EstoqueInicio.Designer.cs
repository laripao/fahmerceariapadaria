namespace PadariaEMerceariaDaFah.Forms.Estoque
{
    partial class EstoqueInicio
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
            this.show_produtos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_produtos
            // 
            this.show_produtos.Location = new System.Drawing.Point(45, 50);
            this.show_produtos.Name = "show_produtos";
            this.show_produtos.Size = new System.Drawing.Size(181, 86);
            this.show_produtos.TabIndex = 0;
            this.show_produtos.Text = "Visualizar produtos";
            this.show_produtos.UseVisualStyleBackColor = true;
            this.show_produtos.Click += new System.EventHandler(this.show_produtos_Click);
            // 
            // EstoqueInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_produtos);
            this.Name = "EstoqueInicio";
            this.Text = "EstoqueInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_produtos;
    }
}
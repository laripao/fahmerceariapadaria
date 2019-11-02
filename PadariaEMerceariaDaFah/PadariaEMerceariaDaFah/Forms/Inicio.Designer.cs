namespace PadariaEMerceariaDaFah
{
    partial class Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.go_gerencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go_gerencia
            // 
            this.go_gerencia.Location = new System.Drawing.Point(38, 339);
            this.go_gerencia.Name = "go_gerencia";
            this.go_gerencia.Size = new System.Drawing.Size(118, 48);
            this.go_gerencia.TabIndex = 0;
            this.go_gerencia.Text = "Gerência";
            this.go_gerencia.UseVisualStyleBackColor = true;
            this.go_gerencia.Click += new System.EventHandler(this.go_gerencia_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.go_gerencia);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go_gerencia;
    }
}


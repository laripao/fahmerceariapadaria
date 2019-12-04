namespace PadariaEMerceariaDaFah.Forms.Estoque.Itens.RemoverItem
{
    partial class RemoverItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoverItem));
            this.acc_remove = new System.Windows.Forms.Button();
            this.cancel_remove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qtd_text = new System.Windows.Forms.TextBox();
            this.data_validade = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.produtos_label = new System.Windows.Forms.Label();
            this.produto_nome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acc_remove
            // 
            this.acc_remove.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.shopping_basket_remove_icon;
            this.acc_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acc_remove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_remove.Location = new System.Drawing.Point(98, 128);
            this.acc_remove.Margin = new System.Windows.Forms.Padding(2);
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
            this.cancel_remove.Location = new System.Drawing.Point(314, 128);
            this.cancel_remove.Margin = new System.Windows.Forms.Padding(2);
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
            this.label6.Location = new System.Drawing.Point(5, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(439, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tem certeza que deseja remover este item?";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.qtd_text);
            this.groupBox1.Controls.Add(this.data_validade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.produtos_label);
            this.groupBox1.Controls.Add(this.produto_nome);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(544, 81);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quantidade:";
            // 
            // qtd_text
            // 
            this.qtd_text.Location = new System.Drawing.Point(476, 41);
            this.qtd_text.Margin = new System.Windows.Forms.Padding(2);
            this.qtd_text.Name = "qtd_text";
            this.qtd_text.Size = new System.Drawing.Size(47, 23);
            this.qtd_text.TabIndex = 26;
            // 
            // data_validade
            // 
            this.data_validade.Location = new System.Drawing.Point(91, 41);
            this.data_validade.Margin = new System.Windows.Forms.Padding(2);
            this.data_validade.Name = "data_validade";
            this.data_validade.Size = new System.Drawing.Size(274, 23);
            this.data_validade.TabIndex = 25;
            this.data_validade.Value = new System.DateTime(2019, 11, 16, 20, 13, 20, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Validade:";
            // 
            // produtos_label
            // 
            this.produtos_label.AutoSize = true;
            this.produtos_label.Location = new System.Drawing.Point(2, 18);
            this.produtos_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.produtos_label.Name = "produtos_label";
            this.produtos_label.Size = new System.Drawing.Size(64, 17);
            this.produtos_label.TabIndex = 19;
            this.produtos_label.Text = "Produto:";
            // 
            // produto_nome
            // 
            this.produto_nome.Enabled = false;
            this.produto_nome.Location = new System.Drawing.Point(91, 15);
            this.produto_nome.Margin = new System.Windows.Forms.Padding(2);
            this.produto_nome.Name = "produto_nome";
            this.produto_nome.Size = new System.Drawing.Size(432, 23);
            this.produto_nome.TabIndex = 18;
            // 
            // RemoverItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(562, 179);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.acc_remove);
            this.Controls.Add(this.cancel_remove);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RemoverItem";
            this.Text = "Remover Item";
            this.Load += new System.EventHandler(this.RemoverItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button acc_remove;
        private System.Windows.Forms.Button cancel_remove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtd_text;
        private System.Windows.Forms.DateTimePicker data_validade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label produtos_label;
        private System.Windows.Forms.TextBox produto_nome;
    }
}
namespace PadariaEMerceariaDaFah.Forms.Estoque.Itens
{
    partial class Itens
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qtd_text = new System.Windows.Forms.TextBox();
            this.data_validade = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.linkProdutos = new System.Windows.Forms.LinkLabel();
            this.produtos_label = new System.Windows.Forms.Label();
            this.produto_nome = new System.Windows.Forms.TextBox();
            this.add_ingrediente_salvar = new System.Windows.Forms.Button();
            this.add_ingrediente_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.linkProdutos);
            this.groupBox1.Controls.Add(this.produtos_label);
            this.groupBox1.Controls.Add(this.produto_nome);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(719, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quantidade:";
            // 
            // qtd_text
            // 
            this.qtd_text.Location = new System.Drawing.Point(635, 97);
            this.qtd_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qtd_text.Name = "qtd_text";
            this.qtd_text.Size = new System.Drawing.Size(61, 27);
            this.qtd_text.TabIndex = 26;
            this.qtd_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtd_text_KeyPress);
            // 
            // data_validade
            // 
            this.data_validade.Location = new System.Drawing.Point(121, 97);
            this.data_validade.Name = "data_validade";
            this.data_validade.Size = new System.Drawing.Size(364, 27);
            this.data_validade.TabIndex = 25;
            this.data_validade.Value = new System.DateTime(2019, 11, 16, 20, 13, 20, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Validade:";
            // 
            // linkProdutos
            // 
            this.linkProdutos.AutoSize = true;
            this.linkProdutos.Location = new System.Drawing.Point(293, 53);
            this.linkProdutos.Name = "linkProdutos";
            this.linkProdutos.Size = new System.Drawing.Size(192, 21);
            this.linkProdutos.TabIndex = 20;
            this.linkProdutos.TabStop = true;
            this.linkProdutos.Text = "Selecione um produto";
            this.linkProdutos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProdutos_LinkClicked);
            // 
            // produtos_label
            // 
            this.produtos_label.AutoSize = true;
            this.produtos_label.Location = new System.Drawing.Point(2, 27);
            this.produtos_label.Name = "produtos_label";
            this.produtos_label.Size = new System.Drawing.Size(81, 21);
            this.produtos_label.TabIndex = 19;
            this.produtos_label.Text = "Produto:";
            // 
            // produto_nome
            // 
            this.produto_nome.Enabled = false;
            this.produto_nome.Location = new System.Drawing.Point(121, 24);
            this.produto_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.produto_nome.Name = "produto_nome";
            this.produto_nome.Size = new System.Drawing.Size(575, 27);
            this.produto_nome.TabIndex = 18;
            // 
            // add_ingrediente_salvar
            // 
            this.add_ingrediente_salvar.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.add_ingrediente_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_ingrediente_salvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_ingrediente_salvar.Location = new System.Drawing.Point(185, 173);
            this.add_ingrediente_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_ingrediente_salvar.Name = "add_ingrediente_salvar";
            this.add_ingrediente_salvar.Size = new System.Drawing.Size(113, 49);
            this.add_ingrediente_salvar.TabIndex = 18;
            this.add_ingrediente_salvar.Text = "Salvar";
            this.add_ingrediente_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_ingrediente_salvar.UseVisualStyleBackColor = true;
            this.add_ingrediente_salvar.Click += new System.EventHandler(this.add_ingrediente_salvar_Click);
            // 
            // add_ingrediente_cancel
            // 
            this.add_ingrediente_cancel.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.Actions_edit_delete_icon;
            this.add_ingrediente_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_ingrediente_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_ingrediente_cancel.Location = new System.Drawing.Point(418, 173);
            this.add_ingrediente_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_ingrediente_cancel.Name = "add_ingrediente_cancel";
            this.add_ingrediente_cancel.Size = new System.Drawing.Size(139, 49);
            this.add_ingrediente_cancel.TabIndex = 17;
            this.add_ingrediente_cancel.Text = "Cancelar";
            this.add_ingrediente_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_ingrediente_cancel.UseVisualStyleBackColor = true;
            this.add_ingrediente_cancel.Click += new System.EventHandler(this.add_ingrediente_cancel_Click);
            // 
            // Itens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(743, 232);
            this.Controls.Add(this.add_ingrediente_salvar);
            this.Controls.Add(this.add_ingrediente_cancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Itens";
            this.Text = "Itens";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkProdutos;
        private System.Windows.Forms.Label produtos_label;
        private System.Windows.Forms.TextBox produto_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtd_text;
        private System.Windows.Forms.DateTimePicker data_validade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_ingrediente_salvar;
        private System.Windows.Forms.Button add_ingrediente_cancel;
    }
}
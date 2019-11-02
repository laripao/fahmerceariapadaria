﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario.AddFuncinario
{
    public partial class AddFuncionario : Form
    {
        public AddFuncionario()
        {
            InitializeComponent();
        }

        private void add_funcionario_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_funcionario_salvar_Click(object sender, EventArgs e)
        {
            var funcionarios = Comercio.GerenciaEmpresa.Instance.Funcionarios;
            var cod = 1;

            if (funcionarios.Any())
            {
                cod = Comercio.GerenciaEmpresa.Instance.Funcionarios.Max(x => x.Codigo) + 1;
            }
            var novoFunc = new Comercio.Funcionario(cod, func_nome.Text, func_funcao.Text, new Comercio.Contato(func_telefone.Text, func_celular.Text, func_email.Text), new Comercio.Endereco(func_rua.Text, func_cidade.Text,func_estado.Text,func_pais.Text, func_cep.Text, func_numero.Text));

            Comercio.GerenciaEmpresa.Instance.AdicionarFuncionario(novoFunc);

            this.Close();
        }

    }
}
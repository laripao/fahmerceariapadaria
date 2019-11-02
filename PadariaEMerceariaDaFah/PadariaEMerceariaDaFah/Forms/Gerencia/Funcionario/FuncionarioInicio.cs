using PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario.AddFuncinario;
using PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario.RemoveFuncionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaEMerceariaDaFah.Forms.Gerencia.Funcionario
{
    public partial class FuncionarioInicio : Form
    {
        public FuncionarioInicio()
        {
            InitializeComponent();
        }

        private void add_funcionario_Click(object sender, EventArgs e)
        {
            var add = new AddFuncionario();
            add.ShowDialog();
            UpdateForm();
        }

        private void UpdateForm(int Selected = 0)
        {
            list_func.Items.Clear();
            foreach (var item in Comercio.GerenciaEmpresa.Instance.Funcionarios)
            {
                list_func.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
            }
            if (Selected != 0)
            {
                var funcSelected = Comercio.GerenciaEmpresa.Instance.Funcionarios.FirstOrDefault(x => x.Codigo == Selected);
                if (funcSelected != null)
                {
                    var index = list_func.Items.IndexOf(funcSelected.Codigo.ToString() + " | " + funcSelected.Nome);
                    list_func.SetSelected(index, true);
                }
            }
        }

        private void FuncionarioInicio_Load(object sender, EventArgs e)
        {
            foreach (var item in Comercio.GerenciaEmpresa.Instance.Funcionarios)
            {
                list_func.Items.Add(item.Codigo.ToString() + " | " + item.Nome);
            }
            HabilitarEdicao();
        }

        private void habilitar_edicao_CheckedChanged_1(object sender, EventArgs e)
        {
            HabilitarEdicao();
        }

        private void HabilitarEdicao()
        {
            if (habilitar_edicao.Checked)
            {
                save_edit_func.Enabled = true;
                remove_func.Enabled = true;

                func_nome.Enabled = true;
                func_funcao.Enabled = true;
                func_celular.Enabled = true;
                func_telefone.Enabled = true;
                func_email.Enabled = true;

                func_pais.Enabled = true;
                func_estado.Enabled = true;
                func_cidade.Enabled = true;
                func_rua.Enabled = true;
                func_numero.Enabled = true;
                func_cep.Enabled = true;
            }
            else
            {
                save_edit_func.Enabled = false;
                remove_func.Enabled = false;

                func_nome.Enabled = false;
                func_funcao.Enabled = false;
                func_celular.Enabled = false;
                func_telefone.Enabled = false;
                func_email.Enabled = false;

                func_pais.Enabled = false;
                func_estado.Enabled = false;
                func_cidade.Enabled = false;
                func_rua.Enabled = false;
                func_numero.Enabled = false;
                func_cep.Enabled = false;

            }
        }

        private void save_edit_func_Click(object sender, EventArgs e)
        {
            if (list_func.SelectedItem != null)
            {
                var selectedFunc = Convert.ToInt32(list_func.SelectedItem.ToString().Split('|').First());
                var func = Comercio.GerenciaEmpresa.Instance.Funcionarios.FirstOrDefault(x => x.Codigo == selectedFunc);

                func.Nome = func_nome.Text;
                func.Funcao = func_funcao.Text;
                func.Contato.Celular = func_celular.Text;
                func.Contato.Telefone = func_telefone.Text;
                func.Contato.Email = func_email.Text;

                func.Endereco.Pais = func_pais.Text;
                func.Endereco.Estado = func_estado.Text;
                func.Endereco.Cidade = func_cidade.Text;
                func.Endereco.Rua = func_rua.Text;
                func.Endereco.Numero = func_numero.Text;
                func.Endereco.CEP = func_cep.Text;

                UpdateForm(selectedFunc);
            }
        }

        private void remove_func_Click(object sender, EventArgs e)
        {
            if (list_func.SelectedItem != null)
            {
                var selectedFunc = Convert.ToInt32(list_func.SelectedItem.ToString().Split('|').First());
                var remove = new RemoverFuncionario(selectedFunc);
                remove.ShowDialog();
                UpdateForm(selectedFunc);
            }

        }

        private void list_func_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedFunc;
            if (list_func.SelectedItem != null)
            {
                selectedFunc = Convert.ToInt32(list_func.SelectedItem.ToString().Split('|').First());
                var func = Comercio.GerenciaEmpresa.Instance.Funcionarios.FirstOrDefault(x => x.Codigo == selectedFunc);

                func_nome.Text = func.Nome;
                func_funcao.Text = func.Funcao;
                func_celular.Text = func.Contato.Celular;
                func_telefone.Text = func.Contato.Telefone;
                func_email.Text = func.Contato.Email;

                func_pais.Text = func.Endereco.Pais;
                func_estado.Text = func.Endereco.Estado;
                func_cidade.Text = func.Endereco.Cidade;
                func_rua.Text = func.Endereco.Rua;
                func_numero.Text = func.Endereco.Numero;
                func_cep.Text = func.Endereco.CEP;

            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arquivos;
using Formulario;

namespace Comercio
{
    [Serializable]
    public class GerenciaEmpresa
    {
        public List<Funcionario> Funcionarios;
        public List<Produto> Produtos;
        public List<Cliente> Clientes;
        public List<Venda> Vendas;
        public List<Fornecedor> Fornecedores;
        public DB Banco;

        public static GerenciaEmpresa Instance;

        public GerenciaEmpresa()
        {
            Funcionarios = new List<Funcionario>();
            Produtos = new List<Produto>();
            Clientes = new List<Cliente>();
            Vendas = new List<Venda>();
            Fornecedores = new List<Fornecedor>();
            Banco = new DB();
            Instance = this;
        }

        public void AdicionarFuncionario(Funcionario Novo)
        {
            Funcionarios.Add(Novo);
        }
        public void AdicionarProduto(Produto Novo)
        {
            Produtos.Add(Novo);
        }
        public void AdicionarCliente(Cliente Novo)
        {
            Clientes.Add(Novo);
        }
        public void AdicionarVenda(Venda Novo)
        {
            Vendas.Add(Novo);
        }
        public void AdicionarFornecedor(Fornecedor Novo)
        {
            Fornecedores.Add(Novo);
        }

        public void RemoverFuncionario(Funcionario Item)
        {
            Funcionarios.Remove(Funcionarios.Find(x => x.Codigo == Item.Codigo));
        }
        public void RemoverProduto(Produto Item)
        {
            Produtos.Remove(Produtos.Find(x=> x.Codigo == Item.Codigo)) ;
        }
        public void RemoverCliente(Cliente Item)
        {
            Clientes.Remove(Clientes.Find(x => x.Codigo == Item.Codigo));
        }
        public void RemoverVenda(Venda Item)
        {
            Vendas.Remove(Vendas.Find(x => x.Codigo == Item.Codigo));
        }

        public void RemoverFornecedor(Fornecedor Item)
        {
            Fornecedores.Remove(Fornecedores.Find(x => x.Codigo == Item.Codigo));
        }

        public void AtualizarFuncionario(Funcionario Item)
        {
            Funcionarios.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarFuncionario(Item);
        }
        public void AtualizarProduto(Produto Item)
        {
            Produtos.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarProduto(Item);
        }
        public void AtualizarCliente(Cliente Item)
        {
            Clientes.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarCliente(Item);
        }
        public void AtualizarVenda(Venda Item)
        {
            Vendas.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarVenda(Item);
        }

        public void AtualizarFornecedor(Fornecedor Item)
        {
            Fornecedores.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarFornecedor(Item);
        }

        public void SalvarFuncionarios(List<Funcionario> Item)
        {
            SalvarEEscrever.SaveBinFile<List<Funcionario>>("funcionarios", Item);
        }
        public void SalvarProdutos(List<Produto> Item)
        {
            SalvarEEscrever.SaveBinFile<List<Produto>>("Produtos", Item);
        }
        public void SalvarClientes(List<Cliente> Item)
        {
            SalvarEEscrever.SaveBinFile<List<Cliente>>("Clientes", Item);
        }
        public void SalvarVendas(List<Venda> Item)
        {
            SalvarEEscrever.SaveBinFile<List<Venda>>("Vendas", Item);
        }
        public void SalvarFornecedores(List<Fornecedor> Item)
        {
            SalvarEEscrever.SaveBinFile<List<Fornecedor>>("Fornecedores", Item);
        }

        public List<Funcionario> CarregarFuncionarios()
        {
            return SalvarEEscrever.ReadBinFile<List<Funcionario>>("Funcionarios");
        }
        public List<Produto> CarregarProdutos()
        {
            return SalvarEEscrever.ReadBinFile<List<Produto>>("Produtos");
        }
        public List<Cliente> CarregarClientes()
        {
            return SalvarEEscrever.ReadBinFile<List<Cliente>>("Clientes");
        }
        public List<Venda> CarregarVendas()
        {
            return SalvarEEscrever.ReadBinFile<List<Venda>>("Vendas");
        }
        public List<Fornecedor> CarregarFornecedores()
        {
            return SalvarEEscrever.ReadBinFile<List<Fornecedor>>("Fornecedores");
        }

        public List<Fornecedor> CarregarFornecedoresBanco(string query)
        {
            var fornecedores = Banco.Select(query);

            var listFornecedores = new List<Fornecedor>();

            for (int i = 0; i < fornecedores.Rows.Count; i++)
            {
                listFornecedores.Add(new Fornecedor(Convert.ToInt32(fornecedores.Rows[i].ItemArray[0]),
                                                    fornecedores.Rows[i].ItemArray[1].ToString(),
                                                    fornecedores.Rows[i].ItemArray[2].ToString(),
                                                    new Contato(
                                                    fornecedores.Rows[i].ItemArray[3].ToString(),
                                                    fornecedores.Rows[i].ItemArray[4].ToString(),
                                                    fornecedores.Rows[i].ItemArray[5].ToString())));
            }
            
           return listFornecedores;
        }

        public List<Funcionario> CarregarFuncionariosBanco(string query)
        {

            var funcionarios = Banco.Select(query);

            var lisFuncionarios = new List<Funcionario>();

            for (int i = 0; i < funcionarios.Rows.Count; i++)
            {
                lisFuncionarios.Add(new Funcionario(Convert.ToInt32(funcionarios.Rows[i].ItemArray[0]),
                                                    funcionarios.Rows[i].ItemArray[2].ToString(),
                                                    funcionarios.Rows[i].ItemArray[3].ToString(),
                                                    funcionarios.Rows[i].ItemArray[1].ToString(),
                                                    new Contato(
                                                    funcionarios.Rows[i].ItemArray[4].ToString(),
                                                    funcionarios.Rows[i].ItemArray[5].ToString(),
                                                    funcionarios.Rows[i].ItemArray[6].ToString()),
                                                    new Endereco(
                                                    funcionarios.Rows[i].ItemArray[7].ToString(),
                                                    funcionarios.Rows[i].ItemArray[8].ToString(),
                                                    funcionarios.Rows[i].ItemArray[9].ToString(),
                                                    funcionarios.Rows[i].ItemArray[10].ToString(),
                                                    funcionarios.Rows[i].ItemArray[12].ToString(),
                                                    funcionarios.Rows[i].ItemArray[11].ToString()
                                                        )

                                ));
            }
            return lisFuncionarios;
        }

        public List<Cliente> CarregarClientesBanco(string query)
        {
            var clientes = Banco.Select(query);

            var listClientes = new List<Cliente>();

            for (int i = 0; i < clientes.Rows.Count; i++)
            {
                listClientes.Add(new Cliente(Convert.ToInt32(clientes.Rows[i].ItemArray[0]),
                                            clientes.Rows[i].ItemArray[1].ToString(),
                                            clientes.Rows[i].ItemArray[2].ToString(),
                                            new Contato(
                                                    clientes.Rows[i].ItemArray[3].ToString(),
                                                    clientes.Rows[i].ItemArray[4].ToString(),
                                                    clientes.Rows[i].ItemArray[5].ToString())
                    ));
            }
            return listClientes;
        }

    }
}

using Arquivos;
using Formulario;
using PadariaEMerceariaDaFah.Classes;
using PadariaEMerceariaDaFah.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public List<Ingrediente> Ingredientes;
        public List<EstoqueItem> EstoqueItens;
        public List<RelacaoForneceIngrediente> RelacaoForneceIngredientes;
        public List<RelacaoVendaProduto> RelacaoVendaProdutos;
        public List<RelacaoProdutoUtilizaIngrediente> RelacaoProdutoUtilizaIngredientes;
        public List<RelacaoForneceProduto> RelacaoForneceProdutos;
        public DB Banco;

        public static GerenciaEmpresa Instance;

        public GerenciaEmpresa()
        {
            Funcionarios = new List<Funcionario>();
            Produtos = new List<Produto>();
            Clientes = new List<Cliente>();
            Vendas = new List<Venda>();
            Fornecedores = new List<Fornecedor>();
            Ingredientes = new List<Ingrediente>();
            EstoqueItens = new List<EstoqueItem>();
            RelacaoVendaProdutos = new List<RelacaoVendaProduto>();
            RelacaoForneceIngredientes = new List<RelacaoForneceIngrediente>();
            RelacaoProdutoUtilizaIngredientes = new List<RelacaoProdutoUtilizaIngrediente>();
            RelacaoForneceProdutos = new List<RelacaoForneceProduto>();
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
        public void AdicionarIngrediente(Ingrediente Novo)
        {
            Ingredientes.Add(Novo);
        }
        public void AdicionarEstoqueItens(EstoqueItem Novo)
        {
            EstoqueItens.Add(Novo);
        }
        public void AdicionarRelacaoForneceIngredientes(RelacaoForneceIngrediente Novo)
        {
            RelacaoForneceIngredientes.Add(Novo);
        }
        public void AdicionarRelacaoProdutoUtilizaIngredientes(RelacaoProdutoUtilizaIngrediente Novo)
        {
            RelacaoProdutoUtilizaIngredientes.Add(Novo);
        }
        public void AdicionarRelacaoVendaProduto(RelacaoVendaProduto Novo)
        {
            RelacaoVendaProdutos.Add(Novo);
        }
        public void AdicionarRelacaoForneceProdutos(RelacaoForneceProduto Novo)
        {
            RelacaoForneceProdutos.Add(Novo);
        }
        public void RemoverFuncionario(Funcionario Item)
        {
            Funcionarios.Remove(Funcionarios.Find(x => x.Codigo == Item.Codigo));
        }
        public void RemoverIngrediente(Ingrediente Item)
        {
            Ingredientes.Remove(Ingredientes.Find(x => x.Codigo == Item.Codigo));
        }
        public void RemoverEstoqueItens(EstoqueItem Item)
        {
            EstoqueItens.Remove(EstoqueItens.Find(x => x.Codigo == Item.Codigo));
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
        public void RemoverRelacaoForneceIngredientes(RelacaoForneceIngrediente Item)
        {
            RelacaoForneceIngredientes.Remove(RelacaoForneceIngredientes.Find(x => x.Codigo == Item.Codigo));
        }
        public void RemoverRelacaoProdutoUtilizaIngredientes(RelacaoProdutoUtilizaIngrediente Item)
        {
            RelacaoProdutoUtilizaIngredientes.Remove(RelacaoProdutoUtilizaIngredientes.Find(x => x.Codigo == Item.Codigo));
        }
        public void RemoverRelacaoVendaProduto(RelacaoVendaProduto Item)
        {
            RelacaoVendaProdutos.Remove(RelacaoVendaProdutos.Find(x => x.Codigo == Item.Codigo));
        }
        public void RemoverRelacaoForneceProdutos(RelacaoForneceProduto Item)
        {
            RelacaoForneceProdutos.Remove(RelacaoForneceProdutos.Find(x => x.Codigo == Item.Codigo));
        }

        public void AtualizarFuncionario(Funcionario Item)
        {
            Funcionarios.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarFuncionario(Item);
        }
        public void AtualizarIngrediente(Ingrediente Item)
        {
            Ingredientes.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarIngrediente(Item);
        }
        public void AtualizarEstoqueItens(EstoqueItem Item)
        {
            EstoqueItens.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarEstoque(Item);
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
        public void AtualizarRelacaoForneceIngredientes(RelacaoForneceIngrediente Item)
        {
            RelacaoForneceIngredientes.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarRelacaoFornece(Item);
        }
        public void AtualizarRelacaoProdutoUtilizaIngredientes(RelacaoProdutoUtilizaIngrediente Item)
        {
            RelacaoProdutoUtilizaIngredientes.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarRelacaoProdutoUtilizaIngrediente(Item);
        }
        public void AtualizarRelacaoVendaProduto(RelacaoVendaProduto Item)
        {
            RelacaoVendaProdutos.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarRelacaoVendaProduto(Item);
        }
        public void AtualizarRelacaoForneceProdutos(RelacaoForneceProduto Item)
        {
            RelacaoForneceProdutos.FirstOrDefault(x => x.Codigo == Item.Codigo).AtualizarRelacaoForneceProduto(Item);
        }
        public void SalvarFuncionarios(List<Funcionario> Item)
        {
            SalvarEEscrever.SaveBinFile<List<Funcionario>>("funcionarios", Item);
        }
        public void SalvarIngredientes(List<Ingrediente> Item)
        {
            SalvarEEscrever.SaveBinFile<List<Ingrediente>>("Ingredientes", Item);
        }
        public void SalvarEstoqueItens(List<EstoqueItem> Item)
        {
            SalvarEEscrever.SaveBinFile<List<EstoqueItem>>("EstoqueItem", Item);
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
        public void SalvarRelacaoForneceIngredientes(List<RelacaoForneceIngrediente> Item)
        {
            SalvarEEscrever.SaveBinFile<List<RelacaoForneceIngrediente>>("RelacaoForneceIngredientes", Item);
        }
        public void SalvarRelacaoForneceProdutos(List<RelacaoForneceProduto> Item)
        {
            SalvarEEscrever.SaveBinFile<List<RelacaoForneceProduto>>("RelacaoForneceIngredientes", Item);
        }
        public void SalvarRelacaoProdutoUtilizaIngredientes(List<RelacaoProdutoUtilizaIngrediente> Item)
        {
            SalvarEEscrever.SaveBinFile<List<RelacaoProdutoUtilizaIngrediente>>("RelacaoProdutoUtilizaIngredientes", Item);
        }
        public void SalvarRelacaoVendaProduto(List<RelacaoVendaProduto> Item)
        {
            SalvarEEscrever.SaveBinFile<List<RelacaoVendaProduto>>("RelacaoVendaProdutos", Item);
        }
        public List<Funcionario> CarregarFuncionarios()
        {
            return SalvarEEscrever.ReadBinFile<List<Funcionario>>("Funcionarios");
        }
        public List<Ingrediente> CarregarIngredientes()
        {
            return SalvarEEscrever.ReadBinFile<List<Ingrediente>>("Ingredientes");
        }
        public List<EstoqueItem> CarregarEstoqueItens()
        {
            return SalvarEEscrever.ReadBinFile<List<EstoqueItem>>("EstoqueItem");
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
        public List<RelacaoForneceIngrediente> CarregarRelacaoForneceIngrediente()
        {
            return SalvarEEscrever.ReadBinFile<List<RelacaoForneceIngrediente>>("RelacaoForneceIngredientes");
        }
        public List<RelacaoProdutoUtilizaIngrediente> CarregarRelacaoProdutoUtilizaIngredientes()
        {
            return SalvarEEscrever.ReadBinFile<List<RelacaoProdutoUtilizaIngrediente>>("RelacaoProdutoUtilizaIngredientes");
        }
        public List<RelacaoVendaProduto> CarregarRelacaoVendaProdutos()
        {
            return SalvarEEscrever.ReadBinFile<List<RelacaoVendaProduto>>("RelacaoVendaProdutos");
        }
        public List<RelacaoForneceProduto> CarregarRelacaoForneceProdutos()
        {
            return SalvarEEscrever.ReadBinFile<List<RelacaoForneceProduto>>("RelacaoForneceProdutos");
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

        public List<Venda> CarregarVendasBanco(string query)
        {
            var vendas = Banco.Select(query);

            var listVendas = new List<Venda>();

            for (int i = 0; i < vendas.Rows.Count; i++)
            {
                listVendas.Add(new Venda(Convert.ToInt32(vendas.Rows[i].ItemArray[0]),
                                                        Convert.ToDateTime(vendas.Rows[i].ItemArray[1]),
                                                        Convert.ToInt32(vendas.Rows[i].ItemArray[2]),
                                                        Convert.ToInt32(vendas.Rows[i].ItemArray[3])));
            }

            return listVendas;
        }
        public List<RelacaoVendaProduto> CarregarRelacaoVendaProdutosBanco(string query)
        {
            var relacao = Banco.Select(query);

            var listRelacoes = new List<RelacaoVendaProduto>();

            for (int i = 0; i < relacao.Rows.Count; i++)
            {
                listRelacoes.Add(new RelacaoVendaProduto(Convert.ToInt32(relacao.Rows[i].ItemArray[0]),
                                                    Convert.ToInt32(relacao.Rows[i].ItemArray[1]),
                                                    Convert.ToInt32(relacao.Rows[i].ItemArray[2]),
                                                    Convert.ToInt32(relacao.Rows[i].ItemArray[3])));
            }

            return listRelacoes;
        }

        public List<Produto> CarregarProdutoBanco(string query)
        {
            var produtos = Banco.Select(query);

            var listProduto = new List<Produto>();

            for (int i = 0; i < produtos.Rows.Count; i++)
            {
                listProduto.Add(new Produto(Convert.ToInt32(produtos.Rows[i].ItemArray[0]),
                                                            produtos.Rows[i].ItemArray[1].ToString(),
                                                            produtos.Rows[i].ItemArray[2].ToString(),
                                                            (Convert.ToInt32(produtos.Rows[i].ItemArray[3]) == 1 ? Produto_tipo.revendido : Produto_tipo.fabricado),
                                                            Convert.ToDouble(produtos.Rows[i].ItemArray[4]),
                                                            Convert.ToInt32(produtos.Rows[i].ItemArray[5]),
                                                            Convert.ToBoolean(produtos.Rows[i].ItemArray[6])));
            }

            return listProduto;
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

        public List<EstoqueItem> CarregarEstoqueItensBanco(string query)
        {
            var itens = Banco.Select(query);

            var listItens = new List<EstoqueItem>();

            for (int i = 0; i < itens.Rows.Count; i++)
            {
                listItens.Add(new EstoqueItem(Convert.ToInt32(itens.Rows[i].ItemArray[0]),
                                              Convert.ToInt32(itens.Rows[i].ItemArray[1]),
                                              Convert.ToDateTime(itens.Rows[i].ItemArray[2]),
                                              Convert.ToInt32(itens.Rows[i].ItemArray[3])));
            }

            return listItens;
        }

        public List<Ingrediente> CarregarIngredientesBanco(string query)
        {
            var ingredientes = Banco.Select(query);

            var listIngredientes = new List<Ingrediente>();

            for (int i = 0; i < ingredientes.Rows.Count; i++)
            {
                var socorro = Convert.ToDateTime(ingredientes.Rows[i].ItemArray[2].ToString().Split(' ')[0]);

                listIngredientes.Add(new Ingrediente(Convert.ToInt32(ingredientes.Rows[i].ItemArray[0]),
                                                     ingredientes.Rows[i].ItemArray[1].ToString(),
                                                     Convert.ToDateTime(ingredientes.Rows[i].ItemArray[2].ToString().Split(' ')[0]),
                                                     Convert.ToDouble(ingredientes.Rows[i].ItemArray[3]),
                                                     Convert.ToInt32(ingredientes.Rows[i].ItemArray[4]),
                                                     Convert.ToBoolean(ingredientes.Rows[i].ItemArray[5])));
            }

            return listIngredientes;
        }
        public List<RelacaoForneceIngrediente> CarregarRelacaoForneceIngredienteBanco(string query)
        {
            var relacaoForneceIngrediente = Banco.Select(query);

            var listrelacoes = new List<RelacaoForneceIngrediente>();

            for (int i = 0; i < relacaoForneceIngrediente.Rows.Count; i++)
            {
                listrelacoes.Add(new RelacaoForneceIngrediente(Convert.ToInt32(relacaoForneceIngrediente.Rows[i].ItemArray[0]),
                                                               Convert.ToInt32(relacaoForneceIngrediente.Rows[i].ItemArray[1]),
                                                               Convert.ToInt32(relacaoForneceIngrediente.Rows[i].ItemArray[2])));
            }

            return listrelacoes;
        }
        public List<RelacaoForneceProduto> CarregarRelacaoForneceProdutosBanco(string query)
        {
            var relacaoForneceProduto = Banco.Select(query);

            var listRelacoes = new List<RelacaoForneceProduto>();

            for (int i = 0; i < relacaoForneceProduto.Rows.Count; i++)
            {
                listRelacoes.Add(new RelacaoForneceProduto(Convert.ToInt32(relacaoForneceProduto.Rows[i].ItemArray[0]),
                                                            Convert.ToInt32(relacaoForneceProduto.Rows[i].ItemArray[1]),
                                                            Convert.ToInt32(relacaoForneceProduto.Rows[i].ItemArray[2]),
                                                            Convert.ToDouble(relacaoForneceProduto.Rows[i].ItemArray[3])));
            }

            return listRelacoes;
        }
        public List<RelacaoProdutoUtilizaIngrediente> CarregarRelacaoProdutoUtilizaIngredientesBanco(string query)
        {
            var utiliza = Banco.Select(query);

            var listRelacoes = new List<RelacaoProdutoUtilizaIngrediente>();

            for (int i = 0; i < utiliza.Rows.Count; i++)
            {
                listRelacoes.Add(new RelacaoProdutoUtilizaIngrediente(Convert.ToInt32(utiliza.Rows[i].ItemArray[0]),
                                                                      Convert.ToInt32(utiliza.Rows[i].ItemArray[1]),
                                                                      Convert.ToInt32(utiliza.Rows[i].ItemArray[2]),
                                                                      Convert.ToInt32(utiliza.Rows[i].ItemArray[3])));
            }

            return listRelacoes;
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

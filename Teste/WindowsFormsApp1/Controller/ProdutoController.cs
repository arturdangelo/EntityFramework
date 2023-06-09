

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public class ProdutoController
    {
        [Key]
        public int Codigo { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double Valor { get; internal set; }

        public static void CadastrarProduto(ProdutoController p)
        {
            using (var contexto = new LojaContextModel())
            {
                contexto.Produtos.Add(p);
                contexto.SaveChanges();
                MessageBox.Show("Produto Cadastrado");
            }
        }

        public static void AtualizarProduto(int codigo, string nome, string categoria, double valor)
        {
            using (var repo = new LojaContextModel())
            {
                IList<ProdutoController> produtos = repo.Produtos.ToList();
                ProdutoController produto = produtos.FirstOrDefault(p => p.Codigo == codigo);

                produto.Nome = nome;
                produto.Categoria = categoria;
                produto.Valor = valor;
                repo.SaveChanges();
                MessageBox.Show("Produto atualizado com sucesso!");
            }
        }
        public static void ExibirTodosProdutos(int codigo)
        {
            using (var repo = new LojaContextModel())
            {
                IList<ProdutoController> produtos = repo.Produtos.ToList();

                if (codigo == 0)
                {
                    if (produtos.Count == 0)
                    {
                        MessageBox.Show("Não há nenhum produto cadastrado!");
                    }
                    else
                    {
                        foreach (var produto in produtos)
                        {
                            MessageBox.Show("Código: "+produto.Codigo+"\nNome: "
                                +produto.Nome+"\nCategoria: "+produto.Categoria+
                                "\n Valor: R$ "+produto.Valor);
                        }
                    }
                }
                else
                {
                    var produtosEncontrados = produtos.Where(p => p.Codigo == codigo).ToList();

                    if (produtosEncontrados.Count > 0)
                    {
                        foreach (var produto in produtosEncontrados)
                        {
                            MessageBox.Show("Código: " + produto.Codigo + "\nNome: "
                                + produto.Nome + "\nCategoria: " + produto.Categoria +
                                "\n Valor: R$ " + produto.Valor);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto encontrado com esse código!");
                    }
                }
            }
        }

        public static void DeletarProdutos(int codigo)
        {
            using (var repo = new LojaContextModel())
            {
                IList<ProdutoController> produtos = repo.Produtos.ToList();

                if (codigo == 0)
                {
                    foreach (var item in produtos)
                    {
                        repo.Produtos.Remove(item);
                    }
                    repo.SaveChanges();
                    MessageBox.Show("Todos os produtos foram removidos!");
                }
                else
                {
                    var produtosEncontrados = produtos.Where(p => p.Codigo == codigo).ToList();

                    if (produtosEncontrados.Count > 0)
                    {
                        foreach (var produto in produtosEncontrados)
                        {
                            MessageBox.Show(produto.Nome + " foi removido com sucesso!");
                            repo.Produtos.Remove(produto);
                        }
                        repo.SaveChanges();
                    }
                }
            }
        }
    }
}

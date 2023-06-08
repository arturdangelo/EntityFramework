

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

        public static void ExibirTodosProdutos(int codigo)
        {
            using (var repo = new LojaContextModel())
            {
                IList<ProdutoController> produtos = repo.Produtos.ToList();

                if (codigo == 0)
                {
                    foreach (var produto in produtos)
                    {
                        MessageBox.Show(produto.Nome);
                    }
                }
                else
                {
                    var produtosEncontrados = produtos.Where(p => p.Codigo == codigo).ToList();

                    if (produtosEncontrados.Count > 0)
                    {
                        foreach (var produto in produtosEncontrados)
                        {
                            MessageBox.Show(produto.Nome);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto encontrado!");
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

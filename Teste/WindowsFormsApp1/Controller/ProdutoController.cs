

using System.ComponentModel.DataAnnotations;
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
        public decimal Valor { get; internal set; }

        public static void CadastrarProduto(ProdutoController p)
        {
            using (var contexto = new LojaContextModel())
            {
                contexto.Produtos.Add(p);
                contexto.SaveChanges();
                MessageBox.Show("Produto Cadastrado");
            }
        }

    }
}

using System;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Não estou fazendo muitos tratamentos e verificações, apenas testando o crud com o entity framework
        public Form1()
        {
            InitializeComponent();
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoController p = new ProdutoController();

                p.Codigo = Convert.ToInt32(Txt_Codigo.Text.ToString());
                p.Nome = Txt_Nome.Text;
                p.Categoria = Txt_Categoria.Text;
                p.Valor = Convert.ToDouble(Txt_Valor.Text.ToString());

                ProdutoController.CadastrarProduto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Para exibir todos os produtos, basta informar o código do produto.
        //Se não informar nada, passará como parâmetro "0" e todos os produtos serão exibidos.
        private void Btn_Exibir_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = 0;
                if (!string.IsNullOrWhiteSpace(Txt_Codigo.Text))
                {
                    codigo = Convert.ToInt32(Txt_Codigo.Text.ToString());
                }

                ProdutoController.ExibirTodosProdutos(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Para deletar o produto, basta informar o código do produto.
        //Se não informar nada, passará como parâmetro "0" e todos os produtos serão removidos
        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = 0;

                if (!string.IsNullOrWhiteSpace(Txt_Codigo.Text))
                {
                    codigo = Convert.ToInt32(Txt_Codigo.Text.ToString());
                }

                ProdutoController.DeletarProdutos(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(Txt_Codigo.Text.ToString());
                string nome = Txt_Nome.Text;
                string categoria = Txt_Categoria.Text;
                double valor = Convert.ToDouble(Txt_Valor.Text.ToString());

                ProdutoController.AtualizarProduto(codigo, nome, categoria, valor);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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
                p.Valor = Convert.ToDecimal(Txt_Valor.Text.ToString());

                ProdutoController.CadastrarProduto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoProduto
{
    public partial class FormExclusaoProduto : Form
    {
        public FormExclusaoProduto()
        {
            InitializeComponent();

            Produto.exibirProdutos(listViewProdutos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var codigo = txtBxCodigo.Text;
            var produto = Produto.buscar(codigo);

            if (produto != null)
            {
                Produto.excluir(txtBxCodigo.Text);

                MessageBox.Show("Produto excluído com sucesso!", "Aviso", MessageBoxButtons.OK);

                Produto.exibirProdutos(listViewProdutos);
            }
            else
            {
                MessageBox.Show("Não foi localizado produto para o código: " + codigo, "Produto não encontrado", MessageBoxButtons.OK);
            }

            

        }

        private void listViewProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void controleFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo com controle Financeiro gerado com sucesso !", "Mensagem", MessageBoxButtons.OK);

            string ValorPrecoVenda = "Seu estoque está avaliado em:";
            string valorPrecoCompra = "Seu valor estipulado para vendas com base no estoque é:";

            StreamWriter x = new StreamWriter("C:\\Users\\luara\\Downloads\\GerenciamentoProduto-4-Periodo-P.I--master\\GerenciamentoProduto-4-Periodo-P.I--master\\GerenciamentoProduto\\bin\\Debug\\financeiro.txt");
            x.WriteLine(ValorPrecoVenda + "Reais");
            x.WriteLine(valorPrecoCompra + "Reais");

            x.Close();
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Arquivo com estoque gerado com sucesso !", "Mensagem", MessageBoxButtons.OK);

            string teste = "puxa valor";
            StreamWriter sw = new StreamWriter("C:\\Users\\luara\\Downloads\\GerenciamentoProduto-4-Periodo-P.I--master\\GerenciamentoProduto-4-Periodo-P.I--master\\GerenciamentoProduto\\bin\\Debug\\estoque.txt");
            sw.WriteLine("Numero total de Produtos em estoque é " + teste);
            sw.Close();
        }
    }
}

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
    public partial class FormBemVindo : Form
    {
        public FormBemVindo()
        {
            InitializeComponent();

            Produto.exibirProdutos(listViewProdutos);
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var telaCadastro = new FormCadastroProduto("");

            telaCadastro.ShowDialog();
        }

        private void excluirProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var telaExclusao= new FormExclusaoProduto();

            telaExclusao.ShowDialog();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var telaEditar= new FormEditarProduto();

            telaEditar.ShowDialog();
        }

        private void FormBemVindo_Load(object sender, EventArgs e)
        {

        }

        private void listViewProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\luara\\Downloads\\GerenciamentoProduto-4-Periodo-P.I--master\\GerenciamentoProduto-4-Periodo-P.I--master\\GerenciamentoProduto\\bin\\Debug\\estoque.txt");

            var produtos = Produto.buscarProdutos();
            int quantidadeProd = produtos.Count;
            var unidadesProdutos = new List<int>();

            produtos.ForEach(p => {
                unidadesProdutos.Add(p.Quantidade);
            });

            var unidades = unidadesProdutos.Sum();

            sw.WriteLine("Estoque contém um total de: " + quantidadeProd + " produtos");
            sw.WriteLine("Estoque contém um total de: " + unidades + " unidades");

            produtos.ForEach(p => {
                sw.WriteLine("Produto: " + p.Nome + " contém " + p.Quantidade + " unidades");
            });

            sw.Close();

            MessageBox.Show("Arquivo de controle de estoque foi gerado com sucesso !", "Atenção", MessageBoxButtons.OK);
        }

        private void controleFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var produtos = Produto.buscarProdutos();
            var precosCompra = new List<double>();
            var precosVenda = new List<double>();

            produtos.ForEach(p => {
                precosCompra.Add(p.PrecoCompra * p.Quantidade);
                precosVenda.Add(p.PrecoVenda * p.Quantidade);
            });

            double custoEstoque = precosCompra.Sum();
            double receitaEstoque = precosVenda.Sum();
            var lucro = receitaEstoque - custoEstoque;

            StreamWriter x = new StreamWriter("C:\\Users\\luara\\Downloads\\GerenciamentoProduto-4-Periodo-P.I--master\\GerenciamentoProduto-4-Periodo-P.I--master\\GerenciamentoProduto\\bin\\Debug\\financeiro.txt");
            x.WriteLine("O custo do seu estoque foi: R$ " + custoEstoque);
            x.WriteLine("A receita do seu estoque será: R$ " + receitaEstoque);
            x.WriteLine("O lucro com seu estoque será: R$ " + lucro);
            x.Close();

            MessageBox.Show("Arquivo de controle Financeiro foi gerado com sucesso !", "Atenção", MessageBoxButtons.OK);
        }

        private void atualizarTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto.exibirProdutos(listViewProdutos);
        }
    }
}

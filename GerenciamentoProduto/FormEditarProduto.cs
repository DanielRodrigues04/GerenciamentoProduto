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
    public partial class FormEditarProduto : Form
    {
        public FormEditarProduto()
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
                var telaCadastro = new FormCadastroProduto(codigo);

                telaCadastro.ShowDialog();

                Produto.exibirProdutos(listViewProdutos);
            } 
            else
            {
                MessageBox.Show("Não foi localizado produto para o código: " + codigo, "Produto não encontrado", MessageBoxButtons.OK);
            }
        }

    

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void controleFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo com controle Financeiro gerado com sucesso !", "Mensagem", MessageBoxButtons.OK);

            //estipula o valor de venda total dos produtos em estoque 
            //total gasto com o valor de compra dos produtos 


            // cria arquivo preciso saber o caminho
            //criar pasta temp
            StreamWriter x = new StreamWriter("c:\\temp\\financeiro.txt");

            x.Close();
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo com estoque gerado com sucesso !", "Mensagem", MessageBoxButtons.OK);

            //me diz a quantidade de produtos somados em estoque

            //cria arquivo preciso saber o caminho 
            //criar pasta temp
            StreamWriter sw = new StreamWriter("c:\\temp\\estoque.txt");

            sw.Close();
        }
    }
}

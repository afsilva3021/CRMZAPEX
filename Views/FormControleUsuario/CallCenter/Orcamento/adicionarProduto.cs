using ProjetoMars.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMars.FormControleUsuario.CallCenter.Orcamento
{

    public partial class adicionarProduto : Form
    {

        public adicionarProduto()
        {
            InitializeComponent();
        }

        private static int contatdor = 0;
        public int id { get; } = ++contatdor;
        

        public adicionarProduto(string codigo, string referencia, string fornecedor, string marca, string valor, string custo, string desconto, string descicao, string saldo, string image)
        {
            InitializeComponent();

            txtCod.Text = codigo;
            txtReferencia.Text = referencia;
            txtCusto.Text = custo;
            txtFornecedor.Text = fornecedor;
            txtMarca.Text = marca;
            txtVlVend.Text = valor;
            txtDesconto.Text = desconto;
            txtDescricao.Text = descicao;
            txtSaldo.Text = saldo;
            pbImg.ImageLocation = image;
            txtCodAtendi.Text = Program.codAtendi;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicinaitens();
            Close();
        }
        
        private void adicinaitens()
        {
           

            Program.conn.UPDATE("START TRANSACTION");

            string Adicionaitem = $"UPDATE XT0020 SET T2_CODIGO = '{txtCod.Text}',T2_REFERENCE = '{txtReferencia.Text}',T2_VALORCUSTO = '{txtCusto.Text}',T2_VALORVENDA = '{txtVlVend.Text}',T2_FORNECEDOR = '{txtFornecedor.Text}',T2_MARCA = '{txtMarca.Text}',T2_DESCIRCAO = '{txtDescricao.Text}', T2_QTD = '{txtQtadVen.Text}', T2_DESCONTO = '{txtDesconto.Text}',T2_XT1NUM = '{txtCodAtendi.Text}' WHERE T2_ID = '{contatdor}'";

            if (!Program.conn.UPDATE(Adicionaitem))
            {
                MessageBox.Show("Erro ao adicionar o item");
            }
            else
            {
                Program.conn.INSERT("COMMIT");
                MessageBox.Show("Item Adicionado");
            }
             

        }
    }
}
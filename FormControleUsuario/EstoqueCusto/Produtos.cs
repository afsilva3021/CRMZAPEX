﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMars.FormControleUsuario.Estoque_e_custo
{
    public partial class Produtos : UserControl
    {
        public Produtos()
        {
            InitializeComponent();
        }

        void consulta()
        {
            string cmdSql = "SELECT D0_COD AS CODIGO, D0_REFENC AS REFERENCIA, D0_FORNEC AS FORNECEDOR, D0_MARCA AS MARCA, D0_CUSTO AS CUSTO, D0_VEND AS VENDA, D0_DESCONTO AS DESCONTO, D0_DESC AS DESCRICAO FROM PD0010";
            var dados = Program.conn.SELECT(cmdSql);

                dataGridView1.DataSource = dados;

                dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);

                dataGridView1.BackgroundColor = Color.Silver;
            
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void Produtos_load(object sender, EventArgs e)
        {
            consulta();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            FormControleUsuario.Estoque_e_custo.CadastroProduto cadastroProdutos = new CadastroProduto();
            cadastroProdutos.ShowDialog();
            consulta();
        }
    }
}

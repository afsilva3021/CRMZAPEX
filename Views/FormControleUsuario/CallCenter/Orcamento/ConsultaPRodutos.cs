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
    public partial class ConsultaPRodutos : Form
    {
        public ConsultaPRodutos()
        {
            InitializeComponent();
        }


        void consulta()
        {
            string cmdSql = $"SELECT D0_COD AS Codigo, D0_REFENC AS Cod_Referencia, D0_FORNEC AS Fornecedor, D0_MARCA AS Marca, D0_CUSTO AS Custo, D0_VEND AS Venda, D0_DESCONTO AS Desconto, D0_DESC AS Descricao, D0_SALDO as Saldo, D0_IMG AS IMAGEM FROM PD0010 WHERE D0_COD like '%{txtBusca.Text}%' OR D0_REFENC like '%{txtBusca.Text}%' OR D0_MARCA like '%{txtBusca.Text}%'";
            var dados = Program.conn.SELECT(cmdSql);

            dataGridView1.DataSource = dados;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[0].HeaderText = "Cod_Referencia";
            dataGridView1.Columns[0].HeaderText = "Fornecedor";
            dataGridView1.Columns[0].HeaderText = "Marca";
            dataGridView1.Columns[0].HeaderText = "Custo";
            dataGridView1.Columns[0].HeaderText = "Venda";
            dataGridView1.Columns[0].HeaderText = "Desconto";
            dataGridView1.Columns[0].HeaderText = "Descricao";
            dataGridView1.Columns[0].HeaderText = "Saldo";
            dataGridView1.Columns[0].HeaderText = "Add Produto";

            dataGridView1.Columns[10].Visible = false;

        }
            private void btnConsulta_Click(object sender, EventArgs e)
        {

            consulta();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            FormControleUsuario.CallCenter.Orcamento.adicionarProduto addProduto = new FormControleUsuario.CallCenter.Orcamento.adicionarProduto(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(), dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(), dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[9].Value.ToString());
            addProduto.ShowDialog();

            

        }

    }
}

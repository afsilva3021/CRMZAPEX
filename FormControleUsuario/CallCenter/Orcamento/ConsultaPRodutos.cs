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
            string cmdSql = $"SELECT D0_COD AS CODIGO, D0_REFENC AS REFERENCIA, D0_FORNEC AS FORNECEDOR, D0_MARCA AS MARCA, D0_CUSTO AS CUSTO, D0_VEND AS VENDA, D0_DESCONTO AS DESCONTO, D0_DESC AS DESCRICAO FROM PD0010 WHERE D0_COD like '%{txtBusca.Text}%' OR D0_REFENC like '%{txtBusca.Text}%'";
            var dados = Program.conn.SELECT(cmdSql);

            if (dados.Rows.Count > 0)
            {

                dataGridView1.DataSource = dados;
                dataGridView1.BackgroundColor = Color.Silver;
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            }
        }
            private void btnConsulta_Click(object sender, EventArgs e)
        {

            consulta();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

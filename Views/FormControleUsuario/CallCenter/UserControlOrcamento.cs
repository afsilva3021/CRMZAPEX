using Google.Protobuf;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;
using ServiceStack;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoMars.FormControleUsuario.CallCenter
{
    public partial class UserControlOrcamento : UserControl
    {
        public UserControlOrcamento()
        {
            InitializeComponent();

          
        }


        private void btnBuscarAtend_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void UserControlOrcamento_Load(object sender, EventArgs e)
        {
            atuailizaGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormControleUsuario.CallCenter.Orcamento.atendimento atendimento = new FormControleUsuario.CallCenter.Orcamento.atendimento();
            atendimento.ShowDialog();
            atuailizaGrid();
        }

        private void atuailizaGrid()
        {

            string cmdSql = "SELECT T0_COD AS NUMERO, T0_CLIENT AS CLIENTE, T0_FANTASIA AS Nome_Fantasia, T0_SITUA AS Situação, T0_ENTREGA AS Entrega, T0_VENDEDOR AS Vendedor, T0_CONDPAG AS Cond_Pagamento, T0_TIPOFRETE AS Tipo_Frete, T0_VALORFRETE as Valor_Frete, T0_NUMPEDCLIENT as N_PEdido_Client  FROM XT0010";
            var dados = Program.conn.SELECT(cmdSql);

                dataGridView1.DataSource = dados;

                dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);

                dataGridView1.BackgroundColor = Color.Silver;
            
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            FormControleUsuario.CallCenter.Orcamento.atendimento atendimento = new FormControleUsuario.CallCenter.Orcamento.atendimento();
            atendimento.ShowDialog();
            atuailizaGrid();
        }
    }
}

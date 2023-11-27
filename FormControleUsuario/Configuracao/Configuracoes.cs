using MySqlX.XDevAPI;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoMars.FormControleUsuario.Configurações
{
    public partial class Configuracoes : UserControl
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        private void dataGridView1_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            busca();
        }

        void consulta()
        {
            string cmdSql = "SELECT USR_USER AS CODIGO, USR_NOME AS NOME, USR_EMAIL AS EMAIL, USR_DEPARTAMENTO AS DEPARTAMENTO, USR_GRUPO AS GRUPO, USR_BLQ AS BLOQUEADO FROM SYS_USR";
            var dados = Program.conn.SELECT(cmdSql);
            
            if (dados.Rows.Count > 0)
            {
                dataGridView1.DataSource = dados;
                dataGridView1.BackgroundColor = Color.Silver;
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            }
        }
        void busca()
        {
            var user = $"SELECT USR_USER AS CODIGO, USR_NOME AS NOME, USR_EMAIL AS EMAIL, USR_DEPARTAMENTO AS DEPARTAMENTO, USR_GRUPO AS GRUPO, USR_BLQ AS BLOQUEADO FROM SYS_USR WHERE USR_COD LIKE '%{txbBusca.Text}%' OR USR_NOME LIKE '%{txbBusca.Text}%' OR USR_EMAIL LIKE '%{txbBusca.Text}%'";
           Program.conn.SELECT(user);
        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            FormControleUsuario.Configuracao.CadastrodeUsuario cadastro = new Configuracao.CadastrodeUsuario();
            cadastro.ShowDialog();
            consulta();
        }
    }
}

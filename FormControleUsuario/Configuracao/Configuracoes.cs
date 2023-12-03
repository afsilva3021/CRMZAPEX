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
using static ProjetoMars.Class.Global;
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
            consulta();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            busca();
        }

        void consulta()
        {
            string cmdSql = "SELECT USR_USER AS CODIGO, USR_NOME AS NOME, USR_EMAIL AS EMAIL, USR_PWD AS SENHA, USR_BLQ AS BLOQUEADO, USR_DEPARTAMENTO AS DEPARTAMENTO, USR_CARGO AS CARGO, USR_GRUPO AS GRUPO FROM SYS_USR";
            var dados = Program.conn.SELECT(cmdSql);
            
            dataGridView1.DataSource = dados;

            dataGridView1.BackgroundColor = Color.Silver;

            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[0].HeaderText = "Nome";
            dataGridView1.Columns[0].HeaderText = "Email";
            dataGridView1.Columns[0].HeaderText = "Senha";
            dataGridView1.Columns[0].HeaderText = "Bloqueado";
            dataGridView1.Columns[0].HeaderText = "Departamento";
            dataGridView1.Columns[0].HeaderText = "Cargo";
            dataGridView1.Columns[0].HeaderText = "Grupo";


        }
        void busca()
        {
            string user = $"SELECT USR_USER AS CODIGO, USR_NOME AS NOME, USR_EMAIL AS EMAIL, USR_PWD AS SENHA, USR_BLQ AS BLOQUEADO, USR_DEPARTAMENTO AS DEPARTAMENTO, USR_CARGO AS CARGO, USR_GRUPO AS GRUPO FROM SYS_USR WHERE USR_COD LIKE '%{txbBusca.Text}%' OR USR_NOME LIKE '%{txbBusca.Text}%' OR USR_EMAIL LIKE '%{txbBusca.Text}%'";
           
            Program.conn.SELECT(user);

            var dados = Program.conn.SELECT(user);

            dataGridView1.DataSource = dados;

            dataGridView1.BackgroundColor = Color.Silver;

            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;      
            
        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            FormControleUsuario.Configuracao.CadastrodeUsuario cadastro = new Configuracao.CadastrodeUsuario();
            cadastro.ShowDialog();
            consulta();
        }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            busca();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormControleUsuario.Configuracao.CadastrodeUsuario cadastro = new Configuracao.CadastrodeUsuario(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(), dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString());
            cadastro.ShowDialog();
            consulta();
        }
    }
}

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
    public partial class atendimento : Form
    {
        public atendimento()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cadastroHeader();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Os dados nao foram Salvos Deseja Cancelar", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                Program.conn.INSERT("ROLLBACK");
                Close();
            }
        }

        void cadastroHeader()
        {
            Program.conn.INSERT("START TRANSACTION");

            string itens = $"CALL HEADERATENDI('{txtCod.Text}','{txtCodClient.Text}','{txtNomeFantasia.Text}','{txtCNPJ.Text}','{cbParcial.Text}');";

            if (!Program.conn.INSERT(itens))
            {
                MessageBox.Show("Erro na Inclusãode dados\nNenhum dado novo incluido");
                Program.conn.INSERT("ROLLBACK");

            }
            else
            {
                Program.conn.INSERT("COMMIT;");

                MessageBox.Show("Dados Salvos com Sucesso");

                Close();
            }
        }

        private int codAtendimento()
        {
            
            Random random = new Random();
            return random.Next(1, 1000);
        }


        

        private void btnConsultaItens_Click(object sender, EventArgs e)
        {
            Program.conn.INSERT($"INSERT INTO XT0020 (T2_XT1NUM) VALUES ('{txtCod.Text}')");
            FormControleUsuario.CallCenter.Orcamento.ConsultaPRodutos Consulta = new FormControleUsuario.CallCenter.Orcamento.ConsultaPRodutos();
            Consulta.ShowDialog();
            mostraProd();
            

            
        }


        private void infClient()
        {

            string codigoClient = txtCodClient.Text;

            string cmdSql = $"SELECT * FROM CL0010 WHERE L0_COD LIKE '%{codigoClient}%' OR L0_FANT LIKE '%{codigoClient}%'";
            var dados = Program.conn.SELECT(cmdSql);

            if (dados != null)
            {
                DataRow codClient = dados.Rows[0];

                Program.codCLient = codClient["L0_COD"].ToString();

                Program.fantaisa = codClient["L0_FANT"].ToString();

                Program.cnpj = codClient["L0_CNPJ"].ToString();

                Program.vendedor = codClient["L0_VEND"].ToString();

                txtCodClient.Text = Program.codCLient;
                txtNomeFantasia.Text = Program.fantaisa;
                txtCNPJ.Text = Program.cnpj;
                txtVendedor.Text = Program.vendedor;
            }
            
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            infClient();
        }

        private void atendimento_Load(object sender, EventArgs e)
        {
            int resultado = codAtendimento();

            txtCod.Text = resultado.ToString();

            Program.codAtendi = resultado.ToString();

            Program.conn.INSERT($"INSERT INTO XT0020 (T2_XT1NUM) VALUES ('{txtCod.Text = Program.codAtendi}')");
            mostraProd();
        }

        private void mostraProd()
        {
            var dados = Program.conn.SELECT($"SELECT * FROM XT0020 WHERE = '{txtCod.Text}'");

            dataGridView1.DataSource = dados;

            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);

            dataGridView1.BackgroundColor = Color.Silver;

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }
    }
}

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
            CadastroItens();
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

            string cmdSql = $"CALL HEADERATENDI('{txtCod.Text}','{txtCodClient.Text}','{txtNomeFantasia.Text}','{txtCNPJ.Text}','{cbParcial.Text}','{cbPreEntrega.Text}','{txtVendedor.Text}','{txtCondicao.Text}','{txtValorFrete.Text}','{cbTipoFrete.Text}','{txtNumClient.Text}','{cBStatu.Text}','{txtDescricao.Text}');";

            if (!Program.conn.INSERT(cmdSql))
            {
                MessageBox.Show("Erro na Inclusãode dados\nNenhum dado novo incluido");
                Program.conn.INSERT("ROLLBACK");

            }
        }

        void CadastroItens()
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

        private int codCliente()
        {

            Random random = new Random();
            return random.Next(1, 1000);
        }

        private void codCliente(object sender, EventArgs e)
        {
            int resultado = codCliente();

            txtCod.Text = resultado.ToString();
        }

        private void btnConsultaItens_Click(object sender, EventArgs e)
        {
            FormControleUsuario.CallCenter.Orcamento.ConsultaPRodutos Consulta = new FormControleUsuario.CallCenter.Orcamento.ConsultaPRodutos();
            Consulta.ShowDialog();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProjetoMars.Class;

namespace ProjetoMars.FormControleUsuario.Estoque_e_custo
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        void Cadastra()
        {
            Program.conn.INSERT("START TRANSACTION");

            var cmdSql = $"INSERT INTO PD0010 (D0_COD, D0_REFENC, D0_FORNEC, D0_MARCA, D0_SALDO, D0_CUSTO, D0_VEND, D0_ESTMINIMO, D0_ESTMAXIMO, D0_DESC, D0_DESCONTO, D0_IMG) VALUES ('{txtCodigo.Text}','{txtReferencia.Text}','{txtFornecedor.Text}','{txtMarca.Text}','{txtSaldo.Text}','{txtCusto.Text}','{txtProco.Text}','{txtEstMinimo.Text}','{txtEstMaximo.Text}','{txtDescricao.Text}','{txtDesc.Text}');";

            if (!Program.conn.INSERT(cmdSql))
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

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Os dados nao foram Salvos Deseja Cancelar", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                Program.conn.INSERT("ROLLBACK");
                Close();
            }
        }

        
    }
}

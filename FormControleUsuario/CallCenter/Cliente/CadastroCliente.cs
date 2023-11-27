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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjetoMars.FormControleUsuario.CallCenter.Cliente
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Program.conn.INSERT("START TRANSACTION;");

            var cmdSql = $"CALL CadCliente('{txbCod.Text}','{txbCNPJ.Text}','{cbPessoa.Text}','{cbUf.Text}','{cBFrete.Text}'," +
                $"'{txbEmail.Text}','{txbNome.Text}','{txbNFantasia.Text}','{txbInscre.Text}','{txbEndereco.Text}','{txbNum.Text}'," +
                $"'{txbBairro.Text}','{txbCidade.Text}','{txbCep.Text}','{txbComplemento.Text}','{txbTelefone.Text}','{txbCelular.Text}'," +
                $"'{txbEndCobr.Text}','{txbNumCob.Text}','{txbBairroCobranca.Text}','{txbUfCobre.Text}','{txbCidCobr.Text}','{txbCepCobre.Text}','{txbEmailCobre.Text}'," +
                $"'{txbCodVend.Text}','{txbTelCobre.Text}','{txbCelCob.Text}','{txbSite.Text}','{txbNatureza.Text}');";

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

        private int codCliente()
        {
            // Substitua esta função pela sua lógica desejada
            Random random = new Random();
            return random.Next(1, 1000);
        }

        private void codCliente(object sender, EventArgs e)
        {
            int resultado = codCliente();

            txbCod.Text = resultado.ToString();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txbCep.Text.Trim());

                        cbUf.Text = endereco.uf;
                        txbCidade.Text = endereco.cidade;
                        txbBairro.Text = endereco.bairro;
                        txbEndereco.Text = endereco.end;

                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido...", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfCep_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txbCep.Text.Trim());

                        txbUfCobre.Text = endereco.uf;
                        txbCidCobr.Text = endereco.cidade;
                        txbBairroCobranca.Text = endereco.bairro;
                        txbEndCobr.Text = endereco.end;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido...", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMars.FormControleUsuario.CallCenter
{
    public partial class UserControlClients : UserControl
    {
        public UserControlClients()
        {
            InitializeComponent();

            lblUsuario.Text = Program.UsuarioLogado;
        }
       

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FormControleUsuario.CallCenter.Cliente.CadastroCliente cliente = new FormControleUsuario.CallCenter.Cliente.CadastroCliente();
            cliente.ShowDialog();
            atualizagrid();

        }

        private void UserControlClients_Load(object sender, EventArgs e)
        {
            atualizagrid();
        }    
        
        void atualizagrid()
        {
            string cmdSql = "SELECT L0_COD AS CODIGO, L0_CNPJ AS CNPJ, L0_PESSOA AS PESSOA, L0_UF AS UF, L0_FRET AS FRETE, L0_EMAIL AS EMAIL, L0_NOME AS NOME, L0_FANT AS FANTASIA, L0_INSC AS INSc_ESTADUAL,  L0_END AS ENDEREÇO, L0_NUM AS NUMERO, L0_BAIR AS BAIRRO, L0_CID AS CIDADE, L0_CEP AS CEP, L0_COMPL AS COMPLEMENTO, L0_TEL AS TELEFONE, L0_CEL AS CELULAR, L0_DATE AS DATA FROM CL0010";
            var dados = Program.conn.SELECT(cmdSql);

            string status = "SELECT L0_STATU FROM CL0010";
            var tipo = Program.conn.SELECT(status);

            if (dados.Rows.Count > 0)
            {

                dataGridView1.DataSource = dados;
                dataGridView1.BackgroundColor = Color.Silver;
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

                if (tipo != null)
                {
                    DataRow statusPedido = tipo.Rows[0];
                    int st = Convert.ToInt32(statusPedido["L0_STATU"]);
                    if (st == 1)
                    {
                        GridStatu.DefaultCellStyle.BackColor = Color.Blue;
                    }
                    else if (st == 2)
                    {
                        GridStatu.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
    }        
}

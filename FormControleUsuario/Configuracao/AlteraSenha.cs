using MySqlX.XDevAPI;
using ProjetoMars.Class;
using ServiceStack.Script;
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

namespace ProjetoMars.FormControleUsuario.Configuracao
{
    public partial class AlteraSenha : Form
    {
        public AlteraSenha()
        {
            InitializeComponent();
        }

        private void bntConfirma_Click(object sender, EventArgs e)
        {
            Novasenha();
        }

        void Novasenha()
        {
             string senhaAntiga = txtSenhaAntiga.Text;
            string senhaNova = txtSenhaNova.Text;
            string confirma = txtConfirmaSenha.Text;

            Program.conn.UPDATE("START TRANSACTION");

            string cmdSQl = $"SELECT SYS_USR  USR_PWD FROM WHERE USR_NOME = '{Program.UsuarioLogado}' AND USR_PWD = '{Encrypt.HashString(senhaAntiga)}'";
            var dados = Program.conn.SELECT(cmdSQl);

            

            if (senhaAntiga == senhaAntiga && senhaNova == confirma)
            {
                string grava = $"UPDATE SYS_USR SET USR_PWD = '{Global.Encrypt.HashString(senhaNova)}', USR_ALT = '1' WHERE USR_NOME = '{Program.UsuarioLogado}'";
                if (!Program.conn.UPDATE(grava))
                {
                    MessageBox.Show("Dados estao Encorretos favor digitar novamente");
                }
                else
                {
                    MessageBox.Show("Senha alterada com Sucesso");
                    Program.conn.INSERT("COMMIT");
                    this.DialogResult = DialogResult.OK;
                }
                
            }
            else
            {

                MessageBox.Show("Senha Encorreta favor digitar novamente");
            }


            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja Fechar o Sistema", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Program.conn.INSERT("ROLLBACK");
            Close();
        }
    }
}

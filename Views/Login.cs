using MySql.Data.MySqlClient;
using ProjetoMars.FormControleUsuario.Configuracao;
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


namespace ProjetoMars
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        FormControleUsuario.Configuracao.AlteraSenha altera = new FormControleUsuario.Configuracao.AlteraSenha();

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            user.ToLower();

            txtUser.TextAlign = HorizontalAlignment.Center;
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Fechar o Sistema", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                Application.Exit(); // Fecha o aplicativo
            }
            // Se o usuário clicar em "Cancelar", nada acontece.
        }

        private void btnVer_Click_1(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
                txtSenha.PasswordChar = '\0';
            else
                txtSenha.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtUser.Text;

            string cmdSql = $"CALL ConsultarSysUsrPorUsuario('{login}');";

            var dados = Program.conn.SELECT(cmdSql);

            if (dados != null)
            {
                DataRow dadosLogin = dados.Rows[0];

                DataRow alteraSenha = dados.Rows[0];

                string senhaUSR = dadosLogin["USR_PWD"].ToString();

                var alterar = alteraSenha["USR_ALT"].ToString();

                if (senhaUSR == Encrypt.HashString(txtSenha.Text))
                {

                    Program.UsuarioLogado = dadosLogin["USR_NOME"].ToString();

                    Program.Email = dadosLogin["USR_EMAIL"].ToString();

                    if (alterar != "False")
                    {
                        altera.ShowDialog();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Senha inválida");
                }
            }
            else
            {
                MessageBox.Show("Usuario nao encontrado");
            }
        }
    }
}

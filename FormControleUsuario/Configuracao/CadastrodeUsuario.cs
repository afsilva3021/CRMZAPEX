using OracleInternal.Secure.Network;
using ProjetoMars.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMars.FormControleUsuario.Configuracao
{
    

    public partial class CadastrodeUsuario : Form
    {
        public CadastrodeUsuario()
        {
            InitializeComponent();
        }     

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cadastro();
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

        void cadastro()
        {

            string senha = txtSenha.Text;
            string confirma = txtConfSenha.Text;

            if (senha == confirma)
            {

            }
            else
            {
                MessageBox.Show("Senha diferente favor corrigir senha.");
                Program.conn.INSERT("ROLLBACK");
            }
            Program.conn.INSERT("START TRANSACTION;");
            
            string cmdSql = $"INSERT INTO SYS_USR (USR_USER, USR_NOME, USR_EMAIL, USR_PWD, USR_BLQ, USR_DEPARTAMENTO, USR_CARGO, USR_GRUPO) VALUES ('{txtCodigo.Text}','{txtNome.Text}','{txtEmail.Text}','{Global.Encrypt.HashString(senha)}','{cbBLQ.Text}','{txtDepartamento.Text}','{txtCargo.Text}','{cbGrupo.Text}');";
            
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked )
            {
                int altera = 1;
                
                Program.conn.INSERT($"INSERT INTO PD0010 (USR_ALT) VALUES ({altera})");
            }
            else
            {
                Program.conn.INSERT("INSERT INTO PD0010 (USR_ALT) VALUES (2)");
            }
        }
    }
}

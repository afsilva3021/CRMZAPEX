using OracleInternal.Secure.Network;
using ProjetoMars.Class;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoMars.Class.Global;

namespace ProjetoMars.FormControleUsuario.Configuracao
{
    

    public partial class CadastrodeUsuario : Form
    {
        public CadastrodeUsuario()
        {
            InitializeComponent();

        }

        public CadastrodeUsuario(string Codigo, string Nome, string Email, string senha, string blq, string Departamento, string Cargo, string Grupo)
        {
            InitializeComponent();

            txtCodigo.Text = Codigo;
            txtNome.Text = Nome;
            txtEmail.Text = Email;
            txtSenha.Text = senha;
            cbBLQ.Text = blq;
            txtDepartamento.Text = Departamento;
            txtCargo.Text = Cargo;
            cbGrupo.Text = Grupo;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                
                MessageBox.Show("Campos não preenchidos Favor preencher os campos com *");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Campos não preenchidos Favor preencher os campos com *");
                return;
            }
            else
            {
                cadastro();
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
        

      public void cadastro()
        {

            string senha = txtSenha.Text;
            string confirma = txtConfSenha.Text;

            if (senha == confirma)
            {
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
                }

                Program.conn.UPDATE($"UPDATE SYS_USR SET USR_ALT = '{checkBox1.Checked}' WHERE USR_USER = '{txtCodigo.Text}'");
                MessageBox.Show("Dados Salvos com Sucesso");

                Close();
            }
            else
            {
                MessageBox.Show("Senha diferente favor corrigir senha.");
                Program.conn.INSERT("ROLLBACK");
            } 
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alteraDados();
            
        }

        public void alteraDados()
        {
            string senha = txtSenha.Text;
            string confirma = txtConfSenha.Text;
            
            if(senha == confirma)
            {
                Program.conn.UPDATE("START TRANSACTION;");

                var altera = $"UPDATE SYS_USR SET USR_USER = '{txtCodigo.Text}', USR_NOME = '{txtNome.Text}', USR_PWD = '{Encrypt.HashString(senha)}', USR_EMAIL = '{txtEmail.Text}', USR_DEPARTAMENTO = '{txtDepartamento.Text}', USR_CARGO = '{txtCargo.Text}', USR_GRUPO = '{cbGrupo.Text}', USR_BLQ = '{cbBLQ.Text}', USR_ALT = '{checkBox1.Checked}' WHERE USR_NOME = '{txtNome.Text}' OR USR_USER = '{txtCodigo.Text}'";

                Program.conn.UPDATE(altera);

                MessageBox.Show("Dados alterado com Sucesso");

                Program.conn.UPDATE("COMMIT");

                Close();
            }
            else
            {
                MessageBox.Show("Senha esta deferente por favor digitar novamente ");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            delete();
            Close();
        }

        public void delete()
        {
            DialogResult resultado = MessageBox.Show("Deseja deletar esse usuario ?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                Program.conn.DELETE($"DELETE FROM sys_usr WHERE USR_USER = '{txtCodigo.Text}'");
            }

        }
    }
}

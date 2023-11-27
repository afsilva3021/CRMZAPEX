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

        string origemCompleto = "";
        string imagenProduto = "";
        string pastaDestino = Global.caminhoImagens;
        string DestinoCompleto = "";

        void Cadastra()
        {
            Program.conn.INSERT("START TRANSACTION");

            string cmdSql = $"CALL cadastroProduto('{txtCodigo.Text}','{txtReferencia.Text}','{txtFornecedor.Text}','{txtMarca.Text}','{txtSaldo.Text}','{txtCusto.Text}','{txtProco.Text}','{txtEstMinimo.Text}','{txtEstMaximo.Text}','{txtDescricao.Text}','{txtDesc.Text}','{DestinoCompleto}');";

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

        

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                origemCompleto=openFileDialog1.FileName;
                imagenProduto=openFileDialog1.SafeFileName;
                DestinoCompleto = pastaDestino+imagenProduto;
            }
            if (File.Exists(DestinoCompleto))
            {
                if (MessageBox.Show("Arquivo ja exite, deseja Substituir ?"+MessageBoxButtons.OKCancel)==DialogResult.Cancel)
                {
                    return;
                }
            }

            System.IO.File.Copy(origemCompleto, DestinoCompleto, true);
            if (File.Exists(DestinoCompleto))
            {
                pbImg.ImageLocation = DestinoCompleto;
            }
            else
            {
                MessageBox.Show("Arquivo nao copiado");
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (DestinoCompleto == "")
            {
                if (MessageBox.Show("Sem imagen Selecionada, deja Salvar mesmo assim?", "ERROR" + MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                if (DestinoCompleto != "")
                {
                    System.IO.File.Copy(origemCompleto, DestinoCompleto, true);
                    if (File.Exists(DestinoCompleto))
                    {
                        pbImg.ImageLocation = DestinoCompleto;
                    }
                    else
                    {
                        if (MessageBox.Show("Erro ao localizar a imagen, deseja continuar?", "ERROR"+MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
            }

            Cadastra();
        }
    }
}

using ProjetoMars.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMars
{



    public partial class PainelPrincipal : Form
    {   
        private Boolean showpanelCallCenter = false;
        private Boolean showpanelEstoqueCustos = false;
        private Boolean showpanelFaturamento = false;
        private Boolean showpanelLivrosFiscais = false;


        UserControl Home = new UserControlHome();
        FormControleUsuario.CallCenter.UserControlOrcamento Orcamento = new FormControleUsuario.CallCenter.UserControlOrcamento();
        FormControleUsuario.CallCenter.UserControlClients Clientes = new FormControleUsuario.CallCenter.UserControlClients();
        FormControleUsuario.CallCenter.UserControlAprovacaoComercial AprovacaoComercial = new FormControleUsuario.CallCenter.UserControlAprovacaoComercial();
        FormControleUsuario.CallCenter.UserControlDashboard Dashboard = new FormControleUsuario.CallCenter.UserControlDashboard();
        FormControleUsuario.Configurações.Configuracoes Configuracoes = new FormControleUsuario.Configurações.Configuracoes();
        FormControleUsuario.Estoque_e_custo.Produtos Produtos = new FormControleUsuario.Estoque_e_custo.Produtos();

        private void tooglePanels()
        {
            if (showpanelCallCenter)
            {
                panelCallCenter.Visibe = true;

            }
            else
            {
                panelCallCenter.Visible = falar;
            }

            if (showpanelEstoqueCustos)
            {
                panelEstoqueCustos.Height = 130;

            }
            else
            {
                panelEstoqueCustos.Height = 0;
            }

            if (showpanelFaturamento)
            {
                panelFaturamento.Height = 100;
            }
            else
            {
                panelFaturamento.Height = 0;
            }

            if (showpanelLivrosFiscais)
            {
                panelLivrosFiscais.Height = 35;
            }
            else
            {
                panelLivrosFiscais.Height = 0;
            }

        }

        public PainelPrincipal()
        {
            InitializeComponent();

            tooglePanels();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(Home);
            Home.Dock = DockStyle.Fill;

        }
        private void PainelPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.UsuarioLogado;
            lblEmail.Text = Program.Email;
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {

        }

        private void btnCallCenter_Click(object sender, EventArgs e)
        {
            showpanelEstoqueCustos = false;
            showpanelFaturamento = false;
            showpanelLivrosFiscais = false;

            showpanelCallCenter = !showpanelCallCenter;


            tooglePanels();
        }

        private void btnEstoqueCusto_Click(object sender, EventArgs e)
        {
            showpanelCallCenter = false;
            showpanelFaturamento = false;
            showpanelLivrosFiscais = false;

            showpanelEstoqueCustos = !showpanelEstoqueCustos;
            tooglePanels();
        }

        private void btnFaturamento_Click(object sender, EventArgs e)
        {
            showpanelCallCenter = false;
            showpanelEstoqueCustos = false;
            showpanelLivrosFiscais = false;

            showpanelFaturamento = !showpanelFaturamento;
            tooglePanels();

        }

        private void btnLivrosFiscal_Click(object sender, EventArgs e)
        {
            showpanelCallCenter = false;
            showpanelEstoqueCustos = false;
            showpanelFaturamento = false;

            showpanelLivrosFiscais = !showpanelLivrosFiscais;
            tooglePanels();

        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            
            panelHome.Controls.Clear();
            panelHome.Controls.Add(Orcamento);
            Orcamento.Dock = DockStyle.Fill;

            
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            
            panelHome.Controls.Clear();
            panelHome.Controls.Add(Clientes);
            Clientes.Dock = DockStyle.Fill;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             DialogResult resultado = MessageBox.Show("Deseja Fechar o Sistema", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            panelHome.Controls.Clear();
            panelHome.Controls.Add(Home);
            Home.Dock = DockStyle.Fill;
            btnHome.Refresh();

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Home.Refresh();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(Produtos);
            Produtos.Dock = DockStyle.Fill;
        }

        private void btnConfiguracao_Click_1(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            panelHome.Controls.Add(Configuracoes);
            Configuracoes.Dock = DockStyle.Fill;
        }
    }
}

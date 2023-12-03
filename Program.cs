using ProjetoMars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoMars.Class;


namespace ProjetoMars
{
    internal static class Program
    {

        public static Conect conn = new Conect("localhost", "crmzapex", "root", "");

        public static string UsuarioLogado;

        public static string Email;
        
        public static string codCLient;

        public static string fantaisa;

        public static string cnpj;

        public static string vendedor;

        public static string codAtendi;
                
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            if (conn.testConect())
            {
                Login login = new Login();
                DialogResult result = login.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Application.Run(new PainelPrincipal());
                }

            }
            else
            {
                MessageBox.Show(
                    conn.getMsgErro(),
                    "Erro de Conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}

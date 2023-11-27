namespace ProjetoMars.FormControleUsuario.CallCenter
{
    partial class UserControlDashboard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dashboard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(1001, 881);
            this.Dashboard.TabIndex = 0;
            // 
            // UserControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Dashboard);
            this.Name = "UserControlDashboard";
            this.Size = new System.Drawing.Size(1001, 881);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Dashboard;
    }
}

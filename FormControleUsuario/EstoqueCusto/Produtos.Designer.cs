namespace ProjetoMars.FormControleUsuario.Estoque_e_custo
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GridStatu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnButons = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnNavbar = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnNotificacao = new System.Windows.Forms.Button();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnButons.SuspendLayout();
            this.pnNavbar.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 849);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridStatu});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1195, 766);
            this.dataGridView1.TabIndex = 3;
            // 
            // GridStatu
            // 
            this.GridStatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridStatu.HeaderText = "Status";
            this.GridStatu.Name = "GridStatu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.pnButons);
            this.panel2.Controls.Add(this.pnNavbar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 849);
            this.panel2.TabIndex = 1;
            // 
            // pnButons
            // 
            this.pnButons.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnButons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnButons.Controls.Add(this.btnAlterar);
            this.pnButons.Controls.Add(this.panel3);
            this.pnButons.Controls.Add(this.btnCadastrar);
            this.pnButons.Controls.Add(this.panel4);
            this.pnButons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnButons.Location = new System.Drawing.Point(0, 46);
            this.pnButons.Name = "pnButons";
            this.pnButons.Size = new System.Drawing.Size(1195, 37);
            this.pnButons.TabIndex = 2;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(197, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(96, 35);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(151, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 35);
            this.panel3.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(38, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(113, 35);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 35);
            this.panel4.TabIndex = 0;
            // 
            // pnNavbar
            // 
            this.pnNavbar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnNavbar.Controls.Add(this.panel11);
            this.pnNavbar.Controls.Add(this.lblProdutos);
            this.pnNavbar.Controls.Add(this.btnBusca);
            this.pnNavbar.Controls.Add(this.txbPesquisa);
            this.pnNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnNavbar.Name = "pnNavbar";
            this.pnNavbar.Size = new System.Drawing.Size(1195, 46);
            this.pnNavbar.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lblUsuario);
            this.panel11.Controls.Add(this.btnNotificacao);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(1010, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(185, 46);
            this.panel11.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(42, 4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnNotificacao
            // 
            this.btnNotificacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNotificacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotificacao.FlatAppearance.BorderSize = 0;
            this.btnNotificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacao.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.btnNotificacao.ForeColor = System.Drawing.Color.White;
            this.btnNotificacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificacao.Location = new System.Drawing.Point(2, 17);
            this.btnNotificacao.Name = "btnNotificacao";
            this.btnNotificacao.Size = new System.Drawing.Size(157, 24);
            this.btnNotificacao.TabIndex = 2;
            this.btnNotificacao.Text = "Notificação";
            this.btnNotificacao.UseVisualStyleBackColor = true;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblProdutos.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblProdutos.Location = new System.Drawing.Point(592, 5);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(119, 31);
            this.lblProdutos.TabIndex = 3;
            this.lblProdutos.Text = "Produtos";
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.Transparent;
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBusca.Location = new System.Drawing.Point(190, 6);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(37, 29);
            this.btnBusca.TabIndex = 1;
            this.btnBusca.UseVisualStyleBackColor = false;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.Location = new System.Drawing.Point(3, 6);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(224, 29);
            this.txbPesquisa.TabIndex = 0;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Produtos";
            this.Size = new System.Drawing.Size(1195, 849);
            this.Load += new System.EventHandler(this.Produtos_load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnButons.ResumeLayout(false);
            this.pnNavbar.ResumeLayout(false);
            this.pnNavbar.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn GridStatu;
        private System.Windows.Forms.Panel pnButons;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnNavbar;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnNotificacao;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txbPesquisa;
    }
}

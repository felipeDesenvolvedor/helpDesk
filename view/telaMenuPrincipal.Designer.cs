namespace view
{
    partial class TelaMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPessoaFísicaToolStripMenuItem_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePessoaJurídicaToolStripMenuItem_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirOsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirOsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.funcionariosToolStripMenuItem,
            this.abrirOsMenu,
            this.abrirOsToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(479, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarPessoaFísicaToolStripMenuItem_Click,
            this.cadastroDePessoaJurídicaToolStripMenuItem_Click});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarPessoaFísicaToolStripMenuItem_Click
            // 
            this.cadastrarPessoaFísicaToolStripMenuItem_Click.Name = "cadastrarPessoaFísicaToolStripMenuItem_Click";
            this.cadastrarPessoaFísicaToolStripMenuItem_Click.Size = new System.Drawing.Size(202, 22);
            this.cadastrarPessoaFísicaToolStripMenuItem_Click.Text = "Cadastro Pessoa fisica";
            this.cadastrarPessoaFísicaToolStripMenuItem_Click.Click += new System.EventHandler(this.cadastrarPessoaFísicaToolStripMenuItem_Click_Click);
            // 
            // cadastroDePessoaJurídicaToolStripMenuItem_Click
            // 
            this.cadastroDePessoaJurídicaToolStripMenuItem_Click.Name = "cadastroDePessoaJurídicaToolStripMenuItem_Click";
            this.cadastroDePessoaJurídicaToolStripMenuItem_Click.Size = new System.Drawing.Size(202, 22);
            this.cadastroDePessoaJurídicaToolStripMenuItem_Click.Text = "Cadastro Pessoa juridica";
            this.cadastroDePessoaJurídicaToolStripMenuItem_Click.Click += new System.EventHandler(this.cadastroDePessoaJurídicaToolStripMenuItem_Click_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // abrirOsMenu
            // 
            this.abrirOsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.abrirOsMenu.Name = "abrirOsMenu";
            this.abrirOsMenu.Size = new System.Drawing.Size(34, 20);
            this.abrirOsMenu.Text = "OS";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // abrirOsToolStripMenuItem
            // 
            this.abrirOsToolStripMenuItem.Name = "abrirOsToolStripMenuItem";
            this.abrirOsToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.abrirOsToolStripMenuItem.Text = "Sair";
            this.abrirOsToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // TelaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 335);
            this.ControlBox = false;
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "TelaMenuPrincipal";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.TelaMenuPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirOsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirOsMenu;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPessoaFísicaToolStripMenuItem_Click;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePessoaJurídicaToolStripMenuItem_Click;
    }
}
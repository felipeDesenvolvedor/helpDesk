namespace view
{
    partial class Clientes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.txtClienteCPF = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(261, 44);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCliente.TabIndex = 1;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.AccessibleName = "ControllerUsuario contr = new ControllerUsuario();";
            this.txtClienteNome.Location = new System.Drawing.Point(12, 44);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(100, 20);
            this.txtClienteNome.TabIndex = 2;
            // 
            // txtClienteCPF
            // 
            this.txtClienteCPF.AccessibleName = "ControllerUsuario contr = new ControllerUsuario();";
            this.txtClienteCPF.Location = new System.Drawing.Point(134, 44);
            this.txtClienteCPF.Name = "txtClienteCPF";
            this.txtClienteCPF.PasswordChar = '*';
            this.txtClienteCPF.Size = new System.Drawing.Size(100, 20);
            this.txtClienteCPF.TabIndex = 3;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 291);
            this.Controls.Add(this.txtClienteCPF);
            this.Controls.Add(this.txtClienteNome);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.TextBox txtClienteNome;
        private System.Windows.Forms.TextBox txtClienteCPF;
    }
}
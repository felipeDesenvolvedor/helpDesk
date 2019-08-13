namespace view
{
    partial class EditarUsuario
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
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnRedefinirSenha = new System.Windows.Forms.Button();
            this.txtUsuarioEditar = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblUuarioEditar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditarUsuario.Location = new System.Drawing.Point(269, 98);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarUsuario.TabIndex = 0;
            this.btnEditarUsuario.Text = "Salvar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnRedefinirSenha
            // 
            this.btnRedefinirSenha.Location = new System.Drawing.Point(133, 98);
            this.btnRedefinirSenha.Name = "btnRedefinirSenha";
            this.btnRedefinirSenha.Size = new System.Drawing.Size(104, 23);
            this.btnRedefinirSenha.TabIndex = 1;
            this.btnRedefinirSenha.Text = "Redefinir Senha";
            this.btnRedefinirSenha.UseVisualStyleBackColor = true;
            this.btnRedefinirSenha.Click += new System.EventHandler(this.btnRedefinirSenha_Click);
            // 
            // txtUsuarioEditar
            // 
            this.txtUsuarioEditar.Location = new System.Drawing.Point(22, 50);
            this.txtUsuarioEditar.Name = "txtUsuarioEditar";
            this.txtUsuarioEditar.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioEditar.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(24, 98);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblUuarioEditar
            // 
            this.lblUuarioEditar.AutoSize = true;
            this.lblUuarioEditar.Location = new System.Drawing.Point(22, 34);
            this.lblUuarioEditar.Name = "lblUuarioEditar";
            this.lblUuarioEditar.Size = new System.Drawing.Size(43, 13);
            this.lblUuarioEditar.TabIndex = 5;
            this.lblUuarioEditar.Text = "Usuario";
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 150);
            this.ControlBox = false;
            this.Controls.Add(this.lblUuarioEditar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtUsuarioEditar);
            this.Controls.Add(this.btnRedefinirSenha);
            this.Controls.Add(this.btnEditarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditarUsuario";
            this.Text = "Editar Clientes";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnRedefinirSenha;
        public System.Windows.Forms.TextBox txtUsuarioEditar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblUuarioEditar;
    }
}
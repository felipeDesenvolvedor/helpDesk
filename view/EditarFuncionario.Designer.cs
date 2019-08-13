namespace view
{
    partial class EditarFuncionario
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
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.lbFuncionarioEditar = new System.Windows.Forms.Label();
            this.dataGridFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblSelecionarCadastro = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsultarFuncionario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(24, 115);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(210, 20);
            this.txtFuncionario.TabIndex = 0;
            // 
            // lbFuncionarioEditar
            // 
            this.lbFuncionarioEditar.AutoSize = true;
            this.lbFuncionarioEditar.Location = new System.Drawing.Point(21, 88);
            this.lbFuncionarioEditar.Name = "lbFuncionarioEditar";
            this.lbFuncionarioEditar.Size = new System.Drawing.Size(62, 13);
            this.lbFuncionarioEditar.TabIndex = 1;
            this.lbFuncionarioEditar.Text = "Funcionario";
            // 
            // dataGridFuncionarios
            // 
            this.dataGridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuncionarios.Location = new System.Drawing.Point(24, 154);
            this.dataGridFuncionarios.Name = "dataGridFuncionarios";
            this.dataGridFuncionarios.Size = new System.Drawing.Size(458, 150);
            this.dataGridFuncionarios.TabIndex = 11;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(24, 320);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblSelecionarCadastro
            // 
            this.lblSelecionarCadastro.AutoSize = true;
            this.lblSelecionarCadastro.Location = new System.Drawing.Point(21, 15);
            this.lblSelecionarCadastro.Name = "lblSelecionarCadastro";
            this.lblSelecionarCadastro.Size = new System.Drawing.Size(102, 13);
            this.lblSelecionarCadastro.TabIndex = 17;
            this.lblSelecionarCadastro.Text = "Selecionar Cadastro";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(265, 114);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(160, 42);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Selecionar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsultarFuncionario
            // 
            this.txtConsultarFuncionario.Location = new System.Drawing.Point(24, 42);
            this.txtConsultarFuncionario.Name = "txtConsultarFuncionario";
            this.txtConsultarFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtConsultarFuncionario.TabIndex = 13;
            // 
            // EditarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 355);
            this.ControlBox = false;
            this.Controls.Add(this.lblSelecionarCadastro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsultarFuncionario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dataGridFuncionarios);
            this.Controls.Add(this.lbFuncionarioEditar);
            this.Controls.Add(this.txtFuncionario);
            this.Name = "EditarFuncionario";
            this.Text = "Editar Funcionario";
            this.Load += new System.EventHandler(this.EditarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFuncionarioEditar;
        public System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.DataGridView dataGridFuncionarios;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblSelecionarCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultarFuncionario;
    }
}
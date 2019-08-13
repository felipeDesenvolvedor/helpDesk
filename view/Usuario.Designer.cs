namespace view
{
    partial class Usuario
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
            this.components = new System.ComponentModel.Container();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoClientesDataSet = new view.BancoClientesDataSet();
            this.clienteTableAdapter = new view.BancoClientesDataSetTableAdapters.ClienteTableAdapter();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.txtConsultarUsuario = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSelecionarCadastro = new System.Windows.Forms.Label();
            this.comboSetor = new System.Windows.Forms.ComboBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoClientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(370, 89);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarUsuario.TabIndex = 0;
            this.btnCadastrarUsuario.Text = "Cadastrar";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(38, 42);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bancoClientesDataSet;
            // 
            // bancoClientesDataSet
            // 
            this.bancoClientesDataSet.DataSetName = "BancoClientesDataSet";
            this.bancoClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Location = new System.Drawing.Point(15, 239);
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.Size = new System.Drawing.Size(523, 150);
            this.dataGridUsuario.TabIndex = 3;
            // 
            // txtConsultarUsuario
            // 
            this.txtConsultarUsuario.Location = new System.Drawing.Point(18, 197);
            this.txtConsultarUsuario.Name = "txtConsultarUsuario";
            this.txtConsultarUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtConsultarUsuario.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(154, 197);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Selecionar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(370, 197);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(260, 197);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarUsuario.TabIndex = 7;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(18, 400);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(35, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblSelecionarCadastro
            // 
            this.lblSelecionarCadastro.AutoSize = true;
            this.lblSelecionarCadastro.Location = new System.Drawing.Point(15, 170);
            this.lblSelecionarCadastro.Name = "lblSelecionarCadastro";
            this.lblSelecionarCadastro.Size = new System.Drawing.Size(102, 13);
            this.lblSelecionarCadastro.TabIndex = 10;
            this.lblSelecionarCadastro.Text = "Selecionar Cadastro";
            // 
            // comboSetor
            // 
            this.comboSetor.FormattingEnabled = true;
            this.comboSetor.Items.AddRange(new object[] {
            "",
            "Administrativo",
            "Atendimento",
            "Técnico"});
            this.comboSetor.Location = new System.Drawing.Point(324, 42);
            this.comboSetor.Name = "comboSetor";
            this.comboSetor.Size = new System.Drawing.Size(121, 21);
            this.comboSetor.TabIndex = 11;
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(321, 16);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(32, 13);
            this.lblSetor.TabIndex = 12;
            this.lblSetor.Text = "Setor";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(174, 15);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 14;
            this.lblFuncionario.Text = "Funcionario";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(177, 43);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtFuncionario.TabIndex = 13;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 435);
            this.ControlBox = false;
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.comboSetor);
            this.Controls.Add(this.lblSelecionarCadastro);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsultarUsuario);
            this.Controls.Add(this.dataGridUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoClientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private BancoClientesDataSet bancoClientesDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BancoClientesDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.TextBox txtConsultarUsuario;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSelecionarCadastro;
        private System.Windows.Forms.ComboBox comboSetor;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.TextBox txtFuncionario;
    }
}
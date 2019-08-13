namespace view
{
    partial class AbrirOS
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
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblEquipamento = new System.Windows.Forms.Label();
            this.lblCodTecnico = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCodTecnico = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.comboPrioridade = new System.Windows.Forms.ComboBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.descricaoOS = new System.Windows.Forms.RichTextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.comboTipoCliente = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Location = new System.Drawing.Point(23, 220);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(54, 13);
            this.lblPrioridade.TabIndex = 2;
            this.lblPrioridade.Text = "Prioridade";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(299, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(172, 35);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(61, 13);
            this.lblCodCliente.TabIndex = 4;
            this.lblCodCliente.Text = "Cod Cliente";
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(23, 105);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(46, 13);
            this.lblTecnico.TabIndex = 5;
            this.lblTecnico.Text = "Técnico";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(23, 307);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblEquipamento
            // 
            this.lblEquipamento.AutoSize = true;
            this.lblEquipamento.Location = new System.Drawing.Point(172, 220);
            this.lblEquipamento.Name = "lblEquipamento";
            this.lblEquipamento.Size = new System.Drawing.Size(117, 13);
            this.lblEquipamento.TabIndex = 7;
            this.lblEquipamento.Text = "Categoria Equipamento";
            // 
            // lblCodTecnico
            // 
            this.lblCodTecnico.AutoSize = true;
            this.lblCodTecnico.Location = new System.Drawing.Point(23, 35);
            this.lblCodTecnico.Name = "lblCodTecnico";
            this.lblCodTecnico.Size = new System.Drawing.Size(68, 13);
            this.lblCodTecnico.TabIndex = 8;
            this.lblCodTecnico.Text = "Cod Técnico";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(172, 105);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCodTecnico
            // 
            this.txtCodTecnico.Location = new System.Drawing.Point(26, 68);
            this.txtCodTecnico.Name = "txtCodTecnico";
            this.txtCodTecnico.Size = new System.Drawing.Size(100, 20);
            this.txtCodTecnico.TabIndex = 13;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(175, 68);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodCliente.TabIndex = 17;
            // 
            // comboPrioridade
            // 
            this.comboPrioridade.FormattingEnabled = true;
            this.comboPrioridade.Items.AddRange(new object[] {
            "",
            "Alta",
            "Média",
            "Baixa"});
            this.comboPrioridade.Location = new System.Drawing.Point(26, 253);
            this.comboPrioridade.Name = "comboPrioridade";
            this.comboPrioridade.Size = new System.Drawing.Size(121, 21);
            this.comboPrioridade.TabIndex = 21;
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "",
            "Computador de mesa",
            "Notbook",
            "Impressora"});
            this.comboCategoria.Location = new System.Drawing.Point(175, 253);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboCategoria.TabIndex = 22;
            // 
            // descricaoOS
            // 
            this.descricaoOS.Location = new System.Drawing.Point(26, 335);
            this.descricaoOS.Name = "descricaoOS";
            this.descricaoOS.Size = new System.Drawing.Size(270, 96);
            this.descricaoOS.TabIndex = 23;
            this.descricaoOS.Text = "";
            // 
            // btnAbrir
            // 
            this.btnAbrir.AccessibleDescription = "";
            this.btnAbrir.Location = new System.Drawing.Point(221, 457);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 24;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(25, 161);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(63, 13);
            this.lblTipoCliente.TabIndex = 25;
            this.lblTipoCliente.Text = "Tipo Cliente";
            // 
            // comboTipoCliente
            // 
            this.comboTipoCliente.FormattingEnabled = true;
            this.comboTipoCliente.Items.AddRange(new object[] {
            "",
            "Pessoa Fisica",
            "Pessoa Juridica"});
            this.comboTipoCliente.Location = new System.Drawing.Point(175, 161);
            this.comboTipoCliente.Name = "comboTipoCliente";
            this.comboTipoCliente.Size = new System.Drawing.Size(121, 21);
            this.comboTipoCliente.TabIndex = 26;
            // 
            // btnVoltar
            // 
            this.btnVoltar.AccessibleDescription = "";
            this.btnVoltar.Location = new System.Drawing.Point(28, 457);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // AbrirOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 494);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.comboTipoCliente);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.descricaoOS);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.comboPrioridade);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.txtCodTecnico);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCodTecnico);
            this.Controls.Add(this.lblEquipamento);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.lblCodCliente);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPrioridade);
            this.Name = "AbrirOS";
            this.Text = "AbrirOS";
            this.Load += new System.EventHandler(this.AbrirOS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblEquipamento;
        private System.Windows.Forms.Label lblCodTecnico;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCodTecnico;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.ComboBox comboPrioridade;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.RichTextBox descricaoOS;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox comboTipoCliente;
        private System.Windows.Forms.Button btnVoltar;
    }
}
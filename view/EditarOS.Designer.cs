namespace view
{
    partial class EditarOS
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gridEditarOS = new System.Windows.Forms.DataGridView();
            this.txtCodTecnico = new System.Windows.Forms.TextBox();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.lblSelecionarOS = new System.Windows.Forms.Label();
            this.txtSelecionarOS = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.comboPrioridade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditarOS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(56, 413);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(607, 413);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gridEditarOS
            // 
            this.gridEditarOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEditarOS.Location = new System.Drawing.Point(56, 97);
            this.gridEditarOS.Name = "gridEditarOS";
            this.gridEditarOS.Size = new System.Drawing.Size(626, 291);
            this.gridEditarOS.TabIndex = 3;
            // 
            // txtCodTecnico
            // 
            this.txtCodTecnico.Location = new System.Drawing.Point(65, 59);
            this.txtCodTecnico.Name = "txtCodTecnico";
            this.txtCodTecnico.Size = new System.Drawing.Size(100, 20);
            this.txtCodTecnico.TabIndex = 6;
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(62, 31);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(82, 13);
            this.lblTecnico.TabIndex = 10;
            this.lblTecnico.Text = "Código Técnico";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Location = new System.Drawing.Point(200, 31);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(54, 13);
            this.lblPrioridade.TabIndex = 11;
            this.lblPrioridade.Text = "Prioridade";
            // 
            // lblSelecionarOS
            // 
            this.lblSelecionarOS.AutoSize = true;
            this.lblSelecionarOS.Location = new System.Drawing.Point(365, 31);
            this.lblSelecionarOS.Name = "lblSelecionarOS";
            this.lblSelecionarOS.Size = new System.Drawing.Size(75, 13);
            this.lblSelecionarOS.TabIndex = 13;
            this.lblSelecionarOS.Text = "Selecionar OS";
            // 
            // txtSelecionarOS
            // 
            this.txtSelecionarOS.Location = new System.Drawing.Point(368, 59);
            this.txtSelecionarOS.Name = "txtSelecionarOS";
            this.txtSelecionarOS.Size = new System.Drawing.Size(100, 20);
            this.txtSelecionarOS.TabIndex = 12;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(502, 56);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 14;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // comboPrioridade
            // 
            this.comboPrioridade.FormattingEnabled = true;
            this.comboPrioridade.Items.AddRange(new object[] {
            "",
            "Alta",
            "Média",
            "Baixa"});
            this.comboPrioridade.Location = new System.Drawing.Point(203, 57);
            this.comboPrioridade.Name = "comboPrioridade";
            this.comboPrioridade.Size = new System.Drawing.Size(121, 21);
            this.comboPrioridade.TabIndex = 15;
            // 
            // EditarOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.comboPrioridade);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblSelecionarOS);
            this.Controls.Add(this.txtSelecionarOS);
            this.Controls.Add(this.lblPrioridade);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.txtCodTecnico);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gridEditarOS);
            this.Name = "EditarOS";
            this.Text = "EditarOS";
            this.Load += new System.EventHandler(this.EditarOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEditarOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gridEditarOS;
        private System.Windows.Forms.TextBox txtCodTecnico;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.Label lblSelecionarOS;
        private System.Windows.Forms.TextBox txtSelecionarOS;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.ComboBox comboPrioridade;
    }
}
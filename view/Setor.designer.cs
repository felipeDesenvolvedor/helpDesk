namespace view
{
    partial class Setor
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSetor = new System.Windows.Forms.TextBox();
            this.DgvSetor = new System.Windows.Forms.DataGridView();
            this.Btnadicionar = new System.Windows.Forms.Button();
            this.Btnselecionar = new System.Windows.Forms.Button();
            this.Btnexcluir = new System.Windows.Forms.Button();
            this.Btnvoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSetor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do setor";
            // 
            // TxtSetor
            // 
            this.TxtSetor.Location = new System.Drawing.Point(104, 28);
            this.TxtSetor.Name = "TxtSetor";
            this.TxtSetor.Size = new System.Drawing.Size(100, 20);
            this.TxtSetor.TabIndex = 1;
            // 
            // DgvSetor
            // 
            this.DgvSetor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSetor.Location = new System.Drawing.Point(22, 93);
            this.DgvSetor.Name = "DgvSetor";
            this.DgvSetor.Size = new System.Drawing.Size(240, 150);
            this.DgvSetor.TabIndex = 2;
            // 
            // Btnadicionar
            // 
            this.Btnadicionar.Location = new System.Drawing.Point(25, 64);
            this.Btnadicionar.Name = "Btnadicionar";
            this.Btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.Btnadicionar.TabIndex = 3;
            this.Btnadicionar.Text = "Adicionar";
            this.Btnadicionar.UseVisualStyleBackColor = true;
            this.Btnadicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btnselecionar
            // 
            this.Btnselecionar.Location = new System.Drawing.Point(106, 64);
            this.Btnselecionar.Name = "Btnselecionar";
            this.Btnselecionar.Size = new System.Drawing.Size(75, 23);
            this.Btnselecionar.TabIndex = 4;
            this.Btnselecionar.Text = "Selecionar";
            this.Btnselecionar.UseVisualStyleBackColor = true;
            this.Btnselecionar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btnexcluir
            // 
            this.Btnexcluir.Enabled = false;
            this.Btnexcluir.Location = new System.Drawing.Point(187, 64);
            this.Btnexcluir.Name = "Btnexcluir";
            this.Btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.Btnexcluir.TabIndex = 5;
            this.Btnexcluir.Text = "Excluir";
            this.Btnexcluir.UseVisualStyleBackColor = true;
            this.Btnexcluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btnvoltar
            // 
            this.Btnvoltar.Location = new System.Drawing.Point(186, 250);
            this.Btnvoltar.Name = "Btnvoltar";
            this.Btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.Btnvoltar.TabIndex = 6;
            this.Btnvoltar.Text = "Voltar";
            this.Btnvoltar.UseVisualStyleBackColor = true;
            this.Btnvoltar.Click += new System.EventHandler(this.Btnvoltar_Click);
            // 
            // Setor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.ControlBox = false;
            this.Controls.Add(this.Btnvoltar);
            this.Controls.Add(this.Btnexcluir);
            this.Controls.Add(this.Btnselecionar);
            this.Controls.Add(this.Btnadicionar);
            this.Controls.Add(this.DgvSetor);
            this.Controls.Add(this.TxtSetor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Setor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setor";
            this.Load += new System.EventHandler(this.Setor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSetor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSetor;
        private System.Windows.Forms.DataGridView DgvSetor;
        private System.Windows.Forms.Button Btnadicionar;
        private System.Windows.Forms.Button Btnselecionar;
        private System.Windows.Forms.Button Btnexcluir;
        private System.Windows.Forms.Button Btnvoltar;
    }
}
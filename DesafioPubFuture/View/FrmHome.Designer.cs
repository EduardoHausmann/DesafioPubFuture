
namespace View
{
    partial class FrmHome
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlContaSubMenu = new System.Windows.Forms.Panel();
            this.btnContaTransfereSaldo = new System.Windows.Forms.Button();
            this.btnContaListaSaldoTotal = new System.Windows.Forms.Button();
            this.btnContaLista = new System.Windows.Forms.Button();
            this.btnContaCadastro = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.pnlDespesaSubMenu = new System.Windows.Forms.Panel();
            this.btnDespesaListaTotal = new System.Windows.Forms.Button();
            this.btnDespesaLista = new System.Windows.Forms.Button();
            this.btnDespesaCadastro = new System.Windows.Forms.Button();
            this.btnDespesa = new System.Windows.Forms.Button();
            this.pnlReceitaSubMenu = new System.Windows.Forms.Panel();
            this.btnReceitaListaTotal = new System.Windows.Forms.Button();
            this.btnReceitaLista = new System.Windows.Forms.Button();
            this.btnReceitaCadastro = new System.Windows.Forms.Button();
            this.btnReceita = new System.Windows.Forms.Button();
            this.pnlTelaFilha = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlContaSubMenu.SuspendLayout();
            this.pnlDespesaSubMenu.SuspendLayout();
            this.pnlReceitaSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenuLateral.Controls.Add(this.btnSair);
            this.pnlMenuLateral.Controls.Add(this.pnlContaSubMenu);
            this.pnlMenuLateral.Controls.Add(this.btnConta);
            this.pnlMenuLateral.Controls.Add(this.pnlDespesaSubMenu);
            this.pnlMenuLateral.Controls.Add(this.btnDespesa);
            this.pnlMenuLateral.Controls.Add(this.pnlReceitaSubMenu);
            this.pnlMenuLateral.Controls.Add(this.btnReceita);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(250, 561);
            this.pnlMenuLateral.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 601);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(233, 45);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlContaSubMenu
            // 
            this.pnlContaSubMenu.Controls.Add(this.btnContaTransfereSaldo);
            this.pnlContaSubMenu.Controls.Add(this.btnContaListaSaldoTotal);
            this.pnlContaSubMenu.Controls.Add(this.btnContaLista);
            this.pnlContaSubMenu.Controls.Add(this.btnContaCadastro);
            this.pnlContaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContaSubMenu.Location = new System.Drawing.Point(0, 417);
            this.pnlContaSubMenu.Name = "pnlContaSubMenu";
            this.pnlContaSubMenu.Size = new System.Drawing.Size(233, 184);
            this.pnlContaSubMenu.TabIndex = 0;
            // 
            // btnContaTransfereSaldo
            // 
            this.btnContaTransfereSaldo.BackColor = System.Drawing.SystemColors.Control;
            this.btnContaTransfereSaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContaTransfereSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContaTransfereSaldo.FlatAppearance.BorderSize = 0;
            this.btnContaTransfereSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContaTransfereSaldo.Location = new System.Drawing.Point(0, 135);
            this.btnContaTransfereSaldo.Name = "btnContaTransfereSaldo";
            this.btnContaTransfereSaldo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnContaTransfereSaldo.Size = new System.Drawing.Size(233, 45);
            this.btnContaTransfereSaldo.TabIndex = 12;
            this.btnContaTransfereSaldo.Text = "Transferência de Saldo Entre Contas";
            this.btnContaTransfereSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContaTransfereSaldo.UseVisualStyleBackColor = false;
            this.btnContaTransfereSaldo.Click += new System.EventHandler(this.btnContaTransferiSaldo_Click);
            // 
            // btnContaListaSaldoTotal
            // 
            this.btnContaListaSaldoTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContaListaSaldoTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContaListaSaldoTotal.FlatAppearance.BorderSize = 0;
            this.btnContaListaSaldoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContaListaSaldoTotal.Location = new System.Drawing.Point(0, 90);
            this.btnContaListaSaldoTotal.Name = "btnContaListaSaldoTotal";
            this.btnContaListaSaldoTotal.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnContaListaSaldoTotal.Size = new System.Drawing.Size(233, 45);
            this.btnContaListaSaldoTotal.TabIndex = 11;
            this.btnContaListaSaldoTotal.Text = "Saldo Total das Contas";
            this.btnContaListaSaldoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContaListaSaldoTotal.UseVisualStyleBackColor = true;
            this.btnContaListaSaldoTotal.Click += new System.EventHandler(this.btnContaListaSaldoTotal_Click);
            // 
            // btnContaLista
            // 
            this.btnContaLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContaLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContaLista.FlatAppearance.BorderSize = 0;
            this.btnContaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContaLista.Location = new System.Drawing.Point(0, 45);
            this.btnContaLista.Name = "btnContaLista";
            this.btnContaLista.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnContaLista.Size = new System.Drawing.Size(233, 45);
            this.btnContaLista.TabIndex = 10;
            this.btnContaLista.Text = "Lista de Contas";
            this.btnContaLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContaLista.UseVisualStyleBackColor = true;
            this.btnContaLista.Click += new System.EventHandler(this.btnContaLista_Click);
            // 
            // btnContaCadastro
            // 
            this.btnContaCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContaCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContaCadastro.FlatAppearance.BorderSize = 0;
            this.btnContaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContaCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnContaCadastro.Name = "btnContaCadastro";
            this.btnContaCadastro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnContaCadastro.Size = new System.Drawing.Size(233, 45);
            this.btnContaCadastro.TabIndex = 9;
            this.btnContaCadastro.Text = "Cadastro";
            this.btnContaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContaCadastro.UseVisualStyleBackColor = true;
            this.btnContaCadastro.Click += new System.EventHandler(this.btnContaCadastro_Click);
            // 
            // btnConta
            // 
            this.btnConta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnConta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConta.Enabled = false;
            this.btnConta.FlatAppearance.BorderSize = 0;
            this.btnConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConta.Location = new System.Drawing.Point(0, 372);
            this.btnConta.Name = "btnConta";
            this.btnConta.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConta.Size = new System.Drawing.Size(233, 45);
            this.btnConta.TabIndex = 8;
            this.btnConta.Text = "Conta";
            this.btnConta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConta.UseVisualStyleBackColor = true;
            // 
            // pnlDespesaSubMenu
            // 
            this.pnlDespesaSubMenu.Controls.Add(this.btnDespesaListaTotal);
            this.pnlDespesaSubMenu.Controls.Add(this.btnDespesaLista);
            this.pnlDespesaSubMenu.Controls.Add(this.btnDespesaCadastro);
            this.pnlDespesaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDespesaSubMenu.Location = new System.Drawing.Point(0, 231);
            this.pnlDespesaSubMenu.Name = "pnlDespesaSubMenu";
            this.pnlDespesaSubMenu.Size = new System.Drawing.Size(233, 141);
            this.pnlDespesaSubMenu.TabIndex = 0;
            // 
            // btnDespesaListaTotal
            // 
            this.btnDespesaListaTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDespesaListaTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDespesaListaTotal.FlatAppearance.BorderSize = 0;
            this.btnDespesaListaTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesaListaTotal.Location = new System.Drawing.Point(0, 90);
            this.btnDespesaListaTotal.Name = "btnDespesaListaTotal";
            this.btnDespesaListaTotal.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDespesaListaTotal.Size = new System.Drawing.Size(233, 45);
            this.btnDespesaListaTotal.TabIndex = 7;
            this.btnDespesaListaTotal.Text = "Total de Despesas";
            this.btnDespesaListaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespesaListaTotal.UseVisualStyleBackColor = true;
            this.btnDespesaListaTotal.Click += new System.EventHandler(this.btnDespesaListaTotal_Click);
            // 
            // btnDespesaLista
            // 
            this.btnDespesaLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDespesaLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDespesaLista.FlatAppearance.BorderSize = 0;
            this.btnDespesaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesaLista.Location = new System.Drawing.Point(0, 45);
            this.btnDespesaLista.Name = "btnDespesaLista";
            this.btnDespesaLista.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDespesaLista.Size = new System.Drawing.Size(233, 45);
            this.btnDespesaLista.TabIndex = 6;
            this.btnDespesaLista.Text = "Lista de Despesas";
            this.btnDespesaLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespesaLista.UseVisualStyleBackColor = true;
            this.btnDespesaLista.Click += new System.EventHandler(this.btnDespesaLista_Click);
            // 
            // btnDespesaCadastro
            // 
            this.btnDespesaCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDespesaCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDespesaCadastro.FlatAppearance.BorderSize = 0;
            this.btnDespesaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesaCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnDespesaCadastro.Name = "btnDespesaCadastro";
            this.btnDespesaCadastro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDespesaCadastro.Size = new System.Drawing.Size(233, 45);
            this.btnDespesaCadastro.TabIndex = 5;
            this.btnDespesaCadastro.Text = "Cadastro";
            this.btnDespesaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespesaCadastro.UseVisualStyleBackColor = true;
            this.btnDespesaCadastro.Click += new System.EventHandler(this.btnDespesaCadastro_Click);
            // 
            // btnDespesa
            // 
            this.btnDespesa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDespesa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDespesa.Enabled = false;
            this.btnDespesa.FlatAppearance.BorderSize = 0;
            this.btnDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespesa.Location = new System.Drawing.Point(0, 186);
            this.btnDespesa.Name = "btnDespesa";
            this.btnDespesa.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDespesa.Size = new System.Drawing.Size(233, 45);
            this.btnDespesa.TabIndex = 4;
            this.btnDespesa.Text = "Despesa";
            this.btnDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDespesa.UseVisualStyleBackColor = true;
            // 
            // pnlReceitaSubMenu
            // 
            this.pnlReceitaSubMenu.Controls.Add(this.btnReceitaListaTotal);
            this.pnlReceitaSubMenu.Controls.Add(this.btnReceitaLista);
            this.pnlReceitaSubMenu.Controls.Add(this.btnReceitaCadastro);
            this.pnlReceitaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReceitaSubMenu.Location = new System.Drawing.Point(0, 45);
            this.pnlReceitaSubMenu.Name = "pnlReceitaSubMenu";
            this.pnlReceitaSubMenu.Size = new System.Drawing.Size(233, 141);
            this.pnlReceitaSubMenu.TabIndex = 0;
            // 
            // btnReceitaListaTotal
            // 
            this.btnReceitaListaTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceitaListaTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceitaListaTotal.FlatAppearance.BorderSize = 0;
            this.btnReceitaListaTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceitaListaTotal.Location = new System.Drawing.Point(0, 90);
            this.btnReceitaListaTotal.Name = "btnReceitaListaTotal";
            this.btnReceitaListaTotal.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReceitaListaTotal.Size = new System.Drawing.Size(233, 45);
            this.btnReceitaListaTotal.TabIndex = 0;
            this.btnReceitaListaTotal.Text = "Total de Receita";
            this.btnReceitaListaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitaListaTotal.UseVisualStyleBackColor = true;
            this.btnReceitaListaTotal.Click += new System.EventHandler(this.btnReceitaListaTotal_Click);
            // 
            // btnReceitaLista
            // 
            this.btnReceitaLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceitaLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceitaLista.FlatAppearance.BorderSize = 0;
            this.btnReceitaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceitaLista.Location = new System.Drawing.Point(0, 45);
            this.btnReceitaLista.Name = "btnReceitaLista";
            this.btnReceitaLista.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReceitaLista.Size = new System.Drawing.Size(233, 45);
            this.btnReceitaLista.TabIndex = 3;
            this.btnReceitaLista.Text = "Lista de Receitas";
            this.btnReceitaLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitaLista.UseVisualStyleBackColor = true;
            this.btnReceitaLista.Click += new System.EventHandler(this.btnReceitaLista_Click);
            // 
            // btnReceitaCadastro
            // 
            this.btnReceitaCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceitaCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceitaCadastro.FlatAppearance.BorderSize = 0;
            this.btnReceitaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceitaCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnReceitaCadastro.Name = "btnReceitaCadastro";
            this.btnReceitaCadastro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReceitaCadastro.Size = new System.Drawing.Size(233, 45);
            this.btnReceitaCadastro.TabIndex = 2;
            this.btnReceitaCadastro.Text = "Cadastro";
            this.btnReceitaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitaCadastro.UseVisualStyleBackColor = true;
            this.btnReceitaCadastro.Click += new System.EventHandler(this.btnReceitaCadastro_Click);
            // 
            // btnReceita
            // 
            this.btnReceita.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnReceita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceita.Enabled = false;
            this.btnReceita.FlatAppearance.BorderSize = 0;
            this.btnReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceita.Location = new System.Drawing.Point(0, 0);
            this.btnReceita.Name = "btnReceita";
            this.btnReceita.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReceita.Size = new System.Drawing.Size(233, 45);
            this.btnReceita.TabIndex = 1;
            this.btnReceita.Text = "Receita";
            this.btnReceita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceita.UseVisualStyleBackColor = true;
            // 
            // pnlTelaFilha
            // 
            this.pnlTelaFilha.BackColor = System.Drawing.Color.White;
            this.pnlTelaFilha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTelaFilha.Location = new System.Drawing.Point(250, 61);
            this.pnlTelaFilha.Name = "pnlTelaFilha";
            this.pnlTelaFilha.Size = new System.Drawing.Size(684, 500);
            this.pnlTelaFilha.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(282, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(86, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Home";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlTelaFilha);
            this.Controls.Add(this.pnlMenuLateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlContaSubMenu.ResumeLayout(false);
            this.pnlDespesaSubMenu.ResumeLayout(false);
            this.pnlReceitaSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Button btnReceita;
        private System.Windows.Forms.Panel pnlReceitaSubMenu;
        private System.Windows.Forms.Button btnReceitaCadastro;
        private System.Windows.Forms.Button btnReceitaListaTotal;
        private System.Windows.Forms.Button btnReceitaLista;
        private System.Windows.Forms.Panel pnlDespesaSubMenu;
        private System.Windows.Forms.Button btnDespesaListaTotal;
        private System.Windows.Forms.Button btnDespesaLista;
        private System.Windows.Forms.Button btnDespesaCadastro;
        private System.Windows.Forms.Button btnDespesa;
        private System.Windows.Forms.Panel pnlContaSubMenu;
        private System.Windows.Forms.Button btnContaTransfereSaldo;
        private System.Windows.Forms.Button btnContaListaSaldoTotal;
        private System.Windows.Forms.Button btnContaLista;
        private System.Windows.Forms.Button btnContaCadastro;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Panel pnlTelaFilha;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Label lblTitulo;
    }
}


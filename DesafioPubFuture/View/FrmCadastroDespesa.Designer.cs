
namespace View
{
    partial class FrmCadastroDespesa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbConta = new System.Windows.Forms.ComboBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.dtpPagamentoEsperado = new System.Windows.Forms.DateTimePicker();
            this.lblPagamentoEsperado = new System.Windows.Forms.Label();
            this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.cbTipoDespesa = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.mbValor = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvDespesa = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // cbConta
            // 
            this.cbConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConta.FormattingEnabled = true;
            this.cbConta.Items.AddRange(new object[] {
            ""});
            this.cbConta.Location = new System.Drawing.Point(213, 168);
            this.cbConta.Name = "cbConta";
            this.cbConta.Size = new System.Drawing.Size(254, 24);
            this.cbConta.TabIndex = 5;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(213, 148);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(45, 17);
            this.lblConta.TabIndex = 0;
            this.lblConta.Text = "Conta";
            // 
            // dtpPagamentoEsperado
            // 
            this.dtpPagamentoEsperado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagamentoEsperado.Location = new System.Drawing.Point(352, 119);
            this.dtpPagamentoEsperado.Name = "dtpPagamentoEsperado";
            this.dtpPagamentoEsperado.Size = new System.Drawing.Size(254, 23);
            this.dtpPagamentoEsperado.TabIndex = 4;
            // 
            // lblPagamentoEsperado
            // 
            this.lblPagamentoEsperado.AutoSize = true;
            this.lblPagamentoEsperado.Location = new System.Drawing.Point(352, 99);
            this.lblPagamentoEsperado.Name = "lblPagamentoEsperado";
            this.lblPagamentoEsperado.Size = new System.Drawing.Size(199, 17);
            this.lblPagamentoEsperado.TabIndex = 0;
            this.lblPagamentoEsperado.Text = "Data do Pagamento Esperado";
            // 
            // dtpPagamento
            // 
            this.dtpPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagamento.Location = new System.Drawing.Point(75, 119);
            this.dtpPagamento.Name = "dtpPagamento";
            this.dtpPagamento.Size = new System.Drawing.Size(254, 23);
            this.dtpPagamento.TabIndex = 3;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(75, 99);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(134, 17);
            this.lblPagamento.TabIndex = 0;
            this.lblPagamento.Text = "Data do Pagamento\r\n";
            // 
            // cbTipoDespesa
            // 
            this.cbTipoDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoDespesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDespesa.FormattingEnabled = true;
            this.cbTipoDespesa.Items.AddRange(new object[] {
            "Alimentação",
            "Educação",
            "Lazer",
            "Moradia",
            "Roupa",
            "Saúde",
            "Transporte",
            "Outros"});
            this.cbTipoDespesa.Location = new System.Drawing.Point(352, 63);
            this.cbTipoDespesa.Name = "cbTipoDespesa";
            this.cbTipoDespesa.Size = new System.Drawing.Size(254, 24);
            this.cbTipoDespesa.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(352, 43);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(116, 17);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo de Despesa";
            // 
            // mbValor
            // 
            this.mbValor.Location = new System.Drawing.Point(75, 64);
            this.mbValor.Name = "mbValor";
            this.mbValor.Size = new System.Drawing.Size(254, 23);
            this.mbValor.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(75, 43);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 17);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(384, 198);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 35);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(303, 199);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 35);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(222, 199);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 35);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvDespesa
            // 
            this.dgvDespesa.AllowUserToAddRows = false;
            this.dgvDespesa.AllowUserToDeleteRows = false;
            this.dgvDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column4,
            this.Column5,
            this.tipo,
            this.Column2,
            this.Column3});
            this.dgvDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDespesa.Location = new System.Drawing.Point(50, 244);
            this.dgvDespesa.Name = "dgvDespesa";
            this.dgvDespesa.ReadOnly = true;
            this.dgvDespesa.RowHeadersVisible = false;
            this.dgvDespesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesa.Size = new System.Drawing.Size(581, 244);
            this.dgvDespesa.TabIndex = 0;
            this.dgvDespesa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespesa_CellClick);
            // 
            // Id
            // 
            dataGridViewCellStyle5.NullValue = null;
            this.Id.DefaultCellStyle = dataGridViewCellStyle5;
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 75;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Conta";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Valor";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo Receita";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 125;
            // 
            // Column2
            // 
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column2.HeaderText = "Data Pagam.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "Data Pagam. Esper.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(26, 4);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(0, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 25);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmCadastroDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 500);
            this.Controls.Add(this.cbConta);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.dtpPagamentoEsperado);
            this.Controls.Add(this.lblPagamentoEsperado);
            this.Controls.Add(this.dtpPagamento);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.cbTipoDespesa);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.mbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvDespesa);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadastroDespesa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConta;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.DateTimePicker dtpPagamentoEsperado;
        private System.Windows.Forms.Label lblPagamentoEsperado;
        private System.Windows.Forms.DateTimePicker dtpPagamento;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.ComboBox cbTipoDespesa;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.MaskedTextBox mbValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvDespesa;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
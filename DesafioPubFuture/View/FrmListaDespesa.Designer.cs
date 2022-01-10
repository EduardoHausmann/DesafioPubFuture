
namespace View
{
    partial class FrmListaDespesa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.dgvDespesa = new System.Windows.Forms.DataGridView();
            this.dtpPagamentoEsperado = new System.Windows.Forms.DateTimePicker();
            this.lblPagamentoEsperado = new System.Windows.Forms.Label();
            this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.rbTipoDespesa = new System.Windows.Forms.RadioButton();
            this.rbPeriodo = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbTipoDespesa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Location = new System.Drawing.Point(570, 77);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 35);
            this.btnFiltro.TabIndex = 33;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
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
            this.dgvDespesa.Location = new System.Drawing.Point(31, 125);
            this.dgvDespesa.Name = "dgvDespesa";
            this.dgvDespesa.ReadOnly = true;
            this.dgvDespesa.RowHeadersVisible = false;
            this.dgvDespesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesa.Size = new System.Drawing.Size(614, 363);
            this.dgvDespesa.TabIndex = 32;
            // 
            // dtpPagamentoEsperado
            // 
            this.dtpPagamentoEsperado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagamentoEsperado.Location = new System.Drawing.Point(371, 84);
            this.dtpPagamentoEsperado.Name = "dtpPagamentoEsperado";
            this.dtpPagamentoEsperado.Size = new System.Drawing.Size(154, 23);
            this.dtpPagamentoEsperado.TabIndex = 31;
            // 
            // lblPagamentoEsperado
            // 
            this.lblPagamentoEsperado.AutoSize = true;
            this.lblPagamentoEsperado.Location = new System.Drawing.Point(371, 63);
            this.lblPagamentoEsperado.Name = "lblPagamentoEsperado";
            this.lblPagamentoEsperado.Size = new System.Drawing.Size(199, 17);
            this.lblPagamentoEsperado.TabIndex = 28;
            this.lblPagamentoEsperado.Text = "Data do Pagamento Esperado";
            // 
            // dtpPagamento
            // 
            this.dtpPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagamento.Location = new System.Drawing.Point(201, 84);
            this.dtpPagamento.Name = "dtpPagamento";
            this.dtpPagamento.Size = new System.Drawing.Size(154, 23);
            this.dtpPagamento.TabIndex = 30;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(201, 62);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(134, 17);
            this.lblPagamento.TabIndex = 29;
            this.lblPagamento.Text = "Data do Pagamento\r\n";
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.rbTipoDespesa);
            this.gbFiltro.Controls.Add(this.rbPeriodo);
            this.gbFiltro.Location = new System.Drawing.Point(31, 0);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(231, 50);
            this.gbFiltro.TabIndex = 26;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtrar Por:";
            // 
            // rbTipoDespesa
            // 
            this.rbTipoDespesa.AutoSize = true;
            this.rbTipoDespesa.Checked = true;
            this.rbTipoDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTipoDespesa.Location = new System.Drawing.Point(6, 22);
            this.rbTipoDespesa.Name = "rbTipoDespesa";
            this.rbTipoDespesa.Size = new System.Drawing.Size(134, 21);
            this.rbTipoDespesa.TabIndex = 0;
            this.rbTipoDespesa.TabStop = true;
            this.rbTipoDespesa.Text = "Tipo de Despesa";
            this.rbTipoDespesa.UseVisualStyleBackColor = true;
            this.rbTipoDespesa.CheckedChanged += new System.EventHandler(this.rbTipoDespesa_CheckedChanged);
            // 
            // rbPeriodo
            // 
            this.rbPeriodo.AutoSize = true;
            this.rbPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPeriodo.Location = new System.Drawing.Point(146, 22);
            this.rbPeriodo.Name = "rbPeriodo";
            this.rbPeriodo.Size = new System.Drawing.Size(75, 21);
            this.rbPeriodo.TabIndex = 0;
            this.rbPeriodo.Text = "Periodo";
            this.rbPeriodo.UseVisualStyleBackColor = true;
            this.rbPeriodo.CheckedChanged += new System.EventHandler(this.rbPeriodo_CheckedChanged);
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
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.cbTipoDespesa.Location = new System.Drawing.Point(31, 83);
            this.cbTipoDespesa.Name = "cbTipoDespesa";
            this.cbTipoDespesa.Size = new System.Drawing.Size(154, 24);
            this.cbTipoDespesa.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tipo de Despesa";
            // 
            // Id
            // 
            dataGridViewCellStyle13.NullValue = null;
            this.Id.DefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Format = "d";
            dataGridViewCellStyle15.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column2.HeaderText = "Data Pagam.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 135;
            // 
            // Column3
            // 
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column3.HeaderText = "Data Pagam. Esper.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // FrmListaDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 500);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.dgvDespesa);
            this.Controls.Add(this.dtpPagamentoEsperado);
            this.Controls.Add(this.lblPagamentoEsperado);
            this.Controls.Add(this.dtpPagamento);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.cbTipoDespesa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListaDespesa";
            this.Text = "FrmListaDespesa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.DataGridView dgvDespesa;
        private System.Windows.Forms.DateTimePicker dtpPagamentoEsperado;
        private System.Windows.Forms.Label lblPagamentoEsperado;
        private System.Windows.Forms.DateTimePicker dtpPagamento;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.RadioButton rbTipoDespesa;
        private System.Windows.Forms.RadioButton rbPeriodo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbTipoDespesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
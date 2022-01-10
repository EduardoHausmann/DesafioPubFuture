
namespace View
{
    partial class FrmListaReceita
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
            this.btnSair = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.rbTipoReceita = new System.Windows.Forms.RadioButton();
            this.rbPeriodo = new System.Windows.Forms.RadioButton();
            this.cbTipoReceita = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.dtpRecebimentoEsperado = new System.Windows.Forms.DateTimePicker();
            this.lblRecebimentoEsperado = new System.Windows.Forms.Label();
            this.dtpRecebimento = new System.Windows.Forms.DateTimePicker();
            this.lblRecebimento = new System.Windows.Forms.Label();
            this.dgvReceita = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceita)).BeginInit();
            this.SuspendLayout();
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
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.rbTipoReceita);
            this.gbFiltro.Controls.Add(this.rbPeriodo);
            this.gbFiltro.Location = new System.Drawing.Point(31, 0);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(220, 50);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtrar Por:";
            // 
            // rbTipoReceita
            // 
            this.rbTipoReceita.AutoSize = true;
            this.rbTipoReceita.Checked = true;
            this.rbTipoReceita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTipoReceita.Location = new System.Drawing.Point(6, 22);
            this.rbTipoReceita.Name = "rbTipoReceita";
            this.rbTipoReceita.Size = new System.Drawing.Size(126, 21);
            this.rbTipoReceita.TabIndex = 0;
            this.rbTipoReceita.TabStop = true;
            this.rbTipoReceita.Text = "Tipo de Receita";
            this.rbTipoReceita.UseVisualStyleBackColor = true;
            this.rbTipoReceita.CheckedChanged += new System.EventHandler(this.rbTipoReceita_CheckedChanged);
            // 
            // rbPeriodo
            // 
            this.rbPeriodo.AutoSize = true;
            this.rbPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPeriodo.Location = new System.Drawing.Point(139, 22);
            this.rbPeriodo.Name = "rbPeriodo";
            this.rbPeriodo.Size = new System.Drawing.Size(75, 21);
            this.rbPeriodo.TabIndex = 0;
            this.rbPeriodo.Text = "Periodo";
            this.rbPeriodo.UseVisualStyleBackColor = true;
            this.rbPeriodo.CheckedChanged += new System.EventHandler(this.rbPeriodo_CheckedChanged);
            // 
            // cbTipoReceita
            // 
            this.cbTipoReceita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoReceita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoReceita.FormattingEnabled = true;
            this.cbTipoReceita.Items.AddRange(new object[] {
            "Salário",
            "Presente",
            "Prêmio",
            "Outros"});
            this.cbTipoReceita.Location = new System.Drawing.Point(31, 83);
            this.cbTipoReceita.Name = "cbTipoReceita";
            this.cbTipoReceita.Size = new System.Drawing.Size(154, 24);
            this.cbTipoReceita.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(31, 63);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(108, 17);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de Receita";
            // 
            // dtpRecebimentoEsperado
            // 
            this.dtpRecebimentoEsperado.Enabled = false;
            this.dtpRecebimentoEsperado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecebimentoEsperado.Location = new System.Drawing.Point(371, 84);
            this.dtpRecebimentoEsperado.Name = "dtpRecebimentoEsperado";
            this.dtpRecebimentoEsperado.Size = new System.Drawing.Size(154, 23);
            this.dtpRecebimentoEsperado.TabIndex = 9;
            // 
            // lblRecebimentoEsperado
            // 
            this.lblRecebimentoEsperado.AutoSize = true;
            this.lblRecebimentoEsperado.Location = new System.Drawing.Point(371, 63);
            this.lblRecebimentoEsperado.Name = "lblRecebimentoEsperado";
            this.lblRecebimentoEsperado.Size = new System.Drawing.Size(210, 17);
            this.lblRecebimentoEsperado.TabIndex = 6;
            this.lblRecebimentoEsperado.Text = "Data do Recebimento Esperado";
            // 
            // dtpRecebimento
            // 
            this.dtpRecebimento.Enabled = false;
            this.dtpRecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecebimento.Location = new System.Drawing.Point(201, 83);
            this.dtpRecebimento.Name = "dtpRecebimento";
            this.dtpRecebimento.Size = new System.Drawing.Size(154, 23);
            this.dtpRecebimento.TabIndex = 8;
            // 
            // lblRecebimento
            // 
            this.lblRecebimento.AutoSize = true;
            this.lblRecebimento.Location = new System.Drawing.Point(201, 62);
            this.lblRecebimento.Name = "lblRecebimento";
            this.lblRecebimento.Size = new System.Drawing.Size(145, 17);
            this.lblRecebimento.TabIndex = 7;
            this.lblRecebimento.Text = "Data do Recebimento";
            // 
            // dgvReceita
            // 
            this.dgvReceita.AllowUserToAddRows = false;
            this.dgvReceita.AllowUserToDeleteRows = false;
            this.dgvReceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column4,
            this.Column5,
            this.Column1,
            this.tipo,
            this.Column2,
            this.Column3});
            this.dgvReceita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvReceita.Location = new System.Drawing.Point(10, 125);
            this.dgvReceita.Name = "dgvReceita";
            this.dgvReceita.ReadOnly = true;
            this.dgvReceita.RowHeadersVisible = false;
            this.dgvReceita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceita.Size = new System.Drawing.Size(664, 363);
            this.dgvReceita.TabIndex = 10;
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
            // Column1
            // 
            this.Column1.HeaderText = "Descrição";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
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
            this.Column2.HeaderText = "Data Receb.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "Data Receb. Esper.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Location = new System.Drawing.Point(599, 77);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 35);
            this.btnFiltro.TabIndex = 11;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // FrmListaReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 500);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.dgvReceita);
            this.Controls.Add(this.dtpRecebimentoEsperado);
            this.Controls.Add(this.lblRecebimentoEsperado);
            this.Controls.Add(this.dtpRecebimento);
            this.Controls.Add(this.lblRecebimento);
            this.Controls.Add(this.cbTipoReceita);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListaReceita";
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.RadioButton rbTipoReceita;
        private System.Windows.Forms.RadioButton rbPeriodo;
        private System.Windows.Forms.ComboBox cbTipoReceita;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DateTimePicker dtpRecebimentoEsperado;
        private System.Windows.Forms.Label lblRecebimentoEsperado;
        private System.Windows.Forms.DateTimePicker dtpRecebimento;
        private System.Windows.Forms.Label lblRecebimento;
        private System.Windows.Forms.DataGridView dgvReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnFiltro;
    }
}
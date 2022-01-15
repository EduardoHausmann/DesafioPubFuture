
namespace View
{
    partial class FrmSaldoTotalConta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvConta = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstituicaoFinanceira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConta)).BeginInit();
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
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvConta
            // 
            this.dgvConta.AllowUserToAddRows = false;
            this.dgvConta.AllowUserToDeleteRows = false;
            this.dgvConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Saldo,
            this.TipoConta,
            this.InstituicaoFinanceira});
            this.dgvConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvConta.Location = new System.Drawing.Point(70, 43);
            this.dgvConta.Name = "dgvConta";
            this.dgvConta.ReadOnly = true;
            this.dgvConta.RowHeadersVisible = false;
            this.dgvConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConta.Size = new System.Drawing.Size(543, 341);
            this.dgvConta.TabIndex = 3;
            // 
            // Id
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.Id.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 75;
            // 
            // Saldo
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 140;
            // 
            // TipoConta
            // 
            this.TipoConta.HeaderText = "Tipo de Conta";
            this.TipoConta.Name = "TipoConta";
            this.TipoConta.ReadOnly = true;
            this.TipoConta.Width = 150;
            // 
            // InstituicaoFinanceira
            // 
            this.InstituicaoFinanceira.HeaderText = "Instituição Financeira";
            this.InstituicaoFinanceira.Name = "InstituicaoFinanceira";
            this.InstituicaoFinanceira.ReadOnly = true;
            this.InstituicaoFinanceira.Width = 250;
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.Location = new System.Drawing.Point(154, 423);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(201, 31);
            this.lblSaldoTotal.TabIndex = 25;
            this.lblSaldoTotal.Text = "Saldo Total: R$";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(361, 423);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(29, 31);
            this.lblValor.TabIndex = 25;
            this.lblValor.Text = "0";
            // 
            // FrmSaldoTotalConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 500);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblSaldoTotal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvConta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSaldoTotalConta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstituicaoFinanceira;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label lblValor;
    }
}
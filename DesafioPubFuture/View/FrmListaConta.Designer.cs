
namespace View
{
    partial class FrmListaConta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvConta = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstituicaoFinanceira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConta)).BeginInit();
            this.SuspendLayout();
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
            this.dgvConta.Location = new System.Drawing.Point(77, 63);
            this.dgvConta.Name = "dgvConta";
            this.dgvConta.ReadOnly = true;
            this.dgvConta.RowHeadersVisible = false;
            this.dgvConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConta.Size = new System.Drawing.Size(543, 382);
            this.dgvConta.TabIndex = 1;
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
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Id
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 75;
            // 
            // Saldo
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle2;
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
            // FrmListaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 500);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvConta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListaConta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstituicaoFinanceira;
    }
}
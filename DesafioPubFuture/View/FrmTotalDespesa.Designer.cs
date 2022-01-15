
namespace View
{
    partial class FrmTotalDespesa
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
            this.dgvDespesa = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).BeginInit();
            this.SuspendLayout();
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
            this.dgvDespesa.Location = new System.Drawing.Point(34, 27);
            this.dgvDespesa.Name = "dgvDespesa";
            this.dgvDespesa.ReadOnly = true;
            this.dgvDespesa.RowHeadersVisible = false;
            this.dgvDespesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesa.Size = new System.Drawing.Size(614, 363);
            this.dgvDespesa.TabIndex = 34;
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
            this.Column2.Width = 135;
            // 
            // Column3
            // 
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "Data Pagam. Esper.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
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
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(376, 421);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(29, 31);
            this.lblValor.TabIndex = 35;
            this.lblValor.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(79, 421);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(291, 31);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "Total de Despesas: R$";
            // 
            // FrmTotalDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 500);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDespesa);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTotalDespesa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTotal;
    }
}
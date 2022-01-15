
namespace View
{
    partial class FrmTotalReceita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReceita = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceita)).BeginInit();
            this.SuspendLayout();
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
            this.dgvReceita.Location = new System.Drawing.Point(12, 31);
            this.dgvReceita.Name = "dgvReceita";
            this.dgvReceita.ReadOnly = true;
            this.dgvReceita.RowHeadersVisible = false;
            this.dgvReceita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceita.Size = new System.Drawing.Size(664, 363);
            this.dgvReceita.TabIndex = 12;
            // 
            // Id
            // 
            dataGridViewCellStyle9.NullValue = null;
            this.Id.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column2.HeaderText = "Data Receb.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column3.HeaderText = "Data Receb. Esper.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
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
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(366, 425);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(29, 31);
            this.lblValor.TabIndex = 37;
            this.lblValor.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(84, 425);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(276, 31);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "Total de Receitas: R$";
            // 
            // FrmTotalReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 500);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvReceita);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTotalReceita";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTotal;
    }
}
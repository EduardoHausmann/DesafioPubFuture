
namespace View
{
    partial class FrmTranfereSaldoConta
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
            this.cbContaOrigem = new System.Windows.Forms.ComboBox();
            this.lblContaOrigem = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.lblContaDestino = new System.Windows.Forms.Label();
            this.cbContaDestino = new System.Windows.Forms.ComboBox();
            this.mbSaldoOrigem = new System.Windows.Forms.MaskedTextBox();
            this.lblSaldoOrigem = new System.Windows.Forms.Label();
            this.lblSaldoDestino = new System.Windows.Forms.Label();
            this.mbSaldoDestino = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.mbValor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cbContaOrigem
            // 
            this.cbContaOrigem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbContaOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContaOrigem.FormattingEnabled = true;
            this.cbContaOrigem.Items.AddRange(new object[] {
            ""});
            this.cbContaOrigem.Location = new System.Drawing.Point(12, 40);
            this.cbContaOrigem.Name = "cbContaOrigem";
            this.cbContaOrigem.Size = new System.Drawing.Size(218, 24);
            this.cbContaOrigem.TabIndex = 1;
            this.cbContaOrigem.SelectedValueChanged += new System.EventHandler(this.cbContaOrigem_SelectedValueChanged);
            // 
            // lblContaOrigem
            // 
            this.lblContaOrigem.AutoSize = true;
            this.lblContaOrigem.Location = new System.Drawing.Point(12, 20);
            this.lblContaOrigem.Name = "lblContaOrigem";
            this.lblContaOrigem.Size = new System.Drawing.Size(115, 17);
            this.lblContaOrigem.TabIndex = 0;
            this.lblContaOrigem.Text = "Conta de Origem";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransferir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.Location = new System.Drawing.Point(397, 153);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(85, 35);
            this.btnTransferir.TabIndex = 6;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // lblContaDestino
            // 
            this.lblContaDestino.AutoSize = true;
            this.lblContaDestino.Location = new System.Drawing.Point(264, 20);
            this.lblContaDestino.Name = "lblContaDestino";
            this.lblContaDestino.Size = new System.Drawing.Size(117, 17);
            this.lblContaDestino.TabIndex = 0;
            this.lblContaDestino.Text = "Conta de Destino";
            // 
            // cbContaDestino
            // 
            this.cbContaDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbContaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContaDestino.FormattingEnabled = true;
            this.cbContaDestino.Items.AddRange(new object[] {
            ""});
            this.cbContaDestino.Location = new System.Drawing.Point(264, 40);
            this.cbContaDestino.Name = "cbContaDestino";
            this.cbContaDestino.Size = new System.Drawing.Size(218, 24);
            this.cbContaDestino.TabIndex = 2;
            this.cbContaDestino.SelectedValueChanged += new System.EventHandler(this.cbContaDestino_SelectedValueChanged);
            // 
            // mbSaldoOrigem
            // 
            this.mbSaldoOrigem.Enabled = false;
            this.mbSaldoOrigem.Location = new System.Drawing.Point(12, 100);
            this.mbSaldoOrigem.Name = "mbSaldoOrigem";
            this.mbSaldoOrigem.Size = new System.Drawing.Size(218, 23);
            this.mbSaldoOrigem.TabIndex = 3;
            this.mbSaldoOrigem.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lblSaldoOrigem
            // 
            this.lblSaldoOrigem.AutoSize = true;
            this.lblSaldoOrigem.Location = new System.Drawing.Point(12, 79);
            this.lblSaldoOrigem.Name = "lblSaldoOrigem";
            this.lblSaldoOrigem.Size = new System.Drawing.Size(94, 17);
            this.lblSaldoOrigem.TabIndex = 0;
            this.lblSaldoOrigem.Text = "Saldo Origem";
            // 
            // lblSaldoDestino
            // 
            this.lblSaldoDestino.AutoSize = true;
            this.lblSaldoDestino.Location = new System.Drawing.Point(264, 79);
            this.lblSaldoDestino.Name = "lblSaldoDestino";
            this.lblSaldoDestino.Size = new System.Drawing.Size(96, 17);
            this.lblSaldoDestino.TabIndex = 0;
            this.lblSaldoDestino.Text = "Saldo Destino";
            // 
            // mbSaldoDestino
            // 
            this.mbSaldoDestino.Enabled = false;
            this.mbSaldoDestino.Location = new System.Drawing.Point(264, 100);
            this.mbSaldoDestino.Name = "mbSaldoDestino";
            this.mbSaldoDestino.Size = new System.Drawing.Size(218, 23);
            this.mbSaldoDestino.TabIndex = 4;
            this.mbSaldoDestino.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(138, 144);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 17);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // mbValor
            // 
            this.mbValor.Location = new System.Drawing.Point(138, 165);
            this.mbValor.Name = "mbValor";
            this.mbValor.Size = new System.Drawing.Size(218, 23);
            this.mbValor.TabIndex = 5;
            this.mbValor.Text = "0";
            // 
            // FrmTranfereSaldoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 207);
            this.Controls.Add(this.mbSaldoDestino);
            this.Controls.Add(this.lblSaldoDestino);
            this.Controls.Add(this.mbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.mbSaldoOrigem);
            this.Controls.Add(this.lblSaldoOrigem);
            this.Controls.Add(this.cbContaDestino);
            this.Controls.Add(this.lblContaDestino);
            this.Controls.Add(this.cbContaOrigem);
            this.Controls.Add(this.lblContaOrigem);
            this.Controls.Add(this.btnTransferir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(510, 246);
            this.MinimumSize = new System.Drawing.Size(510, 246);
            this.Name = "FrmTranfereSaldoConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbContaOrigem;
        private System.Windows.Forms.Label lblContaOrigem;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Label lblContaDestino;
        private System.Windows.Forms.ComboBox cbContaDestino;
        private System.Windows.Forms.MaskedTextBox mbSaldoOrigem;
        private System.Windows.Forms.Label lblSaldoOrigem;
        private System.Windows.Forms.Label lblSaldoDestino;
        private System.Windows.Forms.MaskedTextBox mbSaldoDestino;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MaskedTextBox mbValor;
    }
}

namespace FuncaoMultiRetorno
{
    partial class Exec03
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
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            this.IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEmCaixaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DespesasDoMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GanhosDoMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeLucrouCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbGanhosDoMes = new System.Windows.Forms.Label();
            this.lbDespesasDoMes = new System.Windows.Forms.Label();
            this.txtGanhos = new System.Windows.Forms.TextBox();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistorico
            // 
            this.dgHistorico.AllowUserToAddRows = false;
            this.dgHistorico.AllowUserToDeleteRows = false;
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCol,
            this.ValorEmCaixaCol,
            this.DespesasDoMesCol,
            this.GanhosDoMesCol,
            this.ValorLiquidoCol,
            this.SeLucrouCol});
            this.dgHistorico.Location = new System.Drawing.Point(12, 1);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.ReadOnly = true;
            this.dgHistorico.Size = new System.Drawing.Size(871, 263);
            this.dgHistorico.TabIndex = 0;
            // 
            // IDCol
            // 
            this.IDCol.HeaderText = "ID";
            this.IDCol.Name = "IDCol";
            this.IDCol.ReadOnly = true;
            // 
            // ValorEmCaixaCol
            // 
            this.ValorEmCaixaCol.HeaderText = "ValorEmCaixa";
            this.ValorEmCaixaCol.Name = "ValorEmCaixaCol";
            this.ValorEmCaixaCol.ReadOnly = true;
            // 
            // DespesasDoMesCol
            // 
            this.DespesasDoMesCol.HeaderText = "DespesasDoMes";
            this.DespesasDoMesCol.Name = "DespesasDoMesCol";
            this.DespesasDoMesCol.ReadOnly = true;
            // 
            // GanhosDoMesCol
            // 
            this.GanhosDoMesCol.HeaderText = "GanhosDoMes";
            this.GanhosDoMesCol.Name = "GanhosDoMesCol";
            this.GanhosDoMesCol.ReadOnly = true;
            // 
            // ValorLiquidoCol
            // 
            this.ValorLiquidoCol.HeaderText = "ValorLiquido";
            this.ValorLiquidoCol.Name = "ValorLiquidoCol";
            this.ValorLiquidoCol.ReadOnly = true;
            // 
            // SeLucrouCol
            // 
            this.SeLucrouCol.HeaderText = "SeLucrou";
            this.SeLucrouCol.Name = "SeLucrouCol";
            this.SeLucrouCol.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(782, 352);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbGanhosDoMes
            // 
            this.lbGanhosDoMes.AutoSize = true;
            this.lbGanhosDoMes.Location = new System.Drawing.Point(41, 295);
            this.lbGanhosDoMes.Name = "lbGanhosDoMes";
            this.lbGanhosDoMes.Size = new System.Drawing.Size(82, 13);
            this.lbGanhosDoMes.TabIndex = 2;
            this.lbGanhosDoMes.Text = "Ganhos do Mes";
            // 
            // lbDespesasDoMes
            // 
            this.lbDespesasDoMes.AutoSize = true;
            this.lbDespesasDoMes.Location = new System.Drawing.Point(41, 335);
            this.lbDespesasDoMes.Name = "lbDespesasDoMes";
            this.lbDespesasDoMes.Size = new System.Drawing.Size(94, 13);
            this.lbDespesasDoMes.TabIndex = 3;
            this.lbDespesasDoMes.Text = "Despesas Do Mes";
            // 
            // txtGanhos
            // 
            this.txtGanhos.Location = new System.Drawing.Point(159, 292);
            this.txtGanhos.Name = "txtGanhos";
            this.txtGanhos.Size = new System.Drawing.Size(100, 20);
            this.txtGanhos.TabIndex = 4;
            // 
            // txtDespesas
            // 
            this.txtDespesas.Location = new System.Drawing.Point(159, 332);
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(100, 20);
            this.txtDespesas.TabIndex = 5;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(540, 352);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 6;
            this.btnCalcula.Text = "Calcula Mes";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // Exec03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.txtGanhos);
            this.Controls.Add(this.lbDespesasDoMes);
            this.Controls.Add(this.lbGanhosDoMes);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgHistorico);
            this.Name = "Exec03";
            this.Text = "Exec03";
            this.Load += new System.EventHandler(this.Exec03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEmCaixaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DespesasDoMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GanhosDoMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiquidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeLucrouCol;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbGanhosDoMes;
        private System.Windows.Forms.Label lbDespesasDoMes;
        private System.Windows.Forms.TextBox txtGanhos;
        private System.Windows.Forms.TextBox txtDespesas;
        private System.Windows.Forms.Button btnCalcula;
    }
}
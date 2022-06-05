namespace TestAplikacija
{
    partial class Forma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKlijenti = new System.Windows.Forms.ComboBox();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.btnSqlKod = new System.Windows.Forms.Button();
            this.btnProcedura = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klijent";
            // 
            // cboKlijenti
            // 
            this.cboKlijenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKlijenti.FormattingEnabled = true;
            this.cboKlijenti.Location = new System.Drawing.Point(114, 47);
            this.cboKlijenti.Name = "cboKlijenti";
            this.cboKlijenti.Size = new System.Drawing.Size(352, 24);
            this.cboKlijenti.TabIndex = 1;
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvNarudzbe.Location = new System.Drawing.Point(58, 87);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.RowHeadersWidth = 51;
            this.dgvNarudzbe.RowTemplate.Height = 24;
            this.dgvNarudzbe.Size = new System.Drawing.Size(1229, 827);
            this.dgvNarudzbe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(916, 925);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukupno:";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(1000, 922);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(287, 22);
            this.txtUkupno.TabIndex = 4;
            this.txtUkupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSqlKod
            // 
            this.btnSqlKod.Location = new System.Drawing.Point(517, 43);
            this.btnSqlKod.Name = "btnSqlKod";
            this.btnSqlKod.Size = new System.Drawing.Size(141, 33);
            this.btnSqlKod.TabIndex = 5;
            this.btnSqlKod.Text = "Sql u kodu";
            this.btnSqlKod.UseVisualStyleBackColor = true;
            this.btnSqlKod.Click += new System.EventHandler(this.btnSqlKod_Click);
            // 
            // btnProcedura
            // 
            this.btnProcedura.Location = new System.Drawing.Point(682, 43);
            this.btnProcedura.Name = "btnProcedura";
            this.btnProcedura.Size = new System.Drawing.Size(141, 33);
            this.btnProcedura.TabIndex = 6;
            this.btnProcedura.Text = "Procedura";
            this.btnProcedura.UseVisualStyleBackColor = true;
            this.btnProcedura.Click += new System.EventHandler(this.btnProcedura_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DatumNarudzbe";
            this.Column2.HeaderText = "Datum narudžbe";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ukupno";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Ukupno";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 953);
            this.Controls.Add(this.btnProcedura);
            this.Controls.Add(this.btnSqlKod);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNarudzbe);
            this.Controls.Add(this.cboKlijenti);
            this.Controls.Add(this.label1);
            this.Name = "Forma";
            this.Text = "Narudžbe";
            this.Load += new System.EventHandler(this.Forma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKlijenti;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Button btnSqlKod;
        private System.Windows.Forms.Button btnProcedura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}


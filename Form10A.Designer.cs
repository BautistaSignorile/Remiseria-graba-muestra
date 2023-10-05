namespace Remiseria
{
    partial class Form10A
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
            this.TxtAa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbChofer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnVer = new System.Windows.Forms.Button();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAa
            // 
            this.TxtAa.Location = new System.Drawing.Point(54, 12);
            this.TxtAa.Name = "TxtAa";
            this.TxtAa.Size = new System.Drawing.Size(66, 20);
            this.TxtAa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AÑO";
            // 
            // CbMes
            // 
            this.CbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMes.FormattingEnabled = true;
            this.CbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.CbMes.Location = new System.Drawing.Point(177, 14);
            this.CbMes.Name = "CbMes";
            this.CbMes.Size = new System.Drawing.Size(74, 21);
            this.CbMes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MES";
            // 
            // CbChofer
            // 
            this.CbChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbChofer.FormattingEnabled = true;
            this.CbChofer.Location = new System.Drawing.Point(327, 14);
            this.CbChofer.Name = "CbChofer";
            this.CbChofer.Size = new System.Drawing.Size(172, 21);
            this.CbChofer.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CHOFER";
            // 
            // BtnVer
            // 
            this.BtnVer.Location = new System.Drawing.Point(557, 14);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(75, 23);
            this.BtnVer.TabIndex = 8;
            this.BtnVer.Text = "VER";
            this.BtnVer.UseVisualStyleBackColor = true;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // datagridview1
            // 
            this.datagridview1.AllowUserToAddRows = false;
            this.datagridview1.AllowUserToDeleteRows = false;
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3,
            this.C4,
            this.C5});
            this.datagridview1.Location = new System.Drawing.Point(11, 41);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.ReadOnly = true;
            this.datagridview1.Size = new System.Drawing.Size(664, 307);
            this.datagridview1.TabIndex = 9;
            // 
            // C1
            // 
            this.C1.HeaderText = "FECHA";
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            // 
            // C2
            // 
            this.C2.HeaderText = "DESDE BARRIO";
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            // 
            // C3
            // 
            this.C3.HeaderText = "HASTA BARRIO";
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            // 
            // C4
            // 
            this.C4.HeaderText = "KMS";
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            // 
            // C5
            // 
            this.C5.HeaderText = "IMPORTE";
            this.C5.Name = "C5";
            this.C5.ReadOnly = true;
            // 
            // LblTotal
            // 
            this.LblTotal.BackColor = System.Drawing.Color.Black;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.White;
            this.LblTotal.Location = new System.Drawing.Point(491, 362);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(164, 23);
            this.LblTotal.TabIndex = 11;
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOTAL RECAUDADO =";
            // 
            // Form10A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 394);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datagridview1);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.CbChofer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAa);
            this.Controls.Add(this.label1);
            this.Name = "Form10A";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10A_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbChofer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
        private System.Windows.Forms.DataGridViewTextBoxColumn C5;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label4;
    }
}
namespace Remiseria
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDestino = new System.Windows.Forms.RadioButton();
            this.rbOrigen = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreBarrio,
            this.CantidadTotal});
            this.dataGridView1.Location = new System.Drawing.Point(29, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 342);
            this.dataGridView1.TabIndex = 6;
            // 
            // nombreBarrio
            // 
            this.nombreBarrio.HeaderText = "Nombre Barrio";
            this.nombreBarrio.Name = "nombreBarrio";
            this.nombreBarrio.ReadOnly = true;
            this.nombreBarrio.Width = 300;
            // 
            // CantidadTotal
            // 
            this.CantidadTotal.HeaderText = "Cantidad Total";
            this.CantidadTotal.Name = "CantidadTotal";
            this.CantidadTotal.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(246, 17);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(136, 105);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDestino);
            this.groupBox1.Controls.Add(this.rbOrigen);
            this.groupBox1.Location = new System.Drawing.Point(29, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "barrio";
            // 
            // rbDestino
            // 
            this.rbDestino.AutoSize = true;
            this.rbDestino.Location = new System.Drawing.Point(120, 45);
            this.rbDestino.Name = "rbDestino";
            this.rbDestino.Size = new System.Drawing.Size(59, 17);
            this.rbDestino.TabIndex = 1;
            this.rbDestino.TabStop = true;
            this.rbDestino.Text = "destino";
            this.rbDestino.UseVisualStyleBackColor = true;
            // 
            // rbOrigen
            // 
            this.rbOrigen.AutoSize = true;
            this.rbOrigen.Checked = true;
            this.rbOrigen.Location = new System.Drawing.Point(27, 45);
            this.rbOrigen.Name = "rbOrigen";
            this.rbOrigen.Size = new System.Drawing.Size(54, 17);
            this.rbOrigen.TabIndex = 0;
            this.rbOrigen.TabStop = true;
            this.rbOrigen.Text = "origen";
            this.rbOrigen.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadTotal;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDestino;
        private System.Windows.Forms.RadioButton rbOrigen;
    }
}
namespace MiApp.Interfaces
{
    partial class MercadosForm
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
            this.dataGridViewMercado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuotaOver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuotaUnder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApostadoOver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApostadoUnder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEventos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonMercadosID = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonMercadosView = new System.Windows.Forms.Button();
            this.buttonMercadoDelete = new System.Windows.Forms.Button();
            this.buttonModificarExterno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMercado)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMercado
            // 
            this.dataGridViewMercado.AllowUserToAddRows = false;
            this.dataGridViewMercado.AllowUserToDeleteRows = false;
            this.dataGridViewMercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMercado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Tipo,
            this.CuotaOver,
            this.CuotaUnder,
            this.ApostadoOver,
            this.ApostadoUnder,
            this.IDEventos});
            this.dataGridViewMercado.Location = new System.Drawing.Point(232, 28);
            this.dataGridViewMercado.Name = "dataGridViewMercado";
            this.dataGridViewMercado.ReadOnly = true;
            this.dataGridViewMercado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMercado.Size = new System.Drawing.Size(566, 211);
            this.dataGridViewMercado.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // CuotaOver
            // 
            this.CuotaOver.HeaderText = "Cuota Over";
            this.CuotaOver.Name = "CuotaOver";
            this.CuotaOver.ReadOnly = true;
            // 
            // CuotaUnder
            // 
            this.CuotaUnder.HeaderText = "Cuota Under";
            this.CuotaUnder.Name = "CuotaUnder";
            this.CuotaUnder.ReadOnly = true;
            // 
            // ApostadoOver
            // 
            this.ApostadoOver.HeaderText = "Apostado Over";
            this.ApostadoOver.Name = "ApostadoOver";
            this.ApostadoOver.ReadOnly = true;
            // 
            // ApostadoUnder
            // 
            this.ApostadoUnder.HeaderText = "Apostado Under";
            this.ApostadoUnder.Name = "ApostadoUnder";
            this.ApostadoUnder.ReadOnly = true;
            // 
            // IDEventos
            // 
            this.IDEventos.HeaderText = "ID Eventos";
            this.IDEventos.Name = "IDEventos";
            this.IDEventos.ReadOnly = true;
            // 
            // buttonMercadosID
            // 
            this.buttonMercadosID.Location = new System.Drawing.Point(166, 56);
            this.buttonMercadosID.Name = "buttonMercadosID";
            this.buttonMercadosID.Size = new System.Drawing.Size(60, 23);
            this.buttonMercadosID.TabIndex = 41;
            this.buttonMercadosID.Text = "Search";
            this.buttonMercadosID.UseVisualStyleBackColor = true;
            this.buttonMercadosID.Click += new System.EventHandler(this.buttonMercadosID_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(32, 58);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(128, 20);
            this.textBoxID.TabIndex = 40;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(5, 61);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 39;
            this.labelID.Text = "ID:";
            // 
            // buttonMercadosView
            // 
            this.buttonMercadosView.Location = new System.Drawing.Point(8, 108);
            this.buttonMercadosView.Name = "buttonMercadosView";
            this.buttonMercadosView.Size = new System.Drawing.Size(218, 23);
            this.buttonMercadosView.TabIndex = 42;
            this.buttonMercadosView.Text = "View All";
            this.buttonMercadosView.UseVisualStyleBackColor = true;
            this.buttonMercadosView.Click += new System.EventHandler(this.buttonMercadosView_Click);
            // 
            // buttonMercadoDelete
            // 
            this.buttonMercadoDelete.Location = new System.Drawing.Point(8, 150);
            this.buttonMercadoDelete.Name = "buttonMercadoDelete";
            this.buttonMercadoDelete.Size = new System.Drawing.Size(218, 23);
            this.buttonMercadoDelete.TabIndex = 43;
            this.buttonMercadoDelete.Text = "Delete Mercado";
            this.buttonMercadoDelete.UseVisualStyleBackColor = true;
            this.buttonMercadoDelete.Click += new System.EventHandler(this.buttonMercadoDelete_Click);
            // 
            // buttonModificarExterno
            // 
            this.buttonModificarExterno.Location = new System.Drawing.Point(8, 192);
            this.buttonModificarExterno.Name = "buttonModificarExterno";
            this.buttonModificarExterno.Size = new System.Drawing.Size(222, 47);
            this.buttonModificarExterno.TabIndex = 44;
            this.buttonModificarExterno.Text = "Modificar";
            this.buttonModificarExterno.UseVisualStyleBackColor = true;
            this.buttonModificarExterno.Click += new System.EventHandler(this.buttonModificarExterno_Click);
            // 
            // MercadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 252);
            this.Controls.Add(this.buttonModificarExterno);
            this.Controls.Add(this.buttonMercadoDelete);
            this.Controls.Add(this.buttonMercadosView);
            this.Controls.Add(this.buttonMercadosID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridViewMercado);
            this.Name = "MercadosForm";
            this.Text = "MercadosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMercado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMercado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuotaOver;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuotaUnder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApostadoOver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApostadoUnder;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEventos;
        private System.Windows.Forms.Button buttonMercadosID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonMercadosView;
        private System.Windows.Forms.Button buttonMercadoDelete;
        private System.Windows.Forms.Button buttonModificarExterno;
    }
}
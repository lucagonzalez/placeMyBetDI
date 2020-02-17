namespace MiApp.Interfaces
{
    partial class EventosForm
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
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonEventosID = new System.Windows.Forms.Button();
            this.buttonEventosView = new System.Windows.Forms.Button();
            this.buttonModificarExterno = new System.Windows.Forms.Button();
            this.buttonExternoDelete = new System.Windows.Forms.Button();
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoVisitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 65);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(39, 62);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(128, 20);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // buttonEventosID
            // 
            this.buttonEventosID.Location = new System.Drawing.Point(173, 60);
            this.buttonEventosID.Name = "buttonEventosID";
            this.buttonEventosID.Size = new System.Drawing.Size(60, 23);
            this.buttonEventosID.TabIndex = 5;
            this.buttonEventosID.Text = "Search";
            this.buttonEventosID.UseVisualStyleBackColor = true;
            this.buttonEventosID.Click += new System.EventHandler(this.buttonEventosID_Click);
            // 
            // buttonEventosView
            // 
            this.buttonEventosView.Location = new System.Drawing.Point(12, 144);
            this.buttonEventosView.Name = "buttonEventosView";
            this.buttonEventosView.Size = new System.Drawing.Size(264, 23);
            this.buttonEventosView.TabIndex = 13;
            this.buttonEventosView.Text = "View All";
            this.buttonEventosView.UseVisualStyleBackColor = true;
            this.buttonEventosView.Click += new System.EventHandler(this.buttonEventosView_Click);
            // 
            // buttonModificarExterno
            // 
            this.buttonModificarExterno.Location = new System.Drawing.Point(12, 231);
            this.buttonModificarExterno.Name = "buttonModificarExterno";
            this.buttonModificarExterno.Size = new System.Drawing.Size(264, 47);
            this.buttonModificarExterno.TabIndex = 35;
            this.buttonModificarExterno.Text = "Modificar";
            this.buttonModificarExterno.UseVisualStyleBackColor = true;
            this.buttonModificarExterno.Click += new System.EventHandler(this.buttonModificarExterno_Click);
            // 
            // buttonExternoDelete
            // 
            this.buttonExternoDelete.Location = new System.Drawing.Point(12, 183);
            this.buttonExternoDelete.Name = "buttonExternoDelete";
            this.buttonExternoDelete.Size = new System.Drawing.Size(264, 23);
            this.buttonExternoDelete.TabIndex = 36;
            this.buttonExternoDelete.Text = "Delete evento";
            this.buttonExternoDelete.UseVisualStyleBackColor = true;
            this.buttonExternoDelete.Click += new System.EventHandler(this.buttonExternoDelete_Click);
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.AllowUserToAddRows = false;
            this.dataGridViewEventos.AllowUserToDeleteRows = false;
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Fecha,
            this.EquipoLocal,
            this.EquipoVisitante});
            this.dataGridViewEventos.Location = new System.Drawing.Point(321, 35);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.ReadOnly = true;
            this.dataGridViewEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEventos.Size = new System.Drawing.Size(443, 243);
            this.dataGridViewEventos.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // EquipoLocal
            // 
            this.EquipoLocal.HeaderText = "Equipo Local";
            this.EquipoLocal.Name = "EquipoLocal";
            this.EquipoLocal.ReadOnly = true;
            // 
            // EquipoVisitante
            // 
            this.EquipoVisitante.HeaderText = "Equipo Visitante";
            this.EquipoVisitante.Name = "EquipoVisitante";
            this.EquipoVisitante.ReadOnly = true;
            // 
            // EventosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 320);
            this.Controls.Add(this.dataGridViewEventos);
            this.Controls.Add(this.buttonExternoDelete);
            this.Controls.Add(this.buttonModificarExterno);
            this.Controls.Add(this.buttonEventosView);
            this.Controls.Add(this.buttonEventosID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Name = "EventosForm";
            this.Text = "EventosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonEventosID;
        private System.Windows.Forms.Button buttonEventosView;
        private System.Windows.Forms.Button buttonModificarExterno;
        private System.Windows.Forms.Button buttonExternoDelete;
        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoVisitante;
    }
}
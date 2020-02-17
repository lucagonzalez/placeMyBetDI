namespace MiApp.Interfaces
{
    partial class UpdateEventosForm
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
            this.labelFechaVencimiento = new System.Windows.Forms.Label();
            this.monthCalendarJoinDate = new System.Windows.Forms.MonthCalendar();
            this.EquipoLocal = new System.Windows.Forms.Label();
            this.textBoxEquipoLocal = new System.Windows.Forms.TextBox();
            this.EquipoVisitante = new System.Windows.Forms.Label();
            this.textBoxEquipoVisitante = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxIdentificador = new System.Windows.Forms.TextBox();
            this.labelPatenteID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFechaVencimiento
            // 
            this.labelFechaVencimiento.AutoSize = true;
            this.labelFechaVencimiento.Location = new System.Drawing.Point(65, 78);
            this.labelFechaVencimiento.Name = "labelFechaVencimiento";
            this.labelFechaVencimiento.Size = new System.Drawing.Size(40, 13);
            this.labelFechaVencimiento.TabIndex = 41;
            this.labelFechaVencimiento.Text = "Fecha:";
            // 
            // monthCalendarJoinDate
            // 
            this.monthCalendarJoinDate.Location = new System.Drawing.Point(125, 53);
            this.monthCalendarJoinDate.MaxSelectionCount = 1;
            this.monthCalendarJoinDate.Name = "monthCalendarJoinDate";
            this.monthCalendarJoinDate.TabIndex = 42;
            // 
            // EquipoLocal
            // 
            this.EquipoLocal.AutoSize = true;
            this.EquipoLocal.Location = new System.Drawing.Point(33, 238);
            this.EquipoLocal.Name = "EquipoLocal";
            this.EquipoLocal.Size = new System.Drawing.Size(72, 13);
            this.EquipoLocal.TabIndex = 43;
            this.EquipoLocal.Text = "Equipo Local:";
            // 
            // textBoxEquipoLocal
            // 
            this.textBoxEquipoLocal.Location = new System.Drawing.Point(125, 238);
            this.textBoxEquipoLocal.Name = "textBoxEquipoLocal";
            this.textBoxEquipoLocal.Size = new System.Drawing.Size(192, 20);
            this.textBoxEquipoLocal.TabIndex = 44;
            this.textBoxEquipoLocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEquipoLocal_KeyPress);
            // 
            // EquipoVisitante
            // 
            this.EquipoVisitante.AutoSize = true;
            this.EquipoVisitante.Location = new System.Drawing.Point(19, 283);
            this.EquipoVisitante.Name = "EquipoVisitante";
            this.EquipoVisitante.Size = new System.Drawing.Size(86, 13);
            this.EquipoVisitante.TabIndex = 45;
            this.EquipoVisitante.Text = "Equipo Visitante:";
            // 
            // textBoxEquipoVisitante
            // 
            this.textBoxEquipoVisitante.Location = new System.Drawing.Point(125, 280);
            this.textBoxEquipoVisitante.Name = "textBoxEquipoVisitante";
            this.textBoxEquipoVisitante.Size = new System.Drawing.Size(192, 20);
            this.textBoxEquipoVisitante.TabIndex = 46;
            this.textBoxEquipoVisitante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEquipoVisitante_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(22, 334);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(318, 23);
            this.buttonSave.TabIndex = 47;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(22, 373);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(318, 23);
            this.buttonCancel.TabIndex = 48;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxIdentificador
            // 
            this.textBoxIdentificador.Enabled = false;
            this.textBoxIdentificador.Location = new System.Drawing.Point(125, 21);
            this.textBoxIdentificador.Name = "textBoxIdentificador";
            this.textBoxIdentificador.Size = new System.Drawing.Size(192, 20);
            this.textBoxIdentificador.TabIndex = 49;
            this.textBoxIdentificador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdentificador_KeyPress);
            // 
            // labelPatenteID
            // 
            this.labelPatenteID.AutoSize = true;
            this.labelPatenteID.Location = new System.Drawing.Point(37, 24);
            this.labelPatenteID.Name = "labelPatenteID";
            this.labelPatenteID.Size = new System.Drawing.Size(68, 13);
            this.labelPatenteID.TabIndex = 50;
            this.labelPatenteID.Text = "Identificador:";
            // 
            // UpdateEventosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.labelPatenteID);
            this.Controls.Add(this.textBoxIdentificador);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxEquipoVisitante);
            this.Controls.Add(this.EquipoVisitante);
            this.Controls.Add(this.textBoxEquipoLocal);
            this.Controls.Add(this.EquipoLocal);
            this.Controls.Add(this.monthCalendarJoinDate);
            this.Controls.Add(this.labelFechaVencimiento);
            this.Name = "UpdateEventosForm";
            this.Text = "UpdateEventosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFechaVencimiento;
        private System.Windows.Forms.MonthCalendar monthCalendarJoinDate;
        private System.Windows.Forms.Label EquipoLocal;
        private System.Windows.Forms.TextBox textBoxEquipoLocal;
        private System.Windows.Forms.Label EquipoVisitante;
        private System.Windows.Forms.TextBox textBoxEquipoVisitante;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxIdentificador;
        private System.Windows.Forms.Label labelPatenteID;
    }
}
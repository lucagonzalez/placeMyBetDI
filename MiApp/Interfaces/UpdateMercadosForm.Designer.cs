namespace MiApp.Interfaces
{
    partial class UpdateMercadosForm
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
            this.labelPatenteID = new System.Windows.Forms.Label();
            this.textBoxIdentificador = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxApostadoOver = new System.Windows.Forms.TextBox();
            this.labelCuotaUnder = new System.Windows.Forms.Label();
            this.textBoxCuotaUnder = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelCuotaOver = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.textBoxCuotaOver = new System.Windows.Forms.TextBox();
            this.textBoxApostadoUnder = new System.Windows.Forms.TextBox();
            this.labelApostadoOver = new System.Windows.Forms.Label();
            this.labelApostadoUnder = new System.Windows.Forms.Label();
            this.labelIDEventos = new System.Windows.Forms.Label();
            this.textBoxIDEventos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPatenteID
            // 
            this.labelPatenteID.AutoSize = true;
            this.labelPatenteID.Location = new System.Drawing.Point(65, 30);
            this.labelPatenteID.Name = "labelPatenteID";
            this.labelPatenteID.Size = new System.Drawing.Size(68, 13);
            this.labelPatenteID.TabIndex = 60;
            this.labelPatenteID.Text = "Identificador:";
            // 
            // textBoxIdentificador
            // 
            this.textBoxIdentificador.Enabled = false;
            this.textBoxIdentificador.Location = new System.Drawing.Point(165, 27);
            this.textBoxIdentificador.Name = "textBoxIdentificador";
            this.textBoxIdentificador.Size = new System.Drawing.Size(192, 20);
            this.textBoxIdentificador.TabIndex = 59;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(49, 377);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(318, 23);
            this.buttonCancel.TabIndex = 58;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(49, 334);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(318, 23);
            this.buttonSave.TabIndex = 57;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxApostadoOver
            // 
            this.textBoxApostadoOver.Location = new System.Drawing.Point(165, 200);
            this.textBoxApostadoOver.Name = "textBoxApostadoOver";
            this.textBoxApostadoOver.Size = new System.Drawing.Size(192, 20);
            this.textBoxApostadoOver.TabIndex = 56;
            this.textBoxApostadoOver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApostadoOver_KeyPress);
            // 
            // labelCuotaUnder
            // 
            this.labelCuotaUnder.AutoSize = true;
            this.labelCuotaUnder.Location = new System.Drawing.Point(63, 158);
            this.labelCuotaUnder.Name = "labelCuotaUnder";
            this.labelCuotaUnder.Size = new System.Drawing.Size(70, 13);
            this.labelCuotaUnder.TabIndex = 55;
            this.labelCuotaUnder.Text = "Cuota Under:";
            // 
            // textBoxCuotaUnder
            // 
            this.textBoxCuotaUnder.Location = new System.Drawing.Point(165, 155);
            this.textBoxCuotaUnder.Name = "textBoxCuotaUnder";
            this.textBoxCuotaUnder.Size = new System.Drawing.Size(192, 20);
            this.textBoxCuotaUnder.TabIndex = 54;
            this.textBoxCuotaUnder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCuotaUnder_KeyPress);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(102, 72);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 53;
            this.labelTipo.Text = "Tipo:";
            // 
            // labelCuotaOver
            // 
            this.labelCuotaOver.AutoSize = true;
            this.labelCuotaOver.Location = new System.Drawing.Point(69, 114);
            this.labelCuotaOver.Name = "labelCuotaOver";
            this.labelCuotaOver.Size = new System.Drawing.Size(64, 13);
            this.labelCuotaOver.TabIndex = 51;
            this.labelCuotaOver.Text = "Cuota Over:";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(165, 69);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(192, 20);
            this.textBoxTipo.TabIndex = 61;
            this.textBoxTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTipo_KeyPress);
            // 
            // textBoxCuotaOver
            // 
            this.textBoxCuotaOver.Location = new System.Drawing.Point(165, 111);
            this.textBoxCuotaOver.Name = "textBoxCuotaOver";
            this.textBoxCuotaOver.Size = new System.Drawing.Size(192, 20);
            this.textBoxCuotaOver.TabIndex = 62;
            this.textBoxCuotaOver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCuotaOver_KeyPress);
            // 
            // textBoxApostadoUnder
            // 
            this.textBoxApostadoUnder.Location = new System.Drawing.Point(165, 241);
            this.textBoxApostadoUnder.Name = "textBoxApostadoUnder";
            this.textBoxApostadoUnder.Size = new System.Drawing.Size(192, 20);
            this.textBoxApostadoUnder.TabIndex = 63;
            this.textBoxApostadoUnder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApostadoUnder_KeyPress);
            // 
            // labelApostadoOver
            // 
            this.labelApostadoOver.AutoSize = true;
            this.labelApostadoOver.Location = new System.Drawing.Point(52, 203);
            this.labelApostadoOver.Name = "labelApostadoOver";
            this.labelApostadoOver.Size = new System.Drawing.Size(81, 13);
            this.labelApostadoOver.TabIndex = 65;
            this.labelApostadoOver.Text = "Apostado Over:";
            // 
            // labelApostadoUnder
            // 
            this.labelApostadoUnder.AutoSize = true;
            this.labelApostadoUnder.Location = new System.Drawing.Point(46, 244);
            this.labelApostadoUnder.Name = "labelApostadoUnder";
            this.labelApostadoUnder.Size = new System.Drawing.Size(87, 13);
            this.labelApostadoUnder.TabIndex = 66;
            this.labelApostadoUnder.Text = "Apostado Under:";
            // 
            // labelIDEventos
            // 
            this.labelIDEventos.AutoSize = true;
            this.labelIDEventos.Location = new System.Drawing.Point(70, 290);
            this.labelIDEventos.Name = "labelIDEventos";
            this.labelIDEventos.Size = new System.Drawing.Size(63, 13);
            this.labelIDEventos.TabIndex = 67;
            this.labelIDEventos.Text = "ID Eventos:";
            // 
            // textBoxIDEventos
            // 
            this.textBoxIDEventos.Enabled = false;
            this.textBoxIDEventos.Location = new System.Drawing.Point(165, 287);
            this.textBoxIDEventos.Name = "textBoxIDEventos";
            this.textBoxIDEventos.Size = new System.Drawing.Size(192, 20);
            this.textBoxIDEventos.TabIndex = 68;
            // 
            // UpdateMercadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.textBoxIDEventos);
            this.Controls.Add(this.labelIDEventos);
            this.Controls.Add(this.labelApostadoUnder);
            this.Controls.Add(this.labelApostadoOver);
            this.Controls.Add(this.textBoxApostadoUnder);
            this.Controls.Add(this.textBoxCuotaOver);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.labelPatenteID);
            this.Controls.Add(this.textBoxIdentificador);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxApostadoOver);
            this.Controls.Add(this.labelCuotaUnder);
            this.Controls.Add(this.textBoxCuotaUnder);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelCuotaOver);
            this.Name = "UpdateMercadosForm";
            this.Text = "UpdateMercadosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPatenteID;
        private System.Windows.Forms.TextBox textBoxIdentificador;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxApostadoOver;
        private System.Windows.Forms.Label labelCuotaUnder;
        private System.Windows.Forms.TextBox textBoxCuotaUnder;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelCuotaOver;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.TextBox textBoxCuotaOver;
        private System.Windows.Forms.TextBox textBoxApostadoUnder;
        private System.Windows.Forms.Label labelApostadoOver;
        private System.Windows.Forms.Label labelApostadoUnder;
        private System.Windows.Forms.Label labelIDEventos;
        private System.Windows.Forms.TextBox textBoxIDEventos;
    }
}
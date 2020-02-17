namespace MiApp.Interfaces
{
    partial class PaginaPrincipal
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
            this.buttonEventos = new System.Windows.Forms.Button();
            this.buttonMercados = new System.Windows.Forms.Button();
            this.buttonNuevosEventos = new System.Windows.Forms.Button();
            this.buttonInformes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEventos
            // 
            this.buttonEventos.Location = new System.Drawing.Point(166, 37);
            this.buttonEventos.Name = "buttonEventos";
            this.buttonEventos.Size = new System.Drawing.Size(264, 47);
            this.buttonEventos.TabIndex = 35;
            this.buttonEventos.Text = "Eventos";
            this.buttonEventos.UseVisualStyleBackColor = true;
            this.buttonEventos.Click += new System.EventHandler(this.buttonEventos_Click);
            // 
            // buttonMercados
            // 
            this.buttonMercados.Location = new System.Drawing.Point(166, 109);
            this.buttonMercados.Name = "buttonMercados";
            this.buttonMercados.Size = new System.Drawing.Size(264, 47);
            this.buttonMercados.TabIndex = 36;
            this.buttonMercados.Text = "Mercados";
            this.buttonMercados.UseVisualStyleBackColor = true;
            this.buttonMercados.Click += new System.EventHandler(this.buttonMercados_Click);
            // 
            // buttonNuevosEventos
            // 
            this.buttonNuevosEventos.Location = new System.Drawing.Point(166, 181);
            this.buttonNuevosEventos.Name = "buttonNuevosEventos";
            this.buttonNuevosEventos.Size = new System.Drawing.Size(264, 47);
            this.buttonNuevosEventos.TabIndex = 37;
            this.buttonNuevosEventos.Text = "Crear/eliminar eventos";
            this.buttonNuevosEventos.UseVisualStyleBackColor = true;
            this.buttonNuevosEventos.Click += new System.EventHandler(this.buttonNuevosEventos_Click);
            // 
            // buttonInformes
            // 
            this.buttonInformes.Location = new System.Drawing.Point(166, 250);
            this.buttonInformes.Name = "buttonInformes";
            this.buttonInformes.Size = new System.Drawing.Size(264, 47);
            this.buttonInformes.TabIndex = 38;
            this.buttonInformes.Text = "Informes";
            this.buttonInformes.UseVisualStyleBackColor = true;
            this.buttonInformes.Click += new System.EventHandler(this.buttonInformes_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 336);
            this.Controls.Add(this.buttonInformes);
            this.Controls.Add(this.buttonNuevosEventos);
            this.Controls.Add(this.buttonMercados);
            this.Controls.Add(this.buttonEventos);
            this.Name = "PaginaPrincipal";
            this.Text = "PaginaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEventos;
        private System.Windows.Forms.Button buttonMercados;
        private System.Windows.Forms.Button buttonNuevosEventos;
        private System.Windows.Forms.Button buttonInformes;
    }
}
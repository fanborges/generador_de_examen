namespace examen_ap
{
    partial class Acceso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_presentacion = new System.Windows.Forms.Label();
            this.lbl_nuevo = new System.Windows.Forms.Label();
            this.link_registrarse = new System.Windows.Forms.LinkLabel();
            this.btn_consultar_datos = new System.Windows.Forms.Button();
            this.btn_presentar_examen = new System.Windows.Forms.Button();
            this.txt_box_ingresa_matricula = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_presentacion
            // 
            this.lbl_presentacion.AutoSize = true;
            this.lbl_presentacion.Location = new System.Drawing.Point(93, 28);
            this.lbl_presentacion.Name = "lbl_presentacion";
            this.lbl_presentacion.Size = new System.Drawing.Size(100, 13);
            this.lbl_presentacion.TabIndex = 11;
            this.lbl_presentacion.Text = "ingresa tu matrícula";
            // 
            // lbl_nuevo
            // 
            this.lbl_nuevo.AutoSize = true;
            this.lbl_nuevo.Location = new System.Drawing.Point(78, 194);
            this.lbl_nuevo.Name = "lbl_nuevo";
            this.lbl_nuevo.Size = new System.Drawing.Size(115, 13);
            this.lbl_nuevo.TabIndex = 10;
            this.lbl_nuevo.Text = "¿Nuevo en el sistema?";
            // 
            // link_registrarse
            // 
            this.link_registrarse.AutoSize = true;
            this.link_registrarse.Location = new System.Drawing.Point(101, 219);
            this.link_registrarse.Name = "link_registrarse";
            this.link_registrarse.Size = new System.Drawing.Size(60, 13);
            this.link_registrarse.TabIndex = 9;
            this.link_registrarse.TabStop = true;
            this.link_registrarse.Text = "Registrarse";
            this.link_registrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_registrarse_LinkClicked);
            // 
            // btn_consultar_datos
            // 
            this.btn_consultar_datos.Location = new System.Drawing.Point(161, 112);
            this.btn_consultar_datos.Name = "btn_consultar_datos";
            this.btn_consultar_datos.Size = new System.Drawing.Size(103, 23);
            this.btn_consultar_datos.TabIndex = 8;
            this.btn_consultar_datos.Text = "consultar datos";
            this.btn_consultar_datos.UseVisualStyleBackColor = true;
            this.btn_consultar_datos.Click += new System.EventHandler(this.btn_consultar_datos_Click);
            // 
            // btn_presentar_examen
            // 
            this.btn_presentar_examen.Location = new System.Drawing.Point(20, 112);
            this.btn_presentar_examen.Name = "btn_presentar_examen";
            this.btn_presentar_examen.Size = new System.Drawing.Size(103, 23);
            this.btn_presentar_examen.TabIndex = 7;
            this.btn_presentar_examen.Text = "presentar examen";
            this.btn_presentar_examen.UseVisualStyleBackColor = true;
            this.btn_presentar_examen.Click += new System.EventHandler(this.btn_presentar_examen_Click);
            // 
            // txt_box_ingresa_matricula
            // 
            this.txt_box_ingresa_matricula.Location = new System.Drawing.Point(20, 55);
            this.txt_box_ingresa_matricula.Name = "txt_box_ingresa_matricula";
            this.txt_box_ingresa_matricula.Size = new System.Drawing.Size(244, 20);
            this.txt_box_ingresa_matricula.TabIndex = 6;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(217, 228);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(66, 30);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_presentacion);
            this.Controls.Add(this.lbl_nuevo);
            this.Controls.Add(this.link_registrarse);
            this.Controls.Add(this.btn_consultar_datos);
            this.Controls.Add(this.btn_presentar_examen);
            this.Controls.Add(this.txt_box_ingresa_matricula);
            this.Name = "Acceso";
            this.Text = "Generador de examen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_presentacion;
        private System.Windows.Forms.Label lbl_nuevo;
        private System.Windows.Forms.LinkLabel link_registrarse;
        private System.Windows.Forms.Button btn_consultar_datos;
        private System.Windows.Forms.Button btn_presentar_examen;
        private System.Windows.Forms.TextBox txt_box_ingresa_matricula;
        private System.Windows.Forms.Button btn_salir;
    }
}


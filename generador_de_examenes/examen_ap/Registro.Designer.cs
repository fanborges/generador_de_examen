namespace examen_ap
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_box_nombre = new System.Windows.Forms.TextBox();
            this.txt_box_materno = new System.Windows.Forms.TextBox();
            this.txt_box_paterno = new System.Windows.Forms.TextBox();
            this.txt_box_matricula = new System.Windows.Forms.TextBox();
            this.txt_box_semestre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_paterno = new System.Windows.Forms.Label();
            this.lbl_materno = new System.Windows.Forms.Label();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_semestre = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de alumnos";
            // 
            // txt_box_nombre
            // 
            this.txt_box_nombre.Location = new System.Drawing.Point(28, 108);
            this.txt_box_nombre.Name = "txt_box_nombre";
            this.txt_box_nombre.Size = new System.Drawing.Size(186, 20);
            this.txt_box_nombre.TabIndex = 1;
            // 
            // txt_box_materno
            // 
            this.txt_box_materno.Location = new System.Drawing.Point(432, 108);
            this.txt_box_materno.Name = "txt_box_materno";
            this.txt_box_materno.Size = new System.Drawing.Size(153, 20);
            this.txt_box_materno.TabIndex = 3;
            // 
            // txt_box_paterno
            // 
            this.txt_box_paterno.Location = new System.Drawing.Point(253, 108);
            this.txt_box_paterno.Name = "txt_box_paterno";
            this.txt_box_paterno.Size = new System.Drawing.Size(153, 20);
            this.txt_box_paterno.TabIndex = 2;
            // 
            // txt_box_matricula
            // 
            this.txt_box_matricula.Location = new System.Drawing.Point(217, 176);
            this.txt_box_matricula.Name = "txt_box_matricula";
            this.txt_box_matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_box_matricula.TabIndex = 4;
            // 
            // txt_box_semestre
            // 
            this.txt_box_semestre.Location = new System.Drawing.Point(341, 176);
            this.txt_box_semestre.Name = "txt_box_semestre";
            this.txt_box_semestre.Size = new System.Drawing.Size(100, 20);
            this.txt_box_semestre.TabIndex = 5;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(93, 131);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 6;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_paterno
            // 
            this.lbl_paterno.AutoSize = true;
            this.lbl_paterno.Location = new System.Drawing.Point(289, 131);
            this.lbl_paterno.Name = "lbl_paterno";
            this.lbl_paterno.Size = new System.Drawing.Size(83, 13);
            this.lbl_paterno.TabIndex = 7;
            this.lbl_paterno.Text = "Apellido paterno";
            // 
            // lbl_materno
            // 
            this.lbl_materno.AutoSize = true;
            this.lbl_materno.Location = new System.Drawing.Point(462, 131);
            this.lbl_materno.Name = "lbl_materno";
            this.lbl_materno.Size = new System.Drawing.Size(85, 13);
            this.lbl_materno.TabIndex = 8;
            this.lbl_materno.Text = "Apellido materno";
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(247, 199);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(52, 13);
            this.lbl_matricula.TabIndex = 9;
            this.lbl_matricula.Text = "Matrícula";
            // 
            // lbl_semestre
            // 
            this.lbl_semestre.AutoSize = true;
            this.lbl_semestre.Location = new System.Drawing.Point(366, 199);
            this.lbl_semestre.Name = "lbl_semestre";
            this.lbl_semestre.Size = new System.Drawing.Size(51, 13);
            this.lbl_semestre.TabIndex = 10;
            this.lbl_semestre.Text = "Semestre";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(369, 262);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 11;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(465, 262);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 306);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_semestre);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.lbl_materno);
            this.Controls.Add(this.lbl_paterno);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_box_semestre);
            this.Controls.Add(this.txt_box_matricula);
            this.Controls.Add(this.txt_box_paterno);
            this.Controls.Add(this.txt_box_materno);
            this.Controls.Add(this.txt_box_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_box_nombre;
        private System.Windows.Forms.TextBox txt_box_materno;
        private System.Windows.Forms.TextBox txt_box_paterno;
        private System.Windows.Forms.TextBox txt_box_matricula;
        private System.Windows.Forms.TextBox txt_box_semestre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_paterno;
        private System.Windows.Forms.Label lbl_materno;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_semestre;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}
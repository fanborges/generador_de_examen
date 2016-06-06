namespace examen_ap
{
    partial class Examen
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
            this.lbl_pregunta = new System.Windows.Forms.Label();
            this.radio_respuesta1 = new System.Windows.Forms.RadioButton();
            this.radio_respuesta2 = new System.Windows.Forms.RadioButton();
            this.radio_respuesta3 = new System.Windows.Forms.RadioButton();
            this.radio_respuesta4 = new System.Windows.Forms.RadioButton();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_numero_pregunta = new System.Windows.Forms.Label();
            this.lbl_respuesta1 = new System.Windows.Forms.Label();
            this.lbl_respuesta2 = new System.Windows.Forms.Label();
            this.lbl_respuesta3 = new System.Windows.Forms.Label();
            this.lbl_respuesta4 = new System.Windows.Forms.Label();
            this.grupo_preguntas = new System.Windows.Forms.GroupBox();
            this.grupo_preguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pregunta
            // 
            this.lbl_pregunta.AutoSize = true;
            this.lbl_pregunta.Location = new System.Drawing.Point(115, 29);
            this.lbl_pregunta.Name = "lbl_pregunta";
            this.lbl_pregunta.Size = new System.Drawing.Size(49, 13);
            this.lbl_pregunta.TabIndex = 0;
            this.lbl_pregunta.Text = "pregunta";
            // 
            // radio_respuesta1
            // 
            this.radio_respuesta1.AutoSize = true;
            this.radio_respuesta1.Location = new System.Drawing.Point(404, 84);
            this.radio_respuesta1.Name = "radio_respuesta1";
            this.radio_respuesta1.Size = new System.Drawing.Size(25, 17);
            this.radio_respuesta1.TabIndex = 5;
            this.radio_respuesta1.TabStop = true;
            this.radio_respuesta1.Text = "\r\n";
            this.radio_respuesta1.UseVisualStyleBackColor = true;
            // 
            // radio_respuesta2
            // 
            this.radio_respuesta2.AutoSize = true;
            this.radio_respuesta2.Location = new System.Drawing.Point(404, 126);
            this.radio_respuesta2.Name = "radio_respuesta2";
            this.radio_respuesta2.Size = new System.Drawing.Size(14, 13);
            this.radio_respuesta2.TabIndex = 6;
            this.radio_respuesta2.TabStop = true;
            this.radio_respuesta2.UseVisualStyleBackColor = true;
            // 
            // radio_respuesta3
            // 
            this.radio_respuesta3.AutoSize = true;
            this.radio_respuesta3.Location = new System.Drawing.Point(404, 165);
            this.radio_respuesta3.Name = "radio_respuesta3";
            this.radio_respuesta3.Size = new System.Drawing.Size(14, 13);
            this.radio_respuesta3.TabIndex = 7;
            this.radio_respuesta3.TabStop = true;
            this.radio_respuesta3.UseVisualStyleBackColor = true;
            // 
            // radio_respuesta4
            // 
            this.radio_respuesta4.AutoSize = true;
            this.radio_respuesta4.Location = new System.Drawing.Point(404, 205);
            this.radio_respuesta4.Name = "radio_respuesta4";
            this.radio_respuesta4.Size = new System.Drawing.Size(14, 13);
            this.radio_respuesta4.TabIndex = 8;
            this.radio_respuesta4.TabStop = true;
            this.radio_respuesta4.UseVisualStyleBackColor = true;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(47, 253);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 9;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(368, 253);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_numero_pregunta
            // 
            this.lbl_numero_pregunta.AutoSize = true;
            this.lbl_numero_pregunta.Location = new System.Drawing.Point(70, 29);
            this.lbl_numero_pregunta.Name = "lbl_numero_pregunta";
            this.lbl_numero_pregunta.Size = new System.Drawing.Size(43, 13);
            this.lbl_numero_pregunta.TabIndex = 11;
            this.lbl_numero_pregunta.Text = "lbl_num";
            // 
            // lbl_respuesta1
            // 
            this.lbl_respuesta1.AutoSize = true;
            this.lbl_respuesta1.Location = new System.Drawing.Point(29, 16);
            this.lbl_respuesta1.Name = "lbl_respuesta1";
            this.lbl_respuesta1.Size = new System.Drawing.Size(27, 13);
            this.lbl_respuesta1.TabIndex = 1;
            this.lbl_respuesta1.Text = "res1";
            // 
            // lbl_respuesta2
            // 
            this.lbl_respuesta2.AutoSize = true;
            this.lbl_respuesta2.Location = new System.Drawing.Point(29, 58);
            this.lbl_respuesta2.Name = "lbl_respuesta2";
            this.lbl_respuesta2.Size = new System.Drawing.Size(27, 13);
            this.lbl_respuesta2.TabIndex = 2;
            this.lbl_respuesta2.Text = "res2";
            // 
            // lbl_respuesta3
            // 
            this.lbl_respuesta3.AutoSize = true;
            this.lbl_respuesta3.Location = new System.Drawing.Point(29, 97);
            this.lbl_respuesta3.Name = "lbl_respuesta3";
            this.lbl_respuesta3.Size = new System.Drawing.Size(27, 13);
            this.lbl_respuesta3.TabIndex = 3;
            this.lbl_respuesta3.Text = "res3";
            // 
            // lbl_respuesta4
            // 
            this.lbl_respuesta4.AutoSize = true;
            this.lbl_respuesta4.Location = new System.Drawing.Point(29, 137);
            this.lbl_respuesta4.Name = "lbl_respuesta4";
            this.lbl_respuesta4.Size = new System.Drawing.Size(27, 13);
            this.lbl_respuesta4.TabIndex = 4;
            this.lbl_respuesta4.Text = "res4";
            // 
            // grupo_preguntas
            // 
            this.grupo_preguntas.Controls.Add(this.lbl_respuesta4);
            this.grupo_preguntas.Controls.Add(this.lbl_respuesta3);
            this.grupo_preguntas.Controls.Add(this.lbl_respuesta2);
            this.grupo_preguntas.Controls.Add(this.lbl_respuesta1);
            this.grupo_preguntas.Location = new System.Drawing.Point(47, 68);
            this.grupo_preguntas.Name = "grupo_preguntas";
            this.grupo_preguntas.Size = new System.Drawing.Size(337, 167);
            this.grupo_preguntas.TabIndex = 12;
            this.grupo_preguntas.TabStop = false;
            this.grupo_preguntas.Text = "preguntas";
            // 
            // Examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 301);
            this.Controls.Add(this.grupo_preguntas);
            this.Controls.Add(this.lbl_numero_pregunta);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.radio_respuesta4);
            this.Controls.Add(this.radio_respuesta3);
            this.Controls.Add(this.radio_respuesta2);
            this.Controls.Add(this.radio_respuesta1);
            this.Controls.Add(this.lbl_pregunta);
            this.Name = "Examen";
            this.Text = "Examen";
            this.Load += new System.EventHandler(this.Examen_Load);
            this.grupo_preguntas.ResumeLayout(false);
            this.grupo_preguntas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pregunta;
        private System.Windows.Forms.RadioButton radio_respuesta1;
        private System.Windows.Forms.RadioButton radio_respuesta2;
        private System.Windows.Forms.RadioButton radio_respuesta3;
        private System.Windows.Forms.RadioButton radio_respuesta4;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_numero_pregunta;
        private System.Windows.Forms.Label lbl_respuesta1;
        private System.Windows.Forms.Label lbl_respuesta2;
        private System.Windows.Forms.Label lbl_respuesta3;
        private System.Windows.Forms.Label lbl_respuesta4;
        private System.Windows.Forms.GroupBox grupo_preguntas;
    }
}
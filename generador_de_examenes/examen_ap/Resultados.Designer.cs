namespace examen_ap
{
    partial class Resultados
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
            this.linklbl_intento = new System.Windows.Forms.LinkLabel();
            this.linklbl_alumno = new System.Windows.Forms.LinkLabel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linklbl_intento
            // 
            this.linklbl_intento.AutoSize = true;
            this.linklbl_intento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_intento.Location = new System.Drawing.Point(94, 95);
            this.linklbl_intento.Name = "linklbl_intento";
            this.linklbl_intento.Size = new System.Drawing.Size(97, 20);
            this.linklbl_intento.TabIndex = 0;
            this.linklbl_intento.TabStop = true;
            this.linklbl_intento.Text = "Por intento";
            this.linklbl_intento.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_intento_LinkClicked);
            // 
            // linklbl_alumno
            // 
            this.linklbl_alumno.AutoSize = true;
            this.linklbl_alumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_alumno.Location = new System.Drawing.Point(94, 137);
            this.linklbl_alumno.Name = "linklbl_alumno";
            this.linklbl_alumno.Size = new System.Drawing.Size(99, 20);
            this.linklbl_alumno.TabIndex = 1;
            this.linklbl_alumno.TabStop = true;
            this.linklbl_alumno.Text = "Por alumno";
            this.linklbl_alumno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_alumno_LinkClicked);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(84, 55);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(126, 20);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Ver resultados";
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 228);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.linklbl_alumno);
            this.Controls.Add(this.linklbl_intento);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklbl_intento;
        private System.Windows.Forms.LinkLabel linklbl_alumno;
        private System.Windows.Forms.Label lbl_titulo;
    }
}
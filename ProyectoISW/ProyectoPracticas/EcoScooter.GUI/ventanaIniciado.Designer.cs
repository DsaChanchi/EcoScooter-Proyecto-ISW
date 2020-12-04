namespace EcoScooter.GUI
{
    partial class ventanaIniciado
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
            this.btn_alquilar = new System.Windows.Forms.Button();
            this.btn_devolver = new System.Windows.Forms.Button();
            this.btn_recorridos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idEstacion = new System.Windows.Forms.TextBox();
            this.btn_desconectarse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_alquilar
            // 
            this.btn_alquilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alquilar.Location = new System.Drawing.Point(225, 102);
            this.btn_alquilar.Name = "btn_alquilar";
            this.btn_alquilar.Size = new System.Drawing.Size(288, 60);
            this.btn_alquilar.TabIndex = 0;
            this.btn_alquilar.Text = "Alquilar Patinete";
            this.btn_alquilar.UseVisualStyleBackColor = true;
            this.btn_alquilar.Click += new System.EventHandler(this.btn_alquilar_Click);
            // 
            // btn_devolver
            // 
            this.btn_devolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolver.Location = new System.Drawing.Point(225, 193);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(288, 60);
            this.btn_devolver.TabIndex = 1;
            this.btn_devolver.Text = "Devolver Patinete";
            this.btn_devolver.UseVisualStyleBackColor = true;
            this.btn_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            // 
            // btn_recorridos
            // 
            this.btn_recorridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recorridos.Location = new System.Drawing.Point(225, 286);
            this.btn_recorridos.Name = "btn_recorridos";
            this.btn_recorridos.Size = new System.Drawing.Size(288, 61);
            this.btn_recorridos.TabIndex = 2;
            this.btn_recorridos.Text = "Obtener Recorridos";
            this.btn_recorridos.UseVisualStyleBackColor = true;
            this.btn_recorridos.Click += new System.EventHandler(this.btn_recorridos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(458, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID de la estación:";
            // 
            // txt_idEstacion
            // 
            this.txt_idEstacion.Location = new System.Drawing.Point(581, 46);
            this.txt_idEstacion.Name = "txt_idEstacion";
            this.txt_idEstacion.Size = new System.Drawing.Size(100, 20);
            this.txt_idEstacion.TabIndex = 5;
            // 
            // btn_desconectarse
            // 
            this.btn_desconectarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desconectarse.Location = new System.Drawing.Point(580, 362);
            this.btn_desconectarse.Name = "btn_desconectarse";
            this.btn_desconectarse.Size = new System.Drawing.Size(112, 37);
            this.btn_desconectarse.TabIndex = 6;
            this.btn_desconectarse.Text = "Desconectarse";
            this.btn_desconectarse.UseVisualStyleBackColor = true;
            this.btn_desconectarse.Click += new System.EventHandler(this.btn_desconectarse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(59, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bienvenido,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(209, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "(nombre)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ventanaIniciado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_desconectarse);
            this.Controls.Add(this.txt_idEstacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_recorridos);
            this.Controls.Add(this.btn_devolver);
            this.Controls.Add(this.btn_alquilar);
            this.Name = "ventanaIniciado";
            this.Text = "EcoScooter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_alquilar;
        private System.Windows.Forms.Button btn_devolver;
        private System.Windows.Forms.Button btn_recorridos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idEstacion;
        private System.Windows.Forms.Button btn_desconectarse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
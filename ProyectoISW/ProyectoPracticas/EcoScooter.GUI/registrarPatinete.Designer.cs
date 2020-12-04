namespace EcoScooter.GUI
{
    partial class registrarPatinete
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_estacion = new System.Windows.Forms.TextBox();
            this.btn_disponible = new System.Windows.Forms.RadioButton();
            this.btn_mantenimiento = new System.Windows.Forms.RadioButton();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(80, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(69, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estación:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_estacion
            // 
            this.txt_estacion.Location = new System.Drawing.Point(155, 114);
            this.txt_estacion.Name = "txt_estacion";
            this.txt_estacion.Size = new System.Drawing.Size(147, 20);
            this.txt_estacion.TabIndex = 3;
            // 
            // btn_disponible
            // 
            this.btn_disponible.AutoSize = true;
            this.btn_disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disponible.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_disponible.Location = new System.Drawing.Point(16, 19);
            this.btn_disponible.Name = "btn_disponible";
            this.btn_disponible.Size = new System.Drawing.Size(92, 21);
            this.btn_disponible.TabIndex = 4;
            this.btn_disponible.TabStop = true;
            this.btn_disponible.Text = "Disponible";
            this.btn_disponible.UseVisualStyleBackColor = true;
            // 
            // btn_mantenimiento
            // 
            this.btn_mantenimiento.AutoSize = true;
            this.btn_mantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mantenimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_mantenimiento.Location = new System.Drawing.Point(17, 42);
            this.btn_mantenimiento.Name = "btn_mantenimiento";
            this.btn_mantenimiento.Size = new System.Drawing.Size(139, 21);
            this.btn_mantenimiento.TabIndex = 5;
            this.btn_mantenimiento.TabStop = true;
            this.btn_mantenimiento.Text = "En mantenimiento";
            this.btn_mantenimiento.UseVisualStyleBackColor = true;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(131, 314);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(142, 52);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(291, 393);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(71, 30);
            this.btn_atras.TabIndex = 7;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(155, 52);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(200, 20);
            this.txt_fecha.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_disponible);
            this.groupBox1.Controls.Add(this.btn_mantenimiento);
            this.groupBox1.Location = new System.Drawing.Point(145, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 76);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // registrarPatinete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(374, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_estacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "registrarPatinete";
            this.Text = "EcoScooter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_estacion;
        private System.Windows.Forms.RadioButton btn_disponible;
        private System.Windows.Forms.RadioButton btn_mantenimiento;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
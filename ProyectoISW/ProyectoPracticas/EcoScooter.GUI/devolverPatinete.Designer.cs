namespace EcoScooter.GUI
{
    partial class devolverPatinete
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_si = new System.Windows.Forms.RadioButton();
            this.btn_no = new System.Windows.Forms.RadioButton();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_devolver = new System.Windows.Forms.Button();
            this.txt_estacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_si);
            this.groupBox1.Controls.Add(this.btn_no);
            this.groupBox1.Location = new System.Drawing.Point(131, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 54);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_si
            // 
            this.btn_si.AutoSize = true;
            this.btn_si.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_si.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_si.Location = new System.Drawing.Point(16, 19);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(38, 21);
            this.btn_si.TabIndex = 4;
            this.btn_si.TabStop = true;
            this.btn_si.Text = "Si";
            this.btn_si.UseVisualStyleBackColor = true;
            // 
            // btn_no
            // 
            this.btn_no.AutoSize = true;
            this.btn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_no.Location = new System.Drawing.Point(75, 19);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(44, 21);
            this.btn_no.TabIndex = 5;
            this.btn_no.TabStop = true;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.CheckedChanged += new System.EventHandler(this.btn_no_CheckedChanged);
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(291, 393);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(71, 30);
            this.btn_atras.TabIndex = 15;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_devolver
            // 
            this.btn_devolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolver.Location = new System.Drawing.Point(131, 307);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(142, 52);
            this.btn_devolver.TabIndex = 14;
            this.btn_devolver.Text = "Devolver";
            this.btn_devolver.UseVisualStyleBackColor = true;
            this.btn_devolver.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txt_estacion
            // 
            this.txt_estacion.Location = new System.Drawing.Point(155, 72);
            this.txt_estacion.Name = "txt_estacion";
            this.txt_estacion.Size = new System.Drawing.Size(147, 20);
            this.txt_estacion.TabIndex = 13;
            this.txt_estacion.TextChanged += new System.EventHandler(this.txt_estacion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(69, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Estación:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(99, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "¿Ha ocurrido algún incidente?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // devolverPatinete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(374, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_devolver);
            this.Controls.Add(this.txt_estacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "devolverPatinete";
            this.Text = " EcoScooter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn_si;
        private System.Windows.Forms.RadioButton btn_no;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_devolver;
        private System.Windows.Forms.TextBox txt_estacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
namespace notas
{
    partial class notas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Evaluacion = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Reprobo = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Notafinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Evaluacion
            // 
            this.Evaluacion.Location = new System.Drawing.Point(196, 45);
            this.Evaluacion.Name = "Evaluacion";
            this.Evaluacion.Size = new System.Drawing.Size(87, 23);
            this.Evaluacion.TabIndex = 2;
            this.Evaluacion.Text = "Evaluacion";
            this.Evaluacion.UseVisualStyleBackColor = true;
            this.Evaluacion.Visible = false;
            this.Evaluacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 3;
            // 
            // Reprobo
            // 
            this.Reprobo.Location = new System.Drawing.Point(196, 109);
            this.Reprobo.Name = "Reprobo";
            this.Reprobo.Size = new System.Drawing.Size(87, 23);
            this.Reprobo.TabIndex = 4;
            this.Reprobo.Text = "Reprobo";
            this.Reprobo.UseVisualStyleBackColor = true;
            this.Reprobo.Click += new System.EventHandler(this.Reprobo_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 5;
            // 
            // Notafinal
            // 
            this.Notafinal.Location = new System.Drawing.Point(196, 180);
            this.Notafinal.Name = "Notafinal";
            this.Notafinal.Size = new System.Drawing.Size(87, 23);
            this.Notafinal.TabIndex = 6;
            this.Notafinal.Text = "Nota Final";
            this.Notafinal.UseVisualStyleBackColor = true;
            this.Notafinal.Visible = false;
            this.Notafinal.Click += new System.EventHandler(this.Notafinal_Click);
            // 
            // notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 243);
            this.Controls.Add(this.Notafinal);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Reprobo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Evaluacion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "notas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Evaluacion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Reprobo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Notafinal;
    }
}


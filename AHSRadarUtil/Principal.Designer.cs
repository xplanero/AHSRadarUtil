namespace AHSRadarUtil
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCirculo = new Button();
            btnSalir = new Button();
            btnEncontrar = new Button();
            SuspendLayout();
            // 
            // btnCirculo
            // 
            btnCirculo.Location = new Point(17, 11);
            btnCirculo.Margin = new Padding(2);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(78, 23);
            btnCirculo.TabIndex = 0;
            btnCirculo.Text = "Circulo";
            btnCirculo.UseVisualStyleBackColor = true;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(455, 229);
            btnSalir.Margin = new Padding(1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(79, 21);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEncontrar
            // 
            btnEncontrar.Location = new Point(17, 43);
            btnEncontrar.Name = "btnEncontrar";
            btnEncontrar.Size = new Size(78, 23);
            btnEncontrar.TabIndex = 2;
            btnEncontrar.Text = "Encontrar";
            btnEncontrar.UseVisualStyleBackColor = true;
            btnEncontrar.Click += btnEncontrar_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnEncontrar);
            Controls.Add(btnSalir);
            Controls.Add(btnCirculo);
            Margin = new Padding(2);
            Name = "Principal";
            Text = "UTILIDADES RADAR AIRHISPANIA";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCirculo;
        private Button btnSalir;
        private Button btnEncontrar;
    }
}

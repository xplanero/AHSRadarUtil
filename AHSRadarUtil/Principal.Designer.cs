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
            btnFileInt = new Button();
            SuspendLayout();
            // 
            // btnCirculo
            // 
            btnCirculo.Location = new Point(24, 18);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(111, 38);
            btnCirculo.TabIndex = 0;
            btnCirculo.Text = "Circulo";
            btnCirculo.UseVisualStyleBackColor = true;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(650, 382);
            btnSalir.Margin = new Padding(1, 2, 1, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 35);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEncontrar
            // 
            btnEncontrar.Location = new Point(24, 72);
            btnEncontrar.Margin = new Padding(4, 5, 4, 5);
            btnEncontrar.Name = "btnEncontrar";
            btnEncontrar.Size = new Size(111, 38);
            btnEncontrar.TabIndex = 2;
            btnEncontrar.Text = "Encontrar";
            btnEncontrar.UseVisualStyleBackColor = true;
            btnEncontrar.Click += btnEncontrar_Click;
            // 
            // btnFileInt
            // 
            btnFileInt.Location = new Point(171, 18);
            btnFileInt.Name = "btnFileInt";
            btnFileInt.Size = new Size(112, 34);
            btnFileInt.TabIndex = 3;
            btnFileInt.Text = "Integridad";
            btnFileInt.UseVisualStyleBackColor = true;
            btnFileInt.Click += btnFileInt_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFileInt);
            Controls.Add(btnEncontrar);
            Controls.Add(btnSalir);
            Controls.Add(btnCirculo);
            Name = "Principal";
            Text = "UTILIDADES RADAR AIRHISPANIA";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCirculo;
        private Button btnSalir;
        private Button btnEncontrar;
        private Button btnFileInt;
    }
}

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
            SuspendLayout();
            // 
            // btnCirculo
            // 
            btnCirculo.Location = new Point(36, 44);
            btnCirculo.Margin = new Padding(4, 4, 4, 4);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(168, 50);
            btnCirculo.TabIndex = 0;
            btnCirculo.Text = "Circulo";
            btnCirculo.UseVisualStyleBackColor = true;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(974, 566);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(169, 52);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 666);
            Controls.Add(btnSalir);
            Controls.Add(btnCirculo);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Principal";
            Text = "UTILIDADES RADAR AIRHISPANIA";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCirculo;
        private Button btnSalir;
    }
}
